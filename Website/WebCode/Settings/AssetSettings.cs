using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class AssetSettings : ApplicationSettingsBase
{
	private static AssetSettings defaultInstance = (AssetSettings)SettingsBase.Synchronized(new AssetSettings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static AssetSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IgnoreAssetTypeHeaderCheckForRobloxCreatedAssets => (bool)this["IgnoreAssetTypeHeaderCheckForRobloxCreatedAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IgnoreUserIdInQueryString => (bool)this["IgnoreUserIdInQueryString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStreamingPlaceAudioMappingDataEnabled => (bool)this["IsStreamingPlaceAudioMappingDataEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStreamingPlaceAudioMappingDataFromBatchRequestEnabled => (bool)this["IsStreamingPlaceAudioMappingDataFromBatchRequestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AudioCopyrightBlockedOnItemPageRolloutPercentage => (int)this["AudioCopyrightBlockedOnItemPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetRequestMetricsEnabled => (bool)this["AssetRequestMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetTypeMetricsEnabled => (bool)this["AssetTypeMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RetrievePlaceIdFromHeader => (bool)this["RetrievePlaceIdFromHeader"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ServerPlaceIdToPlaceIdFallbackEnabled => (bool)this["ServerPlaceIdToPlaceIdFallbackEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TranscodeAssetsPlaceIds => (string)this["TranscodeAssetsPlaceIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TranscodingAssetsEnabledForAll => (bool)this["TranscodingAssetsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TranscodingAssetsEnabledForSoothsayers => (bool)this["TranscodingAssetsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TranscodingRolloutPercentage => (int)this["TranscodingRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetEndpointReturnsAssetVersionNumberHeaderEnabled => (bool)this["AssetEndpointReturnsAssetVersionNumberHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseDynamicThumbnailLighting => (bool)this["UseDynamicThumbnailLighting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmotesEnabledForSoothsayers => (bool)this["IsEmotesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmotesEnabledForAll => (bool)this["IsEmotesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UnparseableServerPlaceIdFallBacktoPlaceIdHeaderEnabled => (bool)this["UnparseableServerPlaceIdFallBacktoPlaceIdHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedirectAssetFetchToAssetDeliveryApiEnabled => (bool)this["IsRedirectAssetFetchToAssetDeliveryApiEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsArchivedAssetHidingEnabled => (bool)this["IsArchivedAssetHidingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupPluginsPublishingEnabled => (bool)this["IsGroupPluginsPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCopyrightResponseHeaderEnabled => (bool)this["IsCopyrightResponseHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStudioArchivedAssetHidingEnabled => (bool)this["IsStudioArchivedAssetHidingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUGCValidationEnabled => (bool)this["IsUGCValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUGCValidationServerRequestValidatorEnabled => (bool)this["IsUGCValidationServerRequestValidatorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTexturePackUploadingEnabledForSoothsayers => (bool)this["IsTexturePackUploadingEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsTexturePackUploadingEnabledRolloutPercentage => (int)this["IsTexturePackUploadingEnabledRolloutPercentage"];

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

	internal AssetSettings()
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
