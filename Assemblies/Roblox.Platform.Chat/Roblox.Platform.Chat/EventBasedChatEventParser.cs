using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Core;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class EventBasedChatEventParser : ChatEventChatMessageParserBase, IChatEventParser
{
	private readonly Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> _ChatEventChatMessageSourceParserGetter;

	private readonly Func<ChatMessageEventType, IChatEventParser> _ChatEventEventBasedChatMessageParserGetter;

	private readonly ILogger _Logger;

	protected override IChatEventChatMessageSourceParser GetChatEventChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType)
	{
		return _ChatEventChatMessageSourceParserGetter(chatMessageSourceType);
	}

	internal EventBasedChatEventParser(Func<ChatMessageSourceType, IChatEventChatMessageSourceParser> chatEventChatMessageSourceParserGetter, Func<ChatMessageEventType, IChatEventParser> chatEventEventBasedChatMessageParserGetter, ILogger logger)
	{
		_ChatEventChatMessageSourceParserGetter = chatEventChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("chatEventChatMessageSourceParserGetter");
		_ChatEventEventBasedChatMessageParserGetter = chatEventEventBasedChatMessageParserGetter ?? throw new PlatformArgumentNullException("_ChatEventEventBasedChatMessageParserGetter");
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
		if (!(chatMessageEntity is IEventBasedChatMessageEntity eventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException($"EventBased event parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		ChatEventMessageSource chatEventMessageSource = Translate(chatMessageSourceEntity);
		if (chatEventMessageSource == null)
		{
			return null;
		}
		ChatEventMessage obj = _ChatEventEventBasedChatMessageParserGetter(eventBasedChatMessageEntity.ChatMessageEventType)?.Translate(chatMessageEntity) ?? new ChatEventMessage();
		obj.MessageType = eventBasedChatMessageEntity.MessageType;
		obj.UniqueId = eventBasedChatMessageEntity.UniqueId;
		obj.ChatMessageEventType = eventBasedChatMessageEntity.ChatMessageEventType;
		obj.ChatEventMessageSource = chatEventMessageSource;
		obj.Sent = eventBasedChatMessageEntity.Sent.ToDateTime();
		obj.Decorators = eventBasedChatMessageEntity.Decorators;
		return obj;
	}

	public IChatMessageEntity Translate(IChatEventMessage chatEventMessage)
	{
		IChatEventMessageSource messageSource = chatEventMessage?.ChatEventMessageSource;
		if (messageSource == null)
		{
			throw new PlatformArgumentNullException("messageSource");
		}
		if (chatEventMessage.MessageType != ChatMessageType.EventBased)
		{
			throw new PlatformArgumentException($"EventBased chatEventParser cannot parse chatEventMessage with MessageType: {chatEventMessage.MessageType.ToString()}");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformException($"Could not translate chatEventMessage Source to the corresponding entity, chatEventMessageType: {chatEventMessage.MessageType.ToString()}");
		}
		if (!chatEventMessage.ChatMessageEventType.HasValue)
		{
			throw new PlatformException("EventBased ChatMessage needs a eventType to be set");
		}
		UtcInstant sent = UtcInstant.CoerceFrom(chatEventMessage.Sent, delegate(DateTimeKind kind)
		{
			_Logger.Error($"ChatEventMessage cannot be persisted since the 'sent' field is not UtcDateTime, kind -> {kind}");
		});
		ChatMessageEventType chatMessageEventType = chatEventMessage.ChatMessageEventType.Value;
		IEventBasedChatMessageEntity obj = (_ChatEventEventBasedChatMessageParserGetter(chatMessageEventType)?.Translate(chatEventMessage) as IEventBasedChatMessageEntity) ?? new EventBasedChatMessageEntity();
		obj.ChatMessageEventType = chatMessageEventType;
		obj.MessageType = chatEventMessage.MessageType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		obj.Sent = sent;
		obj.UniqueId = chatEventMessage.UniqueId;
		obj.Decorators = chatEventMessage.Decorators;
		return obj;
	}
}
