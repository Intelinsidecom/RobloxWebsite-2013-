using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentPlainTextChatMessageParser : PersistentChatMessageParserBase, IPersistentChatMessageParser
{
	protected const string _ContentKey = "Content";

	private readonly ILogger _Logger;

	private readonly Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> _PersistentChatMessageSourceParserGetter;

	internal PersistentPlainTextChatMessageParser(Func<ChatMessageSourceType, IPersistentChatMessageSourceParser> persistentChatMessageSourceParserGetter, ILogger logger)
		: base(logger)
	{
		_PersistentChatMessageSourceParserGetter = persistentChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("persistentChatMessageSourceParserGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	protected override IPersistentChatMessageSourceParser GetPersistentEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		return _PersistentChatMessageSourceParserGetter(sourceType);
	}

	public Dictionary<string, AttributeValue> GetChatMessageAttributes(IChatMessageEntity chatMessageEntity)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
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
			throw new PlatformArgumentException($"PlainText message parser cannot parse message with type: {chatMessageEntity.MessageType}");
		}
		Dictionary<string, AttributeValue> chatMessageSourceAttributes = GetChatMessageSourceAttributes(chatMessageSourceEntity);
		chatMessageSourceAttributes.Add("Content", new AttributeValue
		{
			S = plainTextMessageEntity.Over13Content
		});
		return chatMessageSourceAttributes;
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
		return new PlainTextMessageEntity
		{
			Over13Content = chatMessageAttributes["Content"].S,
			ChatMessageSourceEntity = chatMessageSourceEntity
		};
	}
}
