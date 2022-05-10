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
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.Twitter
{
    /// <summary>
    /// Implements a data provider that connects to and can call Twitter.com APIs.
    /// </summary>
    public class TwitterDataProvider : PoliteProvider, ITwitterDataProvider
    {
        private readonly TwitterConfiguration configuration;
        private readonly AuthenticationHeaderValue authorizationHeader;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        /// <summary>
        /// Constructs a new <see cref="TwitterDataProvider"/>.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> to use for logging.</param>
        /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to use.</param>
        /// <param name="configuration">The <see cref="TwitterConfiguration"/> to configure this <see cref="ITwitterDataProvider"/> with.</param>
        public TwitterDataProvider(ILogger logger, IHttpClientFactory httpClientFactory, TwitterConfiguration configuration)
            : base(logger, httpClientFactory)
        {
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
            this.configuration = configuration;
            this.SetRateLimitPerMinute(this.configuration.MaxCallsPerMinute);
            var authorization = this.GetAuthorization().Result;
            this.authorizationHeader = new AuthenticationHeaderValue(authorization.TokenType, authorization.AccessToken);
        }

        /// <inheritdoc/>
        public async Task<List<MicroBlogEntry>> GetRecentTweets(string topic)
        {
            var queryUrl = $"{this.configuration.SearchRecentTweetsUrl}{topic.ToUpperInvariant()}{this.configuration.SearchRecentTweetsFields}{this.configuration.ResultsPerRequest}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            request.Headers.Authorization = this.authorizationHeader;
            var result = await this.Request<TwitterResponse>(request);

            if (result.HasFailed)
            {
                // Ensuring app fails when hitting rate limit.
                if (result.HttpResponseMessage.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    base.Logger.LogWarning("Too many requests to Twitter. Erroring out, shutting down.");
                    throw new TwitterDataProviderException(result.HttpResponseMessage.StatusCode.ToString());
                }

                // Else, just log and continue.
                var response = result?.HttpResponseMessage;
                var reason = response?.ReasonPhrase ?? "No reason phrase given."
                    + " " + response?.StatusCode ?? "No status code given"
                    + " " + response?.Content ?? "No content given";

                base.Logger.LogWarning($"Failed request reason: {reason}");
                base.Logger.LogWarning($"Failed request response: {response}");
                return new List<MicroBlogEntry>();
            }

            if (result.Content.TwitterMetaData.ResultCount == default)
                return new List<MicroBlogEntry>();

            return TweetsAsMicroBlogEntries(result.Content.Data);
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
                var mentions = tweet.TweetEntities?.GetMentionsAsCsv();

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
        /// Gets the authentication header value parameter.
        /// </summary>
        /// <returns>The access token.</returns>
        /// <remarks>https://developer.twitter.com/en/docs/authentication/oauth-2-0/application-only</remarks>
        private async Task<PostClientAuthorizeResponse> GetAuthorization()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, this.configuration.OAuth2TokenUrl)
            {
                Version = new Version(2, 0)
            };
            var content = new Dictionary<string, string>() { { "grant_type", "client_credentials" } };
            request.Content = new FormUrlEncodedContent(content);
            request.Headers.Accept.Add(this.acceptHeader);
            request.Headers.Authorization = this.GetAuthenticationHeaderValue();
            var response = await this.Request<PostClientAuthorizeResponse>(request);
            if (response.HasFailed)
            {
                var error = $"Failed request resulted in the following response (and also, the app will shut down): {response.HttpResponseMessage}";
                base.Logger.LogError(error);
                throw new TwitterDataProviderException(error);
            }

            return response.Content;
        }

        private AuthenticationHeaderValue GetAuthenticationHeaderValue()
        {
            var authenticationHeaderValueParameter = this.GetAuthenticationHeaderValueParameter();
            return new AuthenticationHeaderValue("Basic", authenticationHeaderValueParameter);
        }

        private string GetAuthenticationHeaderValueParameter()
        {
            var parameter = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{this.configuration.ConsumerKey}:{this.configuration.ConsumerSecret}"));
            return parameter;
        }
    }
}
