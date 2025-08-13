using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />
internal class BadgeAwardAsset : IBadgeAwardAsset
{
	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Badge" />
	public IBadgeIdentifier Badge { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Asset" />
	public IAssetIdentifier Asset { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Description" />
	public string Description { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Created" />
	public DateTime Created { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Updated" />
	public DateTime Updated { get; set; }
}
