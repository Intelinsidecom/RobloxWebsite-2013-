using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentEventBasedChatMessageParser : PersistentChatMessageParserBase, IPersistentChatMessageParser
{
	protected const string _ChatMessageEventTypeKey = "EventType";

	private readonly ILogger _Logger;

	private readonly Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> _PersistentChatMessageSourceParserGetter;

	private readonly Func<ChatMessageEventType, IPersistentEventBasedChatMessageParser> _PersistentEventBasedChatMessageParserGetter;

	internal PersistentEventBasedChatMessageParser(Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> persistentChatMessageSourceParserGetter, Func<ChatMessageEventType, IPersistentEventBasedChatMessageParser> persistentEventBasedChatMessageParserGetter, ILogger logger)
		: base(logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_PersistentChatMessageSourceParserGetter = persistentChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("persistentChatMessageSourceParserGetter");
		_PersistentEventBasedChatMessageParserGetter = persistentEventBasedChatMessageParserGetter ?? throw new PlatformArgumentNullException("persistentEventBasedChatMessageParserGetter");
	}

	protected override IPersistentChatMessageSourceParser GetPersistentEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		return _PersistentChatMessageSourceParserGetter(sourceType);
	}

	public Dictionary<string, AttributeValue> GetChatMessageAttributes(IChatMessageEntity chatMessageEntity)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
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
			throw new PlatformArgumentException($"EventBased chat message parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		Dictionary<string, AttributeValue> attributes = GetChatMessageSourceAttributes(chatMessageSourceEntity);
		ChatMessageEventType chatMessageEventType = eventBasedChatMessageEntity.ChatMessageEventType;
		AttributeValue val = new AttributeValue();
		int num = (int)chatMessageEventType;
		val.N = num.ToString();
		attributes.Add("EventType", val);
		List<KeyValuePair<string, AttributeValue>> eventBasedChatMessageAttributes = _PersistentEventBasedChatMessageParserGetter(chatMessageEventType)?.GetEventBasedChatMessageAttributes(eventBasedChatMessageEntity);
		if (eventBasedChatMessageAttributes == null)
		{
			return attributes;
		}
		foreach (KeyValuePair<string, AttributeValue> attribute in eventBasedChatMessageAttributes)
		{
			attributes.Add(attribute.Key, attribute.Value);
		}
		return attributes;
	}

	public IChatMessageEntity GetChatMessageFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes)
	{
		if (chatMessageAttributes == null)
		{
			return null;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = GetChatMessageSourceEntityFromDictionary(chatMessageAttributes);
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("EventType", out var chatMessageEventTypeString) || !int.TryParse(chatMessageEventTypeString.N, out var chatMessageEventTypeInt))
		{
			_Logger.Error($"The chatMessageEventType could not be parsed from the chat message dictionary -> ChatMessageEventType : {chatMessageEventTypeString}");
			return null;
		}
		ChatMessageEventType chatMessageEventType = (ChatMessageEventType)chatMessageEventTypeInt;
		IEventBasedChatMessageEntity obj = _PersistentEventBasedChatMessageParserGetter(chatMessageEventType)?.GetEventBasedChatMessageEntityFromDictionary(chatMessageAttributes) ?? new EventBasedChatMessageEntity();
		obj.ChatMessageEventType = chatMessageEventType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		return obj;
	}
}
