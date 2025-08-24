using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Stream.Properties;

[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
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
	[DefaultSettingValue("10")]
	public int NotificationStreamMaximumPageSize => (int)this["NotificationStreamMaximumPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14.00:00:00")]
	public TimeSpan NotificationStreamEventExpirationDelay => (TimeSpan)this["NotificationStreamEventExpirationDelay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledForSoothSayers => (bool)this["IsNotificationStreamEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledForBetaTesters => (bool)this["IsNotificationStreamEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NotificationStreamRegularUserRolloutPercentage => (int)this["NotificationStreamRegularUserRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnAndroidForRegularUsers => (bool)this["IsNotificationStreamEnabledOnAndroidForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnAndroidForSoothsayers => (bool)this["IsNotificationStreamEnabledOnAndroidForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnAndroidForBetaTesters => (bool)this["IsNotificationStreamEnabledOnAndroidForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnIOSForRegularUsers => (bool)this["IsNotificationStreamEnabledOnIOSForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnIOSForSoothsayers => (bool)this["IsNotificationStreamEnabledOnIOSForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnIOSForBetaTesters => (bool)this["IsNotificationStreamEnabledOnIOSForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnWindowsAppForRegularUsers => (bool)this["IsNotificationStreamEnabledOnWindowsAppForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamEnabledOnWindowsAppForSoothsayers => (bool)this["IsNotificationStreamEnabledOnWindowsAppForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int NotificationStreamMaximumRecentEvents => (int)this["NotificationStreamMaximumRecentEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int HoursPerBucket => (int)this["HoursPerBucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14.00:00:00")]
	public TimeSpan NotificationStreamPromptAccountAgeRequirement => (TimeSpan)this["NotificationStreamPromptAccountAgeRequirement"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumSupportedVersionAndroid => (string)this["MinimumSupportedVersionAndroid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumSupportedVersionIOS => (string)this["MinimumSupportedVersionIOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumSupportedVersionWindowsApp => (string)this["MinimumSupportedVersionWindowsApp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NotificationStreamPopulationRolloutPercentage => (int)this["NotificationStreamPopulationRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int EventsToStorePerStreamItem => (int)this["EventsToStorePerStreamItem"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHourlyCounterUpdateEnabledForRegularUsers => (bool)this["IsHourlyCounterUpdateEnabledForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHourlyCounterUpdateEnabledForSoothsayers => (bool)this["IsHourlyCounterUpdateEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHourlyCounterReadEnabledForRegularUsers => (bool)this["IsHourlyCounterReadEnabledForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHourlyCounterReadEnabledForSoothsayers => (bool)this["IsHourlyCounterReadEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEphemeralEndpointsV2 => (RedisEndpoints)this["RedisEphemeralEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisPersistentEndpointsV2 => (RedisEndpoints)this["RedisPersistentEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("512")]
	public int MaximumEventTargetIdLength => (int)this["MaximumEventTargetIdLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int StreamNotificationsRedisConnectionPoolSize => (int)this["StreamNotificationsRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUseRedisConnectionPoolEnabled => (bool)this["IsUseRedisConnectionPoolEnabled"];

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
