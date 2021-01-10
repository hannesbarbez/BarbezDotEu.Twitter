// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TweetAttachements
    {
        [JsonProperty("media_keys")]
        public List<string> MediaKeys { get; set; }
    }
}
