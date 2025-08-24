using System;
using System.Text.RegularExpressions;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Permissions.Properties;

namespace Roblox.Platform.Permissions;

/// <summary>
/// Returns true if the individual in question meets the COPPA age threshold, and is not considered a "child" for GDPR purposes (either by meeting the GDPR age of consent of their location, or by not being in a GDPR jurisdiction).
///
/// This is a hard-coded implementation optimized against the knowledge that GDPR age of consent is going to be between 13~16  (16 is the default, individual EU members can set it to be something lower but minimum is 13).
/// Future interations will transition this code to be data-driven logic using the Permissions system.
/// </summary>
internal class IsCoppaAdultAndNotGdprChildTest : UserPermissionTest
{
	private readonly ISettings _Settings;

	private readonly IUser _ActorUser;

	private readonly IAgeChecker _AgeChecker;

	private readonly IAccountCountryAccessor _AccountCountryAccessor;

	private readonly ICountryFactory _CountryFactory;

	public IsCoppaAdultAndNotGdprChildTest(ISettings settings, IUser user, IAgeChecker ageChecker, ICountryFactory countryFactory, IAccountCountryAccessor accountCountryAccessor)
		: base(user?.Id)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_AgeChecker = ageChecker ?? throw new ArgumentNullException("ageChecker");
		_AccountCountryAccessor = accountCountryAccessor ?? throw new ArgumentNullException("accountCountryAccessor");
		_CountryFactory = countryFactory ?? throw new ArgumentNullException("countryFactory");
		_ActorUser = user;
		base.PermissionType = PermissionType.IsCoppaAdultAndNotGdprChild;
	}

	public override bool Test()
	{
		return IsUserCoppaAdultAndNotGdprChild(_ActorUser);
	}

	private bool IsUserCoppaAdultAndNotGdprChild(IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (!_AgeChecker.UserMeetsMinimumAgeRequirement(user, _Settings.CoppaAgeThreshold))
		{
			return false;
		}
		if (_Settings.CoppaAgeThreshold >= 16)
		{
			return true;
		}
		string countryCode = _AccountCountryAccessor.GetUserCountry(user)?.Code;
		if (string.IsNullOrEmpty(countryCode))
		{
			return true;
		}
		Regex regexPattern = new Regex($"\\b{countryCode}\\b", RegexOptions.IgnoreCase);
		if (regexPattern.IsMatch(_Settings.GdprAge16Locations))
		{
			return _AgeChecker.UserMeetsMinimumAgeRequirement(user, 16);
		}
		if (_Settings.CoppaAgeThreshold == 15)
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge15Locations))
		{
			return _AgeChecker.UserMeetsMinimumAgeRequirement(user, 15);
		}
		if (_Settings.CoppaAgeThreshold == 14)
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge14Locations))
		{
			return _AgeChecker.UserMeetsMinimumAgeRequirement(user, 14);
		}
		if (_Settings.CoppaAgeThreshold == 13)
		{
			return true;
		}
		if (regexPattern.IsMatch(_Settings.GdprAge13Locations))
		{
			return _AgeChecker.UserMeetsMinimumAgeRequirement(user, 13);
		}
		return true;
	}
}
