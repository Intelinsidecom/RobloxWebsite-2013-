namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetPermissionTypeEntityFactory
{
	IGroupRoleSetPermissionTypeEntity Get(int id);

	IGroupRoleSetPermissionTypeEntity GetByName(string name);
}
