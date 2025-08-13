using System.Collections.Generic;

namespace Roblox.TrackingQueue;

/// <summary>
/// An <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" /> that also tracks progress within Redis
/// to allow for real-time updates on the state of the queue.
/// </summary>
public interface ITrackingQueueConsumer
{
	/// <summary>
	/// Get the next message from the Queue and allocated it to the given <paramref name="worker" />.
	/// We assume that <paramref name="worker" />s are unique. Requesting a message for a 
	/// worker that is already assigned a message will return the existing one.
	/// </summary>
	/// <param name="worker">unique key for the actor working on the given message</param>
	/// <returns></returns>
	ITrackingQueueMessageWithReceipt GetNextMessageForWorker(string worker);

	/// <summary>
	/// Return up to <paramref name="maxCount" /> messages for the given <paramref name="worker" />.
	/// If the <paramref name="worker" /> has existing incomplete work items, those may be returned as part of the set.
	/// </summary>
	/// <param name="worker">unique key for the actor working on the given message</param>
	/// <param name="maxCount">maximum number of messages to return</param>
	/// <returns>A non-null collection of messages.</returns>
	ICollection<ITrackingQueueMessageWithReceipt> GetNextMessagesForWorker(string worker, int maxCount);

	/// <summary>
	/// Delete a message from the queue as represented by the <paramref name="receipt" /> AND
	/// clear the active task for the given <paramref name="worker" />
	/// </summary>
	/// <param name="receipt">message and receipt exactly as they came from <see cref="M:Roblox.TrackingQueue.ITrackingQueueConsumer.GetNextMessageForWorker(System.String)" /></param>
	/// <param name="worker">unique key for the actor working on the given message</param>
	void DeleteMessageForWorker(ITrackingQueueMessageWithReceipt receipt, string worker);
}
