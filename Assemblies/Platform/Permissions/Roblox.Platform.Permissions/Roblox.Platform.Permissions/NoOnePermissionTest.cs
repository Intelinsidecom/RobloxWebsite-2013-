using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class NoOnePermissionTest : UserPermissionTest
{
	internal NoOnePermissionTest(long? userId = null)
		: base(userId)
	{
		base.PermissionType = PermissionType.NoOne;
	}

	public override bool Test()
	{
		return false;
	}
}
