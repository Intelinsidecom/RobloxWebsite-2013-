using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentLinkChatMessageParser : PersistentChatMessageParserBase, IPersistentChatMessageParser
{
	protected const string _ChatMessageLinkTypeKey = "LinkType";

	private readonly ILogger _Logger;

	private readonly Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> _PersistentChatMessageSourceParserGetter;

	private readonly Func<ChatMessageLinkType, IPersistentLinkChatMessageParser> _PersistentLinkChatMessageParserGetter;

	internal PersistentLinkChatMessageParser(Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> persistentChatMessageSourceParserGetter, Func<ChatMessageLinkType, IPersistentLinkChatMessageParser> persistentLinkChatMessageParserGetter, ILogger logger)
		: base(logger)
	{
		_PersistentChatMessageSourceParserGetter = persistentChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("persistentChatMessageSourceParserGetter");
		_PersistentLinkChatMessageParserGetter = persistentLinkChatMessageParserGetter ?? throw new PlatformArgumentNullException("persistentLinkChatMessageParserGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
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
		if (!(chatMessageEntity is ILinkChatMessageEntity linkChatMessageEntity))
		{
			throw new PlatformArgumentException($"Link chat message parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		Dictionary<string, AttributeValue> attributes = GetChatMessageSourceAttributes(chatMessageSourceEntity);
		ChatMessageLinkType chatMessageLinkType = linkChatMessageEntity.ChatMessageLinkType;
		AttributeValue val = new AttributeValue();
		int num = (int)chatMessageLinkType;
		val.N = num.ToString();
		attributes.Add("LinkType", val);
		List<KeyValuePair<string, AttributeValue>> linkChatMessageAttributes = _PersistentLinkChatMessageParserGetter(chatMessageLinkType)?.GetLinkChatMessageAttributes(linkChatMessageEntity);
		if (linkChatMessageAttributes == null)
		{
			return attributes;
		}
		foreach (KeyValuePair<string, AttributeValue> attribute in linkChatMessageAttributes)
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
		if (!chatMessageAttributes.TryGetValue("LinkType", out var chatMessageLinkTypeString) || !int.TryParse(chatMessageLinkTypeString.N, out var chatMessageLinkTypeInt))
		{
			_Logger.Error($"The chatMessageLinkType could not be parsed from the chat message dictionary -> ChatMessageLinkType : {chatMessageLinkTypeString}");
			return null;
		}
		ChatMessageLinkType chatMessageLinkType = (ChatMessageLinkType)chatMessageLinkTypeInt;
		ILinkChatMessageEntity obj = _PersistentLinkChatMessageParserGetter(chatMessageLinkType)?.GetLinkChatMessageEntityFromDictionary(chatMessageAttributes) ?? new LinkChatMessageEntity();
		obj.ChatMessageLinkType = chatMessageLinkType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		return obj;
	}
}
