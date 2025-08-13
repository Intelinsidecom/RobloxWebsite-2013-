using System;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Moderation;
using Roblox.Platform.Universes;
using Roblox.Universes.Client;
using Roblox.Web.ElevatedActions;

namespace Roblox.Platform.Games;

/// <summary>
/// Static class used by extensions only
/// </summary>
internal static class PlacePlayPermissionsProvider
{
	internal static bool CanPlay(IUser user, IPlace place, IAssetPermissionsVerifier assetPermissionsVerifier)
	{
		AssetModerationStatus moderationStatus = place.GetModerationStatus();
		if (user == null)
		{
			return moderationStatus == AssetModerationStatus.Green;
		}
		if (user.HasElevatedActionAuthorization("OverrideCanPlay"))
		{
			return true;
		}
		return moderationStatus switch
		{
			AssetModerationStatus.Green => true, 
			AssetModerationStatus.Yellow => true, 
			AssetModerationStatus.Orange => assetPermissionsVerifier.CanManage(user, place), 
			AssetModerationStatus.Red => false, 
			_ => throw new ApplicationException("Unknown ModerationStatus: " + moderationStatus), 
		};
	}

	internal static bool CanBeUpdated(IPlace place)
	{
		AssetModerationStatus moderationStatus = place.GetModerationStatus();
		return moderationStatus switch
		{
			AssetModerationStatus.Green => true, 
			AssetModerationStatus.Yellow => true, 
			AssetModerationStatus.Orange => false, 
			AssetModerationStatus.Red => false, 
			_ => throw new ApplicationException("Unknown ModerationStatus: " + moderationStatus), 
		};
	}

	[Obsolete("Use IsPlaceUniverseRooted or IsPlaceUniverseRootedAndPublic instead.")]
	internal static bool IsPlayable(IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (place.TypeId != AssetType.PlaceID)
		{
			result = PlayabilityResultEnum.NotAPlace;
			return false;
		}
		if (universeFactory == null)
		{
			throw new PlatformArgumentNullException("Must provide a universe factory.");
		}
		IUniverse universe = universeFactory.GetPlaceUniverse(place.Id);
		if (universe == null)
		{
			result = PlayabilityResultEnum.PlaceHasNoUniverse;
			return false;
		}
		if (!universe.RootPlaceId.HasValue)
		{
			result = PlayabilityResultEnum.UniverseDoesNotHaveARootPlace;
			return false;
		}
		if (universe.RootPlaceId.Value != place.Id)
		{
			return IsPlayable(Roblox.Platform.Assets.Factories.PlaceFactory.Get(universe.RootPlaceId.Value), groupFactory, universeFactory, out result);
		}
		string privacyType = universe.PrivacyType;
		PrivacyType val = (PrivacyType)1;
		if (privacyType != ((object)(PrivacyType)(ref val)).ToString())
		{
			result = PlayabilityResultEnum.UniverseRootPlaceIsNotActive;
			return false;
		}
		result = PlayabilityResultEnum.Playable;
		return true;
	}

	/// <summary>
	/// Returns whether <paramref name="place" /> has a universe with a root place.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="result">A <see cref="T:Roblox.Platform.Games.PlayabilityResultEnum" /> indicating that either <paramref name="place" /> is playable, or the reason it is not playable.</param>
	/// <returns><c>true</c> if <paramref name="place" /> has a universe and the universe has a root place. Returns <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	internal static bool IsPlaceUniverseRooted(IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		IUniverse universe = universeFactory.GetPlaceUniverse(place);
		if (universe == null)
		{
			result = PlayabilityResultEnum.PlaceHasNoUniverse;
			return false;
		}
		if (!universe.RootPlaceId.HasValue)
		{
			result = PlayabilityResultEnum.UniverseDoesNotHaveARootPlace;
			return false;
		}
		result = PlayabilityResultEnum.Playable;
		return true;
	}

	/// <summary>
	/// Returns whether <paramref name="place" /> has a universe with a root place and is public.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="result">A <see cref="T:Roblox.Platform.Games.PlayabilityResultEnum" /> indicating that either <paramref name="place" /> is playable, or the reason it is not playable.</param>
	/// <returns><c>true</c> if <paramref name="place" /> has a universe, the universe has a root place, and the universe is public. Returns <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	internal static bool IsPlaceUniverseRootedAndPublic(IPlace place, IGroupFactory groupFactory, IUniverseFactory universeFactory, out PlayabilityResultEnum result)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		IUniverse universe = universeFactory.GetPlaceUniverse(place);
		if (universe == null)
		{
			result = PlayabilityResultEnum.PlaceHasNoUniverse;
			return false;
		}
		if (!universe.RootPlaceId.HasValue)
		{
			result = PlayabilityResultEnum.UniverseDoesNotHaveARootPlace;
			return false;
		}
		string privacyType = universe.PrivacyType;
		PrivacyType val = (PrivacyType)1;
		bool playable = privacyType == ((object)(PrivacyType)(ref val)).ToString();
		result = ((!playable) ? PlayabilityResultEnum.UniverseRootPlaceIsNotActive : PlayabilityResultEnum.Playable);
		return playable;
	}
}
