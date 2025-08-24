using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Badges;

/// <summary>
/// An exception thrown when an <see cref="T:Roblox.Platform.Membership.IUser" /> does not have permission to use
/// an <see cref="T:Roblox.Platform.Assets.IImage" /> as a badge icon.
/// </summary>
public class UnauthorizedBadgeIconUsageException : Exception
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	public IUser User { get; }

	/// <summary>
	/// The badge icon <see cref="T:Roblox.Platform.Assets.IImage" />.
	/// </summary>
	public IImage BadgeIcon { get; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.UnauthorizedBadgeIconUsageException" />.
	/// </summary>
	/// <param name="user">The <see cref="P:Roblox.Platform.Badges.UnauthorizedBadgeIconUsageException.User" />.</param>
	/// <param name="badgeIcon">The <see cref="P:Roblox.Platform.Badges.UnauthorizedBadgeIconUsageException.BadgeIcon" />.</param>
	public UnauthorizedBadgeIconUsageException(IUser user, IImage badgeIcon)
	{
		User = user;
		BadgeIcon = badgeIcon;
	}
}
