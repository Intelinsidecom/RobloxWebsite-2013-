using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

/// <summary>
/// Container for instances which are related to user permissions
/// </summary>
public interface IUserPermissionsChecker
{
	/// <summary>
	/// Checks the permissions for a specific user, action and target
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked, may be null.</param>
	/// <param name="action">The action.</param>
	/// <param name="targetId">The target id.</param>
	PermissionsStatus DoCheckPermissions(IUser user, string action, long? targetId);
}
