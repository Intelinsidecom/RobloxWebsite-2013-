using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetMssqlCachedEntity : IGroupRoleSetEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public byte Rank { get; set; }

	public long GroupId { get; set; }

	public void Update()
	{
		Roblox.GroupRoleSet cal = Roblox.GroupRoleSet.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on a non persistent entity.");
		}
		cal.Name = Name;
		cal.Description = Description;
		cal.Rank = Rank;
		cal.GroupID = GroupId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.GroupRoleSet groupRoleSet = Roblox.GroupRoleSet.Get(Id);
		if (groupRoleSet == null)
		{
			throw new PlatformDataIntegrityException("Attempted delete on a non persistent entity.");
		}
		groupRoleSet.Delete();
	}
}
