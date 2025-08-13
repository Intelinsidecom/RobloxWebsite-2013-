using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetPermissionEntity : IUpdateableEntity<long>, IEntity<long>
{
	long GroupRoleSetId { get; set; }

	int RoleSetPermissionTypeId { get; set; }
}
