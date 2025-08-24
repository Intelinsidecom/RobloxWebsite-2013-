using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Privacy.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
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
	[DefaultSettingValue("AllUsers")]
	public string GameChatMessagingUnknownUserPrivacySetting => (string)this["GameChatMessagingUnknownUserPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers")]
	public string GameChatMessagingU13DefaultPrivacySetting => (string)this["GameChatMessagingU13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers")]
	public string GameChatMessagingO13DefaultPrivacySetting => (string)this["GameChatMessagingO13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameChatMessagingU13OverridePrivacySetting => (string)this["GameChatMessagingU13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameChatMessagingO13OverridePrivacySetting => (string)this["GameChatMessagingO13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Friends")]
	public string AppChatMessagingUnknownUserPrivacySetting => (string)this["AppChatMessagingUnknownUserPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Friends")]
	public string AppChatMessagingU13DefaultPrivacySetting => (string)this["AppChatMessagingU13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Friends")]
	public string AppChatMessagingO13DefaultPrivacySetting => (string)this["AppChatMessagingO13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppChatMessagingU13OverridePrivacySetting => (string)this["AppChatMessagingU13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppChatMessagingO13OverridePrivacySetting => (string)this["AppChatMessagingO13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan MemcachedExpirationTime => (TimeSpan)this["MemcachedExpirationTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NoOne")]
	public string GameChatMessagingGuestDefaultPrivacySetting => (string)this["GameChatMessagingGuestDefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NoOne")]
	public string PhoneNumberDiscoveryU13DefaultPrivacySetting => (string)this["PhoneNumberDiscoveryU13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers")]
	public string PhoneNumberDiscoveryO13DefaultPrivacySetting => (string)this["PhoneNumberDiscoveryO13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PhoneDiscoveryU13OverridePrivacySetting => (string)this["PhoneDiscoveryU13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PhoneDiscoveryO13OverridePrivacySetting => (string)this["PhoneDiscoveryO13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Friends")]
	public string DisplayInventoryU13DefaultPrivacySetting => (string)this["DisplayInventoryU13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers")]
	public string DisplayInventoryO13DefaultPrivacySetting => (string)this["DisplayInventoryO13DefaultPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DisplayInventoryU13OverridePrivacySetting => (string)this["DisplayInventoryU13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DisplayInventoryO13OverridePrivacySetting => (string)this["DisplayInventoryO13OverridePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InventoryHidingFeatureEnabled => (bool)this["InventoryHidingFeatureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLeasedLockForGetOrCreateUserPrivacySettingEnabled => (bool)this["IsLeasedLockForGetOrCreateUserPrivacySettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan LeasedLockForGetOrCreateUserPrivacySettingTimeSpan => (TimeSpan)this["LeasedLockForGetOrCreateUserPrivacySettingTimeSpan"];

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
