using System;
using System.Collections.Generic;
using StackExchange.Redis;

namespace Roblox.Caching;

internal interface IRedisInvalidationSettingsProvider
{
	event Action<IReadOnlyCollection<ISubscriber>> OnPubSubHandlesAdded;

	event Action<IReadOnlyCollection<ISubscriber>> OnPubSubHandlesRemoved;

	event Action<int> OnNumberOfAttemptsForTopicSubscriptionChanged;

	event Action<int> OnRetryIntervalForTopicSubscriptionsChanged;

	event Action<Exception> OnException;

	int GetNumberOfAttemptsForInvalidationMessageDelivery();

	TimeSpan GetDelayToStopSubscribingAfterNodeRemoval();

	TimeSpan GetDelayToStartPublishingAfterNodeAddition();

	int GetNumberOfAttemptsForTopicSubscription();

	int GetRetryIntervalForTopicSubscriptionsInMilliseconds();

	int GetInvalidationPublisherQueueSize();

	IReadOnlyCollection<ISubscriber> GetPubSubHandles();

	bool IsThrowOnInitializationErrorEnabled();
}
