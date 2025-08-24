using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

[ExcludeFromCodeCoverage]
internal class GroupRoleSetEntityFactory : IGroupRoleSetEntityFactory
{
	public IGroupRoleSetEntity GetById(long groupRoleSetId)
	{
		if (groupRoleSetId == 0L)
		{
			throw new PlatformArgumentException("groupRoleSetId");
		}
		Roblox.GroupRoleSet entity = Roblox.GroupRoleSet.Get(groupRoleSetId);
		return CalToCachedMssql(entity);
	}

	public IReadOnlyCollection<IGroupRoleSetEntity> MultiGet(ICollection<long> groupRoleSetIds)
	{
		if (groupRoleSetIds == null)
		{
			throw new ArgumentNullException("groupRoleSetIds");
		}
		if (groupRoleSetIds.Count == 0)
		{
			return (IReadOnlyCollection<IGroupRoleSetEntity>)(object)new IGroupRoleSetEntity[0];
		}
		return Roblox.GroupRoleSet.MultiGet(groupRoleSetIds).Select(CalToCachedMssql).ToList()
			.AsReadOnly();
	}

	public IEnumerable<IGroupRoleSetEntity> GetAllByGroupId(long groupId)
	{
		if (groupId == 0L)
		{
			throw new PlatformArgumentException("groupId");
		}
		return Roblox.GroupRoleSet.GetGroupRoleSetsByGroupID(groupId).Select(CalToCachedMssql);
	}

	public IGroupRoleSetEntity GetByGroupIdAndUserId(long groupId, long? userId)
	{
		if (groupId == 0L)
		{
			throw new PlatformArgumentException("groupId");
		}
		Roblox.GroupRoleSet entity = Roblox.GroupRoleSet.Get(userId, groupId);
		return CalToCachedMssql(entity);
	}

	public IGroupRoleSetEntity CreateNew(long groupId, string name, string description, byte rank)
	{
		if (groupId == 0L)
		{
			throw new PlatformArgumentException("groupId");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new PlatformArgumentException("name");
		}
		Roblox.GroupRoleSet entity = Roblox.GroupRoleSet.CreateNew(groupId, name, description, rank);
		return CalToCachedMssql(entity);
	}

	private GroupRoleSetMssqlCachedEntity CalToCachedMssql(Roblox.GroupRoleSet groupRoleSet)
	{
		if (!(groupRoleSet == null))
		{
			return new GroupRoleSetMssqlCachedEntity
			{
				Id = groupRoleSet.ID,
				Name = groupRoleSet.Name,
				Description = groupRoleSet.Description,
				Rank = groupRoleSet.Rank,
				GroupId = groupRoleSet.GroupID,
				Created = groupRoleSet.Created,
				Updated = groupRoleSet.Updated
			};
		}
		return null;
	}
}
