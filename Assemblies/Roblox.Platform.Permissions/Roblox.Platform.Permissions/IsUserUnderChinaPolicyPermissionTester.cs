using System.Collections.Generic;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Properties;

namespace Roblox.Platform.Permissions;

public abstract class IsUserUnderChinaPolicyPermissionTester : IsUserUnderCountryPolicyPermissionTester
{
	protected override ICountry _TestCountry { get; }

	internal virtual bool IsEnabledForAll { get; set; }

	internal virtual ICollection<long> WhitelistedUserIds { get; set; }

	internal IsUserUnderChinaPolicyPermissionTester(ICountryFactory countryFactory, IUserFactory userFactory, IGeolocationProvider geolocationProvider, ISettings settings)
		: base(countryFactory, userFactory, geolocationProvider)
	{
		_TestCountry = base._CountryFactory.GetByCode("CN") ?? throw new PlatformException("CountryFactory could not recognize CN country code.");
		settings.ReadValueAndMonitorChanges((ISettings s) => s.AreUserUnderChinaPolicyTestersEnabledForAll, delegate(bool val)
		{
			IsEnabledForAll = val;
		});
		settings.ReadValueAndMonitorChanges((ISettings s) => s.ChinaPolicyWhitelistedUserIdsCsv, delegate(string val)
		{
			WhitelistedUserIds = MultiValueSettingParser.ParseCommaDelimitedListString(val, long.Parse);
		});
	}

	protected bool IsEnabledForUserId(long userId)
	{
		if (!IsEnabledForAll)
		{
			return WhitelistedUserIds.Contains(userId);
		}
		return true;
	}
}
