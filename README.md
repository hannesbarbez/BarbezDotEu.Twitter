<a name='assembly'></a>
# BarbezDotEu.Twitter

An unofficial, modern, very much work-in-progress client for Twitter APIs.

## Contents

- [ITwitterDataProvider](#T-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider 'BarbezDotEu.Twitter.Interfaces.ITwitterDataProvider')
  - [Configure(twitterConfiguration)](#M-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider-Configure-BarbezDotEu-Twitter-TwitterConfiguration- 'BarbezDotEu.Twitter.Interfaces.ITwitterDataProvider.Configure(BarbezDotEu.Twitter.TwitterConfiguration)')
  - [GetRecentTweets(topic)](#M-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider-GetRecentTweets-System-String- 'BarbezDotEu.Twitter.Interfaces.ITwitterDataProvider.GetRecentTweets(System.String)')
- [Tweet](#T-BarbezDotEu-Twitter-DTO-Tweet 'BarbezDotEu.Twitter.DTO.Tweet')
  - [Attachements](#P-BarbezDotEu-Twitter-DTO-Tweet-Attachements 'BarbezDotEu.Twitter.DTO.Tweet.Attachements')
  - [AuthorId](#P-BarbezDotEu-Twitter-DTO-Tweet-AuthorId 'BarbezDotEu.Twitter.DTO.Tweet.AuthorId')
  - [ContextAnnotations](#P-BarbezDotEu-Twitter-DTO-Tweet-ContextAnnotations 'BarbezDotEu.Twitter.DTO.Tweet.ContextAnnotations')
  - [ConversationId](#P-BarbezDotEu-Twitter-DTO-Tweet-ConversationId 'BarbezDotEu.Twitter.DTO.Tweet.ConversationId')
  - [CreatedAt](#P-BarbezDotEu-Twitter-DTO-Tweet-CreatedAt 'BarbezDotEu.Twitter.DTO.Tweet.CreatedAt')
  - [Id](#P-BarbezDotEu-Twitter-DTO-Tweet-Id 'BarbezDotEu.Twitter.DTO.Tweet.Id')
  - [Language](#P-BarbezDotEu-Twitter-DTO-Tweet-Language 'BarbezDotEu.Twitter.DTO.Tweet.Language')
  - [PossiblySensitive](#P-BarbezDotEu-Twitter-DTO-Tweet-PossiblySensitive 'BarbezDotEu.Twitter.DTO.Tweet.PossiblySensitive')
  - [PublicMetrics](#P-BarbezDotEu-Twitter-DTO-Tweet-PublicMetrics 'BarbezDotEu.Twitter.DTO.Tweet.PublicMetrics')
  - [ReplySettings](#P-BarbezDotEu-Twitter-DTO-Tweet-ReplySettings 'BarbezDotEu.Twitter.DTO.Tweet.ReplySettings')
  - [Source](#P-BarbezDotEu-Twitter-DTO-Tweet-Source 'BarbezDotEu.Twitter.DTO.Tweet.Source')
  - [Text](#P-BarbezDotEu-Twitter-DTO-Tweet-Text 'BarbezDotEu.Twitter.DTO.Tweet.Text')
  - [TweetEntities](#P-BarbezDotEu-Twitter-DTO-Tweet-TweetEntities 'BarbezDotEu.Twitter.DTO.Tweet.TweetEntities')
- [TweetAnnotationEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetAnnotationEntity')
  - [NormalizedText](#P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-NormalizedText 'BarbezDotEu.Twitter.DTO.Entities.TweetAnnotationEntity.NormalizedText')
  - [Probability](#P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-Probability 'BarbezDotEu.Twitter.DTO.Entities.TweetAnnotationEntity.Probability')
  - [Type](#P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-Type 'BarbezDotEu.Twitter.DTO.Entities.TweetAnnotationEntity.Type')
- [TweetAttachements](#T-BarbezDotEu-Twitter-DTO-TweetAttachements 'BarbezDotEu.Twitter.DTO.TweetAttachements')
  - [MediaKeys](#P-BarbezDotEu-Twitter-DTO-TweetAttachements-MediaKeys 'BarbezDotEu.Twitter.DTO.TweetAttachements.MediaKeys')
  - [GetMediaKeysAsCsv()](#M-BarbezDotEu-Twitter-DTO-TweetAttachements-GetMediaKeysAsCsv 'BarbezDotEu.Twitter.DTO.TweetAttachements.GetMediaKeysAsCsv')
- [TweetBaseEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetBaseEntity')
  - [End](#P-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity-End 'BarbezDotEu.Twitter.DTO.Entities.TweetBaseEntity.End')
  - [Start](#P-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity-Start 'BarbezDotEu.Twitter.DTO.Entities.TweetBaseEntity.Start')
- [TweetContextAnnotation](#T-BarbezDotEu-Twitter-DTO-TweetContextAnnotation 'BarbezDotEu.Twitter.DTO.TweetContextAnnotation')
  - [Domain](#P-BarbezDotEu-Twitter-DTO-TweetContextAnnotation-Domain 'BarbezDotEu.Twitter.DTO.TweetContextAnnotation.Domain')
  - [Entity](#P-BarbezDotEu-Twitter-DTO-TweetContextAnnotation-Entity 'BarbezDotEu.Twitter.DTO.TweetContextAnnotation.Entity')
- [TweetEntities](#T-BarbezDotEu-Twitter-DTO-Entities-TweetEntities 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities')
  - [Annotations](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Annotations 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.Annotations')
  - [CashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-CashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.CashTags')
  - [HashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-HashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.HashTags')
  - [Mentions](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Mentions 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.Mentions')
  - [Urls](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Urls 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.Urls')
  - [GetCashTagsAsCsv()](#M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetCashTagsAsCsv 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.GetCashTagsAsCsv')
  - [GetHashTagsAsCsv()](#M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetHashTagsAsCsv 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.GetHashTagsAsCsv')
  - [GetMentionsAsCsv()](#M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetMentionsAsCsv 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.GetMentionsAsCsv')
- [TweetKeyOrValue](#T-BarbezDotEu-Twitter-DTO-TweetKeyOrValue 'BarbezDotEu.Twitter.DTO.TweetKeyOrValue')
  - [Description](#P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Description 'BarbezDotEu.Twitter.DTO.TweetKeyOrValue.Description')
  - [Id](#P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Id 'BarbezDotEu.Twitter.DTO.TweetKeyOrValue.Id')
  - [Name](#P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Name 'BarbezDotEu.Twitter.DTO.TweetKeyOrValue.Name')
- [TweetMentionEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetMentionEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetMentionEntity')
  - [Username](#P-BarbezDotEu-Twitter-DTO-Entities-TweetMentionEntity-Username 'BarbezDotEu.Twitter.DTO.Entities.TweetMentionEntity.Username')
- [TweetMetrics](#T-BarbezDotEu-Twitter-DTO-TweetMetrics 'BarbezDotEu.Twitter.DTO.TweetMetrics')
  - [LikeCount](#P-BarbezDotEu-Twitter-DTO-TweetMetrics-LikeCount 'BarbezDotEu.Twitter.DTO.TweetMetrics.LikeCount')
  - [QuoteCount](#P-BarbezDotEu-Twitter-DTO-TweetMetrics-QuoteCount 'BarbezDotEu.Twitter.DTO.TweetMetrics.QuoteCount')
  - [ReplyCount](#P-BarbezDotEu-Twitter-DTO-TweetMetrics-ReplyCount 'BarbezDotEu.Twitter.DTO.TweetMetrics.ReplyCount')
  - [RetweetCount](#P-BarbezDotEu-Twitter-DTO-TweetMetrics-RetweetCount 'BarbezDotEu.Twitter.DTO.TweetMetrics.RetweetCount')
- [TweetTagEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetTagEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetTagEntity')
  - [Tag](#P-BarbezDotEu-Twitter-DTO-Entities-TweetTagEntity-Tag 'BarbezDotEu.Twitter.DTO.Entities.TweetTagEntity.Tag')
- [TweetUrlEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity')
  - [Description](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Description 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.Description')
  - [DisplayUrl](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-DisplayUrl 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.DisplayUrl')
  - [ExpandedUrl](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-ExpandedUrl 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.ExpandedUrl')
  - [Images](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Images 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.Images')
  - [Status](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Status 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.Status')
  - [Title](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Title 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.Title')
  - [UnwoundUrl](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-UnwoundUrl 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.UnwoundUrl')
  - [Url](#P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Url 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity.Url')
- [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration')
  - [#ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-Int64,System-String,System-String,System-String,System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.String,System.Int64,System.String,System.String,System.String,System.String,System.String)')
  - [#ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String,System-String,System-String,System-String,System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.String,System.String,System.String,System.String,System.String,System.String,System.String)')
  - [#ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-Int64,System-Int64,System-String,System-String,System-String,System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.Int64,System.Int64,System.String,System.String,System.String,System.String,System.String)')
  - [#ctor(consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.String,System.String)')
  - [#ctor(maxCallsPerMinute,consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-Int64,System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.Int64,System.String,System.String)')
  - [#ctor(maxCallsPerMinute,consumerKey,consumerSecret)](#M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String,System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.#ctor(System.String,System.String,System.String)')
  - [DEFAULTMAXCALLSPERMINUTE](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTMAXCALLSPERMINUTE 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTMAXCALLSPERMINUTE')
  - [DEFAULTOAUTH2TOKENURL](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTOAUTH2TOKENURL 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTOAUTH2TOKENURL')
  - [DEFAULTRESULTSPERREQUEST](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTRESULTSPERREQUEST 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTRESULTSPERREQUEST')
  - [DEFAULTSEARCHRECENTTWEETSFIELDS](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTSEARCHRECENTTWEETSFIELDS 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTSEARCHRECENTTWEETSFIELDS')
  - [DEFAULTSEARCHRECENTTWEETSURL](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTSEARCHRECENTTWEETSURL 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTSEARCHRECENTTWEETSURL')
  - [ConsumerKey](#P-BarbezDotEu-Twitter-TwitterConfiguration-ConsumerKey 'BarbezDotEu.Twitter.TwitterConfiguration.ConsumerKey')
  - [ConsumerSecret](#P-BarbezDotEu-Twitter-TwitterConfiguration-ConsumerSecret 'BarbezDotEu.Twitter.TwitterConfiguration.ConsumerSecret')
  - [MaxCallsPerMinute](#P-BarbezDotEu-Twitter-TwitterConfiguration-MaxCallsPerMinute 'BarbezDotEu.Twitter.TwitterConfiguration.MaxCallsPerMinute')
  - [OAuth2TokenUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-OAuth2TokenUrl 'BarbezDotEu.Twitter.TwitterConfiguration.OAuth2TokenUrl')
  - [ResultsPerRequest](#P-BarbezDotEu-Twitter-TwitterConfiguration-ResultsPerRequest 'BarbezDotEu.Twitter.TwitterConfiguration.ResultsPerRequest')
  - [SearchRecentTweetsFields](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsFields 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsFields')
  - [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl')
  - [GetResultsPerRequest(resultsPerRequest)](#M-BarbezDotEu-Twitter-TwitterConfiguration-GetResultsPerRequest-System-String- 'BarbezDotEu.Twitter.TwitterConfiguration.GetResultsPerRequest(System.String)')
- [TwitterDataProvider](#T-BarbezDotEu-Twitter-TwitterDataProvider 'BarbezDotEu.Twitter.TwitterDataProvider')
  - [#ctor(logger,httpClientFactory)](#M-BarbezDotEu-Twitter-TwitterDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory- 'BarbezDotEu.Twitter.TwitterDataProvider.#ctor(Microsoft.Extensions.Logging.ILogger,System.Net.Http.IHttpClientFactory)')
  - [Configuration](#P-BarbezDotEu-Twitter-TwitterDataProvider-Configuration 'BarbezDotEu.Twitter.TwitterDataProvider.Configuration')
  - [Configure()](#M-BarbezDotEu-Twitter-TwitterDataProvider-Configure-BarbezDotEu-Twitter-TwitterConfiguration- 'BarbezDotEu.Twitter.TwitterDataProvider.Configure(BarbezDotEu.Twitter.TwitterConfiguration)')
  - [GetAuthorization()](#M-BarbezDotEu-Twitter-TwitterDataProvider-GetAuthorization 'BarbezDotEu.Twitter.TwitterDataProvider.GetAuthorization')
  - [GetRecentTweets()](#M-BarbezDotEu-Twitter-TwitterDataProvider-GetRecentTweets-System-String- 'BarbezDotEu.Twitter.TwitterDataProvider.GetRecentTweets(System.String)')
  - [TweetsAsMicroBlogEntries()](#M-BarbezDotEu-Twitter-TwitterDataProvider-TweetsAsMicroBlogEntries-System-Collections-Generic-List{BarbezDotEu-Twitter-DTO-Tweet}- 'BarbezDotEu.Twitter.TwitterDataProvider.TweetsAsMicroBlogEntries(System.Collections.Generic.List{BarbezDotEu.Twitter.DTO.Tweet})')
- [TwitterDataProviderException](#T-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException 'BarbezDotEu.Twitter.Exceptions.TwitterDataProviderException')
  - [#ctor()](#M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor 'BarbezDotEu.Twitter.Exceptions.TwitterDataProviderException.#ctor')
  - [#ctor()](#M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-String- 'BarbezDotEu.Twitter.Exceptions.TwitterDataProviderException.#ctor(System.String)')
  - [#ctor()](#M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-String,System-Exception- 'BarbezDotEu.Twitter.Exceptions.TwitterDataProviderException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'BarbezDotEu.Twitter.Exceptions.TwitterDataProviderException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [TwitterImage](#T-BarbezDotEu-Twitter-DTO-TwitterImage 'BarbezDotEu.Twitter.DTO.TwitterImage')
  - [Height](#P-BarbezDotEu-Twitter-DTO-TwitterImage-Height 'BarbezDotEu.Twitter.DTO.TwitterImage.Height')
  - [Url](#P-BarbezDotEu-Twitter-DTO-TwitterImage-Url 'BarbezDotEu.Twitter.DTO.TwitterImage.Url')
  - [Width](#P-BarbezDotEu-Twitter-DTO-TwitterImage-Width 'BarbezDotEu.Twitter.DTO.TwitterImage.Width')
- [TwitterMetaData](#T-BarbezDotEu-Twitter-DTO-TwitterMetaData 'BarbezDotEu.Twitter.DTO.TwitterMetaData')
  - [NewestId](#P-BarbezDotEu-Twitter-DTO-TwitterMetaData-NewestId 'BarbezDotEu.Twitter.DTO.TwitterMetaData.NewestId')
  - [NextToken](#P-BarbezDotEu-Twitter-DTO-TwitterMetaData-NextToken 'BarbezDotEu.Twitter.DTO.TwitterMetaData.NextToken')
  - [OldestId](#P-BarbezDotEu-Twitter-DTO-TwitterMetaData-OldestId 'BarbezDotEu.Twitter.DTO.TwitterMetaData.OldestId')
  - [ResultCount](#P-BarbezDotEu-Twitter-DTO-TwitterMetaData-ResultCount 'BarbezDotEu.Twitter.DTO.TwitterMetaData.ResultCount')
- [TwitterResponse](#T-BarbezDotEu-Twitter-DTO-TwitterResponse 'BarbezDotEu.Twitter.DTO.TwitterResponse')
  - [Data](#P-BarbezDotEu-Twitter-DTO-TwitterResponse-Data 'BarbezDotEu.Twitter.DTO.TwitterResponse.Data')
  - [TwitterMetaData](#P-BarbezDotEu-Twitter-DTO-TwitterResponse-TwitterMetaData 'BarbezDotEu.Twitter.DTO.TwitterResponse.TwitterMetaData')

<a name='T-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider'></a>
## ITwitterDataProvider `type`

##### Namespace

BarbezDotEu.Twitter.Interfaces

##### Summary

Defines a blueprint for a data provider that connects to and can call Twitter.com APIs.

<a name='M-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider-Configure-BarbezDotEu-Twitter-TwitterConfiguration-'></a>
### Configure(twitterConfiguration) `method`

##### Summary

Configures this [ITwitterDataProvider](#T-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider 'BarbezDotEu.Twitter.Interfaces.ITwitterDataProvider') so that it can successfully communicate with the Twitter.com APIs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| twitterConfiguration | [BarbezDotEu.Twitter.TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') | The [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') to configure this [ITwitterDataProvider](#T-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider 'BarbezDotEu.Twitter.Interfaces.ITwitterDataProvider') with. |

##### Remarks

Configuration is required before any APIs can be called.

<a name='M-BarbezDotEu-Twitter-Interfaces-ITwitterDataProvider-GetRecentTweets-System-String-'></a>
### GetRecentTweets(topic) `method`

##### Summary

Queries for occurences of the given topic found in tweets from the past 7 days.

##### Returns

A list of [MicroBlogEntry](#T-BarbezDotEu-MicroBlog-DTO-MicroBlogEntry 'BarbezDotEu.MicroBlog.DTO.MicroBlogEntry') items corresponding to the given topic.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| topic | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The topic for which to query. |

<a name='T-BarbezDotEu-Twitter-DTO-Tweet'></a>
## Tweet `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [Tweet](#T-BarbezDotEu-Twitter-DTO-Tweet 'BarbezDotEu.Twitter.DTO.Tweet') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-Attachements'></a>
### Attachements `property`

##### Summary

Gets or sets the attachements.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-AuthorId'></a>
### AuthorId `property`

##### Summary

Gets or sets the author ID.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-ContextAnnotations'></a>
### ContextAnnotations `property`

##### Summary

Gets or sets the context annotations.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-ConversationId'></a>
### ConversationId `property`

##### Summary

Gets or sets the conversation ID.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-CreatedAt'></a>
### CreatedAt `property`

##### Summary

Gets or sets the time when the tweet was created,

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-Id'></a>
### Id `property`

##### Summary

Gets or sets the ID.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-Language'></a>
### Language `property`

##### Summary

Gets or sets the language.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-PossiblySensitive'></a>
### PossiblySensitive `property`

##### Summary

Gets or sets whether the tweet is possibly sensitive.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-PublicMetrics'></a>
### PublicMetrics `property`

##### Summary

Gets or sets the public metrics.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-ReplySettings'></a>
### ReplySettings `property`

##### Summary

Gets or sets the reply settings.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-Source'></a>
### Source `property`

##### Summary

Gets or sets the source.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-Text'></a>
### Text `property`

##### Summary

Gets or sets the text.

<a name='P-BarbezDotEu-Twitter-DTO-Tweet-TweetEntities'></a>
### TweetEntities `property`

##### Summary

Gets or sets the entities.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity'></a>
## TweetAnnotationEntity `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetAnnotationEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetAnnotationEntity') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-NormalizedText'></a>
### NormalizedText `property`

##### Summary

Gets or sets the normalized text.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-Probability'></a>
### Probability `property`

##### Summary

Gets or sets the probability.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetAnnotationEntity-Type'></a>
### Type `property`

##### Summary

Gets or sets the type.

<a name='T-BarbezDotEu-Twitter-DTO-TweetAttachements'></a>
## TweetAttachements `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TweetAttachements](#T-BarbezDotEu-Twitter-DTO-TweetAttachements 'BarbezDotEu.Twitter.DTO.TweetAttachements') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TweetAttachements-MediaKeys'></a>
### MediaKeys `property`

##### Summary

Gets or sets the media keys.

<a name='M-BarbezDotEu-Twitter-DTO-TweetAttachements-GetMediaKeysAsCsv'></a>
### GetMediaKeysAsCsv() `method`

##### Summary

Gets the [MediaKeys](#P-BarbezDotEu-Twitter-DTO-TweetAttachements-MediaKeys 'BarbezDotEu.Twitter.DTO.TweetAttachements.MediaKeys') in CSV format.

##### Returns

The [MediaKeys](#P-BarbezDotEu-Twitter-DTO-TweetAttachements-MediaKeys 'BarbezDotEu.Twitter.DTO.TweetAttachements.MediaKeys') in CSV format.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity'></a>
## TweetBaseEntity `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetBaseEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetBaseEntity') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity-End'></a>
### End `property`

##### Summary

Gets or set the index of the last character of the entity in the tweet.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetBaseEntity-Start'></a>
### Start `property`

##### Summary

Gets or set the index of the first character of the entity in the tweet.

<a name='T-BarbezDotEu-Twitter-DTO-TweetContextAnnotation'></a>
## TweetContextAnnotation `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TweetContextAnnotation](#T-BarbezDotEu-Twitter-DTO-TweetContextAnnotation 'BarbezDotEu.Twitter.DTO.TweetContextAnnotation') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TweetContextAnnotation-Domain'></a>
### Domain `property`

##### Summary

Gets or sets the domain.

<a name='P-BarbezDotEu-Twitter-DTO-TweetContextAnnotation-Entity'></a>
### Entity `property`

##### Summary

Gets or sets the entity.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetEntities'></a>
## TweetEntities `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetEntities](#T-BarbezDotEu-Twitter-DTO-Entities-TweetEntities 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Annotations'></a>
### Annotations `property`

##### Summary

Gets or sets the annotations.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-CashTags'></a>
### CashTags `property`

##### Summary

Gets or sets the cashtags.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-HashTags'></a>
### HashTags `property`

##### Summary

Gets or sets the hashtags.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Mentions'></a>
### Mentions `property`

##### Summary

Gets or sets the mentions.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Urls'></a>
### Urls `property`

##### Summary

Gets or sets the URLs.

<a name='M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetCashTagsAsCsv'></a>
### GetCashTagsAsCsv() `method`

##### Summary

Returns any [CashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-CashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.CashTags') in CSV format.

##### Returns

The [CashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-CashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.CashTags') in CSV format.

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetHashTagsAsCsv'></a>
### GetHashTagsAsCsv() `method`

##### Summary

Returns any [HashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-HashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.HashTags') in CSV format.

##### Returns

The [HashTags](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-HashTags 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.HashTags') in CSV format.

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-GetMentionsAsCsv'></a>
### GetMentionsAsCsv() `method`

##### Summary

Returns any [Mentions](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Mentions 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.Mentions') in CSV format.

##### Returns

The [Mentions](#P-BarbezDotEu-Twitter-DTO-Entities-TweetEntities-Mentions 'BarbezDotEu.Twitter.DTO.Entities.TweetEntities.Mentions') in CSV format.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Twitter-DTO-TweetKeyOrValue'></a>
## TweetKeyOrValue `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TweetKeyOrValue](#T-BarbezDotEu-Twitter-DTO-TweetKeyOrValue 'BarbezDotEu.Twitter.DTO.TweetKeyOrValue') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Description'></a>
### Description `property`

##### Summary

Gets or sets the description.

<a name='P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Id'></a>
### Id `property`

##### Summary

Gets or sets the ID.

<a name='P-BarbezDotEu-Twitter-DTO-TweetKeyOrValue-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetMentionEntity'></a>
## TweetMentionEntity `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetMentionEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetMentionEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetMentionEntity') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetMentionEntity-Username'></a>
### Username `property`

##### Summary

Gets or sets the user name.

<a name='T-BarbezDotEu-Twitter-DTO-TweetMetrics'></a>
## TweetMetrics `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TweetMetrics](#T-BarbezDotEu-Twitter-DTO-TweetMetrics 'BarbezDotEu.Twitter.DTO.TweetMetrics') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TweetMetrics-LikeCount'></a>
### LikeCount `property`

##### Summary

Gets or sets the number of likes.

<a name='P-BarbezDotEu-Twitter-DTO-TweetMetrics-QuoteCount'></a>
### QuoteCount `property`

##### Summary

Gets or sets the number of quotes.

<a name='P-BarbezDotEu-Twitter-DTO-TweetMetrics-ReplyCount'></a>
### ReplyCount `property`

##### Summary

Gets or sets the number of replies.

<a name='P-BarbezDotEu-Twitter-DTO-TweetMetrics-RetweetCount'></a>
### RetweetCount `property`

##### Summary

Gets or sets the number of retweets.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetTagEntity'></a>
## TweetTagEntity `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetTagEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetTagEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetTagEntity') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetTagEntity-Tag'></a>
### Tag `property`

##### Summary

Gets or sets the hash- or cashtag.

<a name='T-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity'></a>
## TweetUrlEntity `type`

##### Namespace

BarbezDotEu.Twitter.DTO.Entities

##### Summary

Implements the [TweetUrlEntity](#T-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity 'BarbezDotEu.Twitter.DTO.Entities.TweetUrlEntity') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Description'></a>
### Description `property`

##### Summary

Gets or sets the description.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-DisplayUrl'></a>
### DisplayUrl `property`

##### Summary

Gets or sets the display URL.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-ExpandedUrl'></a>
### ExpandedUrl `property`

##### Summary

Gets or sets the expanded URL.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Images'></a>
### Images `property`

##### Summary

Gets or sets the images.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Status'></a>
### Status `property`

##### Summary

Gets or sets the status.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Title'></a>
### Title `property`

##### Summary

Gets or sets the title.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-UnwoundUrl'></a>
### UnwoundUrl `property`

##### Summary

Gets or sets the unwound URL.

<a name='P-BarbezDotEu-Twitter-DTO-Entities-TweetUrlEntity-Url'></a>
### Url `property`

##### Summary

Gets or sets the URL.

<a name='T-BarbezDotEu-Twitter-TwitterConfiguration'></a>
## TwitterConfiguration `type`

##### Namespace

BarbezDotEu.Twitter

##### Summary

Implements and houses configuration parameters to correctly connect to and communicate with Twitter.com's services.

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-Int64,System-String,System-String,System-String,System-String,System-String-'></a>
### #ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerMinute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates). |
| resultsPerRequest | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The maximum number of results to return per request. |
| searchRecentTweetsUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields. |
| searchRecentTweetsFields | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query fields to query the [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl') with. |
| oAuth2TokenUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The OAuth 2 Token URL for authentication. |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String,System-String,System-String,System-String,System-String,System-String-'></a>
### #ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerMinute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates). |
| resultsPerRequest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum number of results to return per request. |
| searchRecentTweetsUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields. |
| searchRecentTweetsFields | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query fields to query the [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl') with. |
| oAuth2TokenUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The OAuth 2 Token URL for authentication. |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-Int64,System-Int64,System-String,System-String,System-String,System-String,System-String-'></a>
### #ctor(maxCallsPerMinute,resultsPerRequest,searchRecentTweetsUrl,searchRecentTweetsFields,oAuth2TokenUrl,consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerMinute | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates). |
| resultsPerRequest | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The maximum number of results to return per request. |
| searchRecentTweetsUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields. |
| searchRecentTweetsFields | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query fields to query the [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl') with. |
| oAuth2TokenUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The OAuth 2 Token URL for authentication. |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String-'></a>
### #ctor(consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters and using some default settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-Int64,System-String,System-String-'></a>
### #ctor(maxCallsPerMinute,consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters and using some default settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerMinute | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates). |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-#ctor-System-String,System-String,System-String-'></a>
### #ctor(maxCallsPerMinute,consumerKey,consumerSecret) `constructor`

##### Summary

Constructs a new [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') using given parameters and using some default settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerMinute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum number of calls allowed per minute (see the Twitter.com developer website for current rates). |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for authentication. (Get yours from the Twitter.com developer website) |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret for authentication. (Get yours from the Twitter.com developer website) |

<a name='F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTMAXCALLSPERMINUTE'></a>
### DEFAULTMAXCALLSPERMINUTE `constants`

##### Summary

A constant representing this package's default assumption of the maximum number of calls allowed per minute.

<a name='F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTOAUTH2TOKENURL'></a>
### DEFAULTOAUTH2TOKENURL `constants`

##### Summary

A constant representing this package's default implementation of the OAuth 2 Token URL for authentication.

<a name='F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTRESULTSPERREQUEST'></a>
### DEFAULTRESULTSPERREQUEST `constants`

##### Summary

A constant representing this package's default assumption of the maximum number of results to return per request.

<a name='F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTSEARCHRECENTTWEETSFIELDS'></a>
### DEFAULTSEARCHRECENTTWEETSFIELDS `constants`

##### Summary

A constant representing this package's default implementation for the query fields to query the [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl') with.

<a name='F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTSEARCHRECENTTWEETSURL'></a>
### DEFAULTSEARCHRECENTTWEETSURL `constants`

##### Summary

A constant representing this package's default implementation for the fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-ConsumerKey'></a>
### ConsumerKey `property`

##### Summary

Gets the consumer key for authentication. (Get yours from the Twitter.com developer website)

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-ConsumerSecret'></a>
### ConsumerSecret `property`

##### Summary

Gets the consumer secret for authentication. (Get yours from the Twitter.com developer website)

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-MaxCallsPerMinute'></a>
### MaxCallsPerMinute `property`

##### Summary

Gets the maximum number of calls allowed per minute (see the Twitter developer website for current rates).

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-OAuth2TokenUrl'></a>
### OAuth2TokenUrl `property`

##### Summary

Gets the OAuth 2 Token URL for authentication.

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-ResultsPerRequest'></a>
### ResultsPerRequest `property`

##### Summary

Gets the maximum number of results to return per request.

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsFields'></a>
### SearchRecentTweetsFields `property`

##### Summary

Gets the query fields to query the [SearchRecentTweetsUrl](#P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl 'BarbezDotEu.Twitter.TwitterConfiguration.SearchRecentTweetsUrl') with.

<a name='P-BarbezDotEu-Twitter-TwitterConfiguration-SearchRecentTweetsUrl'></a>
### SearchRecentTweetsUrl `property`

##### Summary

Gets the fully-qualified URL to use to search for topics in recent tweets. However, omits the actual search query and query fields.

<a name='M-BarbezDotEu-Twitter-TwitterConfiguration-GetResultsPerRequest-System-String-'></a>
### GetResultsPerRequest(resultsPerRequest) `method`

##### Summary

From a given string, parses the max. number of results to return per request. If not possible to parse, returns [DEFAULTRESULTSPERREQUEST](#F-BarbezDotEu-Twitter-TwitterConfiguration-DEFAULTRESULTSPERREQUEST 'BarbezDotEu.Twitter.TwitterConfiguration.DEFAULTRESULTSPERREQUEST').

##### Returns

The maximum number of results to return per request.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resultsPerRequest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string representation of the value of the maximum number of results per request. |

<a name='T-BarbezDotEu-Twitter-TwitterDataProvider'></a>
## TwitterDataProvider `type`

##### Namespace

BarbezDotEu.Twitter

##### Summary

Implements a data provider that connects to and can call Twitter.com APIs.

<a name='M-BarbezDotEu-Twitter-TwitterDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory-'></a>
### #ctor(logger,httpClientFactory) `constructor`

##### Summary

Constructs a new [TwitterDataProvider](#T-BarbezDotEu-Twitter-TwitterDataProvider 'BarbezDotEu.Twitter.TwitterDataProvider').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | A [ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') to use for logging. |
| httpClientFactory | [System.Net.Http.IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') | The [IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') to use. |

<a name='P-BarbezDotEu-Twitter-TwitterDataProvider-Configuration'></a>
### Configuration `property`

##### Summary

Gets the [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') this [TwitterConfiguration](#T-BarbezDotEu-Twitter-TwitterConfiguration 'BarbezDotEu.Twitter.TwitterConfiguration') uses to communicate to the APIs.

<a name='M-BarbezDotEu-Twitter-TwitterDataProvider-Configure-BarbezDotEu-Twitter-TwitterConfiguration-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Twitter-TwitterDataProvider-GetAuthorization'></a>
### GetAuthorization() `method`

##### Summary

Gets the authentication header value parameter.

##### Returns

The access token.

##### Parameters

This method has no parameters.

##### Remarks

https://developer.twitter.com/en/docs/authentication/oauth-2-0/application-only

<a name='M-BarbezDotEu-Twitter-TwitterDataProvider-GetRecentTweets-System-String-'></a>
### GetRecentTweets() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Twitter-TwitterDataProvider-TweetsAsMicroBlogEntries-System-Collections-Generic-List{BarbezDotEu-Twitter-DTO-Tweet}-'></a>
### TweetsAsMicroBlogEntries() `method`

##### Summary

Returns a list of [Tweet](#T-BarbezDotEu-Twitter-DTO-Tweet 'BarbezDotEu.Twitter.DTO.Tweet')s as collection of [MicroBlogEntry](#T-BarbezDotEu-MicroBlog-DTO-MicroBlogEntry 'BarbezDotEu.MicroBlog.DTO.MicroBlogEntry') items.

##### Returns

A list of [Tweet](#T-BarbezDotEu-Twitter-DTO-Tweet 'BarbezDotEu.Twitter.DTO.Tweet')s as collection of [MicroBlogEntry](#T-BarbezDotEu-MicroBlog-DTO-MicroBlogEntry 'BarbezDotEu.MicroBlog.DTO.MicroBlogEntry') items.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException'></a>
## TwitterDataProviderException `type`

##### Namespace

BarbezDotEu.Twitter.Exceptions

<a name='M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-BarbezDotEu-Twitter-Exceptions-TwitterDataProviderException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-BarbezDotEu-Twitter-DTO-TwitterImage'></a>
## TwitterImage `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TwitterImage](#T-BarbezDotEu-Twitter-DTO-TwitterImage 'BarbezDotEu.Twitter.DTO.TwitterImage') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterImage-Height'></a>
### Height `property`

##### Summary

Gets or sets the height.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterImage-Url'></a>
### Url `property`

##### Summary

Gets or sets the URL.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterImage-Width'></a>
### Width `property`

##### Summary

Gets or sets the width.

<a name='T-BarbezDotEu-Twitter-DTO-TwitterMetaData'></a>
## TwitterMetaData `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TwitterMetaData](#T-BarbezDotEu-Twitter-DTO-TwitterMetaData 'BarbezDotEu.Twitter.DTO.TwitterMetaData') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterMetaData-NewestId'></a>
### NewestId `property`

##### Summary

Gets or sets the newest ID.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterMetaData-NextToken'></a>
### NextToken `property`

##### Summary

Gets or sets the token for the next results.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterMetaData-OldestId'></a>
### OldestId `property`

##### Summary

Gets or sets the oldest ID.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterMetaData-ResultCount'></a>
### ResultCount `property`

##### Summary

Gets or sets the result count.

<a name='T-BarbezDotEu-Twitter-DTO-TwitterResponse'></a>
## TwitterResponse `type`

##### Namespace

BarbezDotEu.Twitter.DTO

##### Summary

Implements the [TwitterResponse](#T-BarbezDotEu-Twitter-DTO-TwitterResponse 'BarbezDotEu.Twitter.DTO.TwitterResponse') DTO as defined by the third-party provider.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterResponse-Data'></a>
### Data `property`

##### Summary

Gets or sets the data.

<a name='P-BarbezDotEu-Twitter-DTO-TwitterResponse-TwitterMetaData'></a>
### TwitterMetaData `property`

##### Summary

Gets or sets the meta data.
