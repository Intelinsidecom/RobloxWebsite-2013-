using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Localization.Accounts.Properties;

[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("10")]
	public int AccountLocaleUpdateUserIdFloodCheckerLimit => (int)this["AccountLocaleUpdateUserIdFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan AccountLocaleUpdateUserIdFloodCheckerExpiry => (TimeSpan)this["AccountLocaleUpdateUserIdFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCountryChangedEventEnabled => (bool)this["IsCountryChangedEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSupportedLocaleChangedEventEnabled => (bool)this["IsSupportedLocaleChangedEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AccountLocaleUpdateForObservedLocaleFloodCheckerLimit => (int)this["AccountLocaleUpdateForObservedLocaleFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan AccountLocaleUpdateForObservedLocaleFloodCheckerExpiry => (TimeSpan)this["AccountLocaleUpdateForObservedLocaleFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public byte AccountCountriesAuditCompositeEntryCountLimit => (byte)this["AccountCountriesAuditCompositeEntryCountLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountCountriesTableAuditingEnabled => (bool)this["IsAccountCountriesTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountLocalesTableAuditingEnabled => (bool)this["IsAccountLocalesTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public byte AccountLocalesAuditCompositeEntryCountLimit => (byte)this["AccountLocalesAuditCompositeEntryCountLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRemoveUnneededLocaleMappingLogicEnabled => (bool)this["IsRemoveUnneededLocaleMappingLogicEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AccountCountryUpdateForUserFloodCheckerLimit => (int)this["AccountCountryUpdateForUserFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan AccountCountryUpdateForUserFloodCheckerExpiry => (TimeSpan)this["AccountCountryUpdateForUserFloodCheckerExpiry"];

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
