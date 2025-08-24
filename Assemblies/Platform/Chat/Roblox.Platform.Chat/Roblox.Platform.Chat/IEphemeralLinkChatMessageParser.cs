using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal interface IEphemeralLinkChatMessageParser
{
	List<HashEntry> GetLinkChatMessageHashEntries(ILinkChatMessageEntity linkChatMessageEntity);

	ILinkChatMessageEntity GetLinkChatMessageFromHashEntries(HashEntry[] hashEntries);

	ILinkChatMessageEntity Translate(IRawLinkChatMessage rawLinkChatMessage);
}
