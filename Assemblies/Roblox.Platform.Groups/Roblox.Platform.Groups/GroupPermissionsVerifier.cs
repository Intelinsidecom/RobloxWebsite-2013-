using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <inheritdoc cref="T:Roblox.Platform.Groups.IGroupPermissionsVerifier" />
public class GroupPermissionsVerifier : IGroupPermissionsVerifier
{
	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroupPermissionsVerifier.CanUserManageGroup(Roblox.Platform.Membership.IUser,Roblox.Platform.Groups.IGroup)" />
	public bool CanUserManageGroup(IUser user, IGroup group)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (!group.OwnerUserId.HasValue)
		{
			return false;
		}
		return group.OwnerUserId == user.Id;
	}
}
