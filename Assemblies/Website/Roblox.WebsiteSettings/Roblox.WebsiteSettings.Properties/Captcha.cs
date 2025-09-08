using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration for Captcha related features
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Captcha : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Captcha defaultInstance = (Captcha)SettingsBase.Synchronized(new Captcha());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static Captcha Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LoginFunCaptchaEnabledForAll => (bool)this["LoginFunCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LoginFunCaptchaEnabledRolloutPercentage => (int)this["LoginFunCaptchaEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignupFunCaptchaEnabledForAll => (bool)this["SignupFunCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SignupFunCaptchaEnabledRolloutPercentage => (int)this["SignupFunCaptchaEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaApiForSignupFunCaptchaValidationEnabledForAll => (bool)this["CaptchaApiForSignupFunCaptchaValidationEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CaptchaApiForSignupFunCaptchaValidationEnabledRolloutPercentage => (int)this["CaptchaApiForSignupFunCaptchaValidationEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupFunCaptchaEnabledBrowserTrackerIdList => (string)this["SignupFunCaptchaEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginFunCaptchaEnabledBrowserTrackerIdList => (string)this["LoginFunCaptchaEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaApiForSignupFunCaptchaValidationEnabledBrowserTrackerIdList => (string)this["CaptchaApiForSignupFunCaptchaValidationEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int CaptchaMaximumRetriesOnTokenValidationFailure => (int)this["CaptchaMaximumRetriesOnTokenValidationFailure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AppCaptchaDebugAlwaysShowChallenge => (bool)this["AppCaptchaDebugAlwaysShowChallenge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CaptchaScriptLoadPerformanceTrackingEnabledRolloutPercentage => (int)this["CaptchaScriptLoadPerformanceTrackingEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaScriptLoadPerformanceTrackingEnabledForAll => (bool)this["CaptchaScriptLoadPerformanceTrackingEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaScriptLoadPerformanceTrackingEnabledBrowserTrackerIdList => (string)this["CaptchaScriptLoadPerformanceTrackingEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AppCaptchaPerAppTypeMetricsEnabled => (bool)this["AppCaptchaPerAppTypeMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AlwaysCaptchaLoginEnabledRolloutPercentage => (int)this["AlwaysCaptchaLoginEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AlwaysCaptchaLoginEnabledForAll => (bool)this["AlwaysCaptchaLoginEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AlwaysCaptchaLoginEnabledBrowserTrackerIdList => (string)this["AlwaysCaptchaLoginEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameCardRedemptionFunCaptchaEnabledBrowserTrackerIdList => (string)this["GameCardRedemptionFunCaptchaEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameCardRedemptionFunCaptchaRolloutPercentage => (int)this["GameCardRedemptionFunCaptchaRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameCardRedemptionFunCaptchaEnabledForAll => (bool)this["GameCardRedemptionFunCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFunCaptchaForCommentsEnabled => (bool)this["IsFunCaptchaForCommentsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FunCaptchaForIncommEnabled => (bool)this["FunCaptchaForIncommEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FunCaptchaForGiftCardEnabled => (bool)this["FunCaptchaForGiftCardEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int CaptchaTokenValidationFailureMinimumRetryIntervalInMilliseconds => (int)this["CaptchaTokenValidationFailureMinimumRetryIntervalInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1500")]
	public int CaptchaTokenValidationFailureMaximumRetryIntervalInMilliseconds => (int)this["CaptchaTokenValidationFailureMaximumRetryIntervalInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaBeforeSignupRequestEnabledBrowserTrackerIdList => (string)this["SignupCaptchaBeforeSignupRequestEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SignupCaptchaBeforeSignupRequestRolloutPercentage => (int)this["SignupCaptchaBeforeSignupRequestRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignupCaptchaBeforeSignupRequestEnabledForAll => (bool)this["SignupCaptchaBeforeSignupRequestEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CaptchaWebAppForAppCaptchaEnabledRolloutPercentage => (int)this["CaptchaWebAppForAppCaptchaEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaWebAppForAppCaptchaEnabledForAll => (bool)this["CaptchaWebAppForAppCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaWebAppForAppCaptchaEnabledBrowserTrackerIdList => (string)this["CaptchaWebAppForAppCaptchaEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("width=device-width, initial-scale=1")]
	public string AppCaptchaViewportMetaContentValue => (string)this["AppCaptchaViewportMetaContentValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnClothingUpload => (bool)this["DeviceHandleEnabledOnClothingUpload"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CaptchaV2ComponentForSignupEnabledRolloutPercentage => (int)this["CaptchaV2ComponentForSignupEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaV2ComponentForSignupEnabledForAll => (bool)this["CaptchaV2ComponentForSignupEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaV2ComponentForSignupEnabledBrowserTrackerIdList => (string)this["CaptchaV2ComponentForSignupEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CaptchaV2ComponentForLoginEnabledRolloutPercentage => (int)this["CaptchaV2ComponentForLoginEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaV2ComponentForLoginEnabledForAll => (bool)this["CaptchaV2ComponentForLoginEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaV2ComponentForLoginEnabledBrowserTrackerIdList => (string)this["CaptchaV2ComponentForLoginEnabledBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WhitelistedCaptchaAccountsCSV => (string)this["WhitelistedCaptchaAccountsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsWebSignUpEndpointCaptchaVerificationEnabledForAll => (bool)this["IsWebSignUpEndpointCaptchaVerificationEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int WebSignUpEndpointCaptchaVerificationEnabledRolloutPercentage => (int)this["WebSignUpEndpointCaptchaVerificationEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebSignUpEndpointCaptchaVerificationEnabledBrowserTrackerIDList => (string)this["WebSignUpEndpointCaptchaVerificationEnabledBrowserTrackerIDList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBEDEV2CaptchaEnabledForWebSignUpForAll => (bool)this["IsBEDEV2CaptchaEnabledForWebSignUpForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int BEDEV2CaptchaEnabledForWebSignUpRolloutPercentage => (int)this["BEDEV2CaptchaEnabledForWebSignUpRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BEDEV2CaptchaEnabledForWebSignUpBrowserTrackerIDList => (string)this["BEDEV2CaptchaEnabledForWebSignUpBrowserTrackerIDList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBEDEV2CaptchaEnabledForWebLoginForAll => (bool)this["IsBEDEV2CaptchaEnabledForWebLoginForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BEDEV2CaptchaEnabledForWebLoginBrowserTrackerIDList => (string)this["BEDEV2CaptchaEnabledForWebLoginBrowserTrackerIDList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int BEDEV2CaptchaEnabledForWebLoginRolloutPercentage => (int)this["BEDEV2CaptchaEnabledForWebLoginRolloutPercentage"];

	internal Captcha()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
