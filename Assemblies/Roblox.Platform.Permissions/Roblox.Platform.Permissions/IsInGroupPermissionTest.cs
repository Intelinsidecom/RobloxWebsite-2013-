using System;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsInGroupPermissionTest : UserPermissionTest
{
	private readonly IUserFactory _UserFactory;

	private readonly IGroupFactory _GroupFactory;

	internal IsInGroupPermissionTest(long? authenticatedUserId, long? targetId, IUserFactory userFactory, IGroupFactory groupFactory)
		: base(authenticatedUserId, targetId)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_GroupFactory = groupFactory ?? throw new ArgumentNullException("groupFactory");
		base.PermissionType = PermissionType.IsInGroup;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			if (_UserFactory.GetUser(base.AuthenticatedUserId.Value) == null || !base.PermissionTargetId.HasValue)
			{
				return false;
			}
			IGroup group = _GroupFactory.GetById(base.PermissionTargetId.Value);
			if (group == null)
			{
				return false;
			}
			return UserGroup.Get(base.AuthenticatedUserId.Value, group.Id) != null;
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
