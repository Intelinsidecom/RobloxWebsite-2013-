using System;
using System.Collections.Generic;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal interface ISqsReadWriteDeleteClientFactory
{
	ISqsReadWriteDeleteClient GetSqsReadWriteDeleteClient(ISqsBatchDeleter sqsBatchDeleter, IAmazonSQS sqsClient, string sqsUrl, Func<TimeSpan> waitTimeGetter, List<string> requestedMessageAttributes, ISqsPerformanceMonitor totalsPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor, string systemName);
}
