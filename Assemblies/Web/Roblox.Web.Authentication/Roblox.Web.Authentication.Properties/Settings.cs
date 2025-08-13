using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Web.Authentication.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, IFloodCheckerSettings, ISettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AuthCookieVersion => (string)this["AuthCookieVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldAppendDoNotShareWarningToAuthCookie => (bool)this["ShouldAppendDoNotShareWarningToAuthCookie"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldRemoveDoNotShareWarningFromAuthCookie => (bool)this["ShouldRemoveDoNotShareWarningFromAuthCookie"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoveDeletedAuthCookieOnGetOrCreateEnabled => (bool)this["RemoveDeletedAuthCookieOnGetOrCreateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Please sign in with Facebook. This account does not have a password set.")]
	public string SocialMediaLoginMessage => (string)this["SocialMediaLoginMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox")]
	public string LogSource => (string)this["LogSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Warning")]
	public string LogLevel => (string)this["LogLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AccountPinAuthHashSalt => (string)this["AccountPinAuthHashSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan WebSessionTokenTimeToLive => (TimeSpan)this["WebSessionTokenTimeToLive"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan GameSessionTokenTimeToLive => (TimeSpan)this["GameSessionTokenTimeToLive"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForgotUsernameWithPhoneEnabled => (bool)this["IsForgotUsernameWithPhoneEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForgotPasswordWithPhoneEnabled => (bool)this["IsForgotPasswordWithPhoneEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int ForgotUsernameSMSFloodCheckerLimit => (int)this["ForgotUsernameSMSFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan ForgotUsernameSMSFloodCheckerExpiry => (TimeSpan)this["ForgotUsernameSMSFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEnsureExpirationIsCurrentEnabled => (bool)this["IsEnsureExpirationIsCurrentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FailedLoginByUserFloodCheckLimit => (int)this["FailedLoginByUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan FailedLoginByUserFloodCheckExpiry => (TimeSpan)this["FailedLoginByUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int FailedLoginByIpFloodCheckLimit => (int)this["FailedLoginByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan FailedLoginByIpFloodCheckExpiry => (TimeSpan)this["FailedLoginByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int ForgotUsernameSMSPhoneFloodCheckerLimit => (int)this["ForgotUsernameSMSPhoneFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan ForgotUsernameSMSPhoneFloodCheckerExpiry => (TimeSpan)this["ForgotUsernameSMSPhoneFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int ImpersonationFloodCheckLimit => (int)this["ImpersonationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAuthApiForImpersonationEnabled => (bool)this["IsAuthApiForImpersonationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan ImpersonationFloodCheckExpiry => (TimeSpan)this["ImpersonationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountRecoveryReferrerOriginTagEnabled => (bool)this["IsAccountRecoveryReferrerOriginTagEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan UserCredentialsFloodCheckExpiry => (TimeSpan)this["UserCredentialsFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int UserCredentialsFloodCheckLimit => (int)this["UserCredentialsFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeviceHandleFailByUserEnabled => (bool)this["IsDeviceHandleFailByUserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LoginWithEmailRolloutPercentage => (int)this["LoginWithEmailRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LoginWithPhoneRolloutPercentage => (int)this["LoginWithPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginWithEmailBrowserTrackerIdList => (string)this["LoginWithEmailBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginWithPhoneBrowserTrackerIdList => (string)this["LoginWithPhoneBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignInWithUserCredentialsActionLoggingEnabled => (bool)this["SignInWithUserCredentialsActionLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AdministrationFailedLoginByIpFloodCheckLimit => (int)this["AdministrationFailedLoginByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AdministrationFailedLoginByIpFloodCheckExpiry => (TimeSpan)this["AdministrationFailedLoginByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginCaptchaHashingEnabled => (bool)this["IsLoginCaptchaHashingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExistingLoginSessionShouldFailEnabled => (bool)this["ExistingLoginSessionShouldFailEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int SignInWithFacebookByIpAndFacebookIdFloodCheckerLimit => (int)this["SignInWithFacebookByIpAndFacebookIdFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan SignInWithFacebookByIpAndFacebookIdFloodCheckerExpiry => (TimeSpan)this["SignInWithFacebookByIpAndFacebookIdFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int SignInWithFacebookByFacebookIdFloodCheckerLimit => (int)this["SignInWithFacebookByFacebookIdFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan SignInWithFacebookByFacebookIdFloodCheckerExpiry => (TimeSpan)this["SignInWithFacebookByFacebookIdFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int SendVerificationMessageByIpFloodCheckLimit => (int)this["SendVerificationMessageByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:20:00")]
	public TimeSpan SendVerificationMessageByIpFloodCheckExpiry => (TimeSpan)this["SendVerificationMessageByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int SendVerificationMessageByIpAndCredentialsFloodCheckLimit => (int)this["SendVerificationMessageByIpAndCredentialsFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan SendVerificationMessageByIpAndCredentialsFloodCheckExpiry => (TimeSpan)this["SendVerificationMessageByIpAndCredentialsFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int SendVerificationMessageByUserIdFloodCheckLimit => (int)this["SendVerificationMessageByUserIdFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan SendVerificationMessageByUserIdFloodCheckExpiry => (TimeSpan)this["SendVerificationMessageByUserIdFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int LoginAttemptByIpFloodCheckLimit => (int)this["LoginAttemptByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan LoginAttemptByIpFloodCheckExpiry => (TimeSpan)this["LoginAttemptByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginAttemptByIpFloodCheckEnabled => (bool)this["IsLoginAttemptByIpFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AuthApiSignUpEndpointUrl => (string)this["AuthApiSignUpEndpointUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:20:00")]
	public TimeSpan CanSendVerificationMessageByIpFloodCheckExpiry => (TimeSpan)this["CanSendVerificationMessageByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int CanSendVerificationMessageByIpFloodCheckLimit => (int)this["CanSendVerificationMessageByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan CanSendVerificationMessageByIpAndCredentialsFloodCheckExpiry => (TimeSpan)this["CanSendVerificationMessageByIpAndCredentialsFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int CanSendVerificationMessageByIpAndCredentialsFloodCheckLimit => (int)this["CanSendVerificationMessageByIpAndCredentialsFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PromptUnverifiedEmailsOnLoginRolloutPercentage => (int)this["PromptUnverifiedEmailsOnLoginRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PromptUnverifiedEmailsOnLoginBrowserTrackerIdList => (string)this["PromptUnverifiedEmailsOnLoginBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPromptUnverifiedEmailsOnLoginEnabled => (bool)this["IsPromptUnverifiedEmailsOnLoginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginReturnsFloodedOnInvalidDeviceHandleEnabled => (bool)this["IsLoginReturnsFloodedOnInvalidDeviceHandleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSignUpEmailFieldForUserAcquisitionsEnabled => (bool)this["IsSignUpEmailFieldForUserAcquisitionsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMovingHintsUnderTextBoxEnabled => (bool)this["IsMovingHintsUnderTextBoxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MovingHintsUnderTextBoxBrowserTrackerIdList => (string)this["MovingHintsUnderTextBoxBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MovingHintsUnderTextBoxRolloutPercentage => (int)this["MovingHintsUnderTextBoxRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupAppFunCaptchaAndroidAbTestName => (string)this["SignupAppFunCaptchaAndroidAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupAppFunCaptchaiOSAbTestName => (string)this["SignupAppFunCaptchaiOSAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupAppFunCaptchaUWPAbTestName => (string)this["SignupAppFunCaptchaUWPAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnSignupForAndroid => (bool)this["DeviceHandleEnabledOnSignupForAndroid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnSignupForiOS => (bool)this["DeviceHandleEnabledOnSignupForiOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnSignupForUWP => (bool)this["DeviceHandleEnabledOnSignupForUWP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaRequiredForAllSignupAttempts => (bool)this["CaptchaRequiredForAllSignupAttempts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaAndroidMinimumAppVersion => (string)this["SignupCaptchaAndroidMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaAndroidExemptOSMajorVersionList => (string)this["SignupCaptchaAndroidExemptOSMajorVersionList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaiOSMinimumAppVersion => (string)this["SignupCaptchaiOSMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaiOSExemptOSMajorVersionList => (string)this["SignupCaptchaiOSExemptOSMajorVersionList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupCaptchaUWPMinimumAppVersion => (string)this["SignupCaptchaUWPMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnSignupForAllAppTypes => (bool)this["DeviceHandleEnabledOnSignupForAllAppTypes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupWebFunCaptchaAbTestName => (string)this["SignupWebFunCaptchaAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTwoStepVerificationUnavailable => (bool)this["IsTwoStepVerificationUnavailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public Guid ChinaLicenseBuildApiKey => (Guid)this["ChinaLicenseBuildApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCredentialsLoginForChinaLicenseUsersEnabled => (bool)this["IsCredentialsLoginForChinaLicenseUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHideInvalidAccountForForgotCredentialsEnabled => (bool)this["IsHideInvalidAccountForForgotCredentialsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FacebookSignUpOnLandingPageRolloutPercentage => (int)this["FacebookSignUpOnLandingPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FacebookSignUpOnLandingPageBrowserTrackerIdList => (string)this["FacebookSignUpOnLandingPageBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFacebookSignUpOnLandingPageEnabled => (bool)this["IsFacebookSignUpOnLandingPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FacebookSignUpOnLandingPageAbTestName => (string)this["FacebookSignUpOnLandingPageAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CheckWeChatSessionByRolesetRolloutPercentage => (int)this["CheckWeChatSessionByRolesetRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CheckWeChatSessionByRequestContextRolloutPercentage => (int)this["CheckWeChatSessionByRequestContextRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RevertAccountWebAppBrowserTrackerIdList => (string)this["RevertAccountWebAppBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RevertAccountWebAppRolloutPercentage => (int)this["RevertAccountWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRevertTicketSecureBlobEnabled => (bool)this["IsRevertTicketSecureBlobEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AuthCookieDoNotShareWarning => (string)this["AuthCookieDoNotShareWarning"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CheckTencentSessionByRequestContextRolloutPercentage => (int)this["CheckTencentSessionByRequestContextRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CheckTencentSessionByRolesetRolloutPercentage => (int)this["CheckTencentSessionByRolesetRolloutPercentage"];

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
