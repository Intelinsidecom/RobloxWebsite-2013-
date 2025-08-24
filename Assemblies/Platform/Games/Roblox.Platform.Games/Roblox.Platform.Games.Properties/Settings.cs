using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Games.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase
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
	[DefaultSettingValue("50")]
	public int PrivateServersWhitelistMaxCount => (int)this["PrivateServersWhitelistMaxCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int PrivateServersConfigureFloodCheckerLimit => (int)this["PrivateServersConfigureFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int PrivateServerDefaultExpirationMonths => (int)this["PrivateServerDefaultExpirationMonths"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Month")]
	public string PrivateServerRecurrencePeriodType => (string)this["PrivateServerRecurrencePeriodType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int PrivateServerRecurrencePeriodMagnitude => (int)this["PrivateServerRecurrencePeriodMagnitude"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PaymentEvents_PrivateServersProcessor")]
	public string PurchaseCallbackSQSValue => (string)this["PurchaseCallbackSQSValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int PrivateServersConfigureRecurringFloodCheckerLimit => (int)this["PrivateServersConfigureRecurringFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public long PrivateServerDefaultPrice => (long)this["PrivateServerDefaultPrice"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int PrivateServerRecurringBufferHours => (int)this["PrivateServerRecurringBufferHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int MaxFilteredPurchasedGames => (int)this["MaxFilteredPurchasedGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RestrictFilteredPurchasedGames => (bool)this["RestrictFilteredPurchasedGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrivateServerLinksEnabled => (bool)this["PrivateServerLinksEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrivateServerLinksEnabledForSoothsayers => (bool)this["PrivateServerLinksEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int PrivateServersUpdateLinkFloodCheckerLimit => (int)this["PrivateServersUpdateLinkFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PrivateServerConfigurationSnsTopicArn => (string)this["PrivateServerConfigurationSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishPrivateServerConfigurationEventsToSnsEnabled => (bool)this["PublishPrivateServerConfigurationEventsToSnsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PrivateServerConfigurationSnsAwsAccessKeyAndSecretCSV => (string)this["PrivateServerConfigurationSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:02:00")]
	public TimeSpan ReservedServerAccessExpiration => (TimeSpan)this["ReservedServerAccessExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("e4Yn8ckbCJtw2sv7qmbg")]
	public string ReservedServerSignatureKey => (string)this["ReservedServerSignatureKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PrivateServerMinPrice => (int)this["PrivateServerMinPrice"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExcludeMatchmakingContextsFromGameShutdownEnabled => (bool)this["ExcludeMatchmakingContextsFromGameShutdownEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RunningGamesChangesSnsTopicArn => (string)this["RunningGamesChangesSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAccessKey => (string)this["AwsAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsSecretAccessKey => (string)this["AwsSecretAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThrowExceptionOnPublishEnabled => (bool)this["IsThrowExceptionOnPublishEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThrowExceptionOnPublisherInitializationEnabled => (bool)this["IsThrowExceptionOnPublisherInitializationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlaceAttributesReadyToEvaluateIsSecure => (bool)this["IsPlaceAttributesReadyToEvaluateIsSecure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int GameLaunchFollowUserFloodCheckLimit => (int)this["GameLaunchFollowUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan GameLaunchFollowUserFloodCheckExpiry => (TimeSpan)this["GameLaunchFollowUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBruteForceIsSecureCheckEnabled => (bool)this["IsBruteForceIsSecureCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOwnerCancelEventPublishingEnabled => (bool)this["IsOwnerCancelEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCancellingAllPreviousRecurringTransactionProfilesEnabled => (bool)this["IsCancellingAllPreviousRecurringTransactionProfilesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsGamePlacesChangeTopicAccessKeyIdAndSecretCsv => (string)this["AwsGamePlacesChangeTopicAccessKeyIdAndSecretCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsGamePlacesChangeSnsTopicArn => (string)this["AwsGamePlacesChangeSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishToGamePlacesChangeTopicEnabled => (bool)this["IsPublishToGamePlacesChangeTopicEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRemoteCachingEnabled => (bool)this["IsRemoteCachingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGetUniversesUpdateEnabled => (bool)this["IsGetUniversesUpdateEnabled"];

	internal Settings()
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
