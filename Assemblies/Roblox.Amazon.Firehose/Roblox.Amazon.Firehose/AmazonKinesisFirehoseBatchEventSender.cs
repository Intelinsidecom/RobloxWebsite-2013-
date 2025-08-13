using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.KinesisFirehose;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Roblox.Amazon.Firehose.Properties;
using Roblox.Configuration;
using Roblox.Coordination;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Firehose;

/// <summary>
/// Class provides methods to push data to Firehose stream.
/// </summary>
/// <seealso cref="T:Roblox.Coordination.BackgroundWorker" />
public class AmazonKinesisFirehoseBatchEventSender : BackgroundWorker, IDisposable
{
	private readonly ILogger _Logger;

	private IAmazonKinesisFirehose _AmazonKinesisFirehoseClient;

	private readonly AmazonKinesisFirehosePerformanceMonitor _Perfmon;

	private readonly BlockingCollection<string> _WorkQueue;

	private readonly AmazonKinesisFirehoseBatchEventSenderConfig _Config;

	private readonly IRobloxFirehoseClientFactory _FirehoseClientFactory;

	private readonly ICounterRegistry _CounterRegistry;

	private int _MaxBufferSize;

	private int _MaxMessagesPerBatchRequest;

	private int _MaxTimeoutPerMessage;

	private bool _Disposed;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Firehose.AmazonKinesisFirehoseBatchEventSender" /> class.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws access secret key.</param>
	/// <param name="amazonKinesisFirehoseDeliveryStreamName">Name of the amazon kinesis firehose delivery stream.</param>
	/// <param name="maxBufferSize">Maximum size of the buffer (optional, default value will be used when is not specified).</param>
	/// <param name="maxMessagesPerBatchRequest">The maximum messages per batch request (optional, default value will be used when is not specified).</param>
	/// <param name="maxTimeoutPerMessage">The maximum timeout per message (optional, default value will be used when is not specified).</param>
	/// <param name="awsRegionEndpoint">The aws region endpoint (optional, default value will be used when is not specified).</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <exception cref="T:System.ArgumentException"></exception>
	public AmazonKinesisFirehoseBatchEventSender(ILogger logger, string awsAccessKey, string awsSecretKey, string amazonKinesisFirehoseDeliveryStreamName, int? maxBufferSize, int? maxMessagesPerBatchRequest, int? maxTimeoutPerMessage, RegionEndpoint awsRegionEndpoint = null)
		: this(new AmazonKinesisFirehoseBatchEventSenderConfig(awsAccessKey, awsSecretKey, amazonKinesisFirehoseDeliveryStreamName, maxBufferSize, maxMessagesPerBatchRequest, maxTimeoutPerMessage, awsRegionEndpoint), logger, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Firehose.AmazonKinesisFirehoseBatchEventSender" /> class.
	/// </summary>
	/// <param name="config">The configuration.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// config
	/// or
	/// config.AwsRegionEndpoint
	/// or
	/// logger
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// Must be a non-empty string. - config.AwsAccessKey
	/// or
	/// Must be a non-empty string. - config.AwsSecretKey
	/// or
	/// Must be a non-empty string. - config.AwsKinesisFirehoseDeliveryStreamName
	/// or
	/// Has to be bigger than 0. - config.MaxBufferSize
	/// or
	/// Has to be bigger than 0. - config.MaxMessagesPerBatchRequest
	/// or
	/// Has to be bigger than 0. - config.MaxTimeoutPerMessage
	/// </exception>
	internal AmazonKinesisFirehoseBatchEventSender(AmazonKinesisFirehoseBatchEventSenderConfig config, ILogger logger, IRobloxFirehoseClientFactory clientFactory)
	{
		ValidateConfig(config);
		_Config = config;
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_WorkQueue = new BlockingCollection<string>();
		_CounterRegistry = StaticCounterRegistry.Instance;
		_Perfmon = new AmazonKinesisFirehosePerformanceMonitor(_CounterRegistry, _Config.AwsKinesisFirehoseDeliveryStreamName);
		_FirehoseClientFactory = clientFactory ?? RobloxFirehoseClientFactory.Instance;
		_AmazonKinesisFirehoseClient = CreateRobloxFirehoseClient(_Config, _FirehoseClientFactory.GetDefaultSettings());
		_FirehoseClientFactory.DefaultClientSettingsChanged += RebuildFirehoseClientOnSettingsChange;
		InitWorkerSettings();
		InitSettingsMonitors();
	}

	/// <summary>
	/// Enqueues the data to be pushed to Firehose stream. 
	/// </summary>
	/// <param name="workItem">The work item.</param>
	public void EnqueueWork(string workItem)
	{
		if (!base.IsRunning)
		{
			Start();
		}
		_WorkQueue.Add(workItem);
	}

	/// <summary>
	/// Prepares batch items in chunks of defined size.
	/// </summary>
	protected override void DoWork()
	{
		List<byte[]> batchedEvents = new List<byte[]>(_MaxMessagesPerBatchRequest);
		List<byte[]> eventsInternalBuffer = new List<byte[]>();
		int currentBufferSize = 0;
		int totalEvents = 0;
		while (true)
		{
			int count = batchedEvents.Count;
			int? num = _Config.MaxMessagesPerBatchRequest - 1;
			if (count >= num.GetValueOrDefault() || !num.HasValue || !_WorkQueue.TryTake(out var eventItem, _MaxTimeoutPerMessage))
			{
				break;
			}
			byte[] workItemBytes = Encoding.UTF8.GetBytes(eventItem);
			int workItemSize = workItemBytes.Length;
			if (!Settings.Default.SendOneEventPerFirehoseRecord)
			{
				if (workItemSize >= _MaxBufferSize)
				{
					batchedEvents.Add(workItemBytes);
					totalEvents++;
					continue;
				}
				if (workItemSize + currentBufferSize > _MaxBufferSize)
				{
					totalEvents += eventsInternalBuffer.Count;
					batchedEvents.Add(eventsInternalBuffer.SelectMany((byte[] ba) => ba).ToArray());
					currentBufferSize = 0;
					eventsInternalBuffer.Clear();
				}
				eventsInternalBuffer.Add(workItemBytes);
				currentBufferSize += workItemSize;
			}
			else
			{
				batchedEvents.Add(workItemBytes);
				totalEvents++;
			}
		}
		int remainingBufferCount = eventsInternalBuffer.Count;
		if (remainingBufferCount > 0)
		{
			totalEvents += remainingBufferCount;
			batchedEvents.Add(eventsInternalBuffer.SelectMany((byte[] ba) => ba).ToArray());
		}
		if (batchedEvents.Count == 0)
		{
			return;
		}
		try
		{
			ProcessBatch(batchedEvents, totalEvents);
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Logger.Error(() => $"Error while preparing batched events for Firehose : {ex}");
		}
	}

	private void ProcessBatch(List<byte[]> batchedItems, int totalEvents)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		_Logger.Info(() => $"Total events published : {totalEvents}");
		_Logger.Info(() => string.Join("\n", batchedItems.Select((byte[] e) => $"Batched Event published: size - {e.Length} \n {Encoding.Default.GetString(e)}").ToArray()));
		try
		{
			PutRecordBatchRequest putRecordBatchRequest = new PutRecordBatchRequest
			{
				DeliveryStreamName = _Config.AwsKinesisFirehoseDeliveryStreamName,
				Records = ((IEnumerable<byte[]>)batchedItems).Select((Func<byte[], Record>)((byte[] e) => new Record
				{
					Data = new MemoryStream(e)
				})).ToList()
			};
			Stopwatch stopwatch = Stopwatch.StartNew();
			_AmazonKinesisFirehoseClient.PutRecordBatchAsync(putRecordBatchRequest, default(CancellationToken)).ContinueWith(delegate(Task<PutRecordBatchResponse> t)
			{
				stopwatch.Stop();
				if (t.IsFaulted)
				{
					_Perfmon.ErrorsPerSecond.Increment();
					_Perfmon.TotalErrors.Increment();
					Exception ex4 = t.Exception;
					while (ex4 is AggregateException && ex4.InnerException != null)
					{
						ex4 = ex4.InnerException;
					}
					_Logger.Error(() => $"Error in sending batched events to Firehose: {ex4}");
				}
				else
				{
					_Perfmon.MessagesSentPerSecond.IncrementBy(totalEvents);
					_Perfmon.TotalMessagesSent.IncrementBy(totalEvents);
					_Perfmon.BatchSendsPerSecond.Increment();
					_Perfmon.BatchSendAverageDuration.Sample(stopwatch.ElapsedTicks * 1000);
					_Perfmon.BatchSendAverageDurationBase.Increment();
				}
			});
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Perfmon.ErrorsPerSecond.Increment();
			_Perfmon.TotalErrors.Increment();
			_Logger.Error(() => $"Error in sending batched events to Firehose: {ex}");
		}
	}

	private IAmazonKinesisFirehose CreateRobloxFirehoseClient(AmazonKinesisFirehoseBatchEventSenderConfig config, RobloxFirehoseClientDefaultSettings defaultSettings)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(config.AwsAccessKey, config.AwsSecretKey);
		RobloxFirehoseClientConfig robloxFirehoseClientConfig = new RobloxFirehoseClientConfig(config.AwsKinesisFirehoseDeliveryStreamName);
		((ClientConfig)robloxFirehoseClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxFirehoseClientConfig).RegionEndpoint = config.AwsRegionEndpoint ?? RegionEndpoint.GetBySystemName(Settings.Default.FirehoseBatchEventSenderDefaultAwsRegionEndpoint);
		robloxFirehoseClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxFirehoseClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxFirehoseClientConfig clientConfig = robloxFirehoseClientConfig;
		clientConfig.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		clientConfig.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		clientConfig.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)clientConfig).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)clientConfig).Timeout = defaultSettings.RequestTimeout;
		return _FirehoseClientFactory.Create((AWSCredentials)(object)credentials, clientConfig);
	}

	private void InitSettingsMonitors()
	{
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DefaultMaxMessagesPerBatchRequest), (Action)InitWorkerSettings);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DefaultMaxBufferSize), (Action)InitWorkerSettings);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DefaultMaxTimeoutPerMessage), (Action)InitWorkerSettings);
		Settings.Default.MonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.FirehoseBatchEventSenderDefaultAwsRegionEndpoint), (Action)delegate
		{
			RebuildFirehoseClientOnSettingsChange(_FirehoseClientFactory.GetDefaultSettings());
		});
	}

	private void RebuildFirehoseClientOnSettingsChange(RobloxFirehoseClientDefaultSettings updatedDefaultSettings)
	{
		try
		{
			_AmazonKinesisFirehoseClient = CreateRobloxFirehoseClient(_Config, updatedDefaultSettings);
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Logger.Error(() => $"Fatal exception: Error on attempt to recreate Firehose client on settings update: {ex}");
		}
	}

	private void InitWorkerSettings()
	{
		_MaxBufferSize = _Config.MaxBufferSize ?? Settings.Default.DefaultMaxBufferSize;
		_MaxMessagesPerBatchRequest = _Config.MaxMessagesPerBatchRequest ?? Settings.Default.DefaultMaxMessagesPerBatchRequest;
		_MaxTimeoutPerMessage = _Config.MaxTimeoutPerMessage ?? Settings.Default.DefaultMaxTimeoutPerMessage;
	}

	private static void ValidateConfig(AmazonKinesisFirehoseBatchEventSenderConfig config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		if (string.IsNullOrWhiteSpace(config.AwsAccessKey))
		{
			throw new ArgumentException("Must be a non-empty string.", string.Format("{0}.{1}", "config", "AwsAccessKey"));
		}
		if (string.IsNullOrWhiteSpace(config.AwsSecretKey))
		{
			throw new ArgumentException("Must be a non-empty string.", string.Format("{0}.{1}", "config", "AwsSecretKey"));
		}
		if (string.IsNullOrWhiteSpace(config.AwsKinesisFirehoseDeliveryStreamName))
		{
			throw new ArgumentException("Must be a non-empty string.", string.Format("{0}.{1}", "config", "AwsKinesisFirehoseDeliveryStreamName"));
		}
		if (config.MaxBufferSize.HasValue && config.MaxBufferSize.Value <= 0)
		{
			throw new ArgumentException("Has to be bigger than 0.", string.Format("{0}.{1}", "config", "MaxBufferSize"));
		}
		if (config.MaxMessagesPerBatchRequest.HasValue && config.MaxMessagesPerBatchRequest.Value <= 0)
		{
			throw new ArgumentException("Has to be bigger than 0.", string.Format("{0}.{1}", "config", "MaxMessagesPerBatchRequest"));
		}
		if (config.MaxTimeoutPerMessage.HasValue && config.MaxTimeoutPerMessage.Value <= 0)
		{
			throw new ArgumentException("Has to be bigger than 0.", string.Format("{0}.{1}", "config", "MaxTimeoutPerMessage"));
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
			if (_FirehoseClientFactory != null)
			{
				_FirehoseClientFactory.DefaultClientSettingsChanged -= RebuildFirehoseClientOnSettingsChange;
			}
			_Disposed = true;
		}
	}
}
