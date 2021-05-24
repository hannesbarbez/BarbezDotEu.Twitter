// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetMentionEntity : TweetBaseEntity
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
