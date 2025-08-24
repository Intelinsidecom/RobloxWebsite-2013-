using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Amazon.SQS;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerWithReceipt" />
/// </summary>
internal class SqsConsumerWithReceipt : ISqsConsumerWithReceipt, IDisposable
{
	private const string _SqsQueueUrl = ".amazonaws.com/";

	private const string _SqsQueueUrlReplacePattern = "https://sqs.{0}.amazonaws.com/";

	private readonly List<ISqsReadWriteDeleteClient> _SqsReadDeleteClients;

	private readonly Dictionary<string, ISqsBatchDeleter> _SqsBatchDeleters;

	private readonly ConcurrentQueue<ISqsMessageWithReceipt> _Messages;

	private readonly int _VisibilityTimeout;

	private readonly Func<TimeSpan> _WaitTimeGetter;

	private readonly int _BatchSize;

	private readonly ISqsConfigSettings _SqsConfigSettings;

	private readonly SqsDomainFactories _DomainFactories;

	private readonly ISqsPerformanceMonitor _TotalsPerformanceMonitor;

	private readonly Dictionary<string, ISqsPerformanceMonitor> _RegionPerformanceMonitors;

	private readonly List<string> _RequestedMessageAttributes;

	private readonly string _PerformanceMonitorCategory;

	private long _ModCount;

	private ILogger Logger => _DomainFactories.Logger;

	private string QueueUrlReplaceTarget
	{
		get
		{
			int queueUrlReplaceIndex = _SqsConfigSettings.SqsUrl.IndexOf(".amazonaws.com/") + ".amazonaws.com/".Length;
			return _SqsConfigSettings.SqsUrl.Substring(0, queueUrlReplaceIndex);
		}
	}

	/// <summary>
	/// The default public constructor for <see cref="T:Roblox.Amazon.Sqs.SqsConsumerWithReceipt" />.
	/// </summary>
	/// <param name="sqsConfigSettings">The <see cref="T:Roblox.Amazon.Sqs.ISqsConfigSettings" /> for AWS SQS access settings.</param>
	/// <param name="requestedMessageAttributes">The list of SQS request attributes for which to retrieve information from SQS.</param>
	/// <param name="counterRegistry">The Instrumentation CounterRegistry.</param>
	/// <param name="performanceMonitorCategory">The category name of the performance monitor.</param>
	/// <param name="batchSize">The batch size for each SQS message request.</param>
	/// <param name="visibilityTimeout">The visibility timeout in seconds to be set for the SQS request.</param>
	/// <param name="waitTimeGetter">Getter for the wait time to be set for the SQS request.</param>
	/// <param name="domainFactories">The <see cref="T:Roblox.Amazon.Sqs.SqsDomainFactories" />.</param>
	/// <param name="messages">The local cached queue storing messages leased from SQS and is ready to be consumed by consumers.</param>
	/// <param name="totalsPerformanceMonitor">The total performance monitor.</param>
	/// <param name="regionPerformanceMonitors">The regional performance monitor.</param>
	/// <param name="sqsReadWriteDeleteClients">The list of <see cref="T:Roblox.Amazon.Sqs.ISqsReadWriteDeleteClient" />s being used by the object of this class.</param>
	/// <param name="sqsBatchDeleters">The list of <see cref="T:Roblox.Amazon.Sqs.ISqsBatchDeleter" />s being used by the object of this class.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when any of the input parameters settings, sqsConfigSettings, performanceMonitorCategory, 
	/// logger, or domainFactories is null.</exception>
	internal SqsConsumerWithReceipt(ISqsConfigSettings sqsConfigSettings, List<string> requestedMessageAttributes, ICounterRegistry counterRegistry, string performanceMonitorCategory, int batchSize, int visibilityTimeout, Func<TimeSpan> waitTimeGetter, SqsDomainFactories domainFactories, ConcurrentQueue<ISqsMessageWithReceipt> messages, ISqsPerformanceMonitor totalsPerformanceMonitor, Dictionary<string, ISqsPerformanceMonitor> regionPerformanceMonitors, List<ISqsReadWriteDeleteClient> sqsReadWriteDeleteClients, Dictionary<string, ISqsBatchDeleter> sqsBatchDeleters)
	{
		_SqsConfigSettings = sqsConfigSettings ?? throw new ArgumentNullException("sqsConfigSettings");
		_RequestedMessageAttributes = requestedMessageAttributes;
		_PerformanceMonitorCategory = performanceMonitorCategory ?? throw new ArgumentNullException("performanceMonitorCategory");
		_BatchSize = batchSize;
		_VisibilityTimeout = visibilityTimeout;
		_WaitTimeGetter = waitTimeGetter ?? ((Func<TimeSpan>)(() => TimeSpan.FromSeconds(0.0)));
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_Messages = messages ?? throw new ArgumentNullException("messages");
		_TotalsPerformanceMonitor = totalsPerformanceMonitor ?? throw new ArgumentNullException("totalsPerformanceMonitor");
		_RegionPerformanceMonitors = regionPerformanceMonitors ?? throw new ArgumentNullException("regionPerformanceMonitors");
		_SqsReadDeleteClients = sqsReadWriteDeleteClients ?? throw new ArgumentNullException("sqsReadWriteDeleteClients");
		_SqsBatchDeleters = sqsBatchDeleters ?? throw new ArgumentNullException("sqsBatchDeleters");
		Initialize(counterRegistry);
	}

	internal virtual void Initialize(ICounterRegistry counterRegistry)
	{
		foreach (IRobloxRegionEndpoint regionEndpoint in InitializeRegionEndpoints())
		{
			IAmazonSQS sqsClient = _DomainFactories.SqsClientFactory.GetSqsClient(regionEndpoint, _SqsConfigSettings);
			InitializeClients(regionEndpoint.SystemName, sqsClient, counterRegistry);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual IEnumerable<IRobloxRegionEndpoint> InitializeRegionEndpoints()
	{
		return SqsOperations.InitializeRegionEndpoints(_DomainFactories.Settings.RegionEndpointsCSV.Split(new char[1] { ',' }));
	}

	internal virtual void InitializeClients(string systemName, IAmazonSQS sqsClient, ICounterRegistry counterRegistry)
	{
		ISqsPerformanceMonitor regionPerformanceMonitor = _DomainFactories.SqsPerformanceMonitorFactory.GetRegionSqsConsumerWithReceiptPerformanceMonitor(counterRegistry, _PerformanceMonitorCategory, systemName);
		_RegionPerformanceMonitors.Add(systemName, regionPerformanceMonitor);
		string queueUrlReplacement = $"https://sqs.{systemName}.amazonaws.com/";
		string sqsUrl = _SqsConfigSettings.SqsUrl.Replace(QueueUrlReplaceTarget, queueUrlReplacement);
		ISqsBatchDeleter sqsBatchDeleter = _DomainFactories.BatchDeleterFactory.GetBatchDeleter(sqsClient, sqsUrl, _TotalsPerformanceMonitor, regionPerformanceMonitor);
		_SqsBatchDeleters.Add(systemName, sqsBatchDeleter);
		ISqsReadWriteDeleteClient sqsReadDeleteClient = _DomainFactories.SqsReadWriteDeleteClientFactory.GetSqsReadWriteDeleteClient(sqsBatchDeleter, sqsClient, sqsUrl, _WaitTimeGetter, _RequestedMessageAttributes, _TotalsPerformanceMonitor, regionPerformanceMonitor, systemName);
		_SqsReadDeleteClients.Add(sqsReadDeleteClient);
	}

	public ISqsMessageWithReceipt GetNextMessage()
	{
		if (_Messages.IsEmpty)
		{
			GetMessages(_BatchSize);
		}
		ISqsMessageWithReceipt message;
		while (_Messages.TryDequeue(out message))
		{
			if (DateTime.UtcNow < message.MessageExpiry)
			{
				_TotalsPerformanceMonitor.LogMessageProcessingStart();
				_RegionPerformanceMonitors[message.Receipt.RegionName]?.LogMessageProcessingStart();
				return message;
			}
		}
		return null;
	}

	private void GetMessages(int batchSize)
	{
		//IL_009d: Expected O, but got Unknown
		int clientIndex = (int)Math.Abs(Interlocked.Increment(ref _ModCount) % _SqsReadDeleteClients.Count);
		try
		{
			for (int i = 0; i < _SqsReadDeleteClients.Count; i++)
			{
				IReadOnlyCollection<ISqsMessageWithReceipt> messages = _SqsReadDeleteClients[(clientIndex + i) % _SqsReadDeleteClients.Count].GetMessagesWithReceipt(batchSize, _VisibilityTimeout);
				if (messages.Count <= 0)
				{
					continue;
				}
				{
					foreach (ISqsMessageWithReceipt sqsMessage in messages)
					{
						_Messages.Enqueue(sqsMessage);
					}
					break;
				}
			}
		}
		catch (AmazonSQSException val)
		{
			AmazonSQSException e = val;
			Logger.Error((Exception)(object)e);
		}
	}

	public void DeleteMessage(ISqsReceipt sqsReceipt)
	{
		if (sqsReceipt == null)
		{
			throw new ArgumentNullException("sqsReceipt");
		}
		if (!_SqsBatchDeleters.TryGetValue(sqsReceipt.RegionName, out var batchDeleter))
		{
			Logger.Error($"{GetType().Name}: Cannot find batch deleter for the region {sqsReceipt.RegionName}.");
			return;
		}
		batchDeleter.DeleteMessage(sqsReceipt.ReceiptHandle);
		_TotalsPerformanceMonitor.LogMessageProcessSuccess();
		_RegionPerformanceMonitors[sqsReceipt.RegionName]?.LogMessageProcessSuccess();
	}

	public void Dispose()
	{
		foreach (string sqsBatchDeleterKey in _SqsBatchDeleters.Keys)
		{
			_SqsBatchDeleters[sqsBatchDeleterKey]?.Stop();
		}
		_SqsReadDeleteClients.Clear();
		_TotalsPerformanceMonitor.LogStop();
		foreach (string key in _RegionPerformanceMonitors.Keys)
		{
			_RegionPerformanceMonitors[key]?.LogStop();
		}
	}
}
