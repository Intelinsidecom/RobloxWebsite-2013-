using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

internal class LocalePermissionVerifier : ILocalePermissionVerifier
{
	private readonly ILocaleRolloutSettings _LocaleRolloutSettings;

	private readonly ILocaleSettingsMapper _LocaleSettingsMapper;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly IRoleSetValidator _RoleSetValidator;

	public LocalePermissionVerifier(ILocaleRolloutSettings localeRolloutSettings, ILocaleSettingsMapper localeSettingsMapper, IClientDeviceIdentifier clientDeviceIdentifier, IRoleSetValidator roleSetValidator)
		: this(localeRolloutSettings, localeSettingsMapper, clientDeviceIdentifier, roleSetValidator, Settings.Default)
	{
	}

	internal LocalePermissionVerifier(ILocaleRolloutSettings localeRolloutSettings, ILocaleSettingsMapper localeSettingsMapper, IClientDeviceIdentifier clientDeviceIdentifier, IRoleSetValidator roleSetValidator, IAccountLocaleInitializerSettings settings)
	{
		_LocaleRolloutSettings = localeRolloutSettings ?? throw new ArgumentNullException("localeRolloutSettings");
		_LocaleSettingsMapper = localeSettingsMapper ?? throw new ArgumentNullException("localeSettingsMapper");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
	}

	public bool IsUserLocaleEnabledForFullExperience(IUser user, ISupportedLocale supportedLocale, string userAgent)
	{
		ILocaleSettings localeSettings = _LocaleSettingsMapper.GetLocaleSettings(supportedLocale?.Locale);
		if (localeSettings == null)
		{
			return false;
		}
		if (localeSettings.IsLocaleEnabledForAll())
		{
			return true;
		}
		if (localeSettings.IsLocaleEnabledForSoothsayers() && user != null && _RoleSetValidator.IsSoothsayer(user))
		{
			return true;
		}
		if (_ClientDeviceIdentifier.IsRobloxIOSApp(userAgent))
		{
			return IsRobloxAppVersionAtLeast(localeSettings.MinIOSAppVersionToEnableFullExperience(), userAgent);
		}
		if (_ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent))
		{
			return IsRobloxAppVersionAtLeast(localeSettings.MinAndroidAppVersionToEnableFullExperience(), userAgent);
		}
		return localeSettings.IsLocaleEnabledOnDesktopForFullExperience();
	}

	public bool IsUserLocaleEnabledForSignupAndLogin(ISupportedLocale supportedLocale, string userAgent)
	{
		ILocaleSettings localeSettings = _LocaleSettingsMapper.GetLocaleSettings(supportedLocale?.Locale);
		if (localeSettings == null)
		{
			return false;
		}
		if (localeSettings.IsLocaleEnabledForAll())
		{
			return true;
		}
		if (_ClientDeviceIdentifier.IsRobloxIOSApp(userAgent))
		{
			return IsRobloxAppVersionAtLeast(localeSettings.MinIOSAppVersionToEnableSignAndLogin(), userAgent);
		}
		if (_ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent))
		{
			return IsRobloxAppVersionAtLeast(localeSettings.MinAndroidAppVersionToEnableSignAndLogin(), userAgent);
		}
		return localeSettings.IsLocaleEnabledOnDesktopForSignupAndLogin();
	}

	public bool IsUserLocaleEnabledForUgc(IUser user, ISupportedLocale supportedLocale)
	{
		ILocaleSettings localeSettings = _LocaleSettingsMapper.GetLocaleSettings(supportedLocale?.Locale);
		if (localeSettings == null)
		{
			return false;
		}
		if (localeSettings.IsLocaleEnabledForAll())
		{
			return true;
		}
		if (localeSettings.IsUgcLocaleEnabledForAll())
		{
			return true;
		}
		if (localeSettings.IsUgcLocaleEnabledForSoothsayers() && user != null && _RoleSetValidator.IsSoothsayer(user))
		{
			return true;
		}
		return false;
	}

	internal bool IsRobloxAppVersionAtLeast(string minimumEnabledVersion, string userAgent)
	{
		if (string.IsNullOrEmpty(minimumEnabledVersion))
		{
			return false;
		}
		Version minVersion = new Version(minimumEnabledVersion);
		return _ClientDeviceIdentifier.IsRobloxAppVersionAtLeast(minVersion, userAgent);
	}

	public IReadOnlyCollection<ISupportedLocale> WhiteListSupportedLocalesForFullExperience(IUser user, IReadOnlyCollection<ISupportedLocale> supportedLocales, string userAgent)
	{
		IList<ISupportedLocale> whiteListedLocales = new List<ISupportedLocale>();
		foreach (ISupportedLocale supportedLocale in supportedLocales)
		{
			if (IsUserLocaleEnabledForFullExperience(user, supportedLocale, userAgent))
			{
				whiteListedLocales.Add(supportedLocale);
			}
		}
		return new ReadOnlyCollection<ISupportedLocale>(whiteListedLocales);
	}

	public IReadOnlyCollection<ISupportedLocaleLocus> ApplyLocusOnSupportedLocales(IUser user, IReadOnlyCollection<ISupportedLocale> supportedLocales, string userAgent, bool isSortedByFullExperience = false)
	{
		List<ISupportedLocaleLocus> supportedLocalesLocus = new List<ISupportedLocaleLocus>();
		foreach (ISupportedLocale supportedLocale in supportedLocales)
		{
			supportedLocalesLocus.Add(new SupportedLocaleLocus
			{
				IsEnabledForFullExperience = IsUserLocaleEnabledForFullExperience(user, supportedLocale, userAgent),
				IsEnabledForSignupAndLogin = IsUserLocaleEnabledForSignupAndLogin(supportedLocale, userAgent),
				Locale = supportedLocale
			});
		}
		if (!isSortedByFullExperience)
		{
			return supportedLocalesLocus.ToList();
		}
		List<ISupportedLocaleLocus> list = new List<ISupportedLocaleLocus>();
		List<ISupportedLocaleLocus> fullExperienceLocales = (from loc in supportedLocalesLocus
			where loc.IsEnabledForFullExperience
			orderby loc.Locale.NativeName
			select loc).ToList();
		List<ISupportedLocaleLocus> unSupportedLocales = (from loc in supportedLocalesLocus
			where !loc.IsEnabledForFullExperience
			orderby loc.Locale.NativeName
			select loc).ToList();
		list.AddRange(fullExperienceLocales);
		list.AddRange(unSupportedLocales);
		return list;
	}

	public bool IsResetOfSupportedLocaleAllowed()
	{
		return _LocaleRolloutSettings.IsResetOfSupportedLocaleAllowed;
	}
}
