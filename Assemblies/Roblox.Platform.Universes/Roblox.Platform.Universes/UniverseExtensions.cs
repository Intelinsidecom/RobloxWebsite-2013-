using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Universes;

public static class UniverseExtensions
{
	[Obsolete("Use IUniverseFactory.GetPlaceUniverse instead.")]
	public static IUniverse GetUniverse(this IPlace place, IUniverseFactory universeFactory)
	{
		return universeFactory.GetPlaceUniverse(place);
	}

	[Obsolete]
	public static bool IsTeleportableFrom(this IPlace destination, IPlace origin, IUniverseFactory universeFactory)
	{
		if (destination == null)
		{
			return false;
		}
		IUniverse destinationUniverse = universeFactory.GetPlaceUniverse(destination);
		if (destinationUniverse == null)
		{
			return false;
		}
		if (destinationUniverse.RootPlaceId == destination.Id)
		{
			return true;
		}
		if (origin == null)
		{
			return false;
		}
		IUniverse originUniverse = universeFactory.GetPlaceUniverse(origin);
		if (originUniverse == null)
		{
			return false;
		}
		return originUniverse.Id == destinationUniverse.Id;
	}

	[Obsolete("Use explicit checks instead.")]
	public static void VerifyIsNotNull(this IUniverse universe, long? id = null)
	{
		if (universe != null)
		{
			return;
		}
		if (id.HasValue)
		{
			throw new UnknownUniverseException(id.Value);
		}
		throw new UnknownUniverseException();
	}

	[Obsolete]
	public static bool IsCreator(this IUserIdentifier user, IUniverse universe)
	{
		user.VerifyIsNotNull();
		universe.VerifyIsNotNull();
		if ((Roblox.Platform.Core.CreatorType)Enum.Parse(typeof(Roblox.Platform.Core.CreatorType), universe.CreatorType) != 0)
		{
			return false;
		}
		return user.Id == universe.CreatorTargetId;
	}
}
