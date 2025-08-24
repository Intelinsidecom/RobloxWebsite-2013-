using System;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueueMessageWithReceipt" />
public class TrackingQueueMessageWithReceipt : ITrackingQueueMessageWithReceipt, ITrackingQueueMessage, ISqsReceipt
{
	/// <inheritdoc cref="!:ITrackingQueueMessageWithReceipt.Body" />
	public string Body { get; }

	/// <inheritdoc cref="!:ITrackingQueueMessageWithReceipt.Id" />
	public string Id { get; }

	/// <inheritdoc cref="!:ITrackingQueueMessageWithReceipt.ReceiptHandle" />
	public string ReceiptHandle { get; }

	/// <inheritdoc cref="!:ITrackingQueueMessageWithReceipt.RegionName" />
	public string RegionName { get; }

	/// <inheritdoc cref="P:Roblox.TrackingQueue.ITrackingQueueMessageWithReceipt.MessageExpiry" />
	public DateTime MessageExpiry { get; }

	public TrackingQueueMessageWithReceipt(string id, string body, string receiptHandle, string regionName, DateTime messageExpiry)
	{
		Body = body;
		Id = id;
		ReceiptHandle = receiptHandle;
		RegionName = regionName;
		MessageExpiry = messageExpiry;
	}
}
