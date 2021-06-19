// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using BarbezDotEu.Twitter.DTO.Entities;

namespace BarbezDotEu.Twitter.DTO
{
    /// <summary>
    /// Implements the <see cref="Tweet"/> DTO as defined by the third-party provider.
    /// </summary>
    public class Tweet
    {
        /// <summary>
        /// Gets or sets the time when the tweet was created,
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets whether the tweet is possibly sensitive.
        /// </summary>
        [JsonPropertyName("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the conversation ID.
        /// </summary>
        [JsonPropertyName("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the reply settings.
        /// </summary>
        [JsonPropertyName("reply_settings")]
        public string ReplySettings { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("lang")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the author ID.
        /// </summary>
        [JsonPropertyName("author_id")]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the context annotations.
        /// </summary>
        [JsonPropertyName("context_annotations")]
        public List<TweetContextAnnotation> ContextAnnotations { get; set; }

        /// <summary>
        /// Gets or sets the attachements.
        /// </summary>
        [JsonPropertyName("attachments")]
        public TweetAttachements Attachements { get; set; }

        /// <summary>
        /// Gets or sets the public metrics.
        /// </summary>
        [JsonPropertyName("public_metrics")]
        public TweetMetrics PublicMetrics { get; set; }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        [JsonPropertyName("entities")]
        public TweetEntities TweetEntities { get; set; }
    }
}
