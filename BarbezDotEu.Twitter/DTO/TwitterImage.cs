// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterImage
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }
}
