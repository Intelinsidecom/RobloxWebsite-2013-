using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class GameLinkChatEventParser : IChatEventParser
{
	public ChatEventMessage Translate(IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		if (!(chatMessageEntity is ILinkChatMessageEntity linkChatMessageEntity))
		{
			throw new PlatformArgumentException($"Game Link event parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		if (!(linkChatMessageEntity is IGameLinkChatMessageEntity gameLinkChatMessageEntity))
		{
			throw new PlatformArgumentException($"Game Link event parser cannot parse message with link type: {linkChatMessageEntity.ChatMessageLinkType}");
		}
		return new ChatEventMessage
		{
			GameLinkUniverseId = gameLinkChatMessageEntity.UniverseId
		};
	}

	public IChatMessageEntity Translate(IChatEventMessage chatEventMessage)
	{
		if (chatEventMessage == null)
		{
			throw new PlatformArgumentNullException("chatEventMessage");
		}
		if (!chatEventMessage.GameLinkUniverseId.HasValue)
		{
			throw new PlatformArgumentException("Game Link ChatEvent Message needs a valid GameLinkUniverseId");
		}
		return new GameLinkChatMessageEntity
		{
			UniverseId = chatEventMessage.GameLinkUniverseId.Value
		};
	}
}
