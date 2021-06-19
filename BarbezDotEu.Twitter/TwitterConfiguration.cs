// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.Twitter
{
    /// <summary>
    /// Implements and houses configuration parameters to correctly connect to and communicate with Twitter.com's services.
    /// </summary>
    public class TwitterConfiguration
    {
        /// <summary>
        /// A constant representing this package's default implementation for the fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.
        /// </summary>
        public const string DEFAULTSEARCHRECENTTWEETSURL = "https://api.twitter.com/2/tweets/search/recent?query=";

        /// <summary>
        /// A constant representing this package's default implementation for the query fields to query the <see cref="SearchRecentTweetsUrl"/> with.
        /// </summary>
        public const string DEFAULTSEARCHRECENTTWEETSFIELDS = "&tweet.fields=attachments,author_id,context_annotations,conversation_id,created_at,entities,geo,id,in_reply_to_user_id,lang,possibly_sensitive,public_metrics,referenced_tweets,reply_settings,source,text,withheld&max_results=";

        /// <summary>
        /// A constant representing this package's default implementation of the OAuth 2 Token URL for authentication.
        /// </summary>
        public const string DEFAULTOAUTH2TOKENURL = "https://api.twitter.com/oauth2/token";

        /// <summary>
        /// A constant representing this package's default assumption of the maximum number of calls allowed per minute.
        /// </summary>
        public const long DEFAULTMAXCALLSPERMINUTE = 2;

        /// <summary>
        /// A constant representing this package's default assumption of the maximum number of results to return per request.
        /// </summary>
        public const long DEFAULTRESULTSPERREQUEST = 15;

        /// <summary>
        /// Gets the maximum number of calls allowed per minute (see the Twitter developer website for current rates).
        /// </summary>
        public string MaxCallsPerMinute { get; }

        /// <summary>
        /// Gets the maximum number of results to return per request.
        /// </summary>
        public long ResultsPerRequest { get; }

        /// <summary>
        /// Gets the fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.
        /// </summary>
        public string SearchRecentTweetsUrl { get; }

        /// <summary>
        /// Gets the query fields to query the <see cref="SearchRecentTweetsUrl"/> with.
        /// </summary>
        public string SearchRecentTweetsFields { get; }

        /// <summary>
        /// Gets the OAuth 2 Token URL for authentication.
        /// </summary>
        public string OAuth2TokenUrl { get; }

        /// <summary>
        /// Gets the consumer key for authentication. (Get yours from the Twitter.com developer website)
        /// </summary>
        public string ConsumerKey { get; }

        /// <summary>
        /// Gets the consumer secret for authentication. (Get yours from the Twitter.com developer website)
        /// </summary>
        public string ConsumerSecret { get; }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="resultsPerRequest">The maximum number of results to return per request.</param>
        /// <param name="searchRecentTweetsUrl">The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.</param>
        /// <param name="searchRecentTweetsFields">The query fields to query the <see cref="SearchRecentTweetsUrl"/> with.</param>
        /// <param name="oAuth2TokenUrl">The OAuth 2 Token URL for authentication.</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(string maxCallsPerMinute, long resultsPerRequest, string searchRecentTweetsUrl, string searchRecentTweetsFields, string oAuth2TokenUrl, string consumerKey, string consumerSecret)
        {
            this.MaxCallsPerMinute = maxCallsPerMinute;
            this.ResultsPerRequest = resultsPerRequest;
            this.SearchRecentTweetsUrl = searchRecentTweetsUrl;
            this.SearchRecentTweetsFields = searchRecentTweetsFields;
            this.OAuth2TokenUrl = oAuth2TokenUrl;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
        }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="resultsPerRequest">The maximum number of results to return per request.</param>
        /// <param name="searchRecentTweetsUrl">The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.</param>
        /// <param name="searchRecentTweetsFields">The query fields to query the <see cref="SearchRecentTweetsUrl"/> with.</param>
        /// <param name="oAuth2TokenUrl">The OAuth 2 Token URL for authentication.</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(string maxCallsPerMinute, string resultsPerRequest, string searchRecentTweetsUrl, string searchRecentTweetsFields, string oAuth2TokenUrl, string consumerKey, string consumerSecret)
        {
            this.MaxCallsPerMinute = maxCallsPerMinute;
            this.ResultsPerRequest = GetResultsPerRequest(resultsPerRequest);
            this.SearchRecentTweetsUrl = searchRecentTweetsUrl;
            this.SearchRecentTweetsFields = searchRecentTweetsFields;
            this.OAuth2TokenUrl = oAuth2TokenUrl;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
        }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="resultsPerRequest">The maximum number of results to return per request.</param>
        /// <param name="searchRecentTweetsUrl">The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.</param>
        /// <param name="searchRecentTweetsFields">The query fields to query the <see cref="SearchRecentTweetsUrl"/> with.</param>
        /// <param name="oAuth2TokenUrl">The OAuth 2 Token URL for authentication.</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(long maxCallsPerMinute, long resultsPerRequest, string searchRecentTweetsUrl, string searchRecentTweetsFields, string oAuth2TokenUrl, string consumerKey, string consumerSecret)
            : this(maxCallsPerMinute.ToString(), resultsPerRequest, searchRecentTweetsUrl, searchRecentTweetsFields, oAuth2TokenUrl, consumerKey, consumerSecret)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters and using some default settings.
        /// </summary>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(string consumerKey, string consumerSecret)
            : this(DEFAULTMAXCALLSPERMINUTE.ToString(), DEFAULTRESULTSPERREQUEST, DEFAULTSEARCHRECENTTWEETSURL, DEFAULTSEARCHRECENTTWEETSFIELDS, DEFAULTOAUTH2TOKENURL, consumerKey, consumerSecret)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters and using some default settings.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(long maxCallsPerMinute, string consumerKey, string consumerSecret)
            : this(maxCallsPerMinute.ToString(), DEFAULTRESULTSPERREQUEST, DEFAULTSEARCHRECENTTWEETSURL, DEFAULTSEARCHRECENTTWEETSFIELDS, DEFAULTOAUTH2TOKENURL, consumerKey, consumerSecret)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters and using some default settings.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(string maxCallsPerMinute, string consumerKey, string consumerSecret)
            : this(maxCallsPerMinute, DEFAULTRESULTSPERREQUEST, DEFAULTSEARCHRECENTTWEETSURL, DEFAULTSEARCHRECENTTWEETSFIELDS, DEFAULTOAUTH2TOKENURL, consumerKey, consumerSecret)
        {
        }

        /// <summary>
        /// From a given string, parses the max. number of results to return per request. If not possible to parse, returns <see cref="DEFAULTRESULTSPERREQUEST"/>.
        /// </summary>
        /// <param name="resultsPerRequest">The string representation of the value of the maximum number of results per request.</param>
        /// <returns>The maximum number of results to return per request.</returns>
        private static long GetResultsPerRequest(string resultsPerRequest)
        {
            var success = long.TryParse(resultsPerRequest, out long numberOfResultsPerRequest);
            if (success)
                return numberOfResultsPerRequest;

            return DEFAULTRESULTSPERREQUEST;
        }
    }
}
