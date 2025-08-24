using System;
using System.Linq.Expressions;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Roblox.Amazon.DynamoDb.Properties;
using Roblox.Configuration;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Creates clients for Amazon DynamoDB.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IRobloxDynamoDbClientFactory" />
public sealed class RobloxDynamoDbClientFactory : IRobloxDynamoDbClientFactory
{
	private static readonly Lazy<IRobloxDynamoDbClientFactory> _Instance = new Lazy<IRobloxDynamoDbClientFactory>(() => new RobloxDynamoDbClientFactory());

	private RobloxDynamoDbClientDefaultSettings _CurrentDefaultSettings;

	/// <summary>
	/// Gets the instance of <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientFactory" />.
	/// </summary>
	public static IRobloxDynamoDbClientFactory Instance => _Instance.Value;

	/// <inheritdoc cref="E:Roblox.Amazon.DynamoDb.IRobloxDynamoDbClientFactory.DefaultClientSettingsChanged" />
	public event Action<RobloxDynamoDbClientDefaultSettings> DefaultClientSettingsChanged;

	private RobloxDynamoDbClientFactory()
	{
		_CurrentDefaultSettings = GetDefaultSettingsFromSource();
		InitSettingsMonitors();
	}

	/// <summary>
	/// Creates Amazon DynamoDB client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientConfig" />.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonDynamoDB Create(AWSCredentials credentials, RobloxDynamoDbClientConfig config)
	{
		return (IAmazonDynamoDB)(object)new RobloxDynamoDbClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon DynamoDB client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.
	/// (required for performance counters creation)</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonDynamoDB Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName)
	{
		RobloxDynamoDbClientDefaultSettings defaultSettings = GetDefaultSettings();
		RobloxDynamoDbClientConfig robloxDynamoDbClientConfig = new RobloxDynamoDbClientConfig(clientInstanceName);
		((ClientConfig)robloxDynamoDbClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxDynamoDbClientConfig).RegionEndpoint = endpoint;
		robloxDynamoDbClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxDynamoDbClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxDynamoDbClientConfig config = robloxDynamoDbClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = defaultSettings.RequestTimeout;
		return Create(credentials, config);
	}

	/// <summary>
	/// Creates Amazon DynamoDB client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonDynamoDB Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, endpoint, clientInstanceName);
	}

	/// <summary>
	/// Creates Amazon DynamoDB client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientConfig" />.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	public IAmazonDynamoDB Create(string awsAccessKey, string awsSecretKey, RobloxDynamoDbClientConfig config)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, config);
	}

	/// <inheritdoc cref="M:Roblox.Amazon.DynamoDb.IRobloxDynamoDbClientFactory.GetDefaultSettings" />
	public RobloxDynamoDbClientDefaultSettings GetDefaultSettings()
	{
		return _CurrentDefaultSettings;
	}

	/// <summary>
	/// Gets the default settings from source.
	/// </summary>
	private static RobloxDynamoDbClientDefaultSettings GetDefaultSettingsFromSource()
	{
		return new RobloxDynamoDbClientDefaultSettings(Settings.Default.IsDynamoClientCircuitBreakerEnabledByDefault, Settings.Default.IsDynamoClientAsyncRequestTimeoutEnabledByDefault, Settings.Default.IsDynamoClientThrottleRetriesEnabled, Settings.Default.DynamoClientDefaultRequestTimeout, Settings.Default.DynamoClientDefaultReadWriteTimeout, Settings.Default.DynamoClientDefaultFailuresAllowedBeforeCircuitBreakerTrip, Settings.Default.DynamoClientDefaultCircuitBreakerRetryInterval, Settings.Default.DynamoClientDefaultMaxErrorRetry);
	}

	private void InitSettingsMonitors()
	{
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DynamoClientDefaultMaxErrorRetry), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsDynamoClientCircuitBreakerEnabledByDefault), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.DynamoClientDefaultCircuitBreakerRetryInterval), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.DynamoClientDefaultFailuresAllowedBeforeCircuitBreakerTrip), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.DynamoClientDefaultReadWriteTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.DynamoClientDefaultRequestTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsDynamoClientThrottleRetriesEnabled), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsDynamoClientAsyncRequestTimeoutEnabledByDefault), (Action)OnDefaultSettingsChanged);
	}

	private void OnDefaultSettingsChanged()
	{
		RobloxDynamoDbClientDefaultSettings changedSettings = GetDefaultSettingsFromSource();
		if (!_CurrentDefaultSettings.Equals(changedSettings))
		{
			_CurrentDefaultSettings = changedSettings;
			this.DefaultClientSettingsChanged?.Invoke(GetDefaultSettings());
		}
	}
}
