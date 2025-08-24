using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal interface IEphemeralEventBasedChatMessageParser
{
	IReadOnlyCollection<HashEntry> GetEventBasedChatMessageHashEntries(IEventBasedChatMessageEntity eventBasedChatMessageEntity);

	IEventBasedChatMessageEntity GetEventBasedChatMessageEntityFromHashEntries(HashEntry[] hashEntries);

	IEventBasedChatMessageEntity Translate(IRawEventBasedChatMessage rawEventBasedChatMessage);
}
