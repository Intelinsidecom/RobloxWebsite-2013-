using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <summary>
/// A Factory for <see cref="T:Roblox.TrackingQueue.ITrackingQueueConsumer" /> objects.
/// Effectively a wrapper for an <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" /> along with a key.
/// </summary>
public interface ITrackingQueueConsumerFactory
{
	/// <summary>
	/// Create a <see cref="T:Roblox.TrackingQueue.ITrackingQueueConsumer" />.
	/// </summary>
	/// <param name="consumer">The connection to Sqs for consuming</param>
	/// <param name="trackingKey">The specific key to track against.  Tracking data for different queues will be aggregated together if they use the same key.</param>
	/// <returns><see cref="T:Roblox.TrackingQueue.ITrackingQueueConsumer" /></returns>
	ITrackingQueueConsumer Create(ISqsConsumerWithReceipt consumer, string trackingKey);
}
