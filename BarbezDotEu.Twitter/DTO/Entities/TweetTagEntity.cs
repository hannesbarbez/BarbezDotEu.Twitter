// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetTagEntity : TweetBaseEntity
    {
        /// <summary>
        /// Gets or sets the hash- or cashtag.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
