using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal class SqsPublishRequest
{
	internal BatchSenderPerInstancePerformanceMonitor BatchSenderPerformanceMonitor;

	private SqsReadWriteClient CurrentSqsQueueClient { get; set; }

	private Queue<SqsReadWriteClient> BackupSqsQueueClients { get; }

	public IReadOnlyCollection<string> Messages { get; set; }

	public int DelayInSeconds { get; set; }

	public Action<ICollection<string>> BatchCompletedCallback { get; set; }

	public Action<SqsPublishRequest> BatchSendFailed { get; set; }

	public Action<Exception> ExceptionHandler { get; set; }

	public SqsPublishRequest(List<SqsReadWriteClient> senders, IReadOnlyCollection<string> messages, int delayInSeconds, BatchSenderPerInstancePerformanceMonitor batchSenderPerformanceMonitor, Action<ICollection<string>> batchCompletedCallback, Action<SqsPublishRequest> batchSendFailed, Action<Exception> exceptionHandler)
	{
		BackupSqsQueueClients = new Queue<SqsReadWriteClient>(senders);
		CurrentSqsQueueClient = BackupSqsQueueClients.Dequeue();
		DelayInSeconds = delayInSeconds;
		Messages = messages;
		BatchSenderPerformanceMonitor = batchSenderPerformanceMonitor;
		BatchCompletedCallback = batchCompletedCallback;
		BatchSendFailed = batchSendFailed;
		ExceptionHandler = exceptionHandler;
	}

	public bool AreAnyBackupSendersLeft()
	{
		return BackupSqsQueueClients.Any();
	}

	public void SwitchToNextBackupClient()
	{
		SqsReadWriteClient backupClient = BackupSqsQueueClients.Dequeue();
		CurrentSqsQueueClient = backupClient;
		BatchSenderPerformanceMonitor.LogSwitchToBackupSqsClient();
	}

	public string GetQueueUrl()
	{
		return CurrentSqsQueueClient.QueueUrlGetter();
	}

	public IAmazonSQS GetSqsClient()
	{
		return CurrentSqsQueueClient.SqsClientGetter();
	}
}
