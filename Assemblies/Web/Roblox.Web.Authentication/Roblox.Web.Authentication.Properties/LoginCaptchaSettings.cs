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
public sealed class LoginCaptchaSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static LoginCaptchaSettings defaultInstance = (LoginCaptchaSettings)SettingsBase.Synchronized(new LoginCaptchaSettings());

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

	public static LoginCaptchaSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginAppFunCaptchaAndroidAbTestName => (string)this["LoginAppFunCaptchaAndroidAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginAppFunCaptchaiOSAbTestName => (string)this["LoginAppFunCaptchaiOSAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginAppFunCaptchaUWPAbTestName => (string)this["LoginAppFunCaptchaUWPAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnLoginForAndroid => (bool)this["DeviceHandleEnabledOnLoginForAndroid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnLoginForiOS => (bool)this["DeviceHandleEnabledOnLoginForiOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnLoginForUWP => (bool)this["DeviceHandleEnabledOnLoginForUWP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaRequiredForAllLoginAttempts => (bool)this["CaptchaRequiredForAllLoginAttempts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandleEnabledOnLoginForAllAppTypes => (bool)this["DeviceHandleEnabledOnLoginForAllAppTypes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaAndroidMinimumAppVersion => (string)this["LoginCaptchaAndroidMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaiOSMinimumAppVersion => (string)this["LoginCaptchaiOSMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaUWPMinimumAppVersion => (string)this["LoginCaptchaUWPMinimumAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaAndroidExemptOSMajorVersionList => (string)this["LoginCaptchaAndroidExemptOSMajorVersionList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaiOSExemptOSMajorVersionList => (string)this["LoginCaptchaiOSExemptOSMajorVersionList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginWebFunCaptchaAbTestName => (string)this["LoginWebFunCaptchaAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan LoginCaptchaActionSuccessExpirationTime => (TimeSpan)this["LoginCaptchaActionSuccessExpirationTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoginCaptchaExemptCredentialValuesList => (string)this["LoginCaptchaExemptCredentialValuesList"];

	public LoginCaptchaSettings()
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
