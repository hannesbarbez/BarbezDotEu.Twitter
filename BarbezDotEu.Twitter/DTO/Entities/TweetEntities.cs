﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Linq;
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

        public string GetCashTagsAsCsv()
        {
            var cashtagList = this.CashTags?.Select(x => x.Tag)?.ToHashSet();
            var hasCashtags = cashtagList != null && cashtagList.Any();
            var cashTags = hasCashtags
                ? string.Join(",", cashtagList)
                : null;

            return cashTags;
        }

        public string GetHashTagsAsCsv()
        {
            var hashtagList = this.HashTags?.Select(x => x.Tag)?.ToHashSet();
            var hasHashtags = hashtagList != null && hashtagList.Any();
            var hashTags = hasHashtags
                ? string.Join(",", hashtagList)
                : null;

            return hashTags;
        }

        public string GetMentions()
        {
            var mentionList = this.Mentions?.Select(x => x.Username)?.ToHashSet();
            var hasMentions = mentionList != null && mentionList.Any();
            var mentions = hasMentions
                ? string.Join(",", mentionList)
                : null;

            return mentions;
        }
    }
}
