// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetUrlEntity : TweetBaseEntity
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unwound_url")]
        public string UnwoundUrl { get; set; }

        [JsonProperty("images")]
        public List<TwitterImage> Images { get; set; }
    }
}
