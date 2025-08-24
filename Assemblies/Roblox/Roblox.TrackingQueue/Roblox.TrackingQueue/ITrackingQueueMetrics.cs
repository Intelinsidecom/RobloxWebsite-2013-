using System;

namespace Roblox.TrackingQueue;

/// <summary>
/// Provides metrics for the state of work in the given Queue.
/// </summary>
public interface ITrackingQueueMetrics
{
	/// <summary>
	/// Count of the total number of items in the queue.
	/// </summary>
	/// <returns></returns>
	long GetNumberOfItemsInQueue();

	/// <summary>
	/// Count of the total workers with an active item in the queue.
	/// </summary>
	/// <returns></returns>
	long GetNumberOfQueueWorkers();

	/// <summary>
	/// Find the age of the oldest item in the queue.
	/// </summary>
	/// <returns></returns>
	TimeSpan AgeOfOldestItemInQueue();
}
