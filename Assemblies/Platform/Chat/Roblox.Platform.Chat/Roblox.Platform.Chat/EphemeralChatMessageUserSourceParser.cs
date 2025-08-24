using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class EphemeralChatMessageUserSourceParser : IEphemeralChatMessageSourceParser
{
	private const string _HashField_SourceUserId = "SenderUserId";

	public List<HashEntry> GetChatMessageSourceHashEntries(IChatMessageSourceEntity chatMessageSourceEntity)
	{
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageSourceEntity");
		}
		if (!(chatMessageSourceEntity is IChatMessageUserSourceEntity chatMessageSourceUserEntity))
		{
			throw new PlatformArgumentException("Chat message source type is not chat message user source type");
		}
		return new List<HashEntry>
		{
			new HashEntry("SenderUserId", chatMessageSourceUserEntity.SourceUserId)
		};
	}

	public IChatMessageSourceEntity GetChatMessageSourceEntityFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		if (!hashEntries.ToDictionary().TryGetValue("SenderUserId", out var senderUserIdValue) || !long.TryParse(senderUserIdValue, out var senderUserId))
		{
			return null;
		}
		return new ChatMessageUserSourceEntity
		{
			SourceUserId = senderUserId
		};
	}

	public IChatMessageSourceEntity Translate(IRawChatMessageSource rawChatMessageSource)
	{
		if (rawChatMessageSource == null)
		{
			throw new PlatformArgumentNullException("rawChatMessageSource");
		}
		if (!(rawChatMessageSource is IRawChatMessageUserSource rawChatMessageUserSource))
		{
			throw new PlatformArgumentException("rawChatMessageUserSource");
		}
		return new ChatMessageUserSourceEntity
		{
			SourceUserId = rawChatMessageUserSource.SourceUserId
		};
	}
}
