// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Twitter.DTO.Entities
{
    /// <summary>
    /// Implements the <see cref="TweetEntities"/> DTO as defined by the third-party provider.
    /// </summary>
    public class TweetEntities
    {
        /// <summary>
        /// Gets or sets the URLs.
        /// </summary>
        [JsonPropertyName("urls")]
        public List<TweetUrlEntity> Urls { get; set; }

        /// <summary>
        /// Gets or sets the cashtags.
        /// </summary>
        [JsonPropertyName("cashtags")]
        public List<TweetTagEntity> CashTags { get; set; }

        /// <summary>
        /// Gets or sets the hashtags.
        /// </summary>
        [JsonPropertyName("hashtags")]
        public List<TweetTagEntity> HashTags { get; set; }

        /// <summary>
        /// Gets or sets the mentions.
        /// </summary>
        [JsonPropertyName("mentions")]
        public List<TweetMentionEntity> Mentions { get; set; }

        /// <summary>
        /// Gets or sets the annotations.
        /// </summary>
        [JsonPropertyName("annotations")]
        public List<TweetAnnotationEntity> Annotations { get; set; }

        /// <summary>
        /// Returns any <see cref="CashTags"/> in CSV format.
        /// </summary>
        /// <returns>The <see cref="CashTags"/> in CSV format.</returns>
        public string GetCashTagsAsCsv()
        {
            var cashtagList = this.CashTags?.Select(x => x.Tag)?.ToHashSet();
            var hasCashtags = cashtagList != null && cashtagList.Any();
            var cashTags = hasCashtags
                ? string.Join(",", cashtagList)
                : null;

            return cashTags;
        }

        /// <summary>
        /// Returns any <see cref="HashTags"/> in CSV format.
        /// </summary>
        /// <returns>The <see cref="HashTags"/> in CSV format.</returns>
        public string GetHashTagsAsCsv()
        {
            var hashtagList = this.HashTags?.Select(x => x.Tag)?.ToHashSet();
            var hasHashtags = hashtagList != null && hashtagList.Any();
            var hashTags = hasHashtags
                ? string.Join(",", hashtagList)
                : null;

            return hashTags;
        }

        /// <summary>
        /// Returns any <see cref="Mentions"/> in CSV format.
        /// </summary>
        /// <returns>The <see cref="Mentions"/> in CSV format.</returns>
        public string GetMentionsAsCsv()
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
