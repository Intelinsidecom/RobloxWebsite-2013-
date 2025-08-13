using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Roblox.Amazon.Sqs;

public static class SqsOperations
{
	internal static void BatchDeleteAsync(IAmazonSQS client, string queueUrl, IEnumerable<string> receiptHandles, Action<ICollection<string>> batchCompleted, Action<Exception> exceptionOccured, ISqsPerformanceMonitor totalPerfmon, ISqsPerformanceMonitor regionPerfmon)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		string[] receiptHandlesArray = receiptHandles.ToArray();
		IEnumerable<DeleteMessageBatchRequestEntry> entries = ((IEnumerable<string>)receiptHandlesArray).Select((Func<string, int, DeleteMessageBatchRequestEntry>)((string item, int i) => new DeleteMessageBatchRequestEntry
		{
			ReceiptHandle = item,
			Id = i.ToString()
		}));
		List<DeleteMessageBatchRequestEntry> entriesList = entries.ToList();
		DeleteMessageBatchRequest deleteMessageBatchRequest = new DeleteMessageBatchRequest
		{
			Entries = entriesList,
			QueueUrl = queueUrl
		};
		Stopwatch stopwatch = Stopwatch.StartNew();
		client.DeleteMessageBatchAsync(deleteMessageBatchRequest, default(CancellationToken)).ContinueWith(delegate(Task<DeleteMessageBatchResponse> t)
		{
			stopwatch.Stop();
			if (t.IsFaulted)
			{
				Exception ex = t.Exception;
				while (ex is AggregateException && ex.InnerException != null)
				{
					ex = ex.InnerException;
				}
				exceptionOccured?.Invoke(ex);
				totalPerfmon.LogFailedBatchDelete();
				regionPerfmon.LogFailedBatchDelete();
			}
			else if (t.IsCanceled)
			{
				exceptionOccured?.Invoke(new OperationCanceledException());
				totalPerfmon.LogCancelledBatchDelete();
				regionPerfmon.LogCancelledBatchDelete();
			}
			else
			{
				totalPerfmon.LogSuccessfulBatchDelete(stopwatch.ElapsedMilliseconds, entriesList.Count);
				regionPerfmon.LogSuccessfulBatchDelete(stopwatch.ElapsedMilliseconds, entriesList.Count);
				batchCompleted?.Invoke(receiptHandlesArray);
			}
		});
	}

	public static void DeleteSingleMessage(IAmazonSQS client, string queueUrl, string receiptHandle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		DeleteMessageRequest deleteMessageRequest = new DeleteMessageRequest
		{
			QueueUrl = queueUrl,
			ReceiptHandle = receiptHandle
		};
		client.DeleteMessageAsync(deleteMessageRequest, default(CancellationToken)).GetAwaiter().GetResult();
	}

	public static void SendSingleMessage(IAmazonSQS client, string queueUrl, string messageBody)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		SendMessageRequest sendMessageRequest = new SendMessageRequest
		{
			MessageBody = messageBody,
			QueueUrl = queueUrl
		};
		client.SendMessageAsync(sendMessageRequest, default(CancellationToken)).GetAwaiter().GetResult();
	}

	internal static void BatchSendAsync(SqsPublishRequest sqsPublishRequest)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		string[] messagesArray = sqsPublishRequest.Messages.ToArray();
		List<SendMessageBatchRequestEntry> entriesList = ((IEnumerable<string>)messagesArray).Select((Func<string, int, SendMessageBatchRequestEntry>)((string item, int i) => new SendMessageBatchRequestEntry
		{
			MessageBody = item,
			Id = i.ToString(),
			DelaySeconds = sqsPublishRequest.DelayInSeconds
		})).ToList();
		SendMessageBatchRequest sendMessageBatchRequest = new SendMessageBatchRequest
		{
			Entries = entriesList,
			QueueUrl = sqsPublishRequest.GetQueueUrl()
		};
		Stopwatch stopwatch = Stopwatch.StartNew();
		sqsPublishRequest.GetSqsClient().SendMessageBatchAsync(sendMessageBatchRequest, default(CancellationToken)).ContinueWith(delegate(Task<SendMessageBatchResponse> t)
		{
			stopwatch.Stop();
			if (t.IsFaulted)
			{
				Exception ex = t.Exception;
				while (ex is AggregateException && ex.InnerException != null)
				{
					ex = ex.InnerException;
				}
				sqsPublishRequest.BatchSendFailed?.Invoke(sqsPublishRequest);
				sqsPublishRequest.ExceptionHandler?.Invoke(ex);
				sqsPublishRequest.BatchSenderPerformanceMonitor.LogBatchFailed(stopwatch.ElapsedMilliseconds, sqsPublishRequest.Messages.Count);
			}
			else if (t.IsCanceled)
			{
				sqsPublishRequest.BatchSendFailed?.Invoke(sqsPublishRequest);
				sqsPublishRequest.BatchSenderPerformanceMonitor.LogBatchFailed(stopwatch.ElapsedMilliseconds, sqsPublishRequest.Messages.Count);
			}
			else
			{
				sqsPublishRequest.BatchSenderPerformanceMonitor.LogBatchSent(stopwatch.ElapsedMilliseconds, sqsPublishRequest.Messages.Count);
				sqsPublishRequest.BatchCompletedCallback?.Invoke(messagesArray);
			}
		});
	}

	internal static IReadOnlyCollection<IRobloxRegionEndpoint> InitializeRegionEndpoints(IEnumerable<string> regionEndpointNames)
	{
		List<IRobloxRegionEndpoint> regionEndpoints = new List<IRobloxRegionEndpoint>();
		foreach (string regionString in regionEndpointNames)
		{
			foreach (RegionEndpoint regionEndpoint in RegionEndpoint.EnumerableAllRegions)
			{
				if (regionString == regionEndpoint.SystemName)
				{
					RobloxRegionEndpoint robloxRegionEndpoint = new RobloxRegionEndpoint(regionEndpoint);
					regionEndpoints.Add(robloxRegionEndpoint);
					break;
				}
			}
		}
		return regionEndpoints;
	}
}
