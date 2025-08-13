using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class UserIsAuthenticatedPermissionTest : UserPermissionTest
{
	internal UserIsAuthenticatedPermissionTest(long? authenticatedUserId)
		: base(authenticatedUserId)
	{
		base.PermissionType = PermissionType.UserIsAuthenticated;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue && User.Get(base.AuthenticatedUserId.Value) != null)
		{
			return true;
		}
		return false;
	}
}
