using Roblox.Platform.Counters;

namespace Roblox.Platform.Badges;

/// <summary>
/// BadgeCounter information
/// </summary>
public interface IBadgeCounter
{
	/// <summary>
	/// Increments the awarded count for an <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />
	/// </summary>
	/// <param name="badgeIdentifier"> The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgeIdentifier" /></exception>
	void IncrementBadgeAwardCounter(IBadgeIdentifier badgeIdentifier);

	/// <summary>
	/// Returns the count of badge award of a period of time
	/// </summary>
	/// <remarks>Returns 0 when it fails.</remarks>
	/// <param name="badgeIdentifier"> The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /></param>
	/// <param name="frequency">the time period of the count of badge award</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgeIdentifier" /></exception>
	/// <returns>Count of badge award of a period of time.</returns>
	long GetBadgeAwardCount(IBadgeIdentifier badgeIdentifier, Frequency frequency);

	/// <summary>
	/// Returns the win rate percentage of a <see cref="T:Roblox.Platform.Badges.Badge" />.
	/// </summary>
	/// <remarks>
	/// Ideally <paramref name="pastDayRootPlaceVisits" /> could be calculated in the implementation, and would
	/// use the unique universe visit count. But the unique universe visit count is not something  possible to
	/// obtain at the moment.
	/// Until it is, or past day place visit count is more accessible the number will have to be passed in.
	/// </remarks>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /> for the <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <param name="pastDayRootPlaceVisits">The place visit count for the root place the <see cref="T:Roblox.Platform.Badges.Badge" /> is awarded from in the past day.</param>
	/// <returns>The win rate percentage.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badge" /></exception>
	double GetBadgeWinRatePercentage(IBadgeIdentifier badge, long pastDayRootPlaceVisits);
}
