using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetPermissionTypeEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Name { get; set; }

	string Description { get; set; }
}
