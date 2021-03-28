// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BarbezDotEu.MicroBlog.DTO;
using BarbezDotEu.MicroBlog.Enums;
using BarbezDotEu.Provider;
using BarbezDotEu.Provider.DTO;
using BarbezDotEu.Twitter.DTO;
using BarbezDotEu.Twitter.Exceptions;
using BarbezDotEu.Twitter.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.Twitter
{
    public class TwitterDataProvider : PoliteProvider, ITwitterDataProvider
    {
        private readonly AuthenticationHeaderValue authorizationHeader;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;
        private readonly IConfiguration configuration;
        private readonly long resultsPerRequest;
        private readonly string searchRecentTweetsUrl;
        private readonly string searchRecentTweetsFields;

        public TwitterDataProvider(ILogger<IHostedService> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
            : base(logger, httpClientFactory)
        {
            this.configuration = configuration;
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
            var authorization = this.GetAuthorization().Result;
            this.authorizationHeader = new AuthenticationHeaderValue(authorization.TokenType, authorization.AccessToken);
            this.SetRateLimitPerMinute(configuration["Twitter:RateLimit:PerMinute"]);
            this.resultsPerRequest = GetResultsPerRequest(configuration["Twitter:ResultsPerRequest"]);
            this.searchRecentTweetsUrl = configuration["Twitter:SearchRecentTweets:Url"];
            this.searchRecentTweetsFields = configuration["Twitter:SearchRecentTweets:TweetFields"];
        }

        /// <inheritdoc/>
        public async Task<List<MicroBlogEntry>> GetRecentTweets(string symbol)
        {
            var queryUrl = $"{this.searchRecentTweetsUrl}{symbol.ToUpperInvariant()}{this.searchRecentTweetsFields}{this.resultsPerRequest}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            request.Headers.Authorization = this.authorizationHeader;
            var result = await this.Request<TwitterResponse>(request);

            // Ensuring app fails when hitting rate limit.
            if (result.HasFailed && result.FailedResponse.StatusCode == HttpStatusCode.TooManyRequests)
                throw new TwitterDataProviderException(result.FailedResponse.StatusCode.ToString());
                
            if (result.TwitterMetaData.ResultCount == default)
                return new List<MicroBlogEntry>();

            return TweetsAsMicroBlogEntries(result.Data);
        }

        /// <summary>
        /// Returns a list of <see cref="Tweet"/>s as collection of <see cref="MicroBlogEntry"/> items.
        /// </summary>
        /// <returns>A list of <see cref="Tweet"/>s as collection of <see cref="MicroBlogEntry"/> items.</returns>
        private static List<MicroBlogEntry> TweetsAsMicroBlogEntries(List<Tweet> tweets)
        {
            var results = new List<MicroBlogEntry>();
            foreach (var tweet in tweets)
            {
                HashSet<string> urls = new();
                var publicMetrics = tweet.PublicMetrics;
                var mediaKeys = tweet.Attachements?.GetMediaKeysAsCsv();
                var cashTags = tweet.TweetEntities?.GetCashTagsAsCsv();
                var hashTags = tweet.TweetEntities?.GetHashTagsAsCsv();
                var mentions = tweet.TweetEntities?.GetMentions();

                var expandedUrlList = tweet.TweetEntities?.Urls?.Select(x => x.ExpandedUrl);
                var hasExpandedUrls = expandedUrlList != null && expandedUrlList.Any();
                if (hasExpandedUrls) urls.UnionWith(expandedUrlList);

                var imagesUrlList = tweet.TweetEntities?.Urls?.Where(x => x.Images != null && x.Images.Any()).SelectMany(x => x.Images);
                var hasUrls = imagesUrlList != null && imagesUrlList.Any();
                if (hasUrls) urls.UnionWith(imagesUrlList.Select(x => x.Url));

                var annotationList = tweet.TweetEntities?.Annotations;
                var hasAnnotations = annotationList != null && annotationList.Any();
                var annotations = hasAnnotations ? JsonSerializer.Serialize(annotationList) : null;

                var contextAnnotationList = tweet.ContextAnnotations;
                var hasContextAnnotations = contextAnnotationList != null && contextAnnotationList.Any();
                var contextAnnotations = hasContextAnnotations ? JsonSerializer.Serialize(contextAnnotationList) : null;

                var flatTweet = new MicroBlogEntry(
                    tweet.AuthorId,
                    tweet.ConversationId,
                    tweet.CreatedAt,
                    tweet.Id,
                    tweet.Language,
                    tweet.PossiblySensitive,
                    tweet.ReplySettings,
                    tweet.Source,
                    tweet.Text,
                    mediaKeys,
                    publicMetrics.LikeCount,
                    publicMetrics.QuoteCount,
                    publicMetrics.ReplyCount,
                    publicMetrics.RetweetCount,
                    cashTags,
                    hashTags,
                    mentions,
                    urls,
                    annotations,
                    contextAnnotations,
                    MicroBlogHost.Twitter);

                results.Add(flatTweet);
            }

            return results;
        }

        /// <summary>
        /// From a given string, parses the max. number of results to return per request. If not possible to parse, returns 10.
        /// </summary>
        /// <param name="resultsPerRequest">The string representation of the value of the maximum number of results per request.</param>
        /// <returns>The maximum number of results to return per request.</returns>
        private static long GetResultsPerRequest(string resultsPerRequest)
        {
            var success = long.TryParse(resultsPerRequest, out long numberOfResultsPerRequest);
            if (success)
                return numberOfResultsPerRequest;

            return 10;
        }

        /// <summary>
        /// Gets the authentication header value parameter from a <see cref="IConfiguration"/>.
        /// </summary>
        /// <param name="configuration">The <see cref="IConfiguration"/> to source the parameter from.</param>
        /// <returns>The access token.</returns>
        /// <remarks>https://developer.twitter.com/en/docs/authentication/oauth-2-0/application-only</remarks>
        private async Task<PostClientAuthorizeResponse> GetAuthorization()
        {
            var oAuth2TokenUrl = configuration["Twitter:OAuth2TokenUrl"];
            var request = new HttpRequestMessage(HttpMethod.Post, oAuth2TokenUrl);
            var content = new Dictionary<string, string>() { { "grant_type", "client_credentials" } };
            request.Content = new FormUrlEncodedContent(content);
            request.Headers.Accept.Add(this.acceptHeader);
            request.Headers.Authorization = this.GetAuthenticationHeaderValue();
            return await this.Request<PostClientAuthorizeResponse>(request);
        }

        private AuthenticationHeaderValue GetAuthenticationHeaderValue()
        {
            var authenticationHeaderValueParameter = this.GetAuthenticationHeaderValueParameter();
            return new AuthenticationHeaderValue("Basic", authenticationHeaderValueParameter);
        }

        private string GetAuthenticationHeaderValueParameter()
        {
            var consumerKey = configuration["Twitter:ConsumerKey"];
            var consumerSecret = configuration["Twitter:ConsumerSecret"];
            var parameter = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{consumerKey}:{consumerSecret}"));
            return parameter;
        }
    }
}
