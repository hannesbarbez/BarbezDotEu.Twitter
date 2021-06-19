// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    /// <summary>
    /// Implements the <see cref="TweetUrlEntity"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetUrlEntity : TweetBaseEntity
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the expanded URL.
        /// </summary>
        [JsonPropertyName("expanded_url")]
        public string ExpandedUrl { get; set; }

        /// <summary>
        /// Gets or sets the display URL.
        /// </summary>
        [JsonPropertyName("display_url")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the unwound URL.
        /// </summary>
        [JsonPropertyName("unwound_url")]
        public string UnwoundUrl { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        [JsonPropertyName("images")]
        public List<TwitterImage> Images { get; set; }
    }
}
