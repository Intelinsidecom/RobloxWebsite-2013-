namespace Roblox.Platform.Badges;

/// <summary>
/// Logs group action related to platform badges events. 
/// </summary>
public interface IPlatformBadgeEventGroupActionLogger
{
	/// <summary>
	/// Badge updated handler
	/// </summary>
	/// <param name="badge">Updated badge <see cref="T:Roblox.Platform.Badges.Badge" /></param>
	/// <param name="badgeUpdateType">Badge update type <see cref="T:Roblox.Platform.Badges.BadgeUpdateType" /></param>
	void OnBadgeUpdated(Badge badge, BadgeUpdateType badgeUpdateType);

	/// <summary>
	/// Badge created handler
	/// </summary>
	/// <param name="badge">Created badge <see cref="T:Roblox.Platform.Badges.Badge" /></param>
	void OnBadgeCreated(Badge badge);
}
