using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Amazon.Runtime;
using Amazon.SQS;
using Roblox.Amazon.Sqs.Properties;
using Roblox.Configuration;
using Roblox.Coordination;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

public class SqsBatchSender : BatchWorker, ISqsBatchSender, ISqsSender, IBackgroundWorker, IDisposable
{
	private const string _SqsQueueUrl = ".amazonaws.com/";

	private const string _SqsQueueUrlReplacePattern = "https://sqs.{0}.amazonaws.com/";

	private readonly int _DelayInSeconds;

	private List<SqsReadWriteClient> _SqsSenders;

	private readonly BatchSenderPerInstancePerformanceMonitor _BatchSenderPerformanceMonitor;

	private readonly AWSCredentials _AwsCredentials;

	private readonly IRobloxSqsClientFactory _SqsClientFactory;

	private readonly bool _RetryInOtherRegions;

	private readonly string _InstanceName;

	private readonly string _BaseQueueUrl;

	private bool _Disposed;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Occurs when an exception is thrown during SQS client rebuild.
	/// </summary>
	public event Action<Exception> ErrorOnSqsClientRebuildOccurred;

	public SqsBatchSender(string awsAccessKey, string awsSecretKey, string baseQueueUrl, int maxMessagesPerBatchRequest = 10, int maxTimeoutPerMessage = 100, int delayInSeconds = 0, bool retryInOtherRegions = false)
		: base(maxMessagesPerBatchRequest, maxTimeoutPerMessage)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		_InstanceName = ExtractInstanceName(baseQueueUrl);
		_BaseQueueUrl = baseQueueUrl;
		_DelayInSeconds = delayInSeconds;
		_SqsSenders = new List<SqsReadWriteClient>();
		_CounterRegistry = StaticCounterRegistry.Instance;
		_BatchSenderPerformanceMonitor = new BatchSenderPerInstancePerformanceMonitor(_CounterRegistry, _InstanceName);
		_BatchSenderPerformanceMonitor.LogBatchSenderCreated();
		_SqsClientFactory = RobloxSqsClientFactory.Instance;
		_AwsCredentials = (AWSCredentials)new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		_RetryInOtherRegions = retryInOtherRegions;
		_SqsSenders = CreateSqsReadWriteClients();
		Settings.Default.MonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.RegionEndpointsCSV), (Action)RebuildSqsClients);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.BatchSenderDefaultSqsClientReadWriteTimeout), (Action)RebuildSqsClients);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.BatchSenderDefaultSqsClientTimeout), (Action)RebuildSqsClients);
		_SqsClientFactory.DefaultClientSettingsChanged += RebuildSqsReadWriteClientsOnSqsClientDefaultSettingsChange;
	}

	public void SendMessage(string message)
	{
		EnqueueWork(message);
		_BatchSenderPerformanceMonitor.LogSendMessage();
	}

	internal void BatchSendFailed(SqsPublishRequest sqsPublishRequest)
	{
		if (sqsPublishRequest.AreAnyBackupSendersLeft())
		{
			sqsPublishRequest.SwitchToNextBackupClient();
			SqsOperations.BatchSendAsync(sqsPublishRequest);
		}
	}

	private List<SqsReadWriteClient> CreateSqsReadWriteClients()
	{
		IReadOnlyCollection<IRobloxRegionEndpoint> readOnlyCollection = SqsOperations.InitializeRegionEndpoints(Settings.Default.RegionEndpointsCSV.Split(new char[1] { ',' }));
		int queueUrlReplaceIndex = _BaseQueueUrl.IndexOf(".amazonaws.com/") + ".amazonaws.com/".Length;
		string queueUrlReplaceTarget = _BaseQueueUrl.Substring(0, queueUrlReplaceIndex);
		List<SqsReadWriteClient> createdSqsSenders = new List<SqsReadWriteClient>();
		foreach (IRobloxRegionEndpoint regionEndpoint in readOnlyCollection)
		{
			string queueUrlReplacement = $"https://sqs.{regionEndpoint.SystemName}.amazonaws.com/";
			string queueUrl = _BaseQueueUrl.Replace(queueUrlReplaceTarget, queueUrlReplacement);
			RobloxSqsClientDefaultSettings defaultSettings = _SqsClientFactory.GetDefaultSettings();
			RobloxSqsClientConfig robloxSqsClientConfig = new RobloxSqsClientConfig(_InstanceName);
			((ClientConfig)robloxSqsClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
			((ClientConfig)robloxSqsClientConfig).RegionEndpoint = regionEndpoint.GetAwsRegionEndpoint();
			robloxSqsClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
			((ClientConfig)robloxSqsClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
			RobloxSqsClientConfig config = robloxSqsClientConfig;
			config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
			config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
			config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
			((ClientConfig)config).ReadWriteTimeout = Settings.Default.BatchSenderDefaultSqsClientReadWriteTimeout;
			((ClientConfig)config).Timeout = Settings.Default.BatchSenderDefaultSqsClientTimeout;
			IAmazonSQS sqsClient = _SqsClientFactory.Create(_AwsCredentials, config);
			SqsReadWriteClient sqsSender = new SqsReadWriteClient(() => sqsClient, () => queueUrl);
			createdSqsSenders.Add(sqsSender);
			if (!_RetryInOtherRegions)
			{
				break;
			}
		}
		return createdSqsSenders;
	}

	protected override void ProcessBatchAsync(List<string> messages, Action<ICollection<string>> batchCompletedCallback, Action<Exception> exceptionHandler)
	{
		SqsOperations.BatchSendAsync(new SqsPublishRequest(_SqsSenders, messages, _DelayInSeconds, _BatchSenderPerformanceMonitor, batchCompletedCallback, BatchSendFailed, exceptionHandler));
	}

	private string ExtractInstanceName(string baseQueueUrl)
	{
		if (baseQueueUrl.IndexOf("_") == -1)
		{
			throw new ArgumentException($"Invalid baseQueueUrl did not contain '_': {baseQueueUrl}");
		}
		string obj = baseQueueUrl.Split(new char[1] { '_' }, 2)[1];
		if (string.IsNullOrWhiteSpace(obj))
		{
			throw new ArgumentException($"Invalid instanceName derived from baseQueueUrl: {baseQueueUrl}");
		}
		return obj;
	}

	/// <summary>
	/// Disposes the current instance.
	/// </summary>
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void RebuildSqsReadWriteClientsOnSqsClientDefaultSettingsChange(RobloxSqsClientDefaultSettings updatedSettings)
	{
		RebuildSqsClients();
	}

	private void RebuildSqsClients()
	{
		try
		{
			_SqsSenders = CreateSqsReadWriteClients();
		}
		catch (Exception ex)
		{
			this.ErrorOnSqsClientRebuildOccurred?.Invoke(new Exception($"Fatal exception: SQS client rebuild is failed on SQS client endpoints setting update. (SqsBatchSender) Ex: {ex}."));
		}
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (_SqsClientFactory != null)
			{
				_SqsClientFactory.DefaultClientSettingsChanged -= RebuildSqsReadWriteClientsOnSqsClientDefaultSettingsChange;
			}
			_Disposed = true;
		}
	}
}
