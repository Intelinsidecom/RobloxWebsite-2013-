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

namespace Roblox.Platform.Notifications.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
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
	[DefaultSettingValue("32.00:00:00")]
	public TimeSpan NotificationIdLookupExpiry => (TimeSpan)this["NotificationIdLookupExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NotificationSettingsEnabledForAll => (bool)this["NotificationSettingsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NotificationSettingsEnabledForSoothSayers => (bool)this["NotificationSettingsEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NotificationSettingsEnabledForBetaTesters => (bool)this["NotificationSettingsEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationSettingsSourceTypeBlacklistForRegularUsers => (string)this["NotificationSettingsSourceTypeBlacklistForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationSettingsSourceTypeBlacklistForBetaTesters => (string)this["NotificationSettingsSourceTypeBlacklistForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationSettingsReceiverDestinationTypeBlacklistForRegularUsers => (string)this["NotificationSettingsReceiverDestinationTypeBlacklistForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationSettingsReceiverDestinationTypeBlacklistForBetaTesters => (string)this["NotificationSettingsReceiverDestinationTypeBlacklistForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsV2 => (RedisEndpoints)this["RedisEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationSettingsSourceTypeBlacklistForSoothsayers => (string)this["NotificationSettingsSourceTypeBlacklistForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int NotificationsRedisConnectionPoolSize => (int)this["NotificationsRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUseRedisConnectionPoolEnabled => (bool)this["IsUseRedisConnectionPoolEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRemoteCacheForReceiverNotificationBandPreferenceEnabled => (bool)this["IsRemoteCacheForReceiverNotificationBandPreferenceEnabled"];

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
