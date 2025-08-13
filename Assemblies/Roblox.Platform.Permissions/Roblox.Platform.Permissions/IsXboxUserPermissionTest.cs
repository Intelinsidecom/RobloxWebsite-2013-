using System;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsXboxUserPermissionTest : UserPermissionTest
{
	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	private readonly IUserFactory _UserFactory;

	internal IsXboxUserPermissionTest(long? authenticatedUserId, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IUserFactory userFactory)
		: base(authenticatedUserId)
	{
		base.PermissionType = PermissionType.IsXboxUser;
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			IUser user = _UserFactory.GetUser(base.AuthenticatedUserId.Value);
			if (user == null)
			{
				return false;
			}
			return _XboxLiveAccountDataAccessor.GetByAccountId(user.AccountId) != null;
		}
		return false;
	}
}
