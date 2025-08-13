using System;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities.GroupRoleSets;

namespace Roblox.Platform.Groups;

internal class GroupRoleSetPermissionTypeConverter : IGroupRoleSetPermissionTypeConverter
{
	private readonly IGroupRoleSetPermissionTypeEntityFactory _GroupRoleSetPermissionTypeEntityFactory;

	public GroupRoleSetPermissionTypeConverter(IGroupRoleSetPermissionTypeEntityFactory groupRoleSetPermissionTypeEntityFactory)
	{
		_GroupRoleSetPermissionTypeEntityFactory = groupRoleSetPermissionTypeEntityFactory ?? throw new PlatformArgumentNullException("groupRoleSetPermissionTypeEntityFactory");
	}

	public GroupRoleSetPermissionType? GetTypeById(int id)
	{
		IGroupRoleSetPermissionTypeEntity cal = _GroupRoleSetPermissionTypeEntityFactory.Get(id);
		if (cal == null)
		{
			return null;
		}
		if (!Enum.TryParse<GroupRoleSetPermissionType>(cal.Name, out var result))
		{
			return null;
		}
		return result;
	}

	public int GetIdByType(GroupRoleSetPermissionType type)
	{
		return (_GroupRoleSetPermissionTypeEntityFactory.GetByName(type.ToString()) ?? throw new PlatformDataIntegrityException("Unable to get the entity.")).Id;
	}
}
