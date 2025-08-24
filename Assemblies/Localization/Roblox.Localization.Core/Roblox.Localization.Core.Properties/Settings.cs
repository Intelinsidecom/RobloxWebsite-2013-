using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Localization.Core.Properties;

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
	[DefaultSettingValue("en_us")]
	public string DefaultSupportedLocale => (string)this["DefaultSupportedLocale"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("English(US)")]
	public string DefaultSupportedLocaleName => (string)this["DefaultSupportedLocaleName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("English")]
	public string DefaultSupportedLocaleNativeName => (string)this["DefaultSupportedLocaleNativeName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("en")]
	public string DefaultSupportedLocaleAssociatedLanguageCode => (string)this["DefaultSupportedLocaleAssociatedLanguageCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("English")]
	public string DefaultSupportedLocaleAssociatedLanguageName => (string)this["DefaultSupportedLocaleAssociatedLanguageName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("English")]
	public string DefaultSupportedLocaleAssociatedLanguageNativeName => (string)this["DefaultSupportedLocaleAssociatedLanguageNativeName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("en")]
	public string AvailableUgcLanguageCodesCsv => (string)this["AvailableUgcLanguageCodesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("41")]
	public int DefaultSupportedLocaleAssociatedLanguageId => (int)this["DefaultSupportedLocaleAssociatedLanguageId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("en")]
	public string AvailableInGameUgcLanguageCodesCsv => (string)this["AvailableInGameUgcLanguageCodesCsv"];

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
