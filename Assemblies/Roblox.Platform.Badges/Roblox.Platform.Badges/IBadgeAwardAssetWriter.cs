using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// Creates and deletes <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />s.
/// </summary>
public interface IBadgeAwardAssetWriter
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />.
	/// </summary>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <param name="description">The <see cref="P:Roblox.Platform.Badges.IBadgeAwardAsset.Description" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badge" />, <paramref name="asset" /></exception>
	void CreateBadgeAward(IBadgeIdentifier badge, IAssetIdentifier asset, string description);

	/// <summary>
	/// Deletes an <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />.
	/// </summary>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badge" />, <paramref name="asset" /></exception>
	void DeleteBadgeAward(IBadgeIdentifier badge, IAssetIdentifier asset);
}
