using System;
using System.Linq.Expressions;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Roblox.Amazon.Sqs.Properties;
using Roblox.Configuration;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Creates clients for Amazon Sqs.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.Sqs.IRobloxSqsClientFactory" />
public sealed class RobloxSqsClientFactory : IRobloxSqsClientFactory
{
	private static readonly Lazy<RobloxSqsClientFactory> _Instance = new Lazy<RobloxSqsClientFactory>(() => new RobloxSqsClientFactory());

	private RobloxSqsClientDefaultSettings _CurrentDefaultSettings;

	/// <summary>
	/// Gets the instance of <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientFactory" />.
	/// </summary>
	public static RobloxSqsClientFactory Instance => _Instance.Value;

	/// <inheritdoc cref="E:Roblox.Amazon.Sqs.IRobloxSqsClientFactory.DefaultClientSettingsChanged" />
	public event Action<RobloxSqsClientDefaultSettings> DefaultClientSettingsChanged;

	private RobloxSqsClientFactory()
	{
		_CurrentDefaultSettings = GetDefaultSettingsFromSource();
		InitSettingsMonitors();
	}

	/// <summary>
	/// Creates Amazon Sqs client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>
	/// Amazon Sqs client
	/// </returns>
	public IAmazonSQS Create(AWSCredentials credentials, RobloxSqsClientConfig config)
	{
		return (IAmazonSQS)(object)new RobloxSqsClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon Sqs client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.
	/// (required for performance counters creation)</param>
	/// <returns>
	/// Amazon Sqs client
	/// </returns>
	public IAmazonSQS Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName)
	{
		RobloxSqsClientDefaultSettings defaultSettings = GetDefaultSettings();
		RobloxSqsClientConfig robloxSqsClientConfig = new RobloxSqsClientConfig(clientInstanceName);
		((ClientConfig)robloxSqsClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxSqsClientConfig).RegionEndpoint = endpoint;
		robloxSqsClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxSqsClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxSqsClientConfig config = robloxSqsClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = defaultSettings.RequestTimeout;
		return (IAmazonSQS)(object)new RobloxSqsClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon Sqs client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonSQS Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, endpoint, clientInstanceName);
	}

	/// <summary>
	/// Creates Amazon Sqs client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientConfig" />.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonSQS Create(string awsAccessKey, string awsSecretKey, RobloxSqsClientConfig config)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, config);
	}

	/// <inheritdoc cref="M:Roblox.Amazon.Sqs.IRobloxSqsClientFactory.GetDefaultSettings" />
	public RobloxSqsClientDefaultSettings GetDefaultSettings()
	{
		return _CurrentDefaultSettings;
	}

	/// <summary>
	/// Gets the default settings from source.
	/// </summary>
	private static RobloxSqsClientDefaultSettings GetDefaultSettingsFromSource()
	{
		return new RobloxSqsClientDefaultSettings(Settings.Default.IsSqsClientCircuitBreakerEnabledByDefault, Settings.Default.IsSqsClientAsyncRequestTimeoutEnabledByDefault, Settings.Default.IsSqsClientThrottleRetriesEnabled, Settings.Default.SqsClientDefaultRequestTimeout, Settings.Default.SqsClientDefaultReadWriteTimeout, Settings.Default.SqsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip, Settings.Default.SqsClientDefaultCircuitBreakerRetryInterval, Settings.Default.SqsClientDefaultMaxErrorRetry);
	}

	private void InitSettingsMonitors()
	{
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.SqsClientDefaultMaxErrorRetry), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSqsClientCircuitBreakerEnabledByDefault), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SqsClientDefaultCircuitBreakerRetryInterval), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.SqsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SqsClientDefaultReadWriteTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SqsClientDefaultRequestTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSqsClientThrottleRetriesEnabled), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSqsClientAsyncRequestTimeoutEnabledByDefault), (Action)OnDefaultSettingsChanged);
	}

	private void OnDefaultSettingsChanged()
	{
		RobloxSqsClientDefaultSettings changedSettings = GetDefaultSettingsFromSource();
		if (!_CurrentDefaultSettings.Equals(changedSettings))
		{
			_CurrentDefaultSettings = changedSettings;
			this.DefaultClientSettingsChanged?.Invoke(GetDefaultSettings());
		}
	}
}
