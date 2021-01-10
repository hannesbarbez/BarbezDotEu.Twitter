// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using Newtonsoft.Json;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    public class TweetEntities
    {
        [JsonProperty("urls")]
        public List<TweetUrlEntity> Urls { get; set; }

        [JsonProperty("cashtags")]
        public List<TweetTagEntity> CashTags { get; set; }

        [JsonProperty("hashtags")]
        public List<TweetTagEntity> HashTags { get; set; }

        [JsonProperty("mentions")]
        public List<TweetMentionEntity> Mentions { get; set; }

        [JsonProperty("annotations")]
        public List<TweetAnnotationEntity> Annotations { get; set; }
    }
}
