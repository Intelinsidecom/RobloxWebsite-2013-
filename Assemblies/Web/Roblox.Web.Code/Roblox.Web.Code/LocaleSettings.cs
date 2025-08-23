using System;

namespace Roblox.Web.Code;

public class LocaleSettings : ILocaleSettings
{
	public Func<string> MinAndroidAppVersionToEnableSignAndLogin { get; }

	public Func<string> MinIOSAppVersionToEnableSignAndLogin { get; }

	public Func<string> MinAndroidAppVersionToEnableFullExperience { get; }

	public Func<string> MinIOSAppVersionToEnableFullExperience { get; }

	public Func<bool> IsLocaleEnabledForSoothsayers { get; }

	public Func<bool> IsLocaleEnabledForAll { get; }

	public Func<bool> IsLocaleEnabledOnDesktopForSignupAndLogin { get; }

	public Func<bool> IsLocaleEnabledOnDesktopForFullExperience { get; }

	public Func<bool> IsUgcLocaleEnabledForSoothsayers { get; }

	public Func<bool> IsUgcLocaleEnabledForAll { get; }

	public LocaleSettings(Func<string> minAndroidAppVersionToEnableSignAndLogin = null, Func<string> minIOSAppVersionToEnableSignAndLogin = null, Func<string> minAndroidAppVersionToEnableFullExperience = null, Func<string> minIOSAppVersionToEnableFullExperience = null, Func<bool> isLocaleEnabledForSoothsayers = null, Func<bool> isLocaleEnabledForAll = null, Func<bool> isLocaleEnabledOnDesktopForSignupAndLogin = null, Func<bool> isLocaleEnabledOnDesktopForFullExperience = null, Func<bool> isUgcLocaleEnabledForSoothsayers = null, Func<bool> isUgcLocaleEnabledForAll = null)
	{
		MinAndroidAppVersionToEnableFullExperience = minAndroidAppVersionToEnableFullExperience ?? ((Func<string>)(() => ""));
		MinIOSAppVersionToEnableFullExperience = minIOSAppVersionToEnableFullExperience ?? ((Func<string>)(() => ""));
		MinAndroidAppVersionToEnableSignAndLogin = minAndroidAppVersionToEnableSignAndLogin ?? ((Func<string>)(() => ""));
		MinIOSAppVersionToEnableSignAndLogin = minIOSAppVersionToEnableSignAndLogin ?? ((Func<string>)(() => ""));
		IsLocaleEnabledForSoothsayers = isLocaleEnabledForSoothsayers ?? ((Func<bool>)(() => false));
		IsLocaleEnabledForAll = isLocaleEnabledForAll ?? ((Func<bool>)(() => false));
		IsLocaleEnabledOnDesktopForSignupAndLogin = isLocaleEnabledOnDesktopForSignupAndLogin ?? ((Func<bool>)(() => false));
		IsLocaleEnabledOnDesktopForFullExperience = isLocaleEnabledOnDesktopForFullExperience ?? ((Func<bool>)(() => false));
		IsUgcLocaleEnabledForSoothsayers = isUgcLocaleEnabledForSoothsayers ?? ((Func<bool>)(() => false));
		IsUgcLocaleEnabledForAll = isUgcLocaleEnabledForAll ?? ((Func<bool>)(() => false));
	}
}
