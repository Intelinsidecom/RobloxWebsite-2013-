using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal abstract class ChatEventChatMessageParserBase
{
	protected abstract IChatEventChatMessageSourceParser GetChatEventChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType);

	public ChatEventMessageSource Translate(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		ChatMessageSourceType sourceType = chatMessageSourceEntity.SourceType;
		return GetChatEventChatMessageSourceParser(sourceType)?.Translate(chatMessageSourceEntity) ?? new ChatEventMessageSource
		{
			SourceType = sourceType
		};
	}

	protected IChatMessageSourceEntity Translate(IChatEventMessageSource chatEventMessageSource)
	{
		if (chatEventMessageSource == null)
		{
			throw new PlatformArgumentNullException("chatEventMessageSource");
		}
		ChatMessageSourceType sourceType = chatEventMessageSource.SourceType;
		IChatMessageSourceEntity obj = GetChatEventChatMessageSourceParser(sourceType)?.Translate(chatEventMessageSource) ?? new ChatMessageSourceEntity();
		obj.SourceType = sourceType;
		return obj;
	}
}
