using Roblox.Permissions.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Permissions;

public interface IUserPermissionTestFactory
{
	/// <summary>
	/// Gets the permission tests for the specified parameters.
	/// </summary>
	IUserPermissionTest GetPermissionTest(IPermission permissionDefinition, IUser user, long? actionTargetId = null);

	/// <summary>
	/// Produces the permission test determining if the user is a COPPA adult and not a GDPR child
	/// </summary>
	IUserPermissionTest GetIsCoppaAdultAndNotGdprChildTest(IUser user);

	/// <summary>
	/// Produces the permission test determining if the user is in GDPR jurisdiction
	/// </summary>
	IUserPermissionTest GetIsInGdprJurisdictionTest(IUser user);
}
