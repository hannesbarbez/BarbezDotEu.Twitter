// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterResponse
    {
        [JsonPropertyName("data")]
        public List<Tweet> Data { get; set; } = new List<Tweet>();

        [JsonPropertyName("meta")]
        public TwitterMetaData TwitterMetaData { get; set; }
    }
}
