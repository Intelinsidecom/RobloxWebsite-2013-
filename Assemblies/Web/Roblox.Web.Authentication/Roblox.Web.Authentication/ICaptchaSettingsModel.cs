using System.Collections.Generic;

namespace Roblox.Web.Authentication;

/// <summary>
/// Holds device specific configuration information for captcha on a specific operation.
/// </summary>
public interface ICaptchaSettingsModel
{
	string AndroidMinimumAppVersion { get; }

	string iOSMinimumAppVersion { get; }

	string UWPMinimumAppVersion { get; }

	HashSet<int> AndroidExemptOSVersionList { get; }

	HashSet<int> iOSExemptOSVersionList { get; }

	string WebAbTestName { get; }

	string AndroidAbTestName { get; }

	string iOSAbTestName { get; }

	string UWPAbTestName { get; }

	bool AndroidDeviceHandleEnabled { get; }

	bool iOSDeviceHandleEnabled { get; }

	bool UWPDeviceHandleEnabled { get; }

	bool CaptchaAlwaysRequired { get; }

	bool DeviceHandleGlobalEnabled { get; }
}
