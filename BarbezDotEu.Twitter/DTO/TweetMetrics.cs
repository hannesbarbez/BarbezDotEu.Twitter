// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TweetMetrics
    {
        [JsonProperty("retweet_count")]
        public long RetweetCount { get; set; }

        [JsonProperty("reply_count")]
        public long ReplyCount { get; set; }

        [JsonProperty("like_count")]
        public long LikeCount { get; set; }

        [JsonProperty("quote_count")]
        public long QuoteCount { get; set; }
    }
}
