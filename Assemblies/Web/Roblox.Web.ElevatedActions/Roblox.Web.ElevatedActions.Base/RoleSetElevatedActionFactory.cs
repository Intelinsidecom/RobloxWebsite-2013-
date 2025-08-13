using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Web.ElevatedActions.BLL;

namespace Roblox.Web.ElevatedActions.Base;

public class RoleSetElevatedActionFactory : IRoleSetElevatedActionFactory
{
	public ICollection<IRoleset> GetRoleSetsAuthorizedToPerformElevatedActionID(int elevatedActionID)
	{
		return (from rs in RoleSet.GetAllRoleSets()
			where RoleSetElevatedAction.Get(rs.ID, elevatedActionID) != null
			select rs into roleSet
			select new AdaptableRoleSet(roleSet)).Select((Func<AdaptableRoleSet, IRoleset>)((AdaptableRoleSet ars) => ars)).ToList();
	}

	public IRoleSetElevatedAction GetRoleSetElevatedAction(int roleSetId, int elevatedActionId)
	{
		return RoleSetElevatedAction.Get(roleSetId, elevatedActionId);
	}
}
