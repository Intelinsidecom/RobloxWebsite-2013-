using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Platform.EventStream;

/// <summary>
/// Interface for chat training data object to be streamed to AWS Kinesis firehose
/// </summary>
public interface IChatTrainingData
{
	/// <summary>
	/// event type - should be filterTextReq
	/// </summary>
	[JsonProperty(PropertyName = "evt")]
	string Event { get; set; }

	/// <summary>
	/// Context regarding what kind of text this is - i.e. web_chat, web_pm etc
	/// </summary>
	[JsonProperty(PropertyName = "ctx")]
	string Context { get; set; }

	/// <summary>
	/// Integer identifier for the context
	/// </summary>
	[JsonProperty(PropertyName = "subctx1")]
	string Subcontext1 { get; set; }

	/// <summary>
	/// The original, unfiltered text that was input by a user
	/// </summary>
	[JsonProperty(PropertyName = "orig")]
	string OriginalText { get; set; }

	/// <summary>
	/// The time the message was sent
	/// </summary>
	[JsonProperty(PropertyName = "timestamp")]
	DateTime Timestamp { get; set; }

	/// <summary>
	/// The Community Sift request type (Chat, DoubleChat, LongText, etc)
	/// </summary>
	[JsonProperty(PropertyName = "reqType")]
	string RequestType { get; set; }

	/// <summary>
	/// Hashed username of the person who sent text
	/// </summary>
	[JsonProperty(PropertyName = "name")]
	string Name { get; set; }

	/// <summary>
	/// Community Sift's hashed response for under 13 users
	/// </summary>
	[JsonProperty(PropertyName = "u13res")]
	string Under13Response { get; set; }

	/// <summary>
	/// Community Sift's hashed response for over 13 users
	/// </summary>
	[JsonProperty(PropertyName = "o13res")]
	string Over13Response { get; set; }

	/// <summary>
	/// The unsafe topics community sift felt the text failed for under 13 users, if any
	/// EVEN IF NO CATEGORIES ARE RETURNED BY COMMUNITY SIFT YOU STILL MUST INSTANTIATE AN ARRAY
	/// </summary>
	[JsonProperty(PropertyName = "u13categories")]
	List<string> Under13Categories { get; set; }

	/// <summary>
	/// The unsafe topics community sift felt the text failed for over 13 users, if any
	/// EVEN IF NO CATEGORIES ARE RETURNED BY COMMUNITY SIFT YOU STILL MUST INSTANTIATE AN ARRAY
	/// </summary>
	[JsonProperty(PropertyName = "o13categories")]
	List<string> Over13Categories { get; set; }

	/// <summary>
	/// Enum for location that the text was sent from (EU or Non EU)
	/// </summary>
	[JsonProperty(PropertyName = "region")]
	Region Region { get; set; }

	/// <summary>
	/// bool for roblock result
	/// </summary>
	[JsonProperty(PropertyName = "RoblockResult")]
	bool? RoblockResult { get; set; }

	[JsonProperty(PropertyName = "u13moderationLevel")]
	int? Under13ModerationLevel { get; set; }

	[JsonProperty(PropertyName = "o13moderationLevel")]
	int? Over13ModerationLevel { get; set; }
}
