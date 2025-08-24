using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetPermissionTypeEntityFactory : IGroupRoleSetPermissionTypeEntityFactory
{
	public IGroupRoleSetPermissionTypeEntity Get(int id)
	{
		Roblox.GroupRoleSetPermissionType cal = Roblox.GroupRoleSetPermissionType.Get(id);
		return Translate(cal);
	}

	public IGroupRoleSetPermissionTypeEntity GetByName(string name)
	{
		Roblox.GroupRoleSetPermissionType cal = Roblox.GroupRoleSetPermissionType.GetByName(name);
		return Translate(cal);
	}

	private IGroupRoleSetPermissionTypeEntity Translate(Roblox.GroupRoleSetPermissionType entity)
	{
		if (!(entity == null))
		{
			return new GroupRoleSetPermissionTypeMssqlCachedEntity
			{
				Id = entity.ID,
				Name = entity.Name,
				Description = entity.Description,
				Updated = entity.Updated
			};
		}
		return null;
	}
}
