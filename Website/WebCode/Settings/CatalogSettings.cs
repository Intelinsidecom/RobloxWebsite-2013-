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
public sealed class CatalogSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static CatalogSettings defaultInstance = (CatalogSettings)SettingsBase.Synchronized(new CatalogSettings());

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

	public static CatalogSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public float CatalogItemImpressionCountRolloutPercentage => (float)this["CatalogItemImpressionCountRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewCatalogLayoutAbTestEnabled => (bool)this["IsNewCatalogLayoutAbTestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int CatalogDefaultResultsPerPage => (int)this["CatalogDefaultResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.Web.NewCatalogLayout")]
	public string NewCatalogLayoutAbTestName => (string)this["NewCatalogLayoutAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int NumberOfLargeSplashTiles => (int)this["NumberOfLargeSplashTiles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32")]
	public int NumberOfCatalogItemsToDisplayOnSplash => (int)this["NumberOfCatalogItemsToDisplayOnSplash"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogLargeSplashTilesEnabledForAll => (bool)this["IsCatalogLargeSplashTilesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogFiveRowTilesEnabledForAll => (bool)this["IsCatalogFiveRowTilesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogInfiniteScrollEnabledForAll => (bool)this["IsCatalogInfiniteScrollEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogFavoritesLinkEnabledForAll => (bool)this["IsCatalogFavoritesLinkEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MaxNumberOfTagsToDisplay => (int)this["MaxNumberOfTagsToDisplay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDisplayItemTagsForSoothsayersEnabled => (bool)this["IsDisplayItemTagsForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ReadItemTagsRolloutPercentage => (int)this["ReadItemTagsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DisplayItemTagsRolloutPercentage => (int)this["DisplayItemTagsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreNotForSaleNewUgcAssetsHiddenFromCatalogSearchEnabled => (bool)this["AreNotForSaleNewUgcAssetsHiddenFromCatalogSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTagsInCatalogSearchSoothSayerExperimentEnabled => (bool)this["IsTagsInCatalogSearchSoothSayerExperimentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TagsInCatalogSearchSoothSayerExperimentWhitelistCsv => (string)this["TagsInCatalogSearchSoothSayerExperimentWhitelistCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTooManyRequestsResponseFromCatalogJsonEnabled => (bool)this["IsTooManyRequestsResponseFromCatalogJsonEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReadingAssetGenreFromItemTagsServiceEnabledForAllUsers => (bool)this["IsReadingAssetGenreFromItemTagsServiceEnabledForAllUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReadingAssetGenreFromItemTagsServiceEnabledForSoothsayers => (bool)this["IsReadingAssetGenreFromItemTagsServiceEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ReadingAssetGenreFromItemTagsServiceRolloutPercentage => (int)this["ReadingAssetGenreFromItemTagsServiceRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCatalogPageFullScreenEnabled => (bool)this["IsCatalogPageFullScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGetCatalogItemsThrottledByUserEnabled => (bool)this["IsGetCatalogItemsThrottledByUserEnabled"];

	internal CatalogSettings()
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
