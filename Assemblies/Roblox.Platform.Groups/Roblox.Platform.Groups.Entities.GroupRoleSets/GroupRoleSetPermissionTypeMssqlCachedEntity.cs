using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetPermissionTypeMssqlCachedEntity : IGroupRoleSetPermissionTypeEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public DateTime Created { get; }

	public string Description { get; set; }

	public DateTime Updated { get; set; }

	public string Name { get; set; }

	public void Update()
	{
		Roblox.GroupRoleSetPermissionType cal = Roblox.GroupRoleSetPermissionType.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted to update a non persistent entity.");
		}
		cal.Name = Name;
		cal.Description = Description;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.GroupRoleSetPermissionType groupRoleSetPermissionType = Roblox.GroupRoleSetPermissionType.Get(Id);
		if (groupRoleSetPermissionType == null)
		{
			throw new PlatformDataIntegrityException("Attempted to delete a non persistent entity.");
		}
		groupRoleSetPermissionType.Delete();
	}
}
