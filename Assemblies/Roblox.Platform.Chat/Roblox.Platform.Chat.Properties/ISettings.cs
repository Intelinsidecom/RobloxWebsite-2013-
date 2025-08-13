using System;

namespace Roblox.Platform.Chat.Properties;

public interface ISettings
{
	string AwsAccessKey { get; }

	string AwsSecretAccessKey { get; }

	string ChatDynamoDbAccessKeyAndSecret { get; }

	string ChatEventSnsTopicArn { get; }

	TimeSpan ConversationParticipantExpirationTimespan { get; }

	TimeSpan DelayedEventsDelay { get; }

	bool DisableFetchingMessageIdsOnCacheMiss { get; }

	bool IsBlockMessagesFromUsersNotConnectedToRealTimeEnabled { get; }

	bool IsCacheSyncEnabled { get; }

	bool IsChatEventPublishingEnabled { get; }

	bool IsDelayedNewMessageEventPublishingEnabled { get; }

	bool IsGraphemeConversationTitleLengthCalculationEnabled { get; }

	int MaxConversationParticipantsToFetch { get; }

	int MaxConversationsPerParticipant { get; }

	int MaxConversationTitleLength { get; }

	int MaxPagesForCacheSync { get; }

	int MaxParticipantsInCloudEditConversations { get; }

	int MaxParticipantsInConversation { get; }

	int MaxRowsToFetchForCacheSync { get; }

	TimeSpan MessageExpirationTimespan { get; }

	bool MessagePersistenceEnabled { get; }

	TimeSpan MessageSeenCacheExpiry { get; }

	TimeSpan OldestMessageIdStoreExpiration { get; }

	TimeSpan PeriodicParticipantConversationCacheConsistencyCheckFrequency { get; }

	int PeriodicParticipantConversationCacheConsistencyCheckRollout { get; }

	bool UpdateUserTypingStatusFloodCheckEnabled { get; }

	TimeSpan UpdateUserTypingStatusFloodCheckExpiry { get; }

	int UpdateUserTypingStatusFloodCheckLimit { get; }

	bool UseCloudEditPermissionsPlatform { get; }

	string FallbackTextForUnavailableUnder13Content { get; }

	TimeSpan ConversationTitleCacheExpiry { get; }

	int SetConversationUniverseFloodCheckLimit { get; }

	TimeSpan SetConversationUniverseFloodCheckExpiry { get; }

	bool SetConversationUniverseFloodCheckEnabled { get; }

	string PlayTogetherEventSnsTopicArn { get; }

	TimeSpan LastSentMessageTimeStampExpiry { get; }

	TimeSpan ChatMessageSentRecentTimeSpan { get; }

	bool UseRemoteCacheForOneToOneConversationLookup { get; }

	bool IsDynamoDbContextQueryEnabled { get; }

	int MinGroupConversationParticipantsCount { get; }

	int MaxGroupConversationParticipantsCount { get; }

	bool IsExistingChatGroupDeduplicationEnabled { get; }
}
