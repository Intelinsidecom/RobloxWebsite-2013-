using System;
using System.Linq.Expressions;
using Amazon;
using Amazon.KinesisFirehose;
using Amazon.Runtime;
using Roblox.Amazon.Firehose.Properties;
using Roblox.Configuration;

namespace Roblox.Amazon.Firehose;

/// <summary>
/// Creates clients for Amazon KinesisFirehose.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.Firehose.IRobloxFirehoseClientFactory" />
public sealed class RobloxFirehoseClientFactory : IRobloxFirehoseClientFactory
{
	private static readonly Lazy<IRobloxFirehoseClientFactory> _Instance = new Lazy<IRobloxFirehoseClientFactory>(() => new RobloxFirehoseClientFactory());

	private RobloxFirehoseClientDefaultSettings _CurrentDefaultSettings;

	/// <summary>
	/// Gets the instance of <see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClientFactory" />.
	/// </summary>
	public static IRobloxFirehoseClientFactory Instance => _Instance.Value;

	/// <inheritdoc cref="E:Roblox.Amazon.Firehose.IRobloxFirehoseClientFactory.DefaultClientSettingsChanged" />
	public event Action<RobloxFirehoseClientDefaultSettings> DefaultClientSettingsChanged;

	private RobloxFirehoseClientFactory()
	{
		_CurrentDefaultSettings = GetDefaultSettingsFromSource();
		InitSettingsMonitors();
	}

	/// <summary>
	/// Creates Amazon KinesisFirehose client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	public IAmazonKinesisFirehose Create(AWSCredentials credentials, RobloxFirehoseClientConfig config)
	{
		return (IAmazonKinesisFirehose)(object)new RobloxFirehoseClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon KinesisFirehose client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.
	/// (required for performance counters creation)</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	public IAmazonKinesisFirehose Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName)
	{
		RobloxFirehoseClientDefaultSettings defaultSettings = GetDefaultSettings();
		RobloxFirehoseClientConfig robloxFirehoseClientConfig = new RobloxFirehoseClientConfig(clientInstanceName);
		((ClientConfig)robloxFirehoseClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxFirehoseClientConfig).RegionEndpoint = endpoint;
		robloxFirehoseClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxFirehoseClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxFirehoseClientConfig config = robloxFirehoseClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = defaultSettings.RequestTimeout;
		return Create(credentials, config);
	}

	/// <summary>
	/// Creates Amazon KinesisFirehose client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	public IAmazonKinesisFirehose Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, endpoint, clientInstanceName);
	}

	/// <summary>
	/// Creates Amazon KinesisFirehose client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClientConfig" />.</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	public IAmazonKinesisFirehose Create(string awsAccessKey, string awsSecretKey, RobloxFirehoseClientConfig config)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, config);
	}

	/// <inheritdoc cref="M:Roblox.Amazon.Firehose.IRobloxFirehoseClientFactory.GetDefaultSettings" />
	public RobloxFirehoseClientDefaultSettings GetDefaultSettings()
	{
		return _CurrentDefaultSettings;
	}

	/// <summary>
	/// Gets the default settings from source.
	/// </summary>
	private static RobloxFirehoseClientDefaultSettings GetDefaultSettingsFromSource()
	{
		return new RobloxFirehoseClientDefaultSettings(Settings.Default.IsFirehoseClientCircuitBreakerEnabledByDefault, Settings.Default.IsFirehoseClientAsyncRequestTimeoutEnabledByDefault, Settings.Default.IsFirehoseClientThrottleRetriesEnabled, Settings.Default.FirehoseClientDefaultRequestTimeout, Settings.Default.FirehoseClientDefaultReadWriteTimeout, Settings.Default.FirehoseClientDefaultFailuresAllowedBeforeCircuitBreakerTrip, Settings.Default.FirehoseClientDefaultCircuitBreakerRetryInterval, Settings.Default.FirehoseClientDefaultMaxErrorRetry);
	}

	private void InitSettingsMonitors()
	{
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.FirehoseClientDefaultMaxErrorRetry), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsFirehoseClientCircuitBreakerEnabledByDefault), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.FirehoseClientDefaultCircuitBreakerRetryInterval), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.FirehoseClientDefaultFailuresAllowedBeforeCircuitBreakerTrip), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.FirehoseClientDefaultReadWriteTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.FirehoseClientDefaultRequestTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsFirehoseClientThrottleRetriesEnabled), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.FirehoseBatchEventSenderDefaultAwsRegionEndpoint), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsFirehoseClientAsyncRequestTimeoutEnabledByDefault), (Action)OnDefaultSettingsChanged);
	}

	private void OnDefaultSettingsChanged()
	{
		RobloxFirehoseClientDefaultSettings changedSettings = GetDefaultSettingsFromSource();
		if (!_CurrentDefaultSettings.Equals(changedSettings))
		{
			_CurrentDefaultSettings = changedSettings;
			this.DefaultClientSettingsChanged?.Invoke(GetDefaultSettings());
		}
	}
}
