using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Redis;

namespace Roblox.Platform.Avatar.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("")]
	public string DefaultPlayerAvatarType => (string)this["DefaultPlayerAvatarType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int MaxGearInBackpack => (int)this["MaxGearInBackpack"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("assetgame")]
	public string BodyColorsSubdomain => (string)this["BodyColorsSubdomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("R6")]
	public string DefaultThumbnailAvatarType => (string)this["DefaultThumbnailAvatarType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string OverrideThumbnailAvatarType => (string)this["OverrideThumbnailAvatarType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OverrideAvatarScaleWithDefaults => (bool)this["OverrideAvatarScaleWithDefaults"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LogUnknownSourceAvatarChangePercentage => (int)this["LogUnknownSourceAvatarChangePercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int RecentAvatarItemsMaxUpdateRetries => (int)this["RecentAvatarItemsMaxUpdateRetries"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int RecentAvatarItemsMaxItemsPerList => (int)this["RecentAvatarItemsMaxItemsPerList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DisableAdvancedAccessoryMode => (bool)this["DisableAdvancedAccessoryMode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RecentAvatarItemsDisableListenerFromSpawningThreads => (bool)this["RecentAvatarItemsDisableListenerFromSpawningThreads"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("70541466,70541482")]
	public string DefaultClothingShirtAssetIDsCSV => (string)this["DefaultClothingShirtAssetIDsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("70541468,70541490")]
	public string DefaultClothingPantsAssetIDsCSV => (string)this["DefaultClothingPantsAssetIDsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WriteBodyColorsToBodyColorSetId => (bool)this["WriteBodyColorsToBodyColorSetId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StopWritingBodyColorsToAvatarHash => (bool)this["StopWritingBodyColorsToAvatarHash"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DefaultClothingForSimilarColorsEnabled => (bool)this["DefaultClothingForSimilarColorsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("LeftArm,RightArm,LeftLeg,RightLeg,Torso")]
	public string FullyQualifiedOutfitAssetTypesCSV => (string)this["FullyQualifiedOutfitAssetTypesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TryOnEnabledForNonPurchasableAssets => (bool)this["TryOnEnabledForNonPurchasableAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AvatarChangeDiagLoggingPercentage => (int)this["AvatarChangeDiagLoggingPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AvatarChangeEventStreamLoggingPercentage => (int)this["AvatarChangeEventStreamLoggingPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public byte EmoteConfigurationMaximumSlots => (byte)this["EmoteConfigurationMaximumSlots"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string OverridePlayerAvatarType => (string)this["OverridePlayerAvatarType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GetUserAssetByIdUseMultiGetRolloutPercentage => (int)this["GetUserAssetByIdUseMultiGetRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserOwnsUnexpiredAssetCheckRolloutPercentage => (int)this["UserOwnsUnexpiredAssetCheckRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserMayRemoveAssetCheckV2RolloutPercentage => (int)this["UserMayRemoveAssetCheckV2RolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseAvatarServiceForUserIdAccoutrementsRolloutPercentage => (int)this["UseAvatarServiceForUserIdAccoutrementsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseAvatarServiceForUserAssetIdAccoutrementsRolloutPercentage => (int)this["UseAvatarServiceForUserAssetIdAccoutrementsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAvatarEmotesDatabaseEnabled => (bool)this["IsAvatarEmotesDatabaseEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpoints => (RedisEndpoints)this["RedisEndpoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsEmotesRedisCacheReadingEnabledRolloutPercentage => (int)this["IsEmotesRedisCacheReadingEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsEmotesRedisCacheWritingEnabledRolloutPercentage => (int)this["IsEmotesRedisCacheWritingEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmotesRedisCacheClearingEnabled => (bool)this["IsEmotesRedisCacheClearingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("redis-avatar")]
	public string RedisServiceName => (string)this["RedisServiceName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedisServiceDiscoveryEnabled => (bool)this["IsRedisServiceDiscoveryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan EmoteConfigurationsLockDuration => (TimeSpan)this["EmoteConfigurationsLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsEmoteConfigurationsRedisLockingEnabledRolloutPercentage => (int)this["IsEmoteConfigurationsRedisLockingEnabledRolloutPercentage"];

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
