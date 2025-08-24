using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class GameConstraintEntityFactory : IGameConstraintEntityFactory
{
	public IGameConstraintEntity Get(long id)
	{
		return CalToCachedMssql(GameConstraint.Get(id));
	}

	public IGameConstraintEntity GetByPlaceId(long placeId)
	{
		if (placeId == 0L || placeId < 0)
		{
			return null;
		}
		return CalToCachedMssql(GameConstraint.GetByPlaceID(placeId));
	}

	private static IGameConstraintEntity CalToCachedMssql(GameConstraint cal)
	{
		if (cal != null)
		{
			return new GameConstraintCachedMssqlEntity
			{
				Id = cal.ID,
				PlaceId = cal.PlaceID,
				MaxPlayers = cal.MaxPlayers,
				Created = cal.Created,
				Updated = cal.Updated,
				SocialSlots = cal.SocialSlots,
				SocialSlotTypeID = cal.SocialSlotTypeID
			};
		}
		return null;
	}

	public IGameConstraintEntity GetOrCreate(long placeId, int defaultMaxPlayers)
	{
		return CalToCachedMssql(GameConstraint.GetOrCreate(placeId, defaultMaxPlayers));
	}
}
