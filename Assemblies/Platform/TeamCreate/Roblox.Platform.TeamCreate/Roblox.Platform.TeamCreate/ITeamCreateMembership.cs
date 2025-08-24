using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// An interface for information about a team create member
/// </summary>
/// <remarks>
/// This interface is only valid assuming the only entities that can be members are <see cref="T:Roblox.Platform.Membership.IUser" />s
/// If we extend team create outside of just <see cref="T:Roblox.Platform.Membership.IUser" />s we should make a new interface.
/// </remarks>
public interface ITeamCreateMembership
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	IUser User { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	IUniverse Universe { get; }

	/// <summary>
	/// The <see cref="T:System.DateTime" /> the membership was granted
	/// </summary>
	DateTime GrantDate { get; }
}
