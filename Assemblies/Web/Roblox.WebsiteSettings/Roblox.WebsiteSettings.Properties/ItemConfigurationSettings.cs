using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class ItemConfigurationSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static ItemConfigurationSettings defaultInstance = (ItemConfigurationSettings)SettingsBase.Synchronized(new ItemConfigurationSettings());

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

	public static ItemConfigurationSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCreateAssetViaWebAppForSoothsayerEnabled => (bool)this["IsCreateAssetViaWebAppForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CreateAssetViaWebAppRolloutPercentage => (int)this["CreateAssetViaWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsWritingAssetGenreToItemTagsServiceEnabled => (bool)this["IsWritingAssetGenreToItemTagsServiceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedirectCatalogAssetConfigurationPagesForSoothsayerEnabled => (bool)this["IsRedirectCatalogAssetConfigurationPagesForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RedirectCatalogAssetConfigurationPagesRolloutPercentage => (int)this["RedirectCatalogAssetConfigurationPagesRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItemTagFactoryMemoryCacheEnabled => (bool)this["IsItemTagFactoryMemoryCacheEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan ItemTagFactoryMemoryCacheExpiry => (TimeSpan)this["ItemTagFactoryMemoryCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRefreshAheadAssetGenreItemTagDictionaryEnabled => (bool)this["IsRefreshAheadAssetGenreItemTagDictionaryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan RefreshAheadAssetGenreItemTagDictionaryRefreshInterval => (TimeSpan)this["RefreshAheadAssetGenreItemTagDictionaryRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRefreshAheadAssetGenreItemTagNameConverterEnabled => (bool)this["IsRefreshAheadAssetGenreItemTagNameConverterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan RefreshAheadAssetGenreItemTagNameConverterRefreshInterval => (TimeSpan)this["RefreshAheadAssetGenreItemTagNameConverterRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPersistingAssetGenreMigrationStateEnabled => (bool)this["IsPersistingAssetGenreMigrationStateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AllowAssetTypesForItemConfigurationCsv => (string)this["AllowAssetTypesForItemConfigurationCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ItemConfigurationForCatalogAssetEnabledWhiteList => (string)this["ItemConfigurationForCatalogAssetEnabledWhiteList"];

	internal ItemConfigurationSettings()
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
