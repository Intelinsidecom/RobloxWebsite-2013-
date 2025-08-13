using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.TwoStepVerification.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("00:15:00")]
	public TimeSpan TwoStepVerificationCodeExpiration => (TimeSpan)this["TwoStepVerificationCodeExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("no-reply@roblox.com")]
	public string TwoStepVerificationCodeSenderEmailAddress => (string)this["TwoStepVerificationCodeSenderEmailAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTwoStepVerificationLoggingEnabled => (bool)this["IsTwoStepVerificationLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int TwoStepVerificationCodeLength => (int)this["TwoStepVerificationCodeLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1234567890")]
	public string TwoStepVerificationCodeCharacters => (string)this["TwoStepVerificationCodeCharacters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsTwoStepVerificationEnabled => (bool)this["IsTwoStepVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan TwoStepVerificationSessionTokenExpiry => (TimeSpan)this["TwoStepVerificationSessionTokenExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int TwoStepCookieMaxTokenCount => (int)this["TwoStepCookieMaxTokenCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVerificationViaSMSForRegularUsersEnabled => (bool)this["IsVerificationViaSMSForRegularUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSettingsTableAuditingEnabled => (bool)this["IsSettingsTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int TwoStepVerificationCodeGenerationFloodCheckLimit => (int)this["TwoStepVerificationCodeGenerationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan TwoStepVerificationCodeGenerationFloodCheckExpiry => (TimeSpan)this["TwoStepVerificationCodeGenerationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan TwoStepVerificationCodeInputFloodCheckExpiry => (TimeSpan)this["TwoStepVerificationCodeInputFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int TwoStepVerificationCodeInputFloodCheckLimit => (int)this["TwoStepVerificationCodeInputFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int TwoStepVerificationResendCodeFloodCheckLimit => (int)this["TwoStepVerificationResendCodeFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan TwoStepVerificationResendCodeFloodCheckExpiry => (TimeSpan)this["TwoStepVerificationResendCodeFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int TwoStepVerificationSetFloodCheckLimit => (int)this["TwoStepVerificationSetFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan TwoStepVerificationSetFloodCheckExpiry => (TimeSpan)this["TwoStepVerificationSetFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSettingBasedHelpPageLinkLocalizationEnabled => (bool)this["IsSettingBasedHelpPageLinkLocalizationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTwoStepSecureBlobEnabled => (bool)this["IsTwoStepSecureBlobEnabled"];

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
