using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class AllUsersPermissionTest : UserPermissionTest
{
	internal AllUsersPermissionTest(long? authenticatedUserId)
		: base(authenticatedUserId)
	{
		base.PermissionType = PermissionType.AllUsers;
	}

	public override bool Test()
	{
		return true;
	}
}
