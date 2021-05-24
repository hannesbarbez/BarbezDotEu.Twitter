// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetAnnotationEntity : TweetBaseEntity
    {
        [JsonPropertyName("probability")]
        public decimal Probability { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("normalized_text")]
        public string NormalizedText { get; set; }
    }
}
