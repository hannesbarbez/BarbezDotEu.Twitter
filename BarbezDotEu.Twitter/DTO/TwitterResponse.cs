// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using BarbezDotEu.Provider.Interfaces;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterResponse : ICanFail
    {
        [JsonPropertyName("data")]
        public List<Tweet> Data { get; set; } = new List<Tweet>();

        [JsonPropertyName("meta")]
        public TwitterMetaData TwitterMetaData { get; set; }

        /// <inheritdoc/>
        public HttpResponseMessage FailedResponse { get; set; }

        /// <inheritdoc/>
        public bool HasFailed => FailedResponse != null;
    }
}
