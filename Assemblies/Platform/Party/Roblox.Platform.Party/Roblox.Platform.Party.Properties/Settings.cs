using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Redis;

namespace Roblox.Platform.Party.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
[SettingsProvider(typeof(Provider))]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int PartyMemberLimit => (int)this["PartyMemberLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PartyEventsSnsAwsAccessKeyAndSecretKey => (string)this["PartyEventsSnsAwsAccessKeyAndSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PartyEventsSnsTopicArn => (string)this["PartyEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPartyEventPublishingEnabled => (bool)this["IsPartyEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPartyNonDeletionEventPublishingEnabled => (bool)this["IsPartyNonDeletionEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowLeadershipToBeClaimedAtAnyTimeForXboxWalledGarden => (bool)this["AllowLeadershipToBeClaimedAtAnyTimeForXboxWalledGarden"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32")]
	public int XboxPartyMemberLimit => (int)this["XboxPartyMemberLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsV2 => (RedisEndpoints)this["RedisEndpointsV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints PlayTogetherRedisEndpoints => (RedisEndpoints)this["PlayTogetherRedisEndpoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan PartyRedisExpiryTimespan => (TimeSpan)this["PartyRedisExpiryTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:23:00")]
	public TimeSpan UserPartyRedisExpiryTimespan => (TimeSpan)this["UserPartyRedisExpiryTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:23:30")]
	public TimeSpan PartyInvitationExpiryTimespan => (TimeSpan)this["PartyInvitationExpiryTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:23:15")]
	public TimeSpan ConversationPartyMapExpiryTimespan => (TimeSpan)this["ConversationPartyMapExpiryTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PlayTogetherRedisEnabled => (bool)this["PlayTogetherRedisEnabled"];

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string property) => base[property]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

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
