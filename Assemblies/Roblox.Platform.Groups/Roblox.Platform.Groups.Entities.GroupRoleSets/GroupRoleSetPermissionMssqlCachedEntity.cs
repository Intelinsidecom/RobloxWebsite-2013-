using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetPermissionMssqlCachedEntity : IGroupRoleSetPermissionEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long GroupRoleSetId { get; set; }

	public int RoleSetPermissionTypeId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		GroupRoleSetPermission cal = GroupRoleSetPermission.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Cannot update a non persisted entity.");
		}
		cal.RoleSetID = GroupRoleSetId;
		cal.RoleSetPermissionTypeID = RoleSetPermissionTypeId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GroupRoleSetPermission.Get(Id) ?? throw new PlatformDataIntegrityException("Cannot delete a non persisted entity.")).Delete();
	}
}
