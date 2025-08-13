using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat.Entities;

internal class PlainTextMessageEntity : IPlainTextMessageEntity, IChatMessageEntity
{
	public string Over13Content { get; set; }

	public string Under13Content { get; set; }

	public Guid UniqueId { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSourceEntity ChatMessageSourceEntity { get; set; }
}
