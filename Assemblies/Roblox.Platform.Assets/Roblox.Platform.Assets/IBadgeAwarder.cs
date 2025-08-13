using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public interface IBadgeAwarder
{
	/// <summary>
	/// Check if the user owns a badge
	/// </summary>
	/// <param name="iUser">user identifier</param>
	/// <param name="assetBadgeType">type of the badge</param>
	/// <returns>whether the user owns the badge</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">if user is null</exception>
	bool UserOwnsBadge(IUserIdentifier iUser, BadgeType assetBadgeType);

	/// <summary>
	/// Award a badge to the user
	/// </summary>
	/// <param name="iUser">user identifier</param>
	/// <param name="assetBadgeType">type of the badge</param>
	/// /// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">if user is null</exception>
	void AwardBadge(IUserIdentifier iUser, BadgeType assetBadgeType);
}
