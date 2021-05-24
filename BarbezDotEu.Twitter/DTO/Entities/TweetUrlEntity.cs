// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetUrlEntity : TweetBaseEntity
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonPropertyName("display_url")]
        public string DisplayUrl { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("unwound_url")]
        public string UnwoundUrl { get; set; }

        [JsonPropertyName("images")]
        public List<TwitterImage> Images { get; set; }
    }
}
