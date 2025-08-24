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

namespace Roblox.RealTimeNotifications.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SubscriptionProxyUnsubscribeDelay => (TimeSpan)this["SubscriptionProxyUnsubscribeDelay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int RedisAsyncThrottleLimit => (int)this["RedisAsyncThrottleLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints UserNotificationsRedisEndpointsV2 => (RedisEndpoints)this["UserNotificationsRedisEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNativeSignalREnabledOnIOSForSoothsayers => (bool)this["IsNativeSignalREnabledOnIOSForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NativeSignalREnabledOnIOSRolloutPercentage => (int)this["NativeSignalREnabledOnIOSRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NativeSignalRMinimumSupportedIOSAppVersion => (string)this["NativeSignalRMinimumSupportedIOSAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan UserActivityExpiry => (TimeSpan)this["UserActivityExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan UserActivityActiveNowThreshold => (TimeSpan)this["UserActivityActiveNowThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserActivityTrackingEnabled => (bool)this["IsUserActivityTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSubscriptionProxyPerformanceMonitorEnabled => (bool)this["IsSubscriptionProxyPerformanceMonitorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserNotificationPublisherPerformanceMonitorEnabled => (bool)this["IsUserNotificationPublisherPerformanceMonitorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int RealTimeActivityMonitoringRedisConnectionPoolSize => (int)this["RealTimeActivityMonitoringRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserNotificationNamespaceSequenceEnabled => (bool)this["IsUserNotificationNamespaceSequenceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int UserNotificationsRedisConnectionPoolSize => (int)this["UserNotificationsRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsUserNotificationGlobalSequenceEnabled => (bool)this["IsUserNotificationGlobalSequenceEnabled"];

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
