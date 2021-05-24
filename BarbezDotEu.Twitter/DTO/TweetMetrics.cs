// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    public class TweetMetrics
    {
        [JsonPropertyName("retweet_count")]
        public long RetweetCount { get; set; }

        [JsonPropertyName("reply_count")]
        public long ReplyCount { get; set; }

        [JsonPropertyName("like_count")]
        public long LikeCount { get; set; }

        [JsonPropertyName("quote_count")]
        public long QuoteCount { get; set; }
    }
}
