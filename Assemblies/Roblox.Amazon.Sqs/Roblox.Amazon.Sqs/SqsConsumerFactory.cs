using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerFactory" />.
/// </summary>
internal class SqsConsumerFactory : ISqsConsumerFactory
{
	private readonly SqsDomainFactories _DomainFactories;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Default consturctor for <see cref="T:Roblox.Amazon.Sqs.SqsConsumerFactory" />.
	/// </summary>
	/// <param name="domainFactories"><see cref="T:Roblox.Amazon.Sqs.SqsDomainFactories" />.</param>
	public SqsConsumerFactory(SqsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_CounterRegistry = StaticCounterRegistry.Instance;
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Amazon.Sqs.ISqsConsumerFactory.GetSqsConsumerWithReceipt(Roblox.Amazon.Sqs.ISqsConfigSettings,System.Collections.Generic.List{System.String},System.String,System.Int32,System.Int32,System.Func{System.TimeSpan})" />
	/// </summary>
	public ISqsConsumerWithReceipt GetSqsConsumerWithReceipt(ISqsConfigSettings sqsConfigSettings, List<string> requestedMessageAttributes, string performanceMonitorCategory, int batchSize, int visibilityTimeout, Func<TimeSpan> waitTimeGetter = null)
	{
		if (sqsConfigSettings == null)
		{
			throw new ArgumentNullException("sqsConfigSettings");
		}
		if (string.IsNullOrWhiteSpace(performanceMonitorCategory))
		{
			throw new ArgumentException(string.Format("{0} is either null or white space.", "performanceMonitorCategory"));
		}
		ConcurrentQueue<ISqsMessageWithReceipt> messages = new ConcurrentQueue<ISqsMessageWithReceipt>();
		SqsConsumerWithReceiptPerformanceMonitor totalsPerformanceMonitor = new SqsConsumerWithReceiptPerformanceMonitor(_CounterRegistry, performanceMonitorCategory);
		Dictionary<string, ISqsPerformanceMonitor> regionPerformanceMonitors = new Dictionary<string, ISqsPerformanceMonitor>();
		List<ISqsReadWriteDeleteClient> sqsReadWriteDeleteClients = new List<ISqsReadWriteDeleteClient>();
		Dictionary<string, ISqsBatchDeleter> sqsBatchDeleters = new Dictionary<string, ISqsBatchDeleter>();
		return new SqsConsumerWithReceipt(sqsConfigSettings, requestedMessageAttributes, _CounterRegistry, performanceMonitorCategory, batchSize, visibilityTimeout, waitTimeGetter, _DomainFactories, messages, totalsPerformanceMonitor, regionPerformanceMonitors, sqsReadWriteDeleteClients, sqsBatchDeleters);
	}
}
