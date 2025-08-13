namespace Roblox.Platform.Badges.Properties;

/// <summary>
/// Settings belong to <see cref="N:Roblox.Platform.Badges" />.
/// </summary>
public interface ISettings
{
	/// <summary>
	/// The Robux cost of creating a new badge
	/// </summary>
	long BadgePurchaseRobuxPrice { get; }

	/// <summary>
	/// The economy marketplace product Id for a Roblox badge product
	/// </summary>
	long BadgeMarketplaceProductId { get; }

	/// <summary>
	/// The max length of a badge name
	/// </summary>
	int MaxBadgeNameLength { get; }

	/// <summary>
	/// The max length of a badge description
	/// </summary>
	int MaxBadgeDescriptionLength { get; }

	/// <summary>
	/// The max length for the <see cref="T:Roblox.Platform.Badges.Badge" /> <see cref="T:Roblox.Platform.Assets.IImage" /> icon name.
	/// </summary>
	int MaxBadgeIconNameLength { get; }

	/// <summary>
	///  Whether or not badge with fully moderated text is blocked (TextFilter throws)
	/// </summary>
	bool IsBadgeWithFullyModeratedTextBlocked { get; }

	/// <summary>
	/// Maximum amount of items which can be requested in one <see cref="M:Roblox.Platform.Badges.BadgeReader.GetBadges(System.Collections.Generic.ICollection{System.Int64})" /> call
	/// </summary>
	int BadgeReaderGetBadgesPerCallLimit { get; }

	/// <summary>
	/// Used to coerce the win rate percentage of a badge to look more proper.
	/// </summary>
	double BadgeRarityUniquenessCorrectionFactor { get; }
}
