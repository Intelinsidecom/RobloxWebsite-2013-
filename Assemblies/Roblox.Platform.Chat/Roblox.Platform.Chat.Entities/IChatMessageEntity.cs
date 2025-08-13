using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat.Entities;

internal interface IChatMessageEntity
{
	Guid UniqueId { get; set; }

	ChatMessageType MessageType { get; set; }

	UtcInstant Sent { get; set; }

	HashSet<string> Decorators { get; set; }

	IChatMessageSourceEntity ChatMessageSourceEntity { get; set; }
}
