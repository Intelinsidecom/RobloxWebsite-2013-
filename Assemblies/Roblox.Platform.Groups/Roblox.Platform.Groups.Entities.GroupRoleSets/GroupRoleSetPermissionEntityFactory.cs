using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetPermissionEntityFactory : IGroupRoleSetPermissionEntityFactory
{
	public IEnumerable<IGroupRoleSetPermissionEntity> GetAllPermissionsByGroupRoleSetId(long groupRoleSetId)
	{
		if (groupRoleSetId == 0L)
		{
			throw new PlatformArgumentException("groupRoleSetId");
		}
		return GroupRoleSetPermission.GetRoleSetPermissionsByRoleSetID(groupRoleSetId).Select(CalToCached);
	}

	private IGroupRoleSetPermissionEntity CalToCached(GroupRoleSetPermission permission)
	{
		if (permission != null)
		{
			return new GroupRoleSetPermissionMssqlCachedEntity
			{
				Id = permission.ID,
				GroupRoleSetId = permission.RoleSetID,
				RoleSetPermissionTypeId = permission.RoleSetPermissionTypeID,
				Created = permission.Created,
				Updated = permission.Updated
			};
		}
		return null;
	}
}
