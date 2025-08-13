using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Badges;

/// <summary>
/// Gets <see cref="T:Roblox.Platform.Badges.Badge" />
/// </summary>
public interface IBadgeReader
{
	/// <summary>
	/// Gets the allowed page sizes.
	/// </summary>
	IReadOnlyCollection<int> AllowedPageSizes { get; }

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Badges.Badge" /> by <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />
	/// </summary>
	/// <param name="badgeId">The badge Identifier.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Badges.Badge" />.</returns>
	Badge GetBadge(long badgeId);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.Badges.Badge" /> for collection of <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />
	/// </summary>
	/// <param name="badgeIds">The badge Identifiers.</param>
	/// <exception cref="T:System.ArgumentException">
	/// <paramref name="badgeIds" /> Count is bigger than <see cref="P:Roblox.Platform.Badges.Properties.ISettings.BadgeReaderGetBadgesPerCallLimit" />, 
	/// </exception>
	/// <returns>The <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
	ICollection<Badge> GetBadges(ICollection<long> badgeIds);

	/// <summary>
	/// Returns badges which belongs to awarder.
	/// </summary>
	/// <param name="badgeAwarder">The badge awarder.</param>
	/// <param name="exclusiveStartInfo">The information of exclusive start key.</param>
	/// <returns>The page with information about paged results.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgeAwarder" />, <paramref name="exclusiveStartInfo" /></exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="badgeAwarder" /> is not of type <see cref="F:Roblox.Platform.Badges.BadgeAwarderType.Place" />
	/// - <paramref name="badgeAwarder" /> has invalid target Id.
	/// - Page size is not larger than zero
	/// - Exclusive start key is less than zero
	/// </exception>
	IPlatformPageResponse<long, Badge> GetBadgesByAwarder(IBadgeAwarder badgeAwarder, IExclusiveStartKeyInfo<long> exclusiveStartInfo);
}
