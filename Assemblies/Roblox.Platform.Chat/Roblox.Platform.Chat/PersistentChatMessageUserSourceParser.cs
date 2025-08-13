using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentChatMessageUserSourceParser : IPersistentChatMessageSourceParser
{
	protected const string _SourceUserIdKey = "SenderTargetId";

	private readonly ILogger _Logger;

	public PersistentChatMessageUserSourceParser(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public Dictionary<string, AttributeValue> GetChatMessageSourceAttributes(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		if (!(chatMessageSourceEntity is IChatMessageUserSourceEntity chatMessageSourceUserEntity))
		{
			throw new PlatformArgumentException($"User message source parser cannot parse message source with type: {chatMessageSourceEntity.SourceType}");
		}
		return new Dictionary<string, AttributeValue> { 
		{
			"SenderTargetId",
			new AttributeValue
			{
				N = chatMessageSourceUserEntity.SourceUserId.ToString()
			}
		} };
	}

	public IChatMessageSourceEntity GetChatMessageSourceEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes)
	{
		if (chatMessageAttributes == null)
		{
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("SenderTargetId", out var senderUserIdString) || !long.TryParse(senderUserIdString.N, out var sourceUserId))
		{
			_Logger.Error($"The sender userId could not be parsed from the chat message dictionary -> SenderTargetId : {senderUserIdString}");
			return null;
		}
		return new ChatMessageUserSourceEntity
		{
			SourceUserId = sourceUserId
		};
	}
}
