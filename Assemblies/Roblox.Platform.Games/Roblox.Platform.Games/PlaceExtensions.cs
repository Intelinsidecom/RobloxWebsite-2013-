using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

public static class PlaceExtensions
{
	public static bool CanBeUpdated(this IPlace place)
	{
		return PlacePlayPermissionsProvider.CanBeUpdated(place);
	}

	public static bool IsFriendsOnly(this IPlace place)
	{
		return AssetOption.GetOrCreate(place.Id).IsFriendsOnly;
	}

	[Obsolete("Use IsPlaceUniverseRooted or IsPlaceUniverseRootedAndPublic instead.")]
	public static bool IsPlayable(this IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory)
	{
		PlayabilityResultEnum result;
		return PlacePlayPermissionsProvider.IsPlaceUniverseRootedAndPublic(place, groupFactory, universeFactory, out result);
	}

	[Obsolete("Use IsPlaceUniverseRooted or IsPlaceUniverseRootedAndPublic instead.")]
	public static bool IsPlayable(this IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		return PlacePlayPermissionsProvider.IsPlaceUniverseRootedAndPublic(place, groupFactory, universeFactory, out result);
	}

	/// <summary>
	/// Returns whether an <see cref="T:Roblox.Platform.Assets.IPlace" />'s <see cref="T:Roblox.Platform.Universes.IUniverse" /> is rooted.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="result">A <see cref="T:Roblox.Platform.Games.PlayabilityResultEnum" /> indicating that either <paramref name="place" /> is playable or the reason it is not playable.</param>
	/// <returns><c>true</c> if <paramref name="place" /> has a universe, and the universe has a root place. Returns <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	public static bool IsPlaceUniverseRooted(this IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		if (universeFactory == null)
		{
			throw new ArgumentException("universeFactory");
		}
		return PlacePlayPermissionsProvider.IsPlaceUniverseRooted(place, groupFactory, universeFactory, out result);
	}

	/// <summary>
	/// Returns whether an <see cref="T:Roblox.Platform.Assets.IPlace" />'s <see cref="T:Roblox.Platform.Universes.IUniverse" /> is rooted and is public.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="result">A <see cref="T:Roblox.Platform.Games.PlayabilityResultEnum" /> indicating that either <paramref name="place" /> is playable or the reason it is not playable.</param>
	/// <returns><c>true</c> if <paramref name="place" /> has a universe, the universe has a root place, and the universe is public. Returns <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	public static bool IsPlaceUniverseRootedAndPublic(this IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		if (universeFactory == null)
		{
			throw new ArgumentException("universeFactory");
		}
		return PlacePlayPermissionsProvider.IsPlaceUniverseRootedAndPublic(place, groupFactory, universeFactory, out result);
	}

	public static bool CanCreateReservedServer(this IPlace place, IPlace reservedServerPlace, IUniverseFactory universeFactory)
	{
		if (place == null || reservedServerPlace == null || universeFactory == null)
		{
			return false;
		}
		IUniverse originUniverse = universeFactory.GetPlaceUniverse(place);
		if (originUniverse == null)
		{
			return false;
		}
		IUniverse serveredServerUniverse = universeFactory.GetPlaceUniverse(reservedServerPlace);
		if (serveredServerUniverse == null)
		{
			return false;
		}
		return originUniverse.Id == serveredServerUniverse.Id;
	}
}
