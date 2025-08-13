using System;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueueMetrics" />
internal class TrackingQueueMetrics : ITrackingQueueMetrics
{
	private readonly IQueueTracker _QueueTracker;

	internal TrackingQueueMetrics(IQueueTracker queueTracker)
	{
		_QueueTracker = queueTracker ?? throw new ArgumentNullException("queueTracker");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueMetrics.GetNumberOfItemsInQueue" />
	public long GetNumberOfItemsInQueue()
	{
		return _QueueTracker.GetNumberOfItemsInQueue();
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueMetrics.GetNumberOfQueueWorkers" />
	public long GetNumberOfQueueWorkers()
	{
		return _QueueTracker.GetNumberOfQueueWorkers();
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueMetrics.AgeOfOldestItemInQueue" />
	public TimeSpan AgeOfOldestItemInQueue()
	{
		return _QueueTracker.GetAgeOfOldestItemInQueue();
	}
}
