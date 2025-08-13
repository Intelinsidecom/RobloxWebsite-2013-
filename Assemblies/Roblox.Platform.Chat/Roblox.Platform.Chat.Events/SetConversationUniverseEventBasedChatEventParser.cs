using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat.Events;

internal class SetConversationUniverseEventBasedChatEventParser : IChatEventParser
{
	public ChatEventMessage Translate(IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		if (!(chatMessageEntity is IEventBasedChatMessageEntity eventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException($"SetConversationUniverse EventBased event parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		if (!(eventBasedChatMessageEntity is ISetConversationUniverseEventBasedChatMessageEntity setConversationUniverseEventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException($"SetConversationUniverse EventBased event parser cannot parse message with event type: {eventBasedChatMessageEntity.ChatMessageEventType}");
		}
		return new ChatEventMessage
		{
			SetUniverseActorUserId = setConversationUniverseEventBasedChatMessageEntity.ActorUserId,
			SetUniverseId = setConversationUniverseEventBasedChatMessageEntity.UniverseId
		};
	}

	public IChatMessageEntity Translate(IChatEventMessage chatEventMessage)
	{
		if (chatEventMessage == null)
		{
			throw new PlatformArgumentNullException("chatEventMessage");
		}
		if (!chatEventMessage.SetUniverseActorUserId.HasValue || !chatEventMessage.SetUniverseId.HasValue)
		{
			throw new PlatformArgumentException("SetConversationUniverse ChatEventParser could not parse chatEventMessage with null SetUniverseActorUserId");
		}
		if (!chatEventMessage.SetUniverseId.HasValue)
		{
			throw new PlatformArgumentException("SetConversationUniverse ChatEventParser could not translate chatEventMessage with null SetUniverseId");
		}
		return new SetConversationUniverseEventBasedChatMessageEntity
		{
			ActorUserId = chatEventMessage.SetUniverseActorUserId.Value,
			UniverseId = chatEventMessage.SetUniverseId.Value
		};
	}
}
