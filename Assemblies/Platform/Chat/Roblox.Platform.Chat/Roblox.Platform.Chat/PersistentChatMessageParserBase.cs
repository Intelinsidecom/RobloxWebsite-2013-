using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal abstract class PersistentChatMessageParserBase
{
	protected const string _SourceTypeKey = "SenderType";

	private readonly ILogger _Logger;

	protected abstract IPersistentChatMessageSourceParser GetPersistentEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType);

	internal PersistentChatMessageParserBase(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	protected Dictionary<string, AttributeValue> GetChatMessageSourceAttributes(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		ChatMessageSourceType sourceType = chatMessageSourceEntity.SourceType;
		Dictionary<string, AttributeValue> obj = GetPersistentEphemeralChatMessageSourceParser(sourceType)?.GetChatMessageSourceAttributes(chatMessageSourceEntity) ?? new Dictionary<string, AttributeValue>();
		AttributeValue val = new AttributeValue();
		int num = (int)sourceType;
		val.N = num.ToString();
		obj.Add("SenderType", val);
		return obj;
	}

	protected IChatMessageSourceEntity GetChatMessageSourceEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes)
	{
		if (chatMessageAttributes == null)
		{
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("SenderType", out var senderTypeString) || !int.TryParse(senderTypeString.N, out var sourceTypeInt))
		{
			_Logger.Error($"The sender type could not be parsed from the chat message dictionary -> SenderType : {senderTypeString}");
			return null;
		}
		ChatMessageSourceType sourceType = (ChatMessageSourceType)sourceTypeInt;
		IChatMessageSourceEntity obj = GetPersistentEphemeralChatMessageSourceParser(sourceType)?.GetChatMessageSourceEntityFromDictionary(chatMessageAttributes) ?? new ChatMessageSourceEntity();
		obj.SourceType = sourceType;
		return obj;
	}
}
