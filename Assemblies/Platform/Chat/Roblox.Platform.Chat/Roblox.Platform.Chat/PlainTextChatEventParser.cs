using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class PlainTextChatEventParser : ChatEventChatMessageParserBase, IChatEventParser
{
	private readonly Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> _ChatEventChatMessageSourceParserGetter;

	private readonly ILogger _Logger;

	protected override IChatEventChatMessageSourceParser GetChatEventChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType)
	{
		return _ChatEventChatMessageSourceParserGetter(chatMessageSourceType);
	}

	internal PlainTextChatEventParser(Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> chatEventChatMessageSourceParserGetter, ILogger logger)
	{
		_ChatEventChatMessageSourceParserGetter = chatEventChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("chatEventChatMessageSourceParserGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public ChatEventMessage Translate(IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = chatMessageEntity.ChatMessageSourceEntity;
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		if (!(chatMessageEntity is IPlainTextMessageEntity plainTextMessageEntity))
		{
			throw new PlatformArgumentException($"PlainText event parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		ChatEventMessageSource chatEventMessageSource = Translate(chatMessageSourceEntity);
		if (chatEventMessageSource == null)
		{
			return null;
		}
		return new ChatEventMessage
		{
			MessageType = plainTextMessageEntity.MessageType,
			UniqueId = plainTextMessageEntity.UniqueId,
			Over13Content = plainTextMessageEntity.Over13Content,
			Sent = plainTextMessageEntity.Sent.ToDateTime(),
			Under13Content = plainTextMessageEntity.Under13Content,
			ChatEventMessageSource = chatEventMessageSource,
			Decorators = plainTextMessageEntity.Decorators
		};
	}

	public IChatMessageEntity Translate(IChatEventMessage chatEventMessage)
	{
		if (chatEventMessage == null)
		{
			throw new PlatformArgumentNullException("chatEventMessage");
		}
		IChatEventMessageSource messageSource = chatEventMessage.ChatEventMessageSource;
		if (messageSource == null)
		{
			throw new PlatformArgumentException("PlainTextChatEventParser cannot parser chatEventMessage with null chatEventMessageSource");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentException($"PlainTextChatEventParser could not translate chatEventMessageSource into the corresponding entity, sourceType : {messageSource.SourceType.ToString()}");
		}
		UtcInstant sent = UtcInstant.CoerceFrom(chatEventMessage.Sent, delegate(DateTimeKind kind)
		{
			_Logger.Error($"ChatEventMessage cannot be persisted since the 'sent' field is not UtcDateTime, kind -> {kind}");
		});
		return new PlainTextMessageEntity
		{
			MessageType = chatEventMessage.MessageType,
			Over13Content = chatEventMessage.Over13Content,
			ChatMessageSourceEntity = chatMessageSourceEntity,
			Sent = sent,
			Under13Content = chatEventMessage.Under13Content,
			UniqueId = chatEventMessage.UniqueId,
			Decorators = chatEventMessage.Decorators
		};
	}
}
