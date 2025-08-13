using System;
using Roblox.Platform.AbTesting;
using Roblox.Platform.Marketing;
using Roblox.Web.Devices;

namespace Roblox.Web.Authentication;

public abstract class CaptchaAuthorityBase : ICaptchaAuthority
{
	internal const int AbTestAppCaptchaControlVariation = 1;

	internal const int AbTestAppCaptchaWhenFloodedVariation = 2;

	/// <summary>
	/// This variant is now used to test optimizations for the "always captcha"
	/// behavior. The control variation always requires captcha, but clients check if
	/// they are enrolled in this variant to compare optimizations
	/// </summary>
	internal const int AbTestAppCaptchaAlwaysVariation = 3;

	protected IClientDeviceIdentifier ClientDeviceIdentifier;

	protected internal abstract ICaptchaSettingsModel CaptchaSettingsModel { get; }

	protected CaptchaAuthorityBase(IClientDeviceIdentifier clientDeviceIdentifier)
	{
		ClientDeviceIdentifier = clientDeviceIdentifier;
	}

	internal virtual int? EnrollBrowserTrackerTranslated(IBrowserTracker browserTracker, string experimentName)
	{
		return browserTracker?.EnrollTranslated(experimentName);
	}

	/// <inheritdoc cref="T:Roblox.Web.Authentication.ICaptchaAuthority" />
	public bool IsCaptchaRequired(string userAgent, IBrowserTracker browserTracker)
	{
		if (CaptchaSettingsModel.AndroidExemptOSVersionList.Contains(ClientDeviceIdentifier.GetMajorAndroidVersion(userAgent)) || CaptchaSettingsModel.iOSExemptOSVersionList.Contains(ClientDeviceIdentifier.GetMajorIOSVersion(userAgent)))
		{
			return false;
		}
		int? abTestEnrollment = null;
		if (ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent) && DoesAppVersionSupportCaptcha(userAgent, CaptchaSettingsModel.AndroidMinimumAppVersion))
		{
			abTestEnrollment = EnrollBrowserTrackerTranslated(browserTracker, CaptchaSettingsModel.AndroidAbTestName);
		}
		else if (ClientDeviceIdentifier.IsRobloxIOSApp(userAgent) && DoesAppVersionSupportCaptcha(userAgent, CaptchaSettingsModel.iOSMinimumAppVersion))
		{
			abTestEnrollment = EnrollBrowserTrackerTranslated(browserTracker, CaptchaSettingsModel.iOSAbTestName);
		}
		else if (ClientDeviceIdentifier.IsRobloxWindowsApp(userAgent) && DoesAppVersionSupportCaptcha(userAgent, CaptchaSettingsModel.UWPMinimumAppVersion))
		{
			abTestEnrollment = EnrollBrowserTrackerTranslated(browserTracker, CaptchaSettingsModel.UWPAbTestName);
		}
		else if (!ClientDeviceIdentifier.IsRobloxApp(userAgent))
		{
			abTestEnrollment = EnrollBrowserTrackerTranslated(browserTracker, CaptchaSettingsModel.WebAbTestName);
		}
		if (!abTestEnrollment.HasValue || !AbTestVariantRequiresCaptcha(abTestEnrollment))
		{
			if (!abTestEnrollment.HasValue)
			{
				return CaptchaSettingsModel.CaptchaAlwaysRequired;
			}
			return false;
		}
		return true;
	}

	/// <summary>
	/// Can be overridden by child classes if multiple AB test variants require captcha.
	/// </summary>
	/// <param name="abTestEnrollment"></param>
	/// <returns></returns>
	private bool AbTestVariantRequiresCaptcha(int? abTestEnrollment)
	{
		return abTestEnrollment != 2;
	}

	/// <inheritdoc cref="T:Roblox.Web.Authentication.ICaptchaAuthority" />
	public bool IsDeviceHandleEnabled(string userAgent, IBrowserTracker browserTracker)
	{
		if (!CaptchaSettingsModel.DeviceHandleGlobalEnabled || !ClientDeviceIdentifier.IsRobloxApp(userAgent))
		{
			return false;
		}
		bool osExempted = CaptchaSettingsModel.AndroidExemptOSVersionList.Contains(ClientDeviceIdentifier.GetMajorAndroidVersion(userAgent)) || CaptchaSettingsModel.iOSExemptOSVersionList.Contains(ClientDeviceIdentifier.GetMajorIOSVersion(userAgent));
		bool deviceHandleEnabledForApp;
		string abTestName;
		string minAppVersionString;
		if (ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent))
		{
			deviceHandleEnabledForApp = CaptchaSettingsModel.AndroidDeviceHandleEnabled;
			abTestName = CaptchaSettingsModel.AndroidAbTestName;
			minAppVersionString = CaptchaSettingsModel.AndroidMinimumAppVersion;
		}
		else if (ClientDeviceIdentifier.IsRobloxIOSApp(userAgent))
		{
			deviceHandleEnabledForApp = CaptchaSettingsModel.iOSDeviceHandleEnabled;
			abTestName = CaptchaSettingsModel.iOSAbTestName;
			minAppVersionString = CaptchaSettingsModel.iOSMinimumAppVersion;
		}
		else
		{
			if (!ClientDeviceIdentifier.IsRobloxWindowsApp(userAgent))
			{
				return false;
			}
			deviceHandleEnabledForApp = CaptchaSettingsModel.UWPDeviceHandleEnabled;
			abTestName = CaptchaSettingsModel.UWPAbTestName;
			minAppVersionString = CaptchaSettingsModel.UWPMinimumAppVersion;
		}
		return IsDeviceHandleEnabledForApp(userAgent, browserTracker, deviceHandleEnabledForApp, abTestName, minAppVersionString, osExempted);
	}

	private bool IsDeviceHandleEnabledForApp(string userAgent, IBrowserTracker browserTracker, bool deviceHandleEnabled, string abTestName, string minAppVersionString, bool osExempted)
	{
		if (!deviceHandleEnabled)
		{
			return false;
		}
		if (!DoesAppVersionSupportCaptcha(userAgent, minAppVersionString) || osExempted)
		{
			return true;
		}
		int? enrollmentVariation = EnrollBrowserTrackerTranslated(browserTracker, abTestName);
		if (enrollmentVariation != 3)
		{
			return enrollmentVariation != 2;
		}
		return false;
	}

	private bool DoesAppVersionSupportCaptcha(string userAgent, string minAppVersionString)
	{
		if (string.IsNullOrEmpty(minAppVersionString))
		{
			return true;
		}
		Version minVersion;
		try
		{
			minVersion = new Version(minAppVersionString);
		}
		catch (Exception)
		{
			return false;
		}
		return ClientDeviceIdentifier.IsRobloxAppVersionAtLeast(minVersion, userAgent);
	}
}
