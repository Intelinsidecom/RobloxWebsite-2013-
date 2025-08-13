using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Assets.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings, INotifyPropertyChanged
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string DbConnectionString_RobloxAssetCreations => (string)this["DbConnectionString_RobloxAssetCreations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AssetCreationsCacheInvalidationPort => (string)this["AssetCreationsCacheInvalidationPort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int DecalMaxEdgeSize => (int)this["DecalMaxEdgeSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string DbConnectionString_RobloxAssets => (string)this["DbConnectionString_RobloxAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string DbConnectionString_RobloxAssetNamespaces => (string)this["DbConnectionString_RobloxAssetNamespaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseMultigetForCreations => (bool)this["UseMultigetForCreations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseMultigetForCreationContexts => (bool)this["UseMultigetForCreationContexts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NameTypeIDAndNameTargetIDContainInvalidValues => (bool)this["NameTypeIDAndNameTargetIDContainInvalidValues"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreMeshPartsEnabled => (bool)this["AreMeshPartsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAccessoryTypesEnabledForAll => (bool)this["AreAccessoryTypesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAccessoryTypesEnabledForBetaTesters => (bool)this["AreAccessoryTypesEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAccessoryTypesEnabledForSoothsayers => (bool)this["AreAccessoryTypesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAvatarAnimationTypesEnabledForAll => (bool)this["AreAvatarAnimationTypesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAvatarAnimationTypesEnabledForBetaTesters => (bool)this["AreAvatarAnimationTypesEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAvatarAnimationTypesEnabledForSoothsayers => (bool)this["AreAvatarAnimationTypesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetsTableAuditingEnabled => (bool)this["IsAssetsTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("250")]
	public int CreatorAssetTypeUploadFloodCheckerLimit => (int)this["CreatorAssetTypeUploadFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan CreatorAssetTypeUploadFloodCheckerExpiry => (TimeSpan)this["CreatorAssetTypeUploadFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetWithFullyModeratedTextBlocked => (bool)this["IsAssetWithFullyModeratedTextBlocked"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAssetChangeTopicAccessKeyIdAndSecretCsv => (string)this["AwsAssetChangeTopicAccessKeyIdAndSecretCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAssetChangeSnsTopicArn => (string)this["AwsAssetChangeSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAwsAssetChangePublishingEnabled => (bool)this["IsAwsAssetChangePublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AssetVersionCreationEventsSnsAwsAccessKeyAndSecretCSV => (string)this["AssetVersionCreationEventsSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AssetVersionCreationEventsSnsTopicArn => (string)this["AssetVersionCreationEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsAssetChangeOnRevertReportingEnabled => (bool)this["IsAssetChangeOnRevertReportingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("^version \\d")]
	public string MeshAssetVersionValidationRegex => (string)this["MeshAssetVersionValidationRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int AssetDescriptionMaxCharacterCount => (int)this["AssetDescriptionMaxCharacterCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetVersionChangeReportingToAllGamesESEnabled => (bool)this["IsAssetVersionChangeReportingToAllGamesESEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AssetsClientAPIKey => (string)this["AssetsClientAPIKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCloudSavedGamesEnabled => (bool)this["IsCloudSavedGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishToAssetPublishedVersionEnabled => (bool)this["IsPublishToAssetPublishedVersionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DeliveryFromAssetPublishedVersionRolloutPercentage => (int)this["DeliveryFromAssetPublishedVersionRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetCreationNoContextEnabled => (bool)this["AssetCreationNoContextEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AssetVersionLookUpParallelizationDegree => (int)this["AssetVersionLookUpParallelizationDegree"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetVersionIdSetToZeroLoggingEnabled => (bool)this["IsAssetVersionIdSetToZeroLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAssetArchivalChangeTopicAccessIdAndSecretCsv => (string)this["AwsAssetArchivalChangeTopicAccessIdAndSecretCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAssetArchivalChangeSnsTopicArn => (string)this["AwsAssetArchivalChangeSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAwsAssetArchivalChangePublishingEnabled => (bool)this["IsAwsAssetArchivalChangePublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AssetDependenciesServiceWriteRolloutPercentage => (int)this["AssetDependenciesServiceWriteRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldOperationFailIfAssetDependenciesServiceFails => (bool)this["ShouldOperationFailIfAssetDependenciesServiceFails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFetchPluginOwnershipCheckingEnabled => (bool)this["IsFetchPluginOwnershipCheckingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseAssetsServiceForAssetOptionFactoryGetRolloutPercentage => (int)this["UseAssetsServiceForAssetOptionFactoryGetRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseAssetsServiceForAssetOptionFactoryGetOrCreateRolloutPercentage => (int)this["UseAssetsServiceForAssetOptionFactoryGetOrCreateRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJvDelayedPlaceLaunchEnabled => (bool)this["IsJvDelayedPlaceLaunchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan JvPlaceLaunchDelayTimeSpan => (TimeSpan)this["JvPlaceLaunchDelayTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan JvPlaceLaunchRoundUpToNearestTimeSpan => (TimeSpan)this["JvPlaceLaunchRoundUpToNearestTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseAssetsServiceForAssetOptionFactorySaveRolloutPercentage => (int)this["UseAssetsServiceForAssetOptionFactorySaveRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableAssetTextFilter => (bool)this["DisableAssetTextFilter"];

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
