// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterMetaData
    {
        [JsonPropertyName("newest_id")]
        public string NewestId { get; set; }

        [JsonPropertyName("oldest_id")]
        public string OldestId { get; set; }

        [JsonPropertyName("result_count")]
        public long ResultCount { get; set; }

        [JsonPropertyName("next_token")]
        public string NextToken { get; set; }
    }
}
