using System;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <summary>
/// A <see cref="T:Roblox.TrackingQueue.ITrackingQueueMessage" /> with receipt information.
/// Effectively represents a message pulled from the queue, but in the same 
/// format that was submitted.
/// </summary>
public interface ITrackingQueueMessageWithReceipt : ITrackingQueueMessage, ISqsReceipt
{
	/// <summary>
	/// Expected expiry time for the given message.
	/// </summary>
	DateTime MessageExpiry { get; }
}
