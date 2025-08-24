using System;
using System.Collections.Generic;
using Roblox.Platform.CallContext;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Permissions;

public class IsUserUnder13PermissionTester : IPermissionTester
{
	private readonly IUserFactory _UserFactory;

	private readonly IAgeChecker _AgeChecker;

	public IsUserUnder13PermissionTester(IUserFactory userFactory, IAgeChecker ageChecker)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_AgeChecker = ageChecker ?? throw new ArgumentNullException("ageChecker");
	}

	public bool Test(ICallContext callContext, IDictionary<string, object> actionParams, long? permissionTypeTargetId)
	{
		long? authenticatedUserId = callContext.AuthenticatedUserID;
		if (authenticatedUserId.HasValue)
		{
			IUser user = _UserFactory.GetUser(authenticatedUserId.Value);
			if (user != null)
			{
				return _AgeChecker.IsUserYoungerThan(user, 13);
			}
			return true;
		}
		return true;
	}
}
