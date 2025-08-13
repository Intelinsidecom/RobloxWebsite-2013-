using System;
using System.Text.RegularExpressions;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Permissions.Properties;

namespace Roblox.Platform.Permissions;

internal class IsInGdprJurisdictionTest : UserPermissionTest
{
	private readonly ISettings _Settings;

	private readonly IUser _ActorUser;

	private readonly IAccountCountryAccessor _AccountCountryAccessor;

	private readonly ICountryFactory _CountryFactory;

	public IsInGdprJurisdictionTest(ISettings settings, IUser user, ICountryFactory countryFactory, IAccountCountryAccessor accountCountryAccessor)
		: base(user?.Id)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_AccountCountryAccessor = accountCountryAccessor ?? throw new ArgumentNullException("accountCountryAccessor");
		_CountryFactory = countryFactory ?? throw new ArgumentNullException("countryFactory");
		_ActorUser = user;
		base.PermissionType = PermissionType.IsInGdprJurisdiction;
	}

	public override bool Test()
	{
		return IsUserInGdprJurisdiction(_ActorUser);
	}

	private bool IsUserInGdprJurisdiction(IUser user)
	{
		if (user == null)
		{
			return false;
		}
		string countryCode = _AccountCountryAccessor.GetUserCountry(user)?.Code;
		if (string.IsNullOrEmpty(countryCode))
		{
			return false;
		}
		Regex regexPattern = new Regex($"\\b{countryCode}\\b", RegexOptions.IgnoreCase);
		if (regexPattern.IsMatch(_Settings.GdprAge16Locations))
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge15Locations))
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge14Locations))
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge13Locations))
		{
			return true;
		}
		return false;
	}
}
