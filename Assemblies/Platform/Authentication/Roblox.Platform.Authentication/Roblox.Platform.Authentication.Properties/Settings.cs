using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Authentication.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, IAuthenticationSettings
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
	[DefaultSettingValue("5")]
	public int FailedLoginFloodCheck_FailureLimit => (int)this["FailedLoginFloodCheck_FailureLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan FailedLoginFloodCheck_CoolOff => (TimeSpan)this["FailedLoginFloodCheck_CoolOff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string UsersConnectionString => (string)this["UsersConnectionString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XboxLiveGamerTagSecretSalt => (string)this["XboxLiveGamerTagSecretSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountsNeedingPasswordResetsEnabled => (bool)this["IsAccountsNeedingPasswordResetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int PasswordChangeFloodCheckerLimit => (int)this["PasswordChangeFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan PasswordChangeFloodCheckerExpiry => (TimeSpan)this["PasswordChangeFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int AccountsByEmailAddressPageSize => (int)this["AccountsByEmailAddressPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int GetPhoneNumbersByNationalPhoneNumberPageSize => (int)this["GetPhoneNumbersByNationalPhoneNumberPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int NationalPhoneNumbersThreshold => (int)this["NationalPhoneNumbersThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int CheckAccountPhoneNumbersMaxDegreeOfParallelism => (int)this["CheckAccountPhoneNumbersMaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int AccountsPerPhoneNumberThreshold => (int)this["AccountsPerPhoneNumberThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int VerifiedAccountsPerEmailAddressesThreshold => (int)this["VerifiedAccountsPerEmailAddressesThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int CheckEmailAccountsMaxDegreeOfParallelism => (int)this["CheckEmailAccountsMaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int GetAccountPhoneNumbersByPhoneNumberPageSize => (int)this["GetAccountPhoneNumbersByPhoneNumberPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int UnverifiedAccountsPerEmailAddressesThreshold => (int)this["UnverifiedAccountsPerEmailAddressesThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRemoteCacheEnabledForXboxLiveAccount => (bool)this["IsRemoteCacheEnabledForXboxLiveAccount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRemoteCacheEnabledForXboxLiveAccountGetByAccountID => (bool)this["IsRemoteCacheEnabledForXboxLiveAccountGetByAccountID"];

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
