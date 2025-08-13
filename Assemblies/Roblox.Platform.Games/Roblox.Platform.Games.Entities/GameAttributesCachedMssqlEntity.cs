using System;
using Roblox.Entities;

namespace Roblox.Platform.Games.Entities;

internal class GameAttributesCachedMssqlEntity : IGameAttributesEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long UniverseId { get; set; }

	public bool IsSecure { get; set; }

	public bool IsTrusted { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		GameAttributes cal = GameAttributes.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.UniverseID = UniverseId;
		cal.IsSecure = IsSecure;
		cal.IsTrusted = IsTrusted;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GameAttributes.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
