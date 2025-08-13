using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Push.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
internal sealed class Settings : ApplicationSettingsBase
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
	public string PushNotificationEventsSnsAwsAccessKeyAndSecret => (string)this["PushNotificationEventsSnsAwsAccessKeyAndSecret"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushNotificationEventsSnsTopicArn => (string)this["PushNotificationEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SNSApplicationsAccessKeyAndSecretKey => (string)this["SNSApplicationsAccessKeyAndSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxPushNotificationDestinationsPerUser => (int)this["MaxPushNotificationDestinationsPerUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("31.00:00:00")]
	public TimeSpan NotificationMetadataExpiry => (TimeSpan)this["NotificationMetadataExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan NotificationDeliveryRecordExpiry => (TimeSpan)this["NotificationDeliveryRecordExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledForSoothsayers => (bool)this["IsPushNotificationsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledForBetaTesters => (bool)this["IsPushNotificationsEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PushNotificationsRegularUserRolloutPercentage => (int)this["PushNotificationsRegularUserRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int DeliveryDestinationFloodCheckLimit => (int)this["DeliveryDestinationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan DeliveryDestinationFloodCheckExpiry => (TimeSpan)this["DeliveryDestinationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeliveryDestinationFloodCheckEnabled => (bool)this["DeliveryDestinationFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int DeliveryDestinationAndTypeCombinationFloodCheckLimit => (int)this["DeliveryDestinationAndTypeCombinationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan DeliveryDestinationAndTypeCombinationFloodCheckExpiry => (TimeSpan)this["DeliveryDestinationAndTypeCombinationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeliveryDestinationAndTypeCombinationFloodCheckEnabled => (bool)this["DeliveryDestinationAndTypeCombinationFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnChromeForSoothsayers => (bool)this["IsPushNotificationsEnabledOnChromeForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnChromeForRegularUsers => (bool)this["IsPushNotificationsEnabledOnChromeForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnFirefoxForSoothsayers => (bool)this["IsPushNotificationsEnabledOnFirefoxForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnFirefoxForRegularUsers => (bool)this["IsPushNotificationsEnabledOnFirefoxForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnAndroidForSoothsayers => (bool)this["IsPushNotificationsEnabledOnAndroidForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnAndroidForRegularUsers => (bool)this["IsPushNotificationsEnabledOnAndroidForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnIOSForSoothsayers => (bool)this["IsPushNotificationsEnabledOnIOSForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnIOSForRegularUsers => (bool)this["IsPushNotificationsEnabledOnIOSForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOnlyDeactivateReceiverDestinationsOnExpiryEnabled => (bool)this["IsOnlyDeactivateReceiverDestinationsOnExpiryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsV2 => (RedisEndpoints)this["RedisEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendContentEnabledForVisibleIOSNotifications => (bool)this["SendContentEnabledForVisibleIOSNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string IOSSoundName => (string)this["IOSSoundName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishPushNotificationRequestWithIntentFormatEnabled => (bool)this["IsPublishPushNotificationRequestWithIntentFormatEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewStringRepresentationOfPushTypeUsedForReporting => (bool)this["IsNewStringRepresentationOfPushTypeUsedForReporting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushFallbackDeliverySQSUrl => (string)this["PushFallbackDeliverySQSUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushFallbackDeliverySQSPublisherAccessKeyAndSecretKey => (string)this["PushFallbackDeliverySQSPublisherAccessKeyAndSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIOSPushFallbackDeliveryEnabled => (bool)this["IsIOSPushFallbackDeliveryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan PushFallbackDeliveryDelay => (TimeSpan)this["PushFallbackDeliveryDelay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CheckLegacyDeliveryTrackingMethod => (bool)this["CheckLegacyDeliveryTrackingMethod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool LegacyInteractionTrackingEnabled => (bool)this["LegacyInteractionTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIOSPushFallbackDeliveryEnabledForSoothsayers => (bool)this["IsIOSPushFallbackDeliveryEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIOSPushFallbackDeliveryEnabledForBetaTesters => (bool)this["IsIOSPushFallbackDeliveryEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIOSPushFallbackDiagnosticTitleEnabled => (bool)this["IsIOSPushFallbackDiagnosticTitleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7.00:00:00")]
	public TimeSpan ReceiverDestinationUninterruptedFallbackExpiry => (TimeSpan)this["ReceiverDestinationUninterruptedFallbackExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int IOSFallbackDeliveryMuteThreshold => (int)this["IOSFallbackDeliveryMuteThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnAndroidAmazonForSoothsayers => (bool)this["IsPushNotificationsEnabledOnAndroidAmazonForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushNotificationsEnabledOnAndroidAmazonForRegularUsers => (bool)this["IsPushNotificationsEnabledOnAndroidAmazonForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDestinationLookupByHashEnabled => (bool)this["IsDestinationLookupByHashEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNudgeSystemDeliveryForAllEnabled => (bool)this["IsNudgeSystemDeliveryForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNudgeSystemDeliveryForSoothsayersEnabled => (bool)this["IsNudgeSystemDeliveryForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNudgeSystemDeliveryForBetaTestersEnabled => (bool)this["IsNudgeSystemDeliveryForBetaTestersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NudgeSystemDeliveryRolloutPercentage => (int)this["NudgeSystemDeliveryRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NudgeSystemDistributionEnabledSourceTypes => (string)this["NudgeSystemDistributionEnabledSourceTypes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushNotificationsBrokerPushNotificationEventsSnsAwsAccessKeyAndSecret => (string)this["PushNotificationsBrokerPushNotificationEventsSnsAwsAccessKeyAndSecret"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushNotificationsBrokerPushNotificationEventsSnsTopicArn => (string)this["PushNotificationsBrokerPushNotificationEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int PushNotificationsRedisConnectionPoolSize => (int)this["PushNotificationsRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUseRedisConnectionPoolEnabled => (bool)this["IsUseRedisConnectionPoolEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNudgeSystemDeliveryToDestinationEnabled => (bool)this["IsNudgeSystemDeliveryToDestinationEnabled"];

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
