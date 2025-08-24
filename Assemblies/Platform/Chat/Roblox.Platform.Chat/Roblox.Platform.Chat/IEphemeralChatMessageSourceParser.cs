using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal interface IEphemeralChatMessageSourceParser
{
	List<HashEntry> GetChatMessageSourceHashEntries(IChatMessageSourceEntity chatMessageSourceEntity);

	IChatMessageSourceEntity GetChatMessageSourceEntityFromHashEntries(HashEntry[] hashEntries);

	IChatMessageSourceEntity Translate(IRawChatMessageSource rawChatMessageSource);
}
