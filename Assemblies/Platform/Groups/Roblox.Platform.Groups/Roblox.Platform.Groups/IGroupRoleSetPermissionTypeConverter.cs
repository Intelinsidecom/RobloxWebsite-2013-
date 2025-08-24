namespace Roblox.Platform.Groups;

internal interface IGroupRoleSetPermissionTypeConverter
{
	GroupRoleSetPermissionType? GetTypeById(int id);

	int GetIdByType(GroupRoleSetPermissionType type);
}
