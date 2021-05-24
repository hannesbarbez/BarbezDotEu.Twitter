// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using BarbezDotEu.Twitter.DTO.Entities;

namespace BarbezDotEu.Twitter.DTO
{
    public class Tweet
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("conversation_id")]
        public string ConversationId { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("reply_settings")]
        public string ReplySettings { get; set; }

        [JsonPropertyName("lang")]
        public string Language { get; set; }

        [JsonPropertyName("author_id")]
        public string AuthorId { get; set; }

        [JsonPropertyName("context_annotations")]
        public List<TweetContextAnnotation> ContextAnnotations { get; set; }

        [JsonPropertyName("attachments")]
        public TweetAttachements Attachements { get; set; }

        [JsonPropertyName("public_metrics")]
        public TweetMetrics PublicMetrics { get; set; }

        [JsonPropertyName("entities")]
        public TweetEntities TweetEntities { get; set; }
    }
}
