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
        /// Gets the fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.
        /// </summary>
        public readonly string SearchRecentTweetsUrl = "https://api.twitter.com/2/tweets/search/recent?query=";

        /// <summary>
        /// Gets the query fields to query the <see cref="SearchRecentTweetsUrl"/> with.
        /// </summary>
        public readonly string SearchRecentTweetsFields = "&tweet.fields=attachments,author_id,context_annotations,conversation_id,created_at,entities,geo,id,in_reply_to_user_id,lang,possibly_sensitive,public_metrics,referenced_tweets,reply_settings,source,text,withheld&max_results=";

        /// <summary>
        /// Gets the OAuth 2 Token URL for authentication.
        /// </summary>
        public readonly string OAuth2TokenUrl = "https://api.twitter.com/oauth2/token";

        /// <summary>
        /// Gets the maximum number of calls allowed per minute (see the Twitter developer website for current rates).
        /// </summary>
        public long MaxCallsPerMinute { get; }

        /// <summary>
        /// Gets the maximum number of results to return per request.
        /// </summary>
        public long ResultsPerRequest { get; }

        /// <summary>
        /// Gets the consumer key for authentication. (Get yours from the Twitter.com developer website)
        /// </summary>
        internal string ConsumerKey { get; }

        /// <summary>
        /// Gets the consumer secret for authentication. (Get yours from the Twitter.com developer website)
        /// </summary>
        internal string ConsumerSecret { get; }

        /// <summary>
        /// Constructs a new <see cref="TwitterConfiguration"/> using given parameters.
        /// </summary>
        /// <param name="maxCallsPerMinute">The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates).</param>
        /// <param name="resultsPerRequest">The maximum number of results to return per request.</param>
        /// <param name="consumerKey">The consumer key for authentication. (Get yours from the Twitter.com developer website)</param>
        /// <param name="consumerSecret">The secret for authentication. (Get yours from the Twitter.com developer website)</param>
        public TwitterConfiguration(long maxCallsPerMinute, long resultsPerRequest, string consumerKey, string consumerSecret)
        {
            this.MaxCallsPerMinute = maxCallsPerMinute;
            this.ResultsPerRequest = resultsPerRequest;
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
        }
    }
}
