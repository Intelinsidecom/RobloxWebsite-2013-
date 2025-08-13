using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Badges;

/// <summary>
/// Verifies permissions between users, and universes for badges
/// </summary>
public interface IBadgePermissionsVerifier
{
	/// <summary>
	/// Checks an <see cref="T:Roblox.Platform.Membership.IUser" />'s permissions for creating a new badge on an <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><c>true</c> if the user is allowed to create a badge.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" />, <paramref name="universe" /></exception>
	bool CanUserCreateBadgeForUniverse(IUser user, IUniverse universe);

	/// <summary>
	/// Checks whether the <see cref="T:Roblox.Platform.Badges.Badge" /> can be awarded by an <see cref="T:Roblox.Platform.Assets.IPlace" />
	/// </summary>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" />.</param>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" />, <paramref name="badge" /></exception>
	/// <returns><c>true</c> if the badge can be awarded.</returns>
	bool CanAwardBadge(IPlace place, Badge badge);

	/// <summary>
	/// Checks whether the <see cref="T:Roblox.Platform.Badges.Badge" /> can be managed by an <see cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" />, <paramref name="badge" /></exception>
	/// <returns><c>true</c> if the badge can be managed.</returns>
	bool CanUserManageBadge(IUser user, Badge badge);
}
