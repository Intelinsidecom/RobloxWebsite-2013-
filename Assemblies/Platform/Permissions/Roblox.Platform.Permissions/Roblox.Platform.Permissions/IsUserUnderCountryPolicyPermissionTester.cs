using System;
using System.Collections.Generic;
using Roblox.Platform.CallContext;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Permissions;

public abstract class IsUserUnderCountryPolicyPermissionTester : IPermissionTester
{
	protected abstract ICountry _TestCountry { get; }

	protected ICountryFactory _CountryFactory { get; private set; }

	protected IUserFactory _UserFactory { get; private set; }

	protected IGeolocationProvider _GeolocationProvider { get; private set; }

	protected IsUserUnderCountryPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider)
	{
		_CountryFactory = countryFactory ?? throw new ArgumentNullException("countryFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_GeolocationProvider = geolocationProvider ?? throw new ArgumentNullException("geolocationProvider");
	}

	public abstract bool Test(ICallContext callContext, IDictionary<string, object> actionParams, long? permissionTypeTargetId);

	protected bool IsUserGeolocatedInTestCountry(IUser user)
	{
		if (user != null)
		{
			return _GeolocationProvider.GetGeolocationByUser(user)?.CountryId?.Equals(_TestCountry.Id) ?? false;
		}
		return false;
	}
}
