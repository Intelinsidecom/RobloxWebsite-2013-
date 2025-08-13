using System;
using System.Collections.Generic;

namespace Roblox.TrackingQueue;

/// <summary>
/// An interface for tracking messages in one or more queues to be processed by workers.
/// </summary>
public interface IQueueTracker
{
	/// <summary>
	/// Get the age of the oldest message that is not done being processed.
	/// This includes messages already retrieved by workers and is in the middle of processing.
	/// </summary>
	TimeSpan GetAgeOfOldestItemInQueue();

	/// <summary>
	/// Get the id and timespan of the oldest message that is not done being processed.
	/// This includes messages already retrieved by workers and is in the middle of processing.
	/// </summary>
	bool TryDequeueOldestItemInQueue(out string message, out TimeSpan age);

	/// <summary>
	/// Get the messages retrieved by a worker that are not done being processed.
	/// </summary>
	ICollection<ITrackingQueueMessageWithReceipt> GetExistingMessagesForWorker(string worker);

	/// <summary>
	/// Get the number of messages published and are not done being processed
	/// </summary>
	long GetNumberOfItemsInQueue();

	/// <summary>
	/// Get the number of workers that have retrieved messages and are not done processing
	/// </summary>
	/// <returns></returns>
	long GetNumberOfQueueWorkers();

	/// <summary>
	/// Track that a message has been published
	/// </summary>
	void TrackMessagePublished(ITrackingQueueMessage message);

	/// <summary>
	/// Track that a message has been retreived by a worker
	/// </summary>
	void TrackMessageRetrievedByWorker(ITrackingQueueMessageWithReceipt message, string worker);

	/// <summary>
	/// Removes a message from tracking after it's done being processed by a worker
	/// </summary>
	void UntrackMessageProcessedByWorker(ITrackingQueueMessageWithReceipt message, string worker);
}
