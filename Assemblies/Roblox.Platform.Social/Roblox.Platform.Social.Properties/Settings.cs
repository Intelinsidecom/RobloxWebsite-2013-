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

namespace Roblox.Platform.Social.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[ExcludeFromCodeCoverage]
[SettingsProvider(typeof(Provider))]
internal sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public byte DefaultUnder13MessagePrivacySetting => (byte)this["DefaultUnder13MessagePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50000")]
	public int MessageBodyCharacterLimit => (int)this["MessageBodyCharacterLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int MessageSubjectCharacterLimit => (int)this["MessageSubjectCharacterLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int UserIdsOfInterestCount => (int)this["UserIdsOfInterestCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public double TopFriendshipInteractionBias => (double)this["TopFriendshipInteractionBias"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public double MessagesSentUltimateInteractionBias => (double)this["MessagesSentUltimateInteractionBias"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public double MessagesSentPenultimateInteractionBias => (double)this["MessagesSentPenultimateInteractionBias"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.25")]
	public double MessagesSentAntepenultimate => (double)this["MessagesSentAntepenultimate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan UserIdsOfInterestCacheTimeSpan => (TimeSpan)this["UserIdsOfInterestCacheTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishMessageEventsToSnsEnabled => (bool)this["PublishMessageEventsToSnsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MessageEventSnsTopicArn => (string)this["MessageEventSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MessageEventPublisherSnsAwsAccessKeyAndSecretKey => (string)this["MessageEventPublisherSnsAwsAccessKeyAndSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxPlayerInteractionsToStore => (int)this["MaxPlayerInteractionsToStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10.00:00:00")]
	public TimeSpan PlayerInteractionsTTL => (TimeSpan)this["PlayerInteractionsTTL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PlayerInteractionsRedisAsyncThrottleLimit => (int)this["PlayerInteractionsRedisAsyncThrottleLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnforceUserBlockWhenPerformingFriendshipOperations => (bool)this["EnforceUserBlockWhenPerformingFriendshipOperations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxMultigetFollowingExistsCount => (int)this["MaxMultigetFollowingExistsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxMultigetFriendRequestsCount => (int)this["MaxMultigetFriendRequestsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300")]
	public int MaxPageSizeAllowedForFriendshipOperations => (int)this["MaxPageSizeAllowedForFriendshipOperations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxMultigetFriendshipExistsCount => (int)this["MaxMultigetFriendshipExistsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishRealTimeMessageEvents => (bool)this["PublishRealTimeMessageEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaActionSendEventEnabled => (bool)this["CaptchaActionSendEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaActionLogToPerfmonEnabled => (bool)this["CaptchaActionLogToPerfmonEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int FriendsLimitInRecommendationsResponse => (int)this["FriendsLimitInRecommendationsResponse"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int SuggestedNonFriendsLimitInRecommendationsResponse => (int)this["SuggestedNonFriendsLimitInRecommendationsResponse"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGetRecentPlayerInteractionsForRecommendationsEnabled => (bool)this["IsGetRecentPlayerInteractionsForRecommendationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints PlayerInteractionsRedisEndpoints => (RedisEndpoints)this["PlayerInteractionsRedisEndpoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public byte DefaultUnder13FollowPrivacySetting => (byte)this["DefaultUnder13FollowPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPermissionsCheckForSendFriendRequestEnabled => (bool)this["IsPermissionsCheckForSendFriendRequestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayerInteractionsRedisConnectionPoolEnabled => (bool)this["IsPlayerInteractionsRedisConnectionPoolEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int PlayerInteractionsRedisConnectionPoolSize => (int)this["PlayerInteractionsRedisConnectionPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldUseRequestContextToCheckSendFriendRequestPermission => (bool)this["ShouldUseRequestContextToCheckSendFriendRequestPermission"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:02")]
	public TimeSpan PlayerInteractionsRedisMaxReconnectTimeout => (TimeSpan)this["PlayerInteractionsRedisMaxReconnectTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FriendshipSendEventEnabled => (bool)this["FriendshipSendEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("156")]
	public long BuildermanUserId => (long)this["BuildermanUserId"];

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
