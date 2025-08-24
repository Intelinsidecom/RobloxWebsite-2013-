using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Permissions.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
internal sealed class Settings : ApplicationSettingsBase, ISettings, INotifyPropertyChanged
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("BE,BG,HR,CY,DK,EE,FI,FR,DE,GR,HU,IT,LV,LT,LU,MT,NL,PL,PT,RO,SK,SI,ES,SE")]
	public string GdprAge16Locations => (string)this["GdprAge16Locations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GdprAge15Locations => (string)this["GdprAge15Locations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AT")]
	public string GdprAge14Locations => (string)this["GdprAge14Locations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("CZ,IE,PL,SE,UK")]
	public string GdprAge13Locations => (string)this["GdprAge13Locations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("13")]
	public byte CoppaAgeThreshold => (byte)this["CoppaAgeThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreUserUnderChinaPolicyTestersEnabledForAll => (bool)this["AreUserUnderChinaPolicyTestersEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChinaPolicyWhitelistedUserIdsCsv => (string)this["ChinaPolicyWhitelistedUserIdsCsv"];

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
