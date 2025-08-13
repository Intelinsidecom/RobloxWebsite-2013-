using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Redis;

namespace Roblox.Platform.Chat.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
internal sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxParticipantsInConversation => (int)this["MaxParticipantsInConversation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("600")]
	public int MaxConversationsPerParticipant => (int)this["MaxConversationsPerParticipant"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1200")]
	public int MaxConversationParticipantsToFetch => (int)this["MaxConversationParticipantsToFetch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChatEventPublishingEnabled => (bool)this["IsChatEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14.00:00:00")]
	public TimeSpan MessageExpirationTimespan => (TimeSpan)this["MessageExpirationTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10:00:00")]
	public TimeSpan ConversationParticipantExpirationTimespan => (TimeSpan)this["ConversationParticipantExpirationTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxParticipantsInCloudEditConversations => (int)this["MaxParticipantsInCloudEditConversations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCloudEditPermissionsPlatform => (bool)this["UseCloudEditPermissionsPlatform"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatDynamoDbAccessKeyAndSecret => (string)this["ChatDynamoDbAccessKeyAndSecret"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MessagePersistenceEnabled => (bool)this["MessagePersistenceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableFetchingMessageIdsOnCacheMiss => (bool)this["DisableFetchingMessageIdsOnCacheMiss"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDelayedNewMessageEventPublishingEnabled => (bool)this["IsDelayedNewMessageEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan OldestMessageIdStoreExpiration => (TimeSpan)this["OldestMessageIdStoreExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int MaxRowsToFetchForCacheSync => (int)this["MaxRowsToFetchForCacheSync"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaxPagesForCacheSync => (int)this["MaxPagesForCacheSync"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCacheSyncEnabled => (bool)this["IsCacheSyncEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan MessageSeenCacheExpiry => (TimeSpan)this["MessageSeenCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxConversationTitleLength => (int)this["MaxConversationTitleLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatEventSnsTopicArn => (string)this["ChatEventSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:02")]
	public TimeSpan DelayedEventsDelay => (TimeSpan)this["DelayedEventsDelay"];

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
	[DefaultSettingValue("0")]
	public int PeriodicParticipantConversationCacheConsistencyCheckRollout => (int)this["PeriodicParticipantConversationCacheConsistencyCheckRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7.00:00:00")]
	public TimeSpan PeriodicParticipantConversationCacheConsistencyCheckFrequency => (TimeSpan)this["PeriodicParticipantConversationCacheConsistencyCheckFrequency"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBlockMessagesFromUsersNotConnectedToRealTimeEnabled => (bool)this["IsBlockMessagesFromUsersNotConnectedToRealTimeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int UpdateUserTypingStatusFloodCheckLimit => (int)this["UpdateUserTypingStatusFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UpdateUserTypingStatusFloodCheckEnabled => (bool)this["UpdateUserTypingStatusFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan UpdateUserTypingStatusFloodCheckExpiry => (TimeSpan)this["UpdateUserTypingStatusFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("########")]
	public string FallbackTextForUnavailableUnder13Content => (string)this["FallbackTextForUnavailableUnder13Content"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("28.00:00:00")]
	public TimeSpan ConversationTitleCacheExpiry => (TimeSpan)this["ConversationTitleCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnIOSPhoneForSoothsayers => (bool)this["IsLuaChatEnabledOnIOSPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnIOSPhoneForBetaTesters => (bool)this["IsLuaChatEnabledOnIOSPhoneForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnIOSTabletForSoothsayers => (bool)this["IsLuaChatEnabledOnIOSTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnIOSTabletForBetaTesters => (bool)this["IsLuaChatEnabledOnIOSTabletForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnIOSPhoneRolloutPercentage => (int)this["LuaChatOnIOSPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnIOSTabletRolloutPercentage => (int)this["LuaChatOnIOSTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnAndroidPhoneForSoothsayers => (bool)this["IsLuaChatEnabledOnAndroidPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnAndroidPhoneForBetaTesters => (bool)this["IsLuaChatEnabledOnAndroidPhoneForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnAndroidPhoneInclusiveStartRolloutPercentage => (int)this["LuaChatOnAndroidPhoneInclusiveStartRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnAndroidPhoneExclusiveEndRolloutPercentage => (int)this["LuaChatOnAndroidPhoneExclusiveEndRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnAndroidTabletForSoothsayers => (bool)this["IsLuaChatEnabledOnAndroidTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLuaChatEnabledOnAndroidTabletForBetaTesters => (bool)this["IsLuaChatEnabledOnAndroidTabletForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnAndroidTabletInclusiveStartRolloutPercentage => (int)this["LuaChatOnAndroidTabletInclusiveStartRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LuaChatOnAndroidTabletExclusiveEndRolloutPercentage => (int)this["LuaChatOnAndroidTabletExclusiveEndRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsForChatConversation => (RedisEndpoints)this["RedisEndpointsForChatConversation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsForChatMessage => (RedisEndpoints)this["RedisEndpointsForChatMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan ConversationPersistenceDeduplicationInterval => (TimeSpan)this["ConversationPersistenceDeduplicationInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan ConversationPersistenceDeduplicationLockDuration => (TimeSpan)this["ConversationPersistenceDeduplicationLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int SetConversationUniverseFloodCheckLimit => (int)this["SetConversationUniverseFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool SetConversationUniverseFloodCheckEnabled => (bool)this["SetConversationUniverseFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan SetConversationUniverseFloodCheckExpiry => (TimeSpan)this["SetConversationUniverseFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnWebForSoothsayers => (bool)this["IsConversationUniverseEnabledOnWebForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnWebForBetatesters => (bool)this["IsConversationUniverseEnabledOnWebForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationUniverseEnabledOnWebRolloutPercentage => (int)this["ConversationUniverseEnabledOnWebRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnAndroidPhoneForSoothsayers => (bool)this["IsConversationUniverseEnabledOnAndroidPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnAndroidPhoneForBetatesters => (bool)this["IsConversationUniverseEnabledOnAndroidPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnAndroidTabletForSoothsayers => (bool)this["IsConversationUniverseEnabledOnAndroidTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnAndroidTabletForBetatesters => (bool)this["IsConversationUniverseEnabledOnAndroidTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationUniverseEnabledOnAndroidPhoneRolloutPercentage => (int)this["ConversationUniverseEnabledOnAndroidPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationUniverseEnabledOnAndroidTabletRolloutPercentage => (int)this["ConversationUniverseEnabledOnAndroidTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnIOSPhoneForSoothsayers => (bool)this["IsConversationUniverseEnabledOnIOSPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnIOSPhoneForBetatesters => (bool)this["IsConversationUniverseEnabledOnIOSPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnIOSTabletForSoothsayers => (bool)this["IsConversationUniverseEnabledOnIOSTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseEnabledOnIOSTabletForBetatesters => (bool)this["IsConversationUniverseEnabledOnIOSTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationUniverseEnabledOnIOSPhoneRolloutPercentage => (int)this["ConversationUniverseEnabledOnIOSPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationUniverseEnabledOnIOSTabletRolloutPercentage => (int)this["ConversationUniverseEnabledOnIOSTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnAndroidPhoneForSoothsayers => (bool)this["IsPlayTogetherEnabledOnAndroidPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnAndroidPhoneForBetatesters => (bool)this["IsPlayTogetherEnabledOnAndroidPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnAndroidTabletForSoothsayers => (bool)this["IsPlayTogetherEnabledOnAndroidTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnAndroidTabletForBetatesters => (bool)this["IsPlayTogetherEnabledOnAndroidTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlayTogetherEnabledOnAndroidPhoneRolloutPercentage => (int)this["PlayTogetherEnabledOnAndroidPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlayTogetherEnabledOnAndroidTabletRolloutPercentage => (int)this["PlayTogetherEnabledOnAndroidTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnIOSPhoneForSoothsayers => (bool)this["IsPlayTogetherEnabledOnIOSPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnIOSPhoneForBetatesters => (bool)this["IsPlayTogetherEnabledOnIOSPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnIOSTabletForSoothsayers => (bool)this["IsPlayTogetherEnabledOnIOSTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherEnabledOnIOSTabletForBetatesters => (bool)this["IsPlayTogetherEnabledOnIOSTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlayTogetherEnabledOnIOSPhoneRolloutPercentage => (int)this["PlayTogetherEnabledOnIOSPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlayTogetherEnabledOnIOSTabletRolloutPercentage => (int)this["PlayTogetherEnabledOnIOSTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPartyDisabledForSoothsayers => (bool)this["IsPartyDisabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPartyDisabledForBetatesters => (bool)this["IsPartyDisabledForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PartyDisabledRolloutPercentage => (int)this["PartyDisabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int MaxConversationsPerUserToUpdateScoreOnCacheMiss => (int)this["MaxConversationsPerUserToUpdateScoreOnCacheMiss"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConversationScoreUpdateOnCacheMissRolloutPercentage => (int)this["ConversationScoreUpdateOnCacheMissRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoggingEnabledForConversationsScoreUpdateOnCacheMissEvents => (bool)this["IsLoggingEnabledForConversationsScoreUpdateOnCacheMissEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationScoreUpdateOnCacheMissEnabledForSoothsayers => (bool)this["IsConversationScoreUpdateOnCacheMissEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationScoreUpdateOnCacheMissEnabledForBetatesters => (bool)this["IsConversationScoreUpdateOnCacheMissEnabledForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PlayTogetherEventSnsTopicArn => (string)this["PlayTogetherEventSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayTogetherPublishingEnabled => (bool)this["IsPlayTogetherPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PlayTogetherAwsAccessKeyAndSecretCSV => (string)this["PlayTogetherAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan ConversationScoreUpdateCutoffFromLastMessageTimestamp => (TimeSpan)this["ConversationScoreUpdateCutoffFromLastMessageTimestamp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int QueryConversationsWithParticipantsForUserBatchSize => (int)this["QueryConversationsWithParticipantsForUserBatchSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatConversationEventsAwsAccessKey => (string)this["ChatConversationEventsAwsAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatConversationEventsAwsSecretKey => (string)this["ChatConversationEventsAwsSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatConversationEventsSnsTopicArn => (string)this["ChatConversationEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int MaximumGroupConversationsToQueryForCachingChatInteractions => (int)this["MaximumGroupConversationsToQueryForCachingChatInteractions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3.00:00:00")]
	public TimeSpan ChatInteractionsCacheCollectionExpiry => (TimeSpan)this["ChatInteractionsCacheCollectionExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public RedisEndpoints RedisEndpointsForChatInteractions => (RedisEndpoints)this["RedisEndpointsForChatInteractions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("700")]
	public int QueryParticipantConversationsCacheLimitForChatInteractionsCache => (int)this["QueryParticipantConversationsCacheLimitForChatInteractionsCache"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChatConversationEventPublishingEnabled => (bool)this["IsChatConversationEventPublishingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGraphemeConversationTitleLengthCalculationEnabled => (bool)this["IsGraphemeConversationTitleLengthCalculationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DecoratorsWhitelist => (string)this["DecoratorsWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreIceBreakersEnabled => (bool)this["AreIceBreakersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsChatMessageLastSentTimeStampErrorLoggingEnabled => (bool)this["IsChatMessageLastSentTimeStampErrorLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLastSentMessageTimeStampEnabled => (bool)this["IsLastSentMessageTimeStampEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLinkChatMessageEnabledForSoothsayers => (bool)this["IsGameLinkChatMessageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLinkChatMessageEnabledForBetatesters => (bool)this["IsGameLinkChatMessageEnabledForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameLinkChatMessageEnabledRolloutPercentage => (int)this["GameLinkChatMessageEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan LastSentMessageTimeStampExpiry => (TimeSpan)this["LastSentMessageTimeStampExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30.00:00:00")]
	public TimeSpan ChatMessageSentRecentTimeSpan => (TimeSpan)this["ChatMessageSentRecentTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRemoteCacheForOneToOneConversationLookup => (bool)this["UseRemoteCacheForOneToOneConversationLookup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("hi,hello,hey")]
	public string WhitelistMessageContentCsv => (string)this["WhitelistMessageContentCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsWhitelistMessageContentModeratedMetricsEnabled => (bool)this["IsWhitelistMessageContentModeratedMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConversationUniverseChangedChatMessageEnabled => (bool)this["IsConversationUniverseChangedChatMessageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDynamoDbContextQueryEnabled => (bool)this["IsDynamoDbContextQueryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSenderPlatformTypePersistenceEnabled => (bool)this["IsSenderPlatformTypePersistenceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMessageMarkedAsReadNotificationEnabled => (bool)this["IsMessageMarkedAsReadNotificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MinGroupConversationParticipantsCount => (int)this["MinGroupConversationParticipantsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int MaxGroupConversationParticipantsCount => (int)this["MaxGroupConversationParticipantsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsExistingChatGroupDeduplicationEnabled => (bool)this["IsExistingChatGroupDeduplicationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsExistingChatGroupDeduplicationLoggingEnabled => (bool)this["IsExistingChatGroupDeduplicationLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAvoidDuplicateChatInteractionsCacheUpdateEnabled => (bool)this["IsAvoidDuplicateChatInteractionsCacheUpdateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserFactoryMultiGetEnabled => (bool)this["IsUserFactoryMultiGetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserFactoryMultiGetEnabledV2 => (bool)this["IsUserFactoryMultiGetEnabledV2"];

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
