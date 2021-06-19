// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    /// <summary>
    /// Implements the <see cref="TweetTagEntity"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetTagEntity : TweetBaseEntity
    {
        /// <summary>
        /// Gets or sets the hash- or cashtag.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
