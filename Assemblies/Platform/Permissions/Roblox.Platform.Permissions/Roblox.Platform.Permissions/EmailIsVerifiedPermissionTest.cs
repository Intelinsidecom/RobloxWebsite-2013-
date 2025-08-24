using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class EmailIsVerifiedPermissionTest : UserPermissionTest
{
	internal EmailIsVerifiedPermissionTest(long? userId = null)
		: base(userId)
	{
		base.PermissionType = PermissionType.EmailIsVerified;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			User user = User.Get(base.AuthenticatedUserId.Value);
			if (user == null)
			{
				return false;
			}
			return AccountEmailAddress.GetCurrent(user.GetAccount().ID)?.IsVerified ?? false;
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
