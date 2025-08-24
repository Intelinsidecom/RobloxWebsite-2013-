using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueueConsumer" />
internal class TrackingQueueConsumer : ITrackingQueueConsumer
{
	private readonly IQueueTracker _QueueTracker;

	private readonly ISqsConsumerWithReceipt _SqsConsumer;

	public TrackingQueueConsumer(ISqsConsumerWithReceipt sqsConsumer, IQueueTracker queueTracker)
	{
		_SqsConsumer = sqsConsumer ?? throw new ArgumentNullException("sqsConsumer");
		_QueueTracker = queueTracker ?? throw new ArgumentNullException("queueTracker");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueConsumer.GetNextMessageForWorker(System.String)" />
	public ITrackingQueueMessageWithReceipt GetNextMessageForWorker(string worker)
	{
		if (string.IsNullOrWhiteSpace(worker))
		{
			throw new ArgumentNullException("worker");
		}
		return _QueueTracker.GetExistingMessagesForWorker(worker)?.FirstOrDefault() ?? GetNextMessageFromQueue(worker);
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueConsumer.GetNextMessagesForWorker(System.String,System.Int32)" />
	public ICollection<ITrackingQueueMessageWithReceipt> GetNextMessagesForWorker(string worker, int maxCount)
	{
		if (string.IsNullOrWhiteSpace(worker))
		{
			throw new ArgumentNullException("worker");
		}
		if (maxCount < 1)
		{
			throw new ArgumentException(string.Format("{0} must be a positive maxCount", "maxCount"));
		}
		ICollection<ITrackingQueueMessageWithReceipt> existingMessages = _QueueTracker.GetExistingMessagesForWorker(worker);
		if (existingMessages != null && existingMessages.Count >= maxCount)
		{
			return existingMessages.Take(maxCount).ToArray();
		}
		return GetNextMessagesFromQueue(worker, maxCount, existingMessages);
	}

	private ICollection<ITrackingQueueMessageWithReceipt> GetNextMessagesFromQueue(string worker, int number, ICollection<ITrackingQueueMessageWithReceipt> existingMessages)
	{
		int numberOfNewEntriesToGet = number - (existingMessages?.Count ?? 0);
		List<ITrackingQueueMessageWithReceipt> result = ((existingMessages == null) ? new List<ITrackingQueueMessageWithReceipt>() : new List<ITrackingQueueMessageWithReceipt>(existingMessages));
		for (int i = 0; i < numberOfNewEntriesToGet; i++)
		{
			ITrackingQueueMessageWithReceipt nextItem = GetNextMessageFromQueue(worker);
			if (nextItem == null)
			{
				return result;
			}
			result.Add(nextItem);
		}
		return result;
	}

	private ITrackingQueueMessageWithReceipt GetNextMessageFromQueue(string worker)
	{
		ISqsMessageWithReceipt sqsItem = _SqsConsumer.GetNextMessage();
		if (sqsItem == null)
		{
			return null;
		}
		ITrackingQueueMessageWithReceipt messageWithReceipt = ExtractRedisQueueTrackerMessage(sqsItem);
		_QueueTracker.TrackMessageRetrievedByWorker(messageWithReceipt, worker);
		return messageWithReceipt;
	}

	private ITrackingQueueMessageWithReceipt ExtractRedisQueueTrackerMessage(ISqsMessageWithReceipt sqsItem)
	{
		TrackingQueueMessage sqsTrackerMessage = JsonConvert.DeserializeObject<TrackingQueueMessage>(sqsItem.Message);
		return new TrackingQueueMessageWithReceipt(sqsTrackerMessage.Id, sqsTrackerMessage.Body, sqsItem.Receipt.ReceiptHandle, sqsItem.Receipt.RegionName, sqsItem.MessageExpiry);
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueueConsumer.DeleteMessageForWorker(Roblox.TrackingQueue.ITrackingQueueMessageWithReceipt,System.String)" />
	public void DeleteMessageForWorker(ITrackingQueueMessageWithReceipt receipt, string worker)
	{
		if (receipt == null)
		{
			throw new ArgumentNullException("receipt");
		}
		if (string.IsNullOrWhiteSpace(worker))
		{
			throw new ArgumentNullException("worker");
		}
		_QueueTracker.UntrackMessageProcessedByWorker(receipt, worker);
		_SqsConsumer.DeleteMessage(receipt);
	}
}
