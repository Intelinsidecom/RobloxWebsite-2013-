using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Web.ElevatedActions.Base;

public interface IRoleSetElevatedActionFactory
{
	ICollection<IRoleset> GetRoleSetsAuthorizedToPerformElevatedActionID(int elevatedActionId);

	IRoleSetElevatedAction GetRoleSetElevatedAction(int roleSetId, int elevatedActionId);
}
