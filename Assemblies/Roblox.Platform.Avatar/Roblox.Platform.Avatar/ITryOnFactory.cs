using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// A factory to try on unowned assets and create performance monitoring instances to track usage of the feature.
/// Also contains a method to ascentain if a specific asset can be tried on (i.e. whether the asset is werable).
/// </summary>
public interface ITryOnFactory
{
	/// <summary>
	/// An event to track try on usage using <see cref="T:Roblox.Platform.Avatar.IAvatarTracker" />
	/// </summary>
	event Action<AvatarChangedEventArgs> TryOnEvent;

	/// <summary>
	/// Creates a temporary <see cref="T:Roblox.Platform.Outfits.IOutfit" /> with the list of clothing assets added to the current user's avatar. 
	/// </summary>
	/// <param name="wearableAssets">A list of assets to be added to the current user's avatar.</param>
	/// <param name="user">The user trying on the item.</param>
	/// <param name="applyDefaultClothing">Whether to apply default clothing to the thumbnail.</param>
	/// <param name="trackUsage">Whether to track try on usage with AvatarTracker</param>
	/// <returns>A <see cref="T:Roblox.Platform.Outfits.TemporaryOutfit" /></returns>
	IOutfit GetTemporaryOutfit(ICollection<Roblox.Platform.Assets.IAsset> wearableAssets, IUser user, bool applyDefaultClothing = true, bool trackUsage = true);

	/// <summary>
	/// Returns true if the asset can be tried on. Returns false otherwise.
	/// </summary>
	/// <param name="asset">The asset to try on.</param>
	/// <returns>Whether the asset can be tried on.</returns>
	bool IsAssetEligibleForTryingOn(Roblox.Platform.Assets.IAsset asset);
}
