// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetMentionEntity : TweetBaseEntity
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
