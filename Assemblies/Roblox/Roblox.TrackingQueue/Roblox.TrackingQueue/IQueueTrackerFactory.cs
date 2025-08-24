namespace Roblox.TrackingQueue;

/// <summary>
/// A factory producing <see cref="T:Roblox.TrackingQueue.IQueueTracker" />s
/// </summary>
public interface IQueueTrackerFactory
{
	/// <summary>
	/// Creates a <see cref="T:Roblox.TrackingQueue.IQueueTracker" />
	/// </summary>
	/// <param name="trackingKey">The specific key to track against.  Tracking data for different queues will be aggregated together if they use the same key.</param>
	/// <returns></returns>
	IQueueTracker Create(string trackingKey);
}
