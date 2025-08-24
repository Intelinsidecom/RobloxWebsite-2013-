using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Groups.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string GroupsConnectionString => (string)this["GroupsConnectionString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MaxClanMembers => (int)this["MaxClanMembers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupLockingForDeletionEnabled => (bool)this["GroupLockingForDeletionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupMoneyPageEnabled => (bool)this["GroupMoneyPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GroupEventsSnsAwsAccessKeyAndSecretCSV => (string)this["GroupEventsSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GroupEventsSnsTopicArn => (string)this["GroupEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseDurableCountersForGroupMemberCount => (bool)this["UseDurableCountersForGroupMemberCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClanEventPublisherSnsTopicArn => (string)this["ClanEventPublisherSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClanEventPublisherSnsAwsAccessKeyAndSecretCSV => (string)this["ClanEventPublisherSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishClanEventsToSnsEnabled => (bool)this["PublishClanEventsToSnsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int GroupWallPostsToDeletePerPage => (int)this["GroupWallPostsToDeletePerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int GroupDescriptionMaxCharacterCount => (int)this["GroupDescriptionMaxCharacterCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int JoinGroupFloodCheckerLimit => (int)this["JoinGroupFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan JoinGroupFloodCheckerExpiry => (TimeSpan)this["JoinGroupFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int ClaimOwnershipFloodCheckerLimit => (int)this["ClaimOwnershipFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan ClaimOwnershipFloodCheckerExpiry => (TimeSpan)this["ClaimOwnershipFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool JoinGroupFloodCheckerEnabled => (bool)this["JoinGroupFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClaimOwnershipFloodCheckerEnabled => (bool)this["ClaimOwnershipFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("\\p{C}|\\p{So}|\\p{Sk}|\\u00AD")]
	public string GroupNameInvalidCharactersRegex => (string)this["GroupNameInvalidCharactersRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan OwnershipLeasedLockTimeSpan => (TimeSpan)this["OwnershipLeasedLockTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int GroupMembershipsPageLimit => (int)this["GroupMembershipsPageLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsClansFeatureEnabled => (bool)this["IsClansFeatureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsClansFeatureEnabledForSoothsayers => (bool)this["IsClansFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOverridingClansFeatureEnabledForSoothsayers => (bool)this["IsOverridingClansFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsClanMemberConnectionEnabled => (bool)this["IsClanMemberConnectionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsClanInvitationConnectionEnabled => (bool)this["IsClanInvitationConnectionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGroupWallPostsFeatureEnabled => (bool)this["IsGroupWallPostsFeatureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGroupWallPostsFeatureEnabledForSoothsayers => (bool)this["IsGroupWallPostsFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOverridingGroupWallPostsFeatureEnabledForSoothsayers => (bool)this["IsOverridingGroupWallPostsFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupJoinFunCaptchaEnabled => (bool)this["IsGroupJoinFunCaptchaEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupMembershipReadOnlyModeEnabled => (bool)this["IsGroupMembershipReadOnlyModeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMultiGetGroupRoleSetsForGetGroupMembershipsByUserEnabled => (bool)this["IsMultiGetGroupRoleSetsForGetGroupMembershipsByUserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGroupCreatePremiumValidationEnabled => (bool)this["IsGroupCreatePremiumValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGroupJoinPremiumValidationEnabled => (bool)this["IsGroupJoinPremiumValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int RolesetNameMaxLength => (int)this["RolesetNameMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("999")]
	public int RolesetDescriptionMaxLength => (int)this["RolesetDescriptionMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte RolesetMinRank => (byte)this["RolesetMinRank"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("255")]
	public byte RolesetMaxRank => (byte)this["RolesetMaxRank"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserFactoryMultiGetEnabled => (bool)this["IsUserFactoryMultiGetEnabled"];

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
