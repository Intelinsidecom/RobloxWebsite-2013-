using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// A badge award asset.
/// </summary>
/// <remarks>
/// Badge award assets are assets that get granted to a user
/// when they win a badge.
/// </remarks>
public interface IBadgeAwardAsset
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /> the asset is being awarded from.
	/// </summary>
	IBadgeIdentifier Badge { get; }

	/// <summary>
	/// The asset Id getting awarded.
	/// </summary>
	IAssetIdentifier Asset { get; }

	/// <summary>
	/// The badge award asset description.
	/// </summary>
	/// <remarks>
	/// The description is used for the marketing to be able to know
	/// what the awards are for.
	/// </remarks>
	string Description { get; }

	/// <summary>
	/// When the badge award asset was created.
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// When the badge award asset was last updated.
	/// </summary>
	DateTime Updated { get; }
}
