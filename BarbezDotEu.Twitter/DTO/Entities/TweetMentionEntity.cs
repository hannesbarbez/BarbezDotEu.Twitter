// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    /// <summary>
    /// Implements the <see cref="TweetMentionEntity"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetMentionEntity : TweetBaseEntity
    {
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
