// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using BarbezDotEu.Twitter.DTO.Entities;

namespace BarbezDotEu.Twitter.DTO
{
    public class Tweet
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("reply_settings")]
        public string ReplySettings { get; set; }

        [JsonProperty("lang")]
        public string Language { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("context_annotations")]
        public List<TweetContextAnnotation> ContextAnnotations { get; set; }

        [JsonProperty("attachments")]
        public TweetAttachements Attachements { get; set; }

        [JsonProperty("public_metrics")]
        public TweetMetrics PublicMetrics { get; set; }

        [JsonProperty("entities")]
        public TweetEntities TweetEntities { get; set; }
    }
}
