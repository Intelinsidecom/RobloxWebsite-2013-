using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Email.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmailValidationShadyEmailProviderCheckEnabled => (bool)this["IsEmailValidationShadyEmailProviderCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmailValidationIgnorePeriodsInBlacklistCheckEnabled => (bool)this["IsEmailValidationIgnorePeriodsInBlacklistCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EmailValidationShadyEmailProvidersCsv => (string)this["EmailValidationShadyEmailProvidersCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan EmailVerificationTicketExpiration => (TimeSpan)this["EmailVerificationTicketExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserEmailChangeEnabled => (bool)this["IsUserEmailChangeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserEmailVerificationEnabled => (bool)this["IsUserEmailVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("^\\w+([-_+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$")]
	public string ValidEmailRegex => (string)this["ValidEmailRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmailDomainValidationEnabled => (bool)this["IsEmailDomainValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmailValidationBriteVerifyCheckEnabled => (bool)this["IsEmailValidationBriteVerifyCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("24.00:00:00")]
	public TimeSpan ContactUpsellMinimumAccountAge => (TimeSpan)this["ContactUpsellMinimumAccountAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int VerifyEmailFloodCheckLimit => (int)this["VerifyEmailFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan VerifyEmailFloodCheckExpiry => (TimeSpan)this["VerifyEmailFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int MaxValidAccountsPerEmailAddress => (int)this["MaxValidAccountsPerEmailAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("no-reply@roblox.com")]
	public string NoReplyEmailAddress => (string)this["NoReplyEmailAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("info@roblox.com")]
	public string RobloxInfoEmailAddress => (string)this["RobloxInfoEmailAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("username_change@roblox.com")]
	public string UsernameChangeEmailAddress => (string)this["UsernameChangeEmailAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AllowAcceptAll => (bool)this["AllowAcceptAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKickboxEmailValidationEnabled => (bool)this["IsKickboxEmailValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKickboxEmailDomainValidationEnabled => (bool)this["IsKickboxEmailDomainValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSettingBasedHelpPageLinkLocalizationEnabled => (bool)this["IsSettingBasedHelpPageLinkLocalizationEnabled"];

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

	internal Settings()
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
