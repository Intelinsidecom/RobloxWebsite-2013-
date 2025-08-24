using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.Platform.Groups.Interfaces;

namespace Roblox.Platform.Groups;

internal class GroupRoleSetAccessor : IGroupRoleSetAccessorInternal, IGroupRoleSetAccessor
{
	private readonly GroupDomainFactories _DomainFactories;

	public virtual int RolesetNameMaxLength => 100;

	public virtual int RolesetDescriptionMaxLength => 999;

	public virtual byte RolesetMaxRank => byte.MaxValue;

	public virtual byte RolesetMinRank => 0;

	public GroupRoleSetAccessor(GroupDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IGroupRoleSet GetById(long id, bool invalidIdThrows = true)
	{
		if (id <= 0)
		{
			if (invalidIdThrows)
			{
				throw new PlatformArgumentException("id");
			}
			return null;
		}
		IGroupRoleSetEntity groupRoleSetEntity = _DomainFactories.GroupRoleSetEntityFactory.GetById(id);
		return GetByEntity(groupRoleSetEntity);
	}

	public IReadOnlyCollection<IGroupRoleSet> MultiGet(ICollection<long> ids)
	{
		if (ids == null)
		{
			throw new PlatformArgumentException("ids");
		}
		if (ids.Count == 0)
		{
			return (IReadOnlyCollection<IGroupRoleSet>)(object)new IGroupRoleSet[0];
		}
		return _DomainFactories.GroupRoleSetEntityFactory.MultiGet(ids).Select(GetByEntity).ToList()
			.AsReadOnly();
	}

	public IEnumerable<IGroupRoleSet> GetAllForGroup(IGroup group)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
		return GetAllByGroupId(group.Id);
	}

	public IEnumerable<IGroupRoleSet> GetAllByGroupId(long groupId)
	{
		return _DomainFactories.GroupRoleSetEntityFactory.GetAllByGroupId(groupId).Select(GetByEntity);
	}

	public IGroupRoleSet GetByEntity(IGroupRoleSetEntity groupRoleSetEntity)
	{
		if (groupRoleSetEntity != null)
		{
			return new GroupRoleSet(groupRoleSetEntity, _DomainFactories);
		}
		return null;
	}
}
