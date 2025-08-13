using System;
using Roblox.Amazon.Sqs;
using Roblox.EventLog;

namespace Roblox.Platform.Moderation;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Platform.Moderation.ISqsOpenTaskFactory" />.
/// </summary>
internal class SqsOpenTaskFactory : ISqsOpenTaskFactory
{
	protected readonly ILogger Logger;

	protected readonly ISqsReceiptFactory SqsReceiptFactory;

	internal SqsOpenTaskFactory(ILogger logger, ISqsReceiptFactory sqsReceiptFactory)
	{
		Logger = logger ?? throw new ArgumentNullException("logger");
		SqsReceiptFactory = sqsReceiptFactory ?? throw new ArgumentNullException("sqsReceiptFactory");
	}

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" /> with the input data.
	/// </summary>
	/// <param name="queueIdentifier">The <see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" /> of the queue.</param>
	/// <param name="message">The Sqs message associated with the task.</param>
	/// <param name="taskExpiry">The expiry time of the task.</param>
	/// <param name="worker">The unique key for the actor working on the task.</param>
	/// <param name="taskIdentifier">The task identifier that uniquely identify the task.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" />, returns null when the report associated with the message cannot be retrieved.</returns>
	/// <exception cref="T:System.ArgumentNullException">Throws when the input queueIdentifier, or message is null.</exception>
	/// <exception cref="T:System.ArgumentException">Throws when the ReceiptHandle or ReceiptRegionName of taskIdentifier is null or white space.</exception>
	public ISqsOpenTask Create(ITaskQueueIdentifier queueIdentifier, string message, DateTime taskExpiry, string worker, OpenTaskIdentifier taskIdentifier)
	{
		if (queueIdentifier == null)
		{
			throw new ArgumentNullException("queueIdentifier");
		}
		if (string.IsNullOrWhiteSpace(message))
		{
			throw new ArgumentNullException("message");
		}
		if (string.IsNullOrEmpty(worker))
		{
			throw new ArgumentNullException("worker");
		}
		if (string.IsNullOrWhiteSpace(taskIdentifier.ReceiptHandle))
		{
			throw new ArgumentException(string.Format("{0}.{1} is null or white space.", "taskIdentifier", "ReceiptHandle"));
		}
		if (string.IsNullOrWhiteSpace(taskIdentifier.ReceiptRegionName))
		{
			throw new ArgumentException(string.Format("{0}.{1} is null or white space.", "taskIdentifier", "ReceiptRegionName"));
		}
		ISqsReceipt receipt = SqsReceiptFactory.GetSqsReceipt(taskIdentifier.ReceiptHandle, taskIdentifier.ReceiptRegionName);
		return new SqsOpenTask(queueIdentifier, message, taskExpiry, worker, receipt);
	}
}
