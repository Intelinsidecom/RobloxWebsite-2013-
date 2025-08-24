using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Platform.EventStream.ChatTrainingData;

public class ChatTrainingData : IChatTrainingData
{
	[JsonProperty(PropertyName = "evt")]
	public string Event { get; set; }

	[JsonProperty(PropertyName = "ctx")]
	public string Context { get; set; }

	[JsonProperty(PropertyName = "subctx1")]
	public string Subcontext1 { get; set; }

	[JsonProperty(PropertyName = "orig")]
	public string OriginalText { get; set; }

	[JsonProperty(PropertyName = "timestamp")]
	public DateTime Timestamp { get; set; }

	[JsonProperty(PropertyName = "reqType")]
	public string RequestType { get; set; }

	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }

	[JsonProperty(PropertyName = "u13res")]
	public string Under13Response { get; set; }

	[JsonProperty(PropertyName = "o13res")]
	public string Over13Response { get; set; }

	[JsonProperty(PropertyName = "u13categories")]
	public List<string> Under13Categories { get; set; }

	[JsonProperty(PropertyName = "o13categories")]
	public List<string> Over13Categories { get; set; }

	[JsonProperty(PropertyName = "region")]
	public Region Region { get; set; }

	[JsonProperty(PropertyName = "RoblockResult")]
	public bool? RoblockResult { get; set; }

	[JsonProperty(PropertyName = "u13moderationLevel")]
	public int? Under13ModerationLevel { get; set; }

	[JsonProperty(PropertyName = "o13moderationLevel")]
	public int? Over13ModerationLevel { get; set; }
}
