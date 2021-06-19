// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    /// <summary>
    /// Implements the <see cref="TweetAnnotationEntity"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetAnnotationEntity : TweetBaseEntity
    {
        /// <summary>
        /// Gets or sets the probability.
        /// </summary>
        [JsonPropertyName("probability")]
        public decimal Probability { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the normalized text.
        /// </summary>
        [JsonPropertyName("normalized_text")]
        public string NormalizedText { get; set; }
    }
}
