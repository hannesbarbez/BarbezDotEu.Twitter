// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TweetAttachements"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetAttachements
    {
        /// <summary>
        /// Gets or sets the media keys.
        /// </summary>
        [JsonPropertyName("media_keys")]
        public List<string> MediaKeys { get; set; }

        /// <summary>
        /// Gets the <see cref="MediaKeys"/> in CSV format.
        /// </summary>
        /// <returns>The <see cref="MediaKeys"/> in CSV format.</returns>
        public string GetMediaKeysAsCsv()
        {
            var hasAttachements = this.MediaKeys != null && this.MediaKeys.Any();
            var mediaKeys = hasAttachements
                ? string.Join(",", this.MediaKeys)
                : null;

            return mediaKeys;
        }
    }
}
