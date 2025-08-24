using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class LinkChatEventParser : ChatEventChatMessageParserBase, IChatEventParser
{
	private readonly Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> _ChatEventChatMessageSourceParserGetter;

	private readonly Func<ChatMessageLinkType, IChatEventParser> _ChatEventLinkChatMessageParserGetter;

	private readonly ILogger _Logger;

	protected override IChatEventChatMessageSourceParser GetChatEventChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType)
	{
		return _ChatEventChatMessageSourceParserGetter(chatMessageSourceType);
	}

	internal LinkChatEventParser(Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> chatEventChatMessageSourceParserGetter, Func<ChatMessageLinkType, IChatEventParser> chatEventLinkChatMessageParserGetter, ILogger logger)
	{
		_ChatEventChatMessageSourceParserGetter = chatEventChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("chatEventChatMessageSourceParserGetter");
		_ChatEventLinkChatMessageParserGetter = chatEventLinkChatMessageParserGetter ?? throw new PlatformArgumentNullException("chatEventLinkChatMessageParserGetter");
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
		if (!(chatMessageEntity is ILinkChatMessageEntity linkChatMessageEntity))
		{
			throw new PlatformArgumentException($"Link event parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		ChatEventMessageSource chatEventMessageSource = Translate(chatMessageSourceEntity);
		if (chatEventMessageSource == null)
		{
			throw new PlatformArgumentException($"Could not translate chatMessageEntity to ChatEventMessage, type : {chatMessageEntity.MessageType.ToString()}");
		}
		ChatEventMessage obj = _ChatEventLinkChatMessageParserGetter(linkChatMessageEntity.ChatMessageLinkType)?.Translate(chatMessageEntity) ?? new ChatEventMessage();
		obj.MessageType = linkChatMessageEntity.MessageType;
		obj.UniqueId = linkChatMessageEntity.UniqueId;
		obj.ChatMessageLinkType = linkChatMessageEntity.ChatMessageLinkType;
		obj.ChatEventMessageSource = chatEventMessageSource;
		obj.Sent = linkChatMessageEntity.Sent.ToDateTime();
		obj.Decorators = linkChatMessageEntity.Decorators;
		return obj;
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
			throw new PlatformArgumentException("Cannot translate ChatEventMessage having a null chatEventMessageSource");
		}
		ChatMessageType messageType = chatEventMessage.MessageType;
		if (messageType != ChatMessageType.Link)
		{
			throw new PlatformException($"LinkChatEventParser cannot translate the chatEventMessage with type : {messageType.ToString()}");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformException($"Cannot translate chatEventMessageSource to ChatMessageSourceEntity, SourceType : {messageSource.SourceType.ToString()}");
		}
		if (!chatEventMessage.ChatMessageLinkType.HasValue)
		{
			throw new PlatformException("LinkChatEventParser cannot translate chatMessage with no LinkType enum set");
		}
		UtcInstant sent = UtcInstant.CoerceFrom(chatEventMessage.Sent, delegate(DateTimeKind kind)
		{
			_Logger.Error($"ChatEventMessage cannot be persisted since the 'sent' field is not UtcDateTime, kind -> {kind}");
		});
		ChatMessageLinkType chatMessageLinkType = chatEventMessage.ChatMessageLinkType.Value;
		ILinkChatMessageEntity obj = (_ChatEventLinkChatMessageParserGetter(chatMessageLinkType)?.Translate(chatEventMessage) as ILinkChatMessageEntity) ?? new LinkChatMessageEntity();
		obj.ChatMessageLinkType = chatMessageLinkType;
		obj.MessageType = messageType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		obj.Sent = sent;
		obj.UniqueId = chatEventMessage.UniqueId;
		obj.Decorators = chatEventMessage.Decorators;
		return obj;
	}
}
