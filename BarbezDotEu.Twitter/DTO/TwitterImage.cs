// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TwitterImage"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TwitterImage
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public long Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public long Height { get; set; }
    }
}
