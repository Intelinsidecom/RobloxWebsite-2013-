using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// A class that provides <see cref="T:Roblox.Platform.Badges.IBadgeAwarder" />s.
/// </summary>
public interface IBadgeAwarderProvider
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Badges.IBadgeAwarder" /> for an <see cref="T:Roblox.Platform.Assets.IPlace" />.
	/// </summary>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" /> <see cref="T:Roblox.Platform.AssetsCore.IAssetIdentifier" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Badges.IBadgeAwarder" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	IBadgeAwarder GetBadgeAwarderFromPlace(IAssetIdentifier place);
}
