using System;
using System.Collections.Generic;

namespace Roblox.Platform.Chat.Events;

public interface IChatEventMessage
{
	Guid UniqueId { get; }

	ChatMessageType MessageType { get; }

	DateTime Sent { get; }

	IChatEventMessageSource ChatEventMessageSource { get; }

	HashSet<string> Decorators { get; }

	string Over13Content { get; }

	string Under13Content { get; }

	ChatMessageLinkType? ChatMessageLinkType { get; }

	long? GameLinkUniverseId { get; }

	ChatMessageEventType? ChatMessageEventType { get; }

	long? SetUniverseActorUserId { get; }

	long? SetUniverseId { get; }
}
