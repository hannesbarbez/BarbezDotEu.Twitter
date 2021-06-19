// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TweetContextAnnotation"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetContextAnnotation
    {
        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        [JsonPropertyName("domain")]
        public TweetKeyOrValue Domain { get; set; }

        /// <summary>
        /// Gets or sets the entity.
        /// </summary>
        [JsonPropertyName("entity")]
        public TweetKeyOrValue Entity { get; set; }
    }
}
