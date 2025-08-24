using System;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TrackingQueue.ITrackingQueuePublisherFactory" />
/// </summary>
internal class TrackingQueuePublisherFactory : ITrackingQueuePublisherFactory
{
	private readonly IQueueTrackerFactory _TrackerFactory;

	public TrackingQueuePublisherFactory(IQueueTrackerFactory trackerFactory)
	{
		_TrackerFactory = trackerFactory ?? throw new ArgumentNullException("trackerFactory");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueuePublisherFactory.Create(Roblox.Amazon.Sqs.ISqsSender,System.String)" />
	public ITrackingQueuePublisher Create(ISqsSender sender, string trackingKey)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (string.IsNullOrWhiteSpace(trackingKey))
		{
			throw new ArgumentNullException("trackingKey");
		}
		IQueueTracker queueTrackerStorage = _TrackerFactory.Create(trackingKey);
		return new TrackingQueuePublisher(sender, queueTrackerStorage);
	}
}
