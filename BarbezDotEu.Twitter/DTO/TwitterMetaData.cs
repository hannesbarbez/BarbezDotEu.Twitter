// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterMetaData
    {
        [JsonProperty("newest_id")]
        public string NewestId { get; set; }

        [JsonProperty("oldest_id")]
        public string OldestId { get; set; }

        [JsonProperty("result_count")]
        public long ResultCount { get; set; }

        [JsonProperty("next_token")]
        public string NextToken { get; set; }
    }
}
