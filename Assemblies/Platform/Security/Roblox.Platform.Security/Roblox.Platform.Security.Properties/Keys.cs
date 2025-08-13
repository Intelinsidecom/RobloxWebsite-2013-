using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Security.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
public sealed class Keys : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Keys defaultInstance = (Keys)SettingsBase.Synchronized(new Keys());

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

	public static Keys Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClientSignatureKeyBase64 => (string)this["ClientSignatureKeyBase64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseClientSignatureKey => (bool)this["UseClientSignatureKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameJoinTicketSignatureBase64 => (string)this["GameJoinTicketSignatureBase64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseGameJoinTicketSignatureKeyV2ForSigning => (bool)this["UseGameJoinTicketSignatureKeyV2ForSigning"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisallowGameJoinTicketSignatureKey => (bool)this["DisallowGameJoinTicketSignatureKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignScriptWithClientSignatureKeyForSoothSayers => (bool)this["SignScriptWithClientSignatureKeyForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SignScriptWithClientSignatureKeyRolloutPercentage => (int)this["SignScriptWithClientSignatureKeyRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PasswordResetSignatureKeyBase64 => (string)this["PasswordResetSignatureKeyBase64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignupKeyBase64 => (string)this["SignupKeyBase64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClientSignatureKeyV2Base64 => (string)this["ClientSignatureKeyV2Base64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SignScriptWithClientSignatureKeyV2RolloutPercentage => (int)this["SignScriptWithClientSignatureKeyV2RolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClientSignatureKeyForRccBase64 => (string)this["ClientSignatureKeyForRccBase64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignScriptWithClientSignatureKeyV2ForSoothSayers => (bool)this["SignScriptWithClientSignatureKeyV2ForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseClientSignatureKeyForRcc => (bool)this["UseClientSignatureKeyForRcc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameJoinTicketSignatureV2Base64 => (string)this["GameJoinTicketSignatureV2Base64"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowGameJoinTicketSignatureKeyV2ForSigning => (bool)this["AllowGameJoinTicketSignatureKeyV2ForSigning"];

	internal Keys()
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
