using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class EphemeralSetConversationUniverseEventBasedChatMessageParser : IEphemeralEventBasedChatMessageParser
{
	private const string _HashField_SetConversationUniverseEventBasedActorUserId = "SetUniverseActorUserId";

	private const string _HashField_SetConversationUniverseEventBasedUniverseId = "SetUniverseId";

	public IReadOnlyCollection<HashEntry> GetEventBasedChatMessageHashEntries(IEventBasedChatMessageEntity eventBasedChatMessageEntity)
	{
		if (eventBasedChatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("eventBasedChatMessageEntity");
		}
		if (!(eventBasedChatMessageEntity is ISetConversationUniverseEventBasedChatMessageEntity setConversationUniverseEventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("Chat Message with event type : {0} could not be casted to {1}", eventBasedChatMessageEntity.ChatMessageEventType, "ISetConversationUniverseEventBasedChatMessageEntity"));
		}
		return new List<HashEntry>
		{
			new HashEntry("SetUniverseActorUserId", setConversationUniverseEventBasedChatMessageEntity.ActorUserId),
			new HashEntry("SetUniverseId", setConversationUniverseEventBasedChatMessageEntity.UniverseId)
		};
	}

	public IEventBasedChatMessageEntity GetEventBasedChatMessageEntityFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		if (!dictionary.TryGetValue("SetUniverseActorUserId", out var actorUserIdValue) || !long.TryParse(actorUserIdValue, out var actorUserId))
		{
			return null;
		}
		if (!dictionary.TryGetValue("SetUniverseId", out var universeIdValue) || !long.TryParse(universeIdValue, out var universeId))
		{
			return null;
		}
		return new SetConversationUniverseEventBasedChatMessageEntity
		{
			ActorUserId = actorUserId,
			UniverseId = universeId
		};
	}

	public IEventBasedChatMessageEntity Translate(IRawEventBasedChatMessage rawEventBasedChatMessage)
	{
		if (rawEventBasedChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawEventBasedChatMessage");
		}
		if (!(rawEventBasedChatMessage is IRawSetConversationUniverseEventBasedChatMessage rawSetConversationUniverseEventBasedChatMessage))
		{
			throw new PlatformArgumentException("rawSetConversationUniverseEventBasedChatMessage");
		}
		return new SetConversationUniverseEventBasedChatMessageEntity
		{
			ActorUserId = rawSetConversationUniverseEventBasedChatMessage.ActorUserId,
			UniverseId = rawSetConversationUniverseEventBasedChatMessage.UniverseId
		};
	}
}
