// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="TwitterMetaData"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TwitterMetaData
    {
        /// <summary>
        /// Gets or sets the newest ID.
        /// </summary>
        [JsonPropertyName("newest_id")]
        public string NewestId { get; set; }

        /// <summary>
        /// Gets or sets the oldest ID.
        /// </summary>
        [JsonPropertyName("oldest_id")]
        public string OldestId { get; set; }

        /// <summary>
        /// Gets or sets the result count.
        /// </summary>
        [JsonPropertyName("result_count")]
        public long ResultCount { get; set; }

        /// <summary>
        /// Gets or sets the token for the next results.
        /// </summary>
        [JsonPropertyName("next_token")]
        public string NextToken { get; set; }
    }
}
