using System;
using System.Collections.Generic;
using Roblox.Platform.CallContext;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Properties;

namespace Roblox.Platform.Permissions;

public class IsTargetUserUnderChinaPolicyPermissionTester : IsUserUnderChinaPolicyPermissionTester
{
	private const string _TargetUserIdKey = "targetUserId";

	public IsTargetUserUnderChinaPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider)
		: this(countryFactory, userFactory, geolocationProvider, Settings.Default)
	{
	}

	internal IsTargetUserUnderChinaPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider, ISettings settings)
		: base(countryFactory, userFactory, geolocationProvider, settings)
	{
	}

	public override bool Test(ICallContext callContext, IDictionary<string, object> actionParams, long? permissionTypeTargetId)
	{
		long targetUserId = GetTargetUserId(actionParams);
		if (IsEnabledForUserId(targetUserId))
		{
			return DoTest(targetUserId);
		}
		return false;
	}

	private bool DoTest(long targetUserId)
	{
		IUser targetUser = base._UserFactory.GetUser(targetUserId);
		return IsUserGeolocatedInTestCountry(targetUser);
	}

	private long GetTargetUserId(IDictionary<string, object> actionParams)
	{
		if (actionParams == null || !actionParams.TryGetValue("targetUserId", out var targetUserIdObject) || targetUserIdObject == null)
		{
			throw new ArgumentNullException("targetUserId");
		}
		return (targetUserIdObject as long?) ?? throw new ArgumentException(string.Format("The value {0} is not a valid {1}: value of type long expected.", targetUserIdObject, "targetUserId"));
	}
}
