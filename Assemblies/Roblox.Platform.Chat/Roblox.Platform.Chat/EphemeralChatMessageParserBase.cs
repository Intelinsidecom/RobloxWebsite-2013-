using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal abstract class EphemeralChatMessageParserBase
{
	private const string _HashField_SourceType = "SenderType";

	protected abstract IEphemeralChatMessageSourceParser GetEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType);

	protected List<HashEntry> GetChatMessageSourceHashEntries(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		ChatMessageSourceType sourceType = chatMessageSourceEntity.SourceType;
		List<HashEntry> obj = GetEphemeralChatMessageSourceParser(sourceType)?.GetChatMessageSourceHashEntries(chatMessageSourceEntity) ?? new List<HashEntry>();
		obj.Add(new HashEntry("SenderType", (int)sourceType));
		return obj;
	}

	protected IChatMessageSourceEntity GetChatMessageSourceEntityFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		ChatMessageSourceType sourceType = ChatMessageSourceType.User;
		if (dictionary.TryGetValue("SenderType", out var senderTypeValue))
		{
			sourceType = (ChatMessageSourceType)(int)senderTypeValue;
		}
		IChatMessageSourceEntity obj = GetEphemeralChatMessageSourceParser(sourceType)?.GetChatMessageSourceEntityFromHashEntries(hashEntries) ?? new ChatMessageSourceEntity();
		obj.SourceType = sourceType;
		return obj;
	}

	protected IChatMessageSourceEntity Translate(IRawChatMessageSource rawChatMessageSource)
	{
		if (rawChatMessageSource == null)
		{
			throw new PlatformArgumentNullException("rawChatMessageSource");
		}
		ChatMessageSourceType sourceType = rawChatMessageSource.SourceType;
		IChatMessageSourceEntity obj = GetEphemeralChatMessageSourceParser(sourceType)?.Translate(rawChatMessageSource) ?? new ChatMessageSourceEntity();
		obj.SourceType = sourceType;
		return obj;
	}
}
