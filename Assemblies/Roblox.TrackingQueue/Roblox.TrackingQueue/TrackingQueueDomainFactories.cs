using System;

namespace Roblox.TrackingQueue;

/// <summary>
/// Factories for the various Features of the RedisQueueTracker.
/// The Publisher and Consumer effectively wrap an Sqs connection while providing
/// real-time counters for the activity that happens against the queue.
/// The Metrics are provided via the MetricsFactory
/// </summary>
/// <remarks>
/// To work together a Publisher+Consumer+Metrics must all share the same key (as passed into the factory constructors).
/// The Publisher modifies the message that is put "on the wire", so the Publisher and Consumer must be used together.
/// </remarks>
public class TrackingQueueDomainFactories
{
	private readonly IQueueTrackerFactory _TrackerFactory;

	/// <summary>
	/// Factory for getting keyed publishers.
	/// </summary>
	public ITrackingQueuePublisherFactory PublisherFactory { get; }

	/// <summary>
	/// Factory for getting keyed consumers.
	/// </summary>
	public ITrackingQueueConsumerFactory ConsumerFactory { get; }

	/// <summary>
	/// Factory for getting keyed metrics.
	/// </summary>
	public ITrackingQueueMetricsFactory MetricsFactory { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="trackerFactory"><see cref="T:Roblox.TrackingQueue.IQueueTrackerFactory" />, required</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public TrackingQueueDomainFactories(IQueueTrackerFactory trackerFactory)
	{
		_TrackerFactory = trackerFactory ?? throw new ArgumentNullException("trackerFactory");
		PublisherFactory = new TrackingQueuePublisherFactory(trackerFactory);
		ConsumerFactory = new TrackingQueueConsumerFactory(trackerFactory);
		MetricsFactory = new TrackingQueueMetricsFactory(trackerFactory);
	}
}
