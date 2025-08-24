using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <summary>
/// A factory for creating <see cref="T:Roblox.TrackingQueue.ITrackingQueuePublisher" /> objects.
/// These are effectively wrappers for an <see cref="T:Roblox.Amazon.Sqs.ISqsSender" />
/// that track progress in a Keyed redis set.
/// </summary>
public interface ITrackingQueuePublisherFactory
{
	/// <summary>
	/// Create a new <see cref="T:Roblox.TrackingQueue.ITrackingQueuePublisher" />.
	/// </summary>
	/// <param name="sender">The publisher in Sqs.</param>
	/// <param name="trackingKey">The specific key to track against.  Tracking data for different queues will be aggregated together if they use the same key.</param>
	/// <returns></returns>
	ITrackingQueuePublisher Create(ISqsSender sender, string trackingKey);
}
