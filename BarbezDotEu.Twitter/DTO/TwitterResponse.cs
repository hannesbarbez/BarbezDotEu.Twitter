// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Net.Http;
using BarbezDotEu.Provider.Interfaces;
using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO
{
    public class TwitterResponse : ICanFail
    {
        [JsonProperty("data")]
        public List<Tweet> Data { get; set; }

        [JsonProperty("meta")]
        public TwitterMetaData TwitterMetaData { get; set; }

        /// <inheritdoc/>
        public HttpResponseMessage FailedResponse { get; set; }

        /// <inheritdoc/>
        public bool HasFailed => FailedResponse != null;
    }
}
