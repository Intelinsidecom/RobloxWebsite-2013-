using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Platform.Chat.Events;

public class ChatEventMessage : IChatEventMessage
{
	public Guid UniqueId { get; set; }

	public ChatMessageType MessageType { get; set; }

	public DateTime Sent { get; set; }

	[JsonConverter(typeof(ChatEventMessageSourceJsonConverter))]
	public IChatEventMessageSource ChatEventMessageSource { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public HashSet<string> Decorators { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string Over13Content { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string Under13Content { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public ChatMessageLinkType? ChatMessageLinkType { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public long? GameLinkUniverseId { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public ChatMessageEventType? ChatMessageEventType { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public long? SetUniverseActorUserId { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public long? SetUniverseId { get; set; }
}
