// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TwitterResponse"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TwitterResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public List<Tweet> Data { get; set; } = new List<Tweet>();

        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        [JsonPropertyName("meta")]
        public TwitterMetaData TwitterMetaData { get; set; }
    }
}
