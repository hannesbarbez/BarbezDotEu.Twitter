// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetAnnotationEntity : TweetBaseEntity
    {
        [JsonProperty("probability")]
        public decimal Probability { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("normalized_text")]
        public string NormalizedText { get; set; }
    }
}
