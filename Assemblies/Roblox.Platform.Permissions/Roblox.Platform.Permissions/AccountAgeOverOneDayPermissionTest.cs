using System;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class AccountAgeOverOneDayPermissionTest : UserPermissionTest
{
	internal AccountAgeOverOneDayPermissionTest(long? userId = null)
		: base(userId)
	{
		base.PermissionType = PermissionType.AccountAgeOverOneDay;
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
			return user.GetAccount().CreationDate <= DateTime.Now.AddDays(-1.0);
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
