﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public abstract class TweetBaseEntity
    {
        /// <summary>
        /// Gets or set the index of the first character of the entity in the tweet.
        /// </summary>
        [JsonPropertyName("start")]
        public long Start { get; set; }

        /// <summary>
        /// Gets or set the index of the last character of the entity in the tweet.
        /// </summary>
        [JsonPropertyName("end")]
        public long End { get; set; }
    }
}
