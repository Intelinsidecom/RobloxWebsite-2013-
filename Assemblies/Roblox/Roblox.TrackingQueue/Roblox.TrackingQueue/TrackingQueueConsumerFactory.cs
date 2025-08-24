using System;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueueConsumerFactory" />
internal class TrackingQueueConsumerFactory : ITrackingQueueConsumerFactory
{
	private readonly IQueueTrackerFactory _TrackerFactory;

	public TrackingQueueConsumerFactory(IQueueTrackerFactory trackerFactory)
	{
		_TrackerFactory = trackerFactory ?? throw new ArgumentNullException("trackerFactory");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueConsumerFactory.Create(Roblox.Amazon.Sqs.ISqsConsumerWithReceipt,System.String)" />
	public ITrackingQueueConsumer Create(ISqsConsumerWithReceipt consumer, string trackingKey)
	{
		if (consumer == null)
		{
			throw new ArgumentNullException("consumer");
		}
		if (string.IsNullOrWhiteSpace(trackingKey))
		{
			throw new ArgumentNullException("trackingKey");
		}
		IQueueTracker storage = _TrackerFactory.Create(trackingKey);
		return new TrackingQueueConsumer(consumer, storage);
	}
}
