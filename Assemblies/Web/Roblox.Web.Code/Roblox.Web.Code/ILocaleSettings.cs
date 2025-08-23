using System;

namespace Roblox.Web.Code;

public interface ILocaleSettings
{
	Func<string> MinAndroidAppVersionToEnableSignAndLogin { get; }

	Func<string> MinIOSAppVersionToEnableSignAndLogin { get; }

	Func<string> MinAndroidAppVersionToEnableFullExperience { get; }

	Func<string> MinIOSAppVersionToEnableFullExperience { get; }

	Func<bool> IsLocaleEnabledForSoothsayers { get; }

	Func<bool> IsLocaleEnabledForAll { get; }

	Func<bool> IsLocaleEnabledOnDesktopForSignupAndLogin { get; }

	Func<bool> IsLocaleEnabledOnDesktopForFullExperience { get; }

	Func<bool> IsUgcLocaleEnabledForSoothsayers { get; }

	Func<bool> IsUgcLocaleEnabledForAll { get; }
}
