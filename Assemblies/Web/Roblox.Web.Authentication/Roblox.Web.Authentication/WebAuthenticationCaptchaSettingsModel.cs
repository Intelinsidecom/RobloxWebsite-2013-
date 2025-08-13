using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

internal class WebAuthenticationCaptchaSettingsModel : ICaptchaSettingsModel
{
	public string AndroidMinimumAppVersion => LoginCaptchaSettings.Default.LoginCaptchaAndroidMinimumAppVersion;

	public string iOSMinimumAppVersion => LoginCaptchaSettings.Default.LoginCaptchaiOSMinimumAppVersion;

	public string UWPMinimumAppVersion => LoginCaptchaSettings.Default.LoginCaptchaUWPMinimumAppVersion;

	public HashSet<int> AndroidExemptOSVersionList { get; private set; } = MultiValueSettingParser.TryParseCommaDelimitedListString(LoginCaptchaSettings.Default.LoginCaptchaAndroidExemptOSMajorVersionList, int.Parse);


	public HashSet<int> iOSExemptOSVersionList { get; private set; } = MultiValueSettingParser.TryParseCommaDelimitedListString(LoginCaptchaSettings.Default.LoginCaptchaiOSMinimumAppVersion, int.Parse);


	public string WebAbTestName => LoginCaptchaSettings.Default.LoginWebFunCaptchaAbTestName;

	public string AndroidAbTestName => LoginCaptchaSettings.Default.LoginAppFunCaptchaAndroidAbTestName;

	public string iOSAbTestName => LoginCaptchaSettings.Default.LoginAppFunCaptchaiOSAbTestName;

	public string UWPAbTestName => LoginCaptchaSettings.Default.LoginAppFunCaptchaUWPAbTestName;

	public bool AndroidDeviceHandleEnabled => LoginCaptchaSettings.Default.DeviceHandleEnabledOnLoginForAndroid;

	public bool iOSDeviceHandleEnabled => LoginCaptchaSettings.Default.DeviceHandleEnabledOnLoginForiOS;

	public bool UWPDeviceHandleEnabled => LoginCaptchaSettings.Default.DeviceHandleEnabledOnLoginForUWP;

	public bool CaptchaAlwaysRequired => LoginCaptchaSettings.Default.CaptchaRequiredForAllLoginAttempts;

	public bool DeviceHandleGlobalEnabled => LoginCaptchaSettings.Default.DeviceHandleEnabledOnLoginForAllAppTypes;

	public WebAuthenticationCaptchaSettingsModel()
	{
		LoginCaptchaSettings.Default.MonitorChanges((Expression<Func<LoginCaptchaSettings, string>>)((LoginCaptchaSettings s) => s.LoginCaptchaAndroidExemptOSMajorVersionList), (Action)delegate
		{
			AndroidExemptOSVersionList = MultiValueSettingParser.TryParseCommaDelimitedListString(LoginCaptchaSettings.Default.LoginCaptchaAndroidExemptOSMajorVersionList, int.Parse);
		});
		LoginCaptchaSettings.Default.MonitorChanges((Expression<Func<LoginCaptchaSettings, string>>)((LoginCaptchaSettings s) => s.LoginCaptchaiOSExemptOSMajorVersionList), (Action)delegate
		{
			iOSExemptOSVersionList = MultiValueSettingParser.TryParseCommaDelimitedListString(LoginCaptchaSettings.Default.LoginCaptchaiOSExemptOSMajorVersionList, int.Parse);
		});
	}
}
