using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public interface IGroupMembershipFactory
{
	IGroupMembership Get(IGroup group, IUser user);

	IGroupMembership CheckedGet(IUser user, long groupId);

	IGroupMembership Get(IGroup group, long? userId);

	IGroupMembership CheckedGet(long groupId, long? userId);

	IEnumerable<IGroupMembership> GetGroupMembershipsByUser(IUser user);

	/// <summary>
	/// Gets the group memberships for <paramref name="user" /> for groups the <see cref="T:Roblox.Platform.Membership.IUser" /> has permission to develop games in.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>List of <see cref="T:Roblox.Platform.Groups.IGroupMembership" />s, with <paramref name="user" />'s primary group first.</returns>
	ICollection<IGroupMembership> GetDevelopmentGroupMembershipsByUser(IUser user);
}
