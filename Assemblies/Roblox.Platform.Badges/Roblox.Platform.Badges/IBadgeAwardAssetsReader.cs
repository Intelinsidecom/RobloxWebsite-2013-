using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Badges;

/// <summary>
/// A class to get assets granted from <see cref="T:Roblox.Platform.Badges.Badge" /> awards.
/// </summary>
public interface IBadgeAwardAssetsReader
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" /> that should be granted when a <see cref="T:Roblox.Platform.Badges.Badge" /> is awarded.
	/// </summary>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <returns>The collection of the <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" /> Ids.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badge" /></exception>
	ICollection<IBadgeAwardAsset> GetBadgeAwardAssetsByBadge(IBadgeIdentifier badge);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />s.
	/// </summary>
	/// <param name="exclusiveStartKey">The paging details.</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.Badges.IBadgeAwardAsset" />s.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="exclusiveStartKey" /></exception>
	IPlatformPageResponse<int, IBadgeAwardAsset> GetBadgeAwardAssets(IExclusiveStartKeyInfo<int> exclusiveStartKey);

	/// <summary>
	/// Returns the total number of badge award assets.
	/// </summary>
	/// <remarks>
	/// Exists to not expose the entity.
	/// Ideally we wouldn't expose this count but it's still in use.
	/// </remarks>
	/// <returns>The total number of badge award assets.</returns>
	long GetTotalNumberOfBadgeAwardAssets();
}
