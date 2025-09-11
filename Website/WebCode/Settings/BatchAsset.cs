using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class BatchAsset : ApplicationSettingsBase, IBatchAssetSettings
{
	/// <summary>
	/// Configuration that uses Roblox.Configuration.Provider
	/// </summary>
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static BatchAsset defaultInstance = (BatchAsset)SettingsBase.Synchronized(new BatchAsset());

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

	public static BatchAsset Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PlaceScriptInsertForbidden => (bool)this["PlaceScriptInsertForbidden"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int TrackClientSideInsertsInEphemeralCountersPercentage => (int)this["TrackClientSideInsertsInEphemeralCountersPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CheckAssetTypeInAssetHandler => (bool)this["CheckAssetTypeInAssetHandler"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IgnoreAssetTypeHeaderCheckForRobloxCreatedAssets => (bool)this["IgnoreAssetTypeHeaderCheckForRobloxCreatedAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AllowCreatorsToAccessInReviewAssets => (bool)this["AllowCreatorsToAccessInReviewAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEnabledForSoothSayers => (bool)this["IsEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEnabledForAll => (bool)this["IsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("128")]
	public int MaxAssetsPerBatch => (int)this["MaxAssetsPerBatch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double StatisticalMetricsDatasetPercent => (double)this["StatisticalMetricsDatasetPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogRequestBody => (bool)this["LogRequestBody"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAudioAssetContentRestrictedAccessEnabled => (bool)this["IsAudioAssetContentRestrictedAccessEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAudioAssetContentRestrictedAccessLoggingEnabled => (bool)this["IsAudioAssetContentRestrictedAccessLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAudioAssetContentRestrictedAccessCounterEnabled => (bool)this["IsAudioAssetContentRestrictedAccessCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AudioAssetCopyrightHeaderAndReplacementRolloutPercentage => (int)this["AudioAssetCopyrightHeaderAndReplacementRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Audio, Animation")]
	public string HashRequestBlacklistedAssetTypesCsv => (string)this["HashRequestBlacklistedAssetTypesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdditionalChecksForAssetRequestsByHashEnabled => (bool)this["AdditionalChecksForAssetRequestsByHashEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UsePlaceIdHeaderInsteadOfQueryString => (bool)this["UsePlaceIdHeaderInsteadOfQueryString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxProxiedForHeaderForAssetDeliveryEnabled => (bool)this["RobloxProxiedForHeaderForAssetDeliveryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArchivedAssetCheckEnabled => (bool)this["ArchivedAssetCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArchivedAssetLocationEnabled => (bool)this["ArchivedAssetLocationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AssetVersionReadFromPlatformRolloutPercentage => (int)this["AssetVersionReadFromPlatformRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserGeneratedContentRenderingEnabledForCatalog => (bool)this["UserGeneratedContentRenderingEnabledForCatalog"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserGeneratedContentRenderingEnabledForAll => (bool)this["UserGeneratedContentRenderingEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserGeneratedContentRenderingEnabledForCatalogItemCreators => (bool)this["UserGeneratedContentRenderingEnabledForCatalogItemCreators"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserGeneratedContentRenderingAssetTypeIdCsv => (string)this["UserGeneratedContentRenderingAssetTypeIdCsv"];

	internal BatchAsset()
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
