using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Localization.Accounts.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
public sealed class UgcLocaleRolloutSettings : ApplicationSettingsBase, IUgcLocaleRolloutSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static UgcLocaleRolloutSettings defaultInstance = (UgcLocaleRolloutSettings)SettingsBase.Synchronized(new UgcLocaleRolloutSettings());

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

	public static UgcLocaleRolloutSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcSpanishLocaleEnabledForSoothsayers => (bool)this["IsUgcSpanishLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcSpanishLocaleEnabledForAll => (bool)this["IsUgcSpanishLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcPortugueseLocaleEnabledForSoothsayers => (bool)this["IsUgcPortugueseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcPortugueseLocaleEnabledForAll => (bool)this["IsUgcPortugueseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcThaiLocaleEnabledForSoothsayers => (bool)this["IsUgcThaiLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcThaiLocaleEnabledForAll => (bool)this["IsUgcThaiLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcRussianLocaleEnabledForSoothsayers => (bool)this["IsUgcRussianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcRussianLocaleEnabledForAll => (bool)this["IsUgcRussianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcIndonesianLocaleEnabledForSoothsayers => (bool)this["IsUgcIndonesianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcIndonesianLocaleEnabledForAll => (bool)this["IsUgcIndonesianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcVietnameseLocaleEnabledForSoothsayers => (bool)this["IsUgcVietnameseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcVietnameseLocaleEnabledForAll => (bool)this["IsUgcVietnameseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcTurkishLocaleEnabledForSoothsayers => (bool)this["IsUgcTurkishLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcTurkishLocaleEnabledForAll => (bool)this["IsUgcTurkishLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcKoreanLocaleEnabledForSoothsayers => (bool)this["IsUgcKoreanLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcKoreanLocaleEnabledForAll => (bool)this["IsUgcKoreanLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcGermanLocaleEnabledForSoothsayers => (bool)this["IsUgcGermanLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcGermanLocaleEnabledForAll => (bool)this["IsUgcGermanLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcFrenchLocaleEnabledForSoothsayers => (bool)this["IsUgcFrenchLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcFrenchLocaleEnabledForAll => (bool)this["IsUgcFrenchLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcItalianLocaleEnabledForSoothsayers => (bool)this["IsUgcItalianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcItalianLocaleEnabledForAll => (bool)this["IsUgcItalianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcJapaneseLocaleEnabledForSoothsayers => (bool)this["IsUgcJapaneseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcJapaneseLocaleEnabledForAll => (bool)this["IsUgcJapaneseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcSimplifiedChineseLocaleEnabledForSoothsayers => (bool)this["IsUgcSimplifiedChineseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcSimplifiedChineseLocaleEnabledForAll => (bool)this["IsUgcSimplifiedChineseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcTraditionalChineseLocaleEnabledForSoothsayers => (bool)this["IsUgcTraditionalChineseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUgcTraditionalChineseLocaleEnabledForAll => (bool)this["IsUgcTraditionalChineseLocaleEnabledForAll"];

	internal UgcLocaleRolloutSettings()
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
