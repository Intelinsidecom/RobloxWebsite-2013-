using System.Collections.Generic;
using Roblox.Platform.MembershipCore;
using Roblox.Web.ElevatedActions.BLL;

namespace Roblox.Web.ElevatedActions;

public static class UserIdentifierExtensions
{
	public static bool HasElevatedActionAuthorization(this IUserIdentifier user, string elevatedActionName)
	{
		if (user == null)
		{
			return false;
		}
		ElevatedAction elevatedActionEntity = ElevatedAction.Get(elevatedActionName);
		if (elevatedActionEntity == null)
		{
			return false;
		}
		ICollection<AccountRoleSet> accountRoleSets = User.Get(user.Id).GetAccount().GetAccountRoleSets();
		bool isPermitted = false;
		foreach (AccountRoleSet item in accountRoleSets)
		{
			if (RoleSetElevatedAction.Get(item.RoleSetID, elevatedActionEntity.ID) != null)
			{
				isPermitted = true;
				break;
			}
		}
		return isPermitted;
	}
}
