using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Roblox.Amazon.Sqs.Properties;
using Roblox.Configuration;
using Roblox.Coordination;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Redis;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

public abstract class SqsThrottlingStreamSubscriberBase : IDisposable
{
	private readonly string _PerfmonInstanceName;

	private readonly ILogger _Logger;

	private readonly SqsStreamSubscriberPerformanceMonitor _TotalsPerformanceMonitor;

	private readonly List<SqsStreamSubscriberPerformanceMonitor> _RegionPerformanceMonitors;

	private readonly List<ElasticConsumer> _ElasticConsumers;

	private readonly List<SqsElasticConsumerMonitor> _ElasticConsumerMonitors;

	private readonly List<SqsBatchDeleter> _BatchDeleters;

	private readonly Dictionary<RegionEndpoint, List<SqsConsumer>> _Consumers;

	private HashSet<RegionEndpoint> _RegionEndpoints;

	private readonly ISqsReceiptFactory _SqsReceiptFactory;

	private readonly IRobloxSqsClientFactory _SqsClientFactory;

	private bool _Disposed;

	private readonly ICounterRegistry _CounterRegistry;

	protected abstract int NumberOfThreads { get; }

	protected abstract string AwsAccessKeyAndSecretAccessKey { get; }

	protected abstract string AmazonSqsUrl { get; }

	protected abstract bool ThroughputThrottlingEnabled { get; }

	protected abstract TimeSpan ThroughputThrottlingPeriod { get; }

	protected abstract int ThroughputThrottlingLimit { get; }

	/// <summary>
	/// This value, when true, causes the SqsMessages to be trimmed before being echoed into the logger. Trimming starts at the index SqsMessageTrimmingStartIndex
	/// </summary>
	protected virtual bool IsSqsMessageTrimmingEnabled => false;

	/// <summary>
	/// When IsSqsMessageTrimmingEnabled is true, the value of SqsMessageTrimmingStartIndex controls the position at which the trimming function begins.
	/// A value of 0 indicates that the entire message is trimmed, a value of 1 indicates that all but the first character is trimmed
	/// Negative values are not supported at this time and are treated the same as a zero, with an additional warning log entry being generated
	/// </summary>
	protected virtual int SqsMessageTrimmingStartIndex => 0;

	/// <summary>
	/// This flag can be set to true to prefix the echoed sqsMessage body with the AWS provided message id attribute
	/// </summary>
	protected virtual bool IsSqsMessageIdIncludedInErrorLogs => false;

	protected virtual bool DynamicallyAllocateThreads => Settings.Default.DynamicallyAllocateConsumerThreadsEnabled;

	protected virtual List<string> RequestedMessageAttributes => null;

	protected virtual int MaxMessageBatchSize => Settings.Default.SqsMessageBatchGetCount;

	protected virtual Func<TimeSpan> WaitTimeGetter => null;

	protected virtual Func<int, TimeSpan> BackoffCalculator => null;

	protected virtual int RetryIterationLimit => Settings.Default.DefaultRetryIterationLimit;

	protected abstract bool ProcessMessage(ISqsMessage message);

	protected SqsThrottlingStreamSubscriberBase(string perfmonInstanceName, ILogger logger)
	{
		if (string.IsNullOrWhiteSpace(perfmonInstanceName))
		{
			throw new ArgumentException("perfmonInstanceName");
		}
		_PerfmonInstanceName = perfmonInstanceName;
		_CounterRegistry = StaticCounterRegistry.Instance;
		_TotalsPerformanceMonitor = new SqsStreamSubscriberPerformanceMonitor(_CounterRegistry, perfmonInstanceName);
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_RegionPerformanceMonitors = new List<SqsStreamSubscriberPerformanceMonitor>();
		_ElasticConsumers = new List<ElasticConsumer>();
		_ElasticConsumerMonitors = new List<SqsElasticConsumerMonitor>();
		_BatchDeleters = new List<SqsBatchDeleter>();
		_Consumers = new Dictionary<RegionEndpoint, List<SqsConsumer>>();
		_SqsReceiptFactory = new SqsReceiptFactory();
		_SqsClientFactory = RobloxSqsClientFactory.Instance;
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.DynamicallyAllocateConsumerThreadsEnabled), (Action)Restart);
		Settings.Default.MonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.RegionEndpointsCSV), (Action)Restart);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DefaultRetryIterationLimit), (Action)Restart);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.StreamSubscriberDefaultSqsClientTimeout), (Action)Restart);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.StreamSubscriberDefaultSqsClientReadWriteTimeout), (Action)Restart);
		_SqsClientFactory.DefaultClientSettingsChanged += RestartOnSqsClientDefaultSettingsChange;
	}

	private IAmazonSQS InitializeSqsClient(string awsAccessKey, string awsSecretKey, RegionEndpoint regionEndpoint)
	{
		_Logger.Info(() => $"Starting SQS client with timeout={Settings.Default.StreamSubscriberDefaultSqsClientTimeout} readWriteTimeout={Settings.Default.StreamSubscriberDefaultSqsClientReadWriteTimeout}");
		RobloxSqsClientDefaultSettings defaultSettings = _SqsClientFactory.GetDefaultSettings();
		RobloxSqsClientConfig robloxSqsClientConfig = new RobloxSqsClientConfig(_PerfmonInstanceName);
		((ClientConfig)robloxSqsClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxSqsClientConfig).RegionEndpoint = regionEndpoint;
		robloxSqsClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxSqsClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxSqsClientConfig config = robloxSqsClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = Settings.Default.StreamSubscriberDefaultSqsClientReadWriteTimeout;
		((ClientConfig)config).Timeout = Settings.Default.StreamSubscriberDefaultSqsClientTimeout;
		return _SqsClientFactory.Create(awsAccessKey, awsSecretKey, config);
	}

	private SqsBatchDeleter InitializeBatchDeleter(IAmazonSQS sqsClient, string sqsUrl, SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor)
	{
		SqsBatchDeleter sqsBatchDeleter = new SqsBatchDeleter(sqsClient, sqsUrl, _TotalsPerformanceMonitor, regionPerformanceMonitor);
		sqsBatchDeleter.Start();
		return sqsBatchDeleter;
	}

	private void RestartOnSqsClientDefaultSettingsChange(RobloxSqsClientDefaultSettings updatedSettings)
	{
		try
		{
			Restart();
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Logger.Error(() => $"Fatal exception: Restart is failed on default client settings update. (SqsThrottlingStreamSubscriberBase) Ex: {ex}.");
		}
	}

	private void SetupDynamicThreadAllocation(Func<Consumer> consumerFactory, SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor)
	{
		ElasticConsumer elasticConsumer = new ElasticConsumer(consumerFactory, MaxMessageBatchSize, CalculatePredictionConfidence, () => NumberOfThreads);
		SqsElasticConsumerMonitor elasticConsumerMonitor = new SqsElasticConsumerMonitor(elasticConsumer, _TotalsPerformanceMonitor, regionPerformanceMonitor);
		elasticConsumerMonitor.Start();
		elasticConsumer.Start();
		_ElasticConsumers.Add(elasticConsumer);
		_ElasticConsumerMonitors.Add(elasticConsumerMonitor);
	}

	private void SetupStaticThreadAllocation(Func<Consumer> consumerFactory, SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor, RegionEndpoint regionEndpoint)
	{
		List<SqsConsumer> consumers = new List<SqsConsumer>();
		for (int i = 0; i < NumberOfThreads; i++)
		{
			SqsConsumer consumer = (SqsConsumer)consumerFactory();
			consumer.BatchSize = MaxMessageBatchSize;
			consumer.Start();
			consumers.Add(consumer);
		}
		regionPerformanceMonitor.LogSetCurrentThreads(NumberOfThreads);
		_TotalsPerformanceMonitor.LogThreadsIncreased(NumberOfThreads);
		_Consumers.Add(regionEndpoint, consumers);
	}

	/// <summary>
	/// Every region endpoint has a batchDeleter.
	/// </summary>
	private void SetupRegionEndpoint(string[] awsKeys, RegionEndpoint regionEndpoint)
	{
		string sqsUrl = AmazonSqsUrl.Replace("us-east-1", regionEndpoint.SystemName);
		string regionPerfmonInstanceName = $"{_PerfmonInstanceName}.{regionEndpoint.SystemName}";
		SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor = new SqsStreamSubscriberPerformanceMonitor(_CounterRegistry, regionPerfmonInstanceName);
		_RegionPerformanceMonitors.Add(regionPerformanceMonitor);
		IAmazonSQS sqsClient = InitializeSqsClient(awsKeys[0], awsKeys[1], regionEndpoint);
		SqsBatchDeleter batchDeleter = InitializeBatchDeleter(sqsClient, sqsUrl, regionPerformanceMonitor);
		_BatchDeleters.Add(batchDeleter);
		SqsReadWriteDeleteClient sqsReadDeleteClient = new SqsReadWriteDeleteClient(() => batchDeleter, () => sqsClient, () => sqsUrl, WaitTimeGetter, RequestedMessageAttributes, _TotalsPerformanceMonitor, regionPerformanceMonitor, _SqsReceiptFactory, regionEndpoint.SystemName);
		RedisRollingWindowFloodChecker floodchecker = new RedisRollingWindowFloodChecker(_PerfmonInstanceName, $"{_PerfmonInstanceName}.ProcessMessage", () => ThroughputThrottlingLimit, () => ThroughputThrottlingPeriod, () => ThroughputThrottlingEnabled, _Logger);
		Func<IMessage, bool> messageRecievedFunc = (IMessage message) => Consumer_MessageReceived(message, regionPerformanceMonitor, floodchecker);
		string name = $"{sqsUrl} Consumer";
		Func<Consumer> consumerFactory = () => new SqsConsumer(_Logger, name, messageRecievedFunc, sqsReadDeleteClient, BackoffCalculator, RetryIterationLimit);
		if (DynamicallyAllocateThreads)
		{
			SetupDynamicThreadAllocation(consumerFactory, regionPerformanceMonitor);
		}
		else
		{
			SetupStaticThreadAllocation(consumerFactory, regionPerformanceMonitor, regionEndpoint);
		}
	}

	private void InitializeRegionEndpointsSet()
	{
		IReadOnlyCollection<IRobloxRegionEndpoint> regionEndpoints = SqsOperations.InitializeRegionEndpoints(Settings.Default.RegionEndpointsCSV.Split(new char[1] { ',' }));
		_RegionEndpoints = new HashSet<RegionEndpoint>(regionEndpoints.Select((IRobloxRegionEndpoint r) => r.GetAwsRegionEndpoint()));
	}

	public virtual void Start()
	{
		try
		{
			if (string.IsNullOrEmpty(AmazonSqsUrl))
			{
				throw new ArgumentNullException("AmazonSqsUrl");
			}
			_Logger.LifecycleEvent("Starting SQS Stream Subscriber.");
			string[] awsKeys = AwsAccessKeyAndSecretAccessKey.Split(new char[1] { ',' });
			InitializeRegionEndpointsSet();
			foreach (RegionEndpoint regionEndpoint in _RegionEndpoints)
			{
				SetupRegionEndpoint(awsKeys, regionEndpoint);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	private bool Consumer_MessageReceived(IMessage message, SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor, IFloodChecker floodChecker)
	{
		if (!(message is ISqsMessage sqsMessage))
		{
			throw new ApplicationException("SqsThrottlingStreamSubscriberBase can only process ISqsMessages.");
		}
		bool readyToReceiveMessages = false;
		if (floodChecker.IsFlooded())
		{
			regionPerformanceMonitor.LogMessageThrottled();
			_TotalsPerformanceMonitor.LogMessageThrottled();
			return false;
		}
		floodChecker.UpdateCount();
		regionPerformanceMonitor.LogMessageProcessingStart();
		_TotalsPerformanceMonitor.LogMessageProcessingStart();
		Stopwatch sw = Stopwatch.StartNew();
		try
		{
			readyToReceiveMessages = ProcessMessage(sqsMessage);
			sw.Stop();
			long paddedDuration2 = sw.ElapsedMilliseconds;
			regionPerformanceMonitor.LogMessageProcessSuccess(paddedDuration2);
			_TotalsPerformanceMonitor.LogMessageProcessSuccess(paddedDuration2);
		}
		catch (Exception ex)
		{
			sw.Stop();
			long paddedDuration = sw.ElapsedMilliseconds;
			regionPerformanceMonitor.LogMessageProcessFailure(paddedDuration);
			_TotalsPerformanceMonitor.LogMessageProcessFailure(paddedDuration);
			_Logger.Error($"Error for message: {BuildSqsMessageForException(sqsMessage)} \r\n{ex}");
		}
		if (readyToReceiveMessages)
		{
			sqsMessage.OnCompleted();
		}
		return readyToReceiveMessages;
	}

	internal string BuildSqsMessageForException(ISqsMessage sqsMessage)
	{
		string finalMessage = sqsMessage.Message;
		if (IsSqsMessageTrimmingEnabled)
		{
			if (SqsMessageTrimmingStartIndex < 0)
			{
				_Logger.Warning($"SqsMessageTrimmingStartIndex should be greater than or equal to 0. Trimming will occur as though SqsMessageTrimmingStartIndex were 0. The actual value is negative. Value: ({SqsMessageTrimmingStartIndex})");
			}
			finalMessage = "The following message has been trimmed: " + TrimMessage(finalMessage) + ". ";
		}
		if (IsSqsMessageIdIncludedInErrorLogs)
		{
			finalMessage = $"SQS Message Id: {sqsMessage.FullMessage.MessageId}. " + finalMessage;
		}
		return finalMessage;
	}

	internal string TrimMessage(string message)
	{
		return message[..((SqsMessageTrimmingStartIndex >= 0) ? SqsMessageTrimmingStartIndex : 0)];
	}

	private double CalculatePredictionConfidence(bool isDegreeOfParallelismIncreasing)
	{
		if (isDegreeOfParallelismIncreasing)
		{
			return Settings.Default.SqsConsumerAdjustmentPredictionConfidence;
		}
		return Settings.Default.SqsConsumerDestructionPredictionConfidence;
	}

	public void Restart()
	{
		_Logger.Info("Restarting Sqs Stream subscriber");
		Stop();
		Start();
	}

	public virtual void Stop()
	{
		foreach (ElasticConsumer elasticConsumer in _ElasticConsumers)
		{
			elasticConsumer.Stop();
		}
		_ElasticConsumers.Clear();
		foreach (SqsBatchDeleter batchDeleter in _BatchDeleters)
		{
			batchDeleter.Stop();
		}
		_BatchDeleters.Clear();
		foreach (SqsElasticConsumerMonitor elasticConsumerMonitor in _ElasticConsumerMonitors)
		{
			elasticConsumerMonitor.Stop();
		}
		_ElasticConsumerMonitors.Clear();
		foreach (RegionEndpoint region in _Consumers.Keys)
		{
			List<SqsConsumer> consumers = new List<SqsConsumer>();
			if (!_Consumers.TryGetValue(region, out consumers))
			{
				continue;
			}
			foreach (SqsConsumer item in consumers)
			{
				item.Stop();
			}
		}
		_Consumers.Clear();
		_TotalsPerformanceMonitor.LogStop();
		foreach (SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor in _RegionPerformanceMonitors)
		{
			regionPerformanceMonitor.LogStop();
		}
	}

	/// <summary>
	/// Disposes the current instance.
	/// </summary>
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (disposing)
			{
				Stop();
			}
			if (_SqsClientFactory != null)
			{
				_SqsClientFactory.DefaultClientSettingsChanged -= RestartOnSqsClientDefaultSettingsChange;
			}
			_Disposed = true;
		}
	}
}
