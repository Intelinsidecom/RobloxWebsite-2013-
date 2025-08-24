using Roblox.Platform.Core;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationUniverseEntityFactory : IConversationUniverseEntityFactory
{
	public IConversationUniverseEntity Get(long id)
	{
		return CalToCachedMssql(ConversationUniverse.Get(id));
	}

	public IConversationUniverseEntity GetByConversationId(long conversationId)
	{
		if (conversationId <= 0)
		{
			throw new PlatformArgumentException("Conversation Id cannot be non-positive.");
		}
		return CalToCachedMssql(ConversationUniverse.GetByConversationId(conversationId));
	}

	public IConversationUniverseEntity Create(long conversationId, long universeId)
	{
		return CalToCachedMssql(ConversationUniverse.Create(conversationId, universeId));
	}

	private static IConversationUniverseEntity CalToCachedMssql(ConversationUniverse cal)
	{
		if (cal != null)
		{
			return new ConversationUniverseCachedMssqlEntity
			{
				Id = cal.ID,
				ConversationId = cal.ConversationId,
				UniverseId = cal.UniverseId,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
