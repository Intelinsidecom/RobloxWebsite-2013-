using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Web.ElevatedActions.BLL;

namespace Roblox.Web.ElevatedActions;

public static class UserExtensions
{
	/// <summary>
	/// Determines whether or not a user can perform any elevated actions.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>Whether or not the given <see cref="T:Roblox.Platform.Membership.IUser" /> can perform any elevated actions.</returns>
	public static bool HasAnyElevatedActionAuthorization(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		foreach (AccountRoleSet accountRoleSet in Account.Get(user.AccountId).GetAccountRoleSets())
		{
			if (RoleSetElevatedAction.GetRoleSetElevatedActionsByRoleSetID(accountRoleSet.RoleSetID).Any())
			{
				return true;
			}
		}
		return false;
	}
}
