using System;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an open moderation task that is to be worked on by a moderator.
/// An effective wrapper around a task message and other necessary queue information in order 
/// for a moderator to work on and then to perform the removal of the message from the queue.
/// </summary>
public interface IOpenTask
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" /> of queue the task is retrieved from.
	/// </summary>
	ITaskQueueIdentifier QueueIdentifier { get; }

	/// <summary>
	/// The message body.
	/// </summary>
	string Message { get; }

	/// <summary>
	/// The expiry time of the task.
	/// </summary>
	DateTime TaskExpiry { get; }

	/// <summary>
	/// The unique key for the actor working on the task.
	/// </summary>
	string Worker { get; }
}
