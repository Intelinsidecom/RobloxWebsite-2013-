using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Badges;

/// <summary>
/// An exception thrown when an <see cref="T:Roblox.Platform.Membership.IUser" /> doesn't have permission
/// to create a badge for an <see cref="T:Roblox.Platform.Universes.IUniverse" />
/// </summary>
public class UnauthorizedBadgeCreationException : Exception
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	public IUser User { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	public IUniverse Universe { get; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.UnauthorizedBadgeCreationException" />.
	/// </summary>
	/// <param name="user">The <see cref="P:Roblox.Platform.Badges.UnauthorizedBadgeCreationException.User" />.</param>
	/// <param name="universe">The <see cref="P:Roblox.Platform.Badges.UnauthorizedBadgeCreationException.Universe" />.</param>
	public UnauthorizedBadgeCreationException(IUser user, IUniverse universe)
		: base($"{user?.Id} is not allowed to create a badge for {universe?.Name}")
	{
		User = user;
		Universe = universe;
	}
}
