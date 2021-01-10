// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TweetContextAnnotation
    {
        [JsonProperty("domain")]
        public TweetKeyOrValue Domain { get; set; }

        [JsonProperty("entity")]
        public TweetKeyOrValue Entity { get; set; }
    }
}
