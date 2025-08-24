using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.SimpleNotificationService.Model;
using Newtonsoft.Json;
using Roblox.Amazon.Sns.Properties;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sns;

/// <inheritdoc cref="T:Roblox.Amazon.Sns.ISnsPublisher" />
public class SnsPublisher : ISnsPublisher, IDisposable
{
	private readonly SnsPublisherConfig _PublisherConfig;

	private readonly IRobloxSnsClientFactory _SnsClientFactory;

	private SnsRegionPublisher _PrimarySnsPublisher;

	private List<SnsRegionPublisher> _BackupSnsPublishers;

	private const string _TotalPerformanceCategoryName = "Roblox.Amazon.SnsPublisher.TotalsV1";

	private const string _PerTopicCategoryName = "Roblox.Amazon.SnsPublisher.ByTopicV1";

	private bool _Disposed;

	internal readonly PerInstancePerformanceMonitor TotalPerformanceMonitor;

	/// <summary>
	/// Occurs when an SNS message fails to publish.
	/// </summary>
	public event Action<Exception, string> SnsError;

	/// <summary>
	/// Occurs when an SNS message successfully publish.
	/// </summary>
	public event Action<string> SnsPublished;

	/// <summary>
	/// Occurs when an exception is thrown during publishers rebuild.
	/// </summary>
	public event Action<Exception> ErrorOnPublishersRebuildOccurred;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sns.SnsPublisher" /> class.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="primaryRegionEndpoint">The primary region endpoint.</param>
	/// <param name="snsTopicArn">The SNS topic arn.</param>
	/// <param name="perfmonInstanceName">The performance monitor category.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	public SnsPublisher(string awsAccessKey, string awsSecretKey, RegionEndpoint primaryRegionEndpoint, string snsTopicArn, string perfmonInstanceName, ICounterRegistry counterRegistry)
		: this(new SnsPublisherConfig(awsAccessKey, awsSecretKey, primaryRegionEndpoint, snsTopicArn, perfmonInstanceName), counterRegistry)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sns.SnsPublisher" /> class.
	/// </summary>
	/// <param name="config">The SNS publisher configuration <see cref="T:Roblox.Amazon.Sns.SnsPublisherConfig" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <exception cref="T:System.ArgumentNullException">snsPublisherConfig
	/// or
	/// snsPublisherConfig.PrimaryRegionEndpoint</exception>
	/// <exception cref="T:System.ArgumentException">Must be a non-empty string. - snsPublisherConfig.AwsAccessKey
	/// or
	/// Must be a non-empty string. - snsPublisherConfig.AwsSecretKey
	/// or
	/// Must be a non-empty string. - snsPublisherConfig.PrimarySnsTopicArn
	/// or
	/// Must be a non-empty string. - snsPublisherConfig.PerfmonInstanceName</exception>
	public SnsPublisher(SnsPublisherConfig config, ICounterRegistry counterRegistry)
	{
		ValidateConfig(config);
		_PublisherConfig = config;
		_SnsClientFactory = RobloxSnsClientFactory.Instance;
		TotalPerformanceMonitor = new PerInstancePerformanceMonitor(counterRegistry, "Roblox.Amazon.SnsPublisher.TotalsV1", "Roblox.Amazon.SnsPublisher.ByTopicV1", config.PerfmonInstanceName);
		RobloxSnsClientDefaultSettings defaultClientSettings = _SnsClientFactory.GetDefaultSettings();
		_PrimarySnsPublisher = CreateSnsRegionPublisher(_PublisherConfig, defaultClientSettings);
		_BackupSnsPublishers = BuildBackupSnsRegionPublishers(_PublisherConfig, defaultClientSettings);
		_SnsClientFactory.DefaultClientSettingsChanged += RebuildClientsOnSettingsChange;
	}

	/// <inheritdoc cref="M:Roblox.Amazon.Sns.ISnsPublisher.Publish(System.Object)" />
	public void Publish(object message)
	{
		PublishRequestWithRetries publishRequestWithRetries = new PublishRequestWithRetries(JsonConvert.SerializeObject(message), backupSnsClients: new Queue<SnsRegionPublisher>(_BackupSnsPublishers), numberOfRetries: Settings.Default.TotalNumberOfRetryAttemptsPerRegion, snsClient: _PrimarySnsPublisher, totalPerformanceMonitor: TotalPerformanceMonitor);
		Publish(publishRequestWithRetries);
	}

	private void Publish(PublishRequestWithRetries publishRequestWithRetries)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Stopwatch sw = Stopwatch.StartNew();
		string topicArn = publishRequestWithRetries.SnsRegionPublisher.SnsTopicArn;
		string message = publishRequestWithRetries.Message;
		PublishRequest publishRequest = new PublishRequest(topicArn, message);
		Task publishResponse = publishRequestWithRetries.PublishAsync(publishRequest, CancellationToken.None);
		try
		{
			publishResponse.ContinueWith(delegate(Task task)
			{
				try
				{
					sw.Stop();
					long elapsedMilliseconds = sw.ElapsedMilliseconds;
					if (task.IsFaulted)
					{
						publishRequestWithRetries.LogFailedRequest(elapsedMilliseconds);
						Exception ex2 = task.Exception;
						while (ex2 is AggregateException && ex2.InnerException != null)
						{
							ex2 = ex2.InnerException;
						}
						Republish(publishRequestWithRetries, publishRequest, ex2);
					}
					else if (task.IsCanceled)
					{
						publishRequestWithRetries.LogCancelledRequest(elapsedMilliseconds);
						Republish(publishRequestWithRetries, publishRequest, null);
					}
					else
					{
						publishRequestWithRetries.TotalTimer.Stop();
						long elapsedMilliseconds2 = publishRequestWithRetries.TotalTimer.ElapsedMilliseconds;
						publishRequestWithRetries.LogSuccessfulPublish(elapsedMilliseconds, elapsedMilliseconds2);
						this.SnsPublished?.Invoke(publishRequest.Message);
					}
				}
				catch (Exception arg)
				{
					publishRequestWithRetries.LogCompletePublishFailure(publishRequestWithRetries.TotalTimer.ElapsedMilliseconds);
					this.SnsError?.Invoke(arg, publishRequestWithRetries.Message);
				}
				finally
				{
					publishRequestWithRetries.CleanUpRunningRequestsCount();
				}
			});
		}
		catch (Exception ex)
		{
			publishRequestWithRetries.CleanUpRunningRequestsCount();
			this.SnsError?.Invoke(ex, publishRequestWithRetries.Message);
		}
	}

	private void Republish(PublishRequestWithRetries publishRequestWithRetries, PublishRequest publishRequest, Exception ex)
	{
		try
		{
			if (publishRequestWithRetries.TotalNumberOfAttemptsLeft > 0)
			{
				publishRequestWithRetries.LogRepublishRequest();
				publishRequestWithRetries.TotalNumberOfAttemptsLeft--;
				Publish(publishRequestWithRetries);
			}
			else if (publishRequestWithRetries.BackupSnsRegionPublishers.Any())
			{
				publishRequestWithRetries.LogSwitchToDifferentRegion();
				SnsRegionPublisher newPrimarySnsRegionPublisher = publishRequestWithRetries.BackupSnsRegionPublishers.Dequeue();
				publishRequestWithRetries.SnsRegionPublisher = newPrimarySnsRegionPublisher;
				publishRequestWithRetries.TotalNumberOfAttemptsLeft = Settings.Default.TotalNumberOfRetryAttemptsPerRegion;
				Publish(publishRequestWithRetries);
			}
			else
			{
				publishRequestWithRetries.LogCompletePublishFailure(publishRequestWithRetries.TotalTimer.ElapsedMilliseconds);
				this.SnsError?.Invoke(ex, publishRequest.Message);
			}
		}
		catch (Exception e)
		{
			this.SnsError?.Invoke(e, publishRequest.Message);
		}
	}

	private List<SnsRegionPublisher> BuildBackupSnsRegionPublishers(SnsPublisherConfig config, RobloxSnsClientDefaultSettings defaultClientSettings)
	{
		List<SnsRegionPublisher> backupSnsClients = new List<SnsRegionPublisher>();
		if (!string.IsNullOrWhiteSpace(Settings.Default.BackupRegionEndpointsCSV))
		{
			return backupSnsClients;
		}
		string snsTopicReplaceTarget = $"arn:aws:sns:{config.AwsPrimaryRegionEndpoint.SystemName}:";
		string[] array = Settings.Default.BackupRegionEndpointsCSV.Split(new char[1] { ',' });
		foreach (string backupRegionEndpointName in array)
		{
			foreach (RegionEndpoint regionEndpoint in RegionEndpoint.EnumerableAllRegions)
			{
				if (backupRegionEndpointName == regionEndpoint.SystemName)
				{
					string snsTopicReplacement = $"arn:aws:sns:{regionEndpoint.SystemName}:";
					string snsTopicArn = config.AwsPrimarySnsTopicArn.Replace(snsTopicReplaceTarget, snsTopicReplacement);
					SnsRegionPublisher snsRegionPublisher = CreateSnsRegionPublisher(config, defaultClientSettings, snsTopicArn, regionEndpoint);
					backupSnsClients.Add(snsRegionPublisher);
					break;
				}
			}
		}
		return backupSnsClients;
	}

	/// <summary>
	/// Initializes the new instance of <see cref="T:Roblox.Amazon.Sns.SnsRegionPublisher" />.
	/// </summary>
	/// <param name="publisherConfig">The publisher configuration.</param>
	/// <param name="defaultSettings">The default settings.</param>
	/// <param name="snsTopicArn">The SNS topic arn.
	/// (optional, PrimarySnsTopicArn property value of <paramref name="publisherConfig" />
	/// will be used when <paramref name="snsTopicArn" /> is not specified).</param>
	/// <param name="regionEndpoint">The region endpoint.
	/// (optional, PrimaryRegionEndpoint property value of <paramref name="publisherConfig" />
	/// will be used when <paramref name="regionEndpoint" /> is not specified).</param>
	/// <returns>
	///   <see cref="T:Roblox.Amazon.Sns.SnsRegionPublisher" />
	/// </returns>
	private SnsRegionPublisher CreateSnsRegionPublisher(SnsPublisherConfig publisherConfig, RobloxSnsClientDefaultSettings defaultSettings, string snsTopicArn = null, RegionEndpoint regionEndpoint = null)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		RobloxSnsClientConfig robloxSnsClientConfig = new RobloxSnsClientConfig(publisherConfig.PerfmonInstanceName);
		((ClientConfig)robloxSnsClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxSnsClientConfig).RegionEndpoint = regionEndpoint ?? publisherConfig.AwsPrimaryRegionEndpoint;
		robloxSnsClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxSnsClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxSnsClientConfig config = robloxSnsClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = defaultSettings.RequestTimeout;
		BasicAWSCredentials credentials = new BasicAWSCredentials(publisherConfig.AwsAccessKey, publisherConfig.AwsSecretKey);
		return new SnsRegionPublisher(_SnsClientFactory.Create((AWSCredentials)(object)credentials, config), snsTopicArn ?? publisherConfig.AwsPrimarySnsTopicArn, regionEndpoint ?? publisherConfig.AwsPrimaryRegionEndpoint);
	}

	private static void ValidateConfig(SnsPublisherConfig config)
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
		if (string.IsNullOrWhiteSpace(config.AwsPrimarySnsTopicArn))
		{
			throw new ArgumentException("Must be a non-empty string.", string.Format("{0}.{1}", "config", "AwsPrimarySnsTopicArn"));
		}
		if (string.IsNullOrWhiteSpace(config.PerfmonInstanceName))
		{
			throw new ArgumentException("Must be a non-empty string.", string.Format("{0}.{1}", "config", "PerfmonInstanceName"));
		}
		if (config.AwsPrimaryRegionEndpoint == null)
		{
			throw new ArgumentNullException(string.Format("{0}.{1}", "config", "PerfmonInstanceName"));
		}
	}

	private void RebuildClientsOnSettingsChange(RobloxSnsClientDefaultSettings updatedDefaultSettings)
	{
		try
		{
			_PrimarySnsPublisher = CreateSnsRegionPublisher(_PublisherConfig, updatedDefaultSettings);
			_BackupSnsPublishers = BuildBackupSnsRegionPublishers(_PublisherConfig, updatedDefaultSettings);
		}
		catch (Exception ex)
		{
			this.ErrorOnPublishersRebuildOccurred?.Invoke(new Exception($"Fatal exception: SNS publishers creation is failed on client settings update. Ex: {ex}."));
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
			if (_SnsClientFactory != null)
			{
				_SnsClientFactory.DefaultClientSettingsChanged -= RebuildClientsOnSettingsChange;
			}
			_Disposed = true;
		}
	}
}
