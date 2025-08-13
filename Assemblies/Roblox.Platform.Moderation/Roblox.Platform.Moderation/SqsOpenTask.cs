using System;
using Roblox.Amazon.Sqs;

namespace Roblox.Platform.Moderation;

internal class SqsOpenTask : ISqsOpenTask, IOpenTask
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.Moderation.IOpenTask.QueueIdentifier" />
	/// </summary>
	public ITaskQueueIdentifier QueueIdentifier { get; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.Moderation.IOpenTask.Message" />
	/// </summary>
	public string Message { get; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.Moderation.IOpenTask.TaskExpiry" />
	/// </summary>
	public DateTime TaskExpiry { get; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.Moderation.IOpenTask.Worker" />
	/// </summary>
	public string Worker { get; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.Moderation.ISqsOpenTask.TaskIdentifier" />
	/// </summary>
	public OpenTaskIdentifier TaskIdentifier { get; }

	internal SqsOpenTask(ITaskQueueIdentifier queueIdentifier, string message, DateTime taskExpiry, string worker, ISqsReceipt receipt)
	{
		QueueIdentifier = queueIdentifier ?? throw new ArgumentNullException("queueIdentifier");
		if (string.IsNullOrWhiteSpace(message))
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
		TaskExpiry = taskExpiry;
		if (string.IsNullOrEmpty(worker))
		{
			throw new ArgumentNullException("worker");
		}
		Worker = worker;
		receipt = receipt ?? throw new ArgumentNullException("receipt");
		TaskIdentifier = new OpenTaskIdentifier
		{
			ReceiptHandle = receipt.ReceiptHandle,
			ReceiptRegionName = receipt.RegionName
		};
	}

	internal SqsOpenTask(ITaskQueueIdentifier queueIdentifier, string message, DateTime taskExpiry, string worker, OpenTaskIdentifier taskIdentifier)
	{
		QueueIdentifier = queueIdentifier ?? throw new ArgumentNullException("queueIdentifier");
		if (string.IsNullOrWhiteSpace(message))
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
		TaskExpiry = taskExpiry;
		if (string.IsNullOrEmpty(worker))
		{
			throw new ArgumentNullException("worker");
		}
		Worker = worker;
		TaskIdentifier = taskIdentifier;
	}
}
