using System;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueueMetricsFactory" />
internal class TrackingQueueMetricsFactory : ITrackingQueueMetricsFactory
{
	private IQueueTrackerFactory _TrackerFactory;

	public TrackingQueueMetricsFactory(IQueueTrackerFactory trackerFactory)
	{
		_TrackerFactory = trackerFactory ?? throw new ArgumentNullException("trackerFactory");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueMetricsFactory.Create(System.String)" />
	public ITrackingQueueMetrics Create(string trackingKey)
	{
		if (string.IsNullOrWhiteSpace(trackingKey))
		{
			throw new ArgumentNullException("trackingKey");
		}
		return new TrackingQueueMetrics(_TrackerFactory.Create(trackingKey));
	}
}
