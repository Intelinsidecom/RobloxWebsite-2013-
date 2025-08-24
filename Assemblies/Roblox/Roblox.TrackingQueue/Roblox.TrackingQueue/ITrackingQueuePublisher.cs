namespace Roblox.TrackingQueue;

/// <summary>
/// A Queue Publisher that also tracks state of added items in Redis.
/// </summary>
public interface ITrackingQueuePublisher
{
	/// <summary>
	/// Send the queue message to the queue and track it based on the key.
	/// Note that the message will be edited. 
	/// Use the <see cref="T:Roblox.TrackingQueue.ITrackingQueueConsumer" /> to read data back out.
	/// </summary>
	/// <param name="message"></param>
	void SendMessage(ITrackingQueueMessage message);
}
