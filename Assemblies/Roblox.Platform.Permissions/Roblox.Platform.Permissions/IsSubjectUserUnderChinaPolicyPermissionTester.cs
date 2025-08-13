using System;
using System.Collections.Generic;
using Roblox.Platform.CallContext;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Properties;

namespace Roblox.Platform.Permissions;

public class IsSubjectUserUnderChinaPolicyPermissionTester : IsUserUnderChinaPolicyPermissionTester
{
	private const string _SubjectUserIdKey = "subjectUserId";

	public IsSubjectUserUnderChinaPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider)
		: this(countryFactory, userFactory, geolocationProvider, Settings.Default)
	{
	}

	internal IsSubjectUserUnderChinaPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider, ISettings settings)
		: base(countryFactory, userFactory, geolocationProvider, settings)
	{
	}

	public override bool Test(ICallContext callContext, IDictionary<string, object> actionParams, long? permissionTypeTargetId)
	{
		long subjectUserId = GetSubjectUserId(actionParams);
		if (IsEnabledForUserId(subjectUserId))
		{
			return DoTest(subjectUserId);
		}
		return false;
	}

	private bool DoTest(long subjectUserId)
	{
		IUser subjectUser = base._UserFactory.GetUser(subjectUserId);
		return IsUserGeolocatedInTestCountry(subjectUser);
	}

	private long GetSubjectUserId(IDictionary<string, object> actionParams)
	{
		if (actionParams == null || !actionParams.TryGetValue("subjectUserId", out var subjectUserIdObject) || subjectUserIdObject == null)
		{
			throw new ArgumentNullException("subjectUserId");
		}
		return (subjectUserIdObject as long?) ?? throw new ArgumentException(string.Format("The value {0} is not a valid {1}: value of type long expected.", subjectUserIdObject, "subjectUserId"));
	}
}
