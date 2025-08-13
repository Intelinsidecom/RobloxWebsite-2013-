namespace Roblox.TrackingQueue;

/// <summary>
/// A message to be placed on the Queue.
/// The <see cref="P:Roblox.TrackingQueue.ITrackingQueueMessage.Body" /> is used for the actual message.
/// The <see cref="P:Roblox.TrackingQueue.ITrackingQueueMessage.Id" /> is used for uniquely identifying that message through the life cycle.
/// </summary>
public interface ITrackingQueueMessage
{
	/// <summary>
	/// The message to place on the Queue.
	/// </summary>
	string Body { get; }

	/// <summary>
	/// The unique identifier for the given item on the queue.
	/// </summary>
	string Id { get; }
}
