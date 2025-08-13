using System.Collections.Generic;
using Roblox.Platform.Groups.Entities.GroupRoleSets;

namespace Roblox.Platform.Groups.Interfaces;

internal interface IGroupRoleSetAccessorInternal : IGroupRoleSetAccessor
{
	IGroupRoleSet GetByEntity(IGroupRoleSetEntity groupRoleSetEntity);

	IReadOnlyCollection<IGroupRoleSet> MultiGet(ICollection<long> ids);
}
