using System;
using System.Collections.Generic;
using Amazon.SQS;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsBatchDeleter" />.
/// </summary>
internal class SqsBatchDeleter : BatchWorker, ISqsBatchDeleter, ISqsDeleter, IBackgroundWorker
{
	private readonly IAmazonSQS _SqsClient;

	private readonly string _SqsQueueUrl;

	private readonly ISqsPerformanceMonitor _TotalsPerformanceMonitor;

	private readonly ISqsPerformanceMonitor _RegionPerformanceMonitor;

	internal SqsBatchDeleter(IAmazonSQS sqsClient, string queueUrl, ISqsPerformanceMonitor totalPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor, int maxMessagesPerBatchRequest = 10, int maxTimeoutPerMessage = 100)
		: base(maxMessagesPerBatchRequest, maxTimeoutPerMessage)
	{
		_SqsClient = sqsClient ?? throw new ArgumentNullException("sqsClient");
		if (string.IsNullOrWhiteSpace(queueUrl))
		{
			throw new ArgumentNullException("queueUrl");
		}
		_SqsQueueUrl = queueUrl;
		_TotalsPerformanceMonitor = totalPerformanceMonitor ?? throw new ArgumentNullException("totalPerformanceMonitor");
		_RegionPerformanceMonitor = regionPerformanceMonitor ?? throw new ArgumentNullException("regionPerformanceMonitor");
	}

	protected override void ProcessBatchAsync(List<string> receiptHandles, Action<ICollection<string>> batchCompletedCallback, Action<Exception> exceptionHandler)
	{
		SqsOperations.BatchDeleteAsync(_SqsClient, _SqsQueueUrl, receiptHandles, batchCompletedCallback, exceptionHandler, _TotalsPerformanceMonitor, _RegionPerformanceMonitor);
	}

	public void DeleteMessage(string receiptHandle)
	{
		EnqueueWork(receiptHandle);
	}
}
