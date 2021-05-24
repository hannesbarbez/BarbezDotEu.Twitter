// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    public class TweetContextAnnotation
    {
        [JsonPropertyName("domain")]
        public TweetKeyOrValue Domain { get; set; }

        [JsonPropertyName("entity")]
        public TweetKeyOrValue Entity { get; set; }
    }
}
