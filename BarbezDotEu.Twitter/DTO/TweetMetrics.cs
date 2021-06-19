// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TweetMetrics"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetMetrics
    {
        /// <summary>
        /// Gets or sets the number of retweets.
        /// </summary>
        [JsonPropertyName("retweet_count")]
        public long RetweetCount { get; set; }

        /// <summary>
        /// Gets or sets the number of replies.
        /// </summary>
        [JsonPropertyName("reply_count")]
        public long ReplyCount { get; set; }

        /// <summary>
        /// Gets or sets the number of likes.
        /// </summary>
        [JsonPropertyName("like_count")]
        public long LikeCount { get; set; }

        /// <summary>
        /// Gets or sets the number of quotes.
        /// </summary>
        [JsonPropertyName("quote_count")]
        public long QuoteCount { get; set; }
    }
}
