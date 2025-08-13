using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// A platform interface to store the group.
/// </summary>
public interface IGroup
{
	long Id { get; }

	long AgentId { get; }

	long? PreviousOwnerUserId { get; }

	long? OwnerUserId { get; }

	string Name { get; set; }

	string Description { get; set; }

	long EmblemId { get; }

	bool PublicEntryAllowed { get; }

	bool BCOnly { get; }

	bool HasClan { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	GroupDomainFactories DomainFactories { get; }

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> user identifier. If the <paramref name="user" /> is null, this returns a guest RoleSet.
	/// // TODO Extract the getting of guest roleset logic from SCL and move to platform.
	/// </summary>
	/// <param name="user">The user identifier.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </returns>
	IGroupRoleSet GetGroupRoleSetByUserId(IUser user);

	/// <summary>
	/// Whether or not the group is locked.
	/// </summary>
	/// <returns><c>true</c> if the group is locked.</returns>
	bool IsLocked();

	/// <summary>
	/// Locks the group.
	/// Users will not be able to access the groups page, no new members may join, no users may post etc.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> locking the group.</param>
	void Lock(IUser user);

	/// <summary>
	/// Unlocks the group.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> unlocking the group.</param>
	void Unlock(IUser user);
}
