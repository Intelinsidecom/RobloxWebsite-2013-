using System.Collections.Generic;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetPermissionEntityFactory
{
	IEnumerable<IGroupRoleSetPermissionEntity> GetAllPermissionsByGroupRoleSetId(long groupRoleSetId);
}
