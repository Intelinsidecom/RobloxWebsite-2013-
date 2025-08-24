using System;
using Roblox.Entities;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationUniverseCachedMssqlEntity : IConversationUniverseEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long ConversationId { get; set; }

	public long UniverseId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		ConversationUniverse cal = ConversationUniverse.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.ConversationId = ConversationId;
		cal.UniverseId = UniverseId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(ConversationUniverse.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
