using System;
using System.Collections.Generic;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal class SqsReadWriteDeleteClientFactory : ISqsReadWriteDeleteClientFactory
{
	private readonly SqsDomainFactories _DomainFactories;

	public SqsReadWriteDeleteClientFactory(SqsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	public ISqsReadWriteDeleteClient GetSqsReadWriteDeleteClient(ISqsBatchDeleter sqsBatchDeleter, IAmazonSQS sqsClient, string sqsUrl, Func<TimeSpan> waitTimeGetter, List<string> requestedMessageAttributes, ISqsPerformanceMonitor totalsPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor, string systemName)
	{
		return new SqsReadWriteDeleteClient(() => sqsBatchDeleter, () => sqsClient, () => sqsUrl, waitTimeGetter, requestedMessageAttributes, totalsPerformanceMonitor, regionPerformanceMonitor, _DomainFactories.SqsReceiptFactory, systemName);
	}
}
