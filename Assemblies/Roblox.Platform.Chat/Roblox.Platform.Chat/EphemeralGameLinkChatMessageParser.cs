using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class EphemeralGameLinkChatMessageParser : IEphemeralLinkChatMessageParser
{
	private const string _HashField_GameLinkUniverseId = "GameLinkUniverseId";

	public List<HashEntry> GetLinkChatMessageHashEntries(ILinkChatMessageEntity linkChatMessageEntity)
	{
		if (linkChatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("linkChatMessageEntity");
		}
		if (!(linkChatMessageEntity is IGameLinkChatMessageEntity gameLinkChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("Chat Message with link type : {0} could not be casted to {1}", linkChatMessageEntity.ChatMessageLinkType, "IGameLinkChatMessageEntity"));
		}
		return new List<HashEntry>
		{
			new HashEntry("GameLinkUniverseId", gameLinkChatMessageEntity.UniverseId)
		};
	}

	public ILinkChatMessageEntity GetLinkChatMessageFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		if (!hashEntries.ToDictionary().TryGetValue("GameLinkUniverseId", out var universeIdValue) || !long.TryParse(universeIdValue, out var universeId))
		{
			return null;
		}
		return new GameLinkChatMessageEntity
		{
			UniverseId = universeId
		};
	}

	public ILinkChatMessageEntity Translate(IRawLinkChatMessage rawLinkChatMessage)
	{
		if (rawLinkChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawLinkChatMessage");
		}
		if (!(rawLinkChatMessage is IRawGameLinkChatMessage rawGameLinkChatMessage))
		{
			throw new PlatformArgumentException("rawGameLinkChatMessage");
		}
		return new GameLinkChatMessageEntity
		{
			UniverseId = rawGameLinkChatMessage.UniverseId
		};
	}
}
