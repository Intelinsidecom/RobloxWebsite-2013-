using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class ChatEventChatMessageUserSourceParser : IChatEventChatMessageSourceParser
{
	public ChatEventMessageSource Translate(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		if (!(chatMessageSourceEntity is IChatMessageUserSourceEntity chatMessageUserSourceEntity))
		{
			throw new PlatformArgumentException($"user source event parser cannot parse source with type: {chatMessageSourceEntity.SourceType}");
		}
		return new ChatEventMessageSource
		{
			SourceUserId = chatMessageUserSourceEntity.SourceUserId,
			SourceType = chatMessageUserSourceEntity.SourceType
		};
	}

	public IChatMessageSourceEntity Translate(IChatEventMessageSource chatEventMessageSource)
	{
		if (chatEventMessageSource == null)
		{
			throw new PlatformArgumentNullException("chatEventMessageSource");
		}
		return new ChatMessageUserSourceEntity
		{
			SourceUserId = chatEventMessageSource.SourceUserId
		};
	}
}
