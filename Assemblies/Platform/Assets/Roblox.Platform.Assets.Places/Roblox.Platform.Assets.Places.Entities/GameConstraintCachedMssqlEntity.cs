using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class GameConstraintCachedMssqlEntity : IGameConstraintEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long PlaceId { get; set; }

	public int MaxPlayers { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public int? SocialSlots { get; set; }

	public int? SocialSlotTypeID { get; set; }

	public void Update()
	{
		GameConstraint cal = GameConstraint.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.PlaceID = PlaceId;
		cal.MaxPlayers = MaxPlayers;
		cal.SocialSlots = SocialSlots;
		cal.SocialSlotTypeID = SocialSlotTypeID;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GameConstraint.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
