using System;

namespace Roblox.Platform.Moderation;

/// <summary>
/// A factory for creating and retrieving <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" />.
/// </summary>
public interface ISqsOpenTaskFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" /> with the input data.
	/// </summary>
	/// <param name="queueIdentifier">The <see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" /> of the queue.</param>
	/// <param name="message">The Sqs message associated with the task.</param>
	/// <param name="taskExpiry">The expiry time of the task.</param>
	/// <param name="worker">The unique key for the actor working on the task.</param>
	/// <param name="taskIdentifier">The task identifier that uniquely identify the task.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Throws when the input queueIdentifier, or message is null.</exception>
	/// <exception cref="T:System.ArgumentException">Throws when the ReceiptHandle or ReceiptRegionName of taskIdentifier is null or white space.</exception>
	ISqsOpenTask Create(ITaskQueueIdentifier queueIdentifier, string message, DateTime taskExpiry, string worker, OpenTaskIdentifier taskIdentifier);
}
