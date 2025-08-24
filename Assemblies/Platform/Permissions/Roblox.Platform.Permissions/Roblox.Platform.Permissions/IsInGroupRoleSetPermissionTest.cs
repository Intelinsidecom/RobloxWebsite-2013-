using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsInGroupRoleSetPermissionTest : UserPermissionTest
{
	internal GroupDomainFactories GroupDomainFactories { get; }

	internal IUserFactory UserFactory { get; }

	internal IsInGroupRoleSetPermissionTest(long? authenticatedUserId, long? targetId, GroupDomainFactories groupDomainFactories, IUserFactory userfactory)
		: base(authenticatedUserId, targetId)
	{
		GroupDomainFactories = groupDomainFactories;
		UserFactory = userfactory;
		base.PermissionType = PermissionType.IsInGroupRoleSet;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			IUser user = UserFactory.GetUser(base.AuthenticatedUserId.Value);
			if (user == null || !base.PermissionTargetId.HasValue)
			{
				return false;
			}
			IGroupRoleSet targetGroupRoleSet = GroupDomainFactories.GroupRoleSetAccessor.GetById((int)base.PermissionTargetId.Value);
			if (targetGroupRoleSet == null)
			{
				return false;
			}
			IGroupRoleSet actualGroupRoleSet = GroupDomainFactories.GroupFactory.GetById(targetGroupRoleSet.GroupId).GetGroupRoleSetByUserId(user);
			return targetGroupRoleSet.Id == actualGroupRoleSet.Id;
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
