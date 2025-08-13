using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

public static class UserExtensions
{
	public static PermissionsStatus CheckPermissions(this IUser user, IUserPermissionsChecker userPermissionsChecker, string action, long? targetId)
	{
		return userPermissionsChecker.DoCheckPermissions(user, action, targetId);
	}

	/// <summary>
	/// Checks whether the user is in the GDPR jurisdiction.  Returns FALSE if the user is null.
	/// </summary>
	public static bool IsInGdprJurisdiction(this IUser user, IUserPermissionsChecker userPermissionsChecker)
	{
		if (user == null)
		{
			return false;
		}
		PermissionsStatus permissionStatus = userPermissionsChecker.DoCheckPermissions(user, "BeInGdprJurisdiction", null);
		if (permissionStatus.WasTested)
		{
			return permissionStatus.IsSuccess;
		}
		return false;
	}
}
