using System;
using System.Linq.Expressions;
using Amazon;
using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Roblox.Amazon.Sns.Properties;
using Roblox.Configuration;

namespace Roblox.Amazon.Sns;

/// <summary>
/// Creates clients for Amazon SNS.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.Sns.IRobloxSnsClientFactory" />
public sealed class RobloxSnsClientFactory : IRobloxSnsClientFactory
{
	private static readonly Lazy<RobloxSnsClientFactory> _Instance = new Lazy<RobloxSnsClientFactory>(() => new RobloxSnsClientFactory());

	private RobloxSnsClientDefaultSettings _CurrentDefaultSettings;

	/// <summary>
	/// Gets the instance of <see cref="T:Roblox.Amazon.Sns.RobloxSnsClientFactory" />.
	/// </summary>
	public static RobloxSnsClientFactory Instance => _Instance.Value;

	/// <inheritdoc cref="E:Roblox.Amazon.Sns.IRobloxSnsClientFactory.DefaultClientSettingsChanged" />
	public event Action<RobloxSnsClientDefaultSettings> DefaultClientSettingsChanged;

	private RobloxSnsClientFactory()
	{
		_CurrentDefaultSettings = GetDefaultSettingsFromSource();
		InitSettingsMonitors();
	}

	/// <summary>
	/// Creates Amazon SNS client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	public IAmazonSimpleNotificationService Create(AWSCredentials credentials, RobloxSnsClientConfig config)
	{
		return (IAmazonSimpleNotificationService)(object)new RobloxSnsClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon SNS client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.
	/// (required for performance counters creation)</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	public IAmazonSimpleNotificationService Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName)
	{
		RobloxSnsClientDefaultSettings defaultSettings = GetDefaultSettings();
		RobloxSnsClientConfig robloxSnsClientConfig = new RobloxSnsClientConfig(clientInstanceName);
		((ClientConfig)robloxSnsClientConfig).MaxErrorRetry = defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxSnsClientConfig).RegionEndpoint = endpoint;
		robloxSnsClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxSnsClientConfig).ThrottleRetries = defaultSettings.IsThrottleRetriesEnabled;
		RobloxSnsClientConfig config = robloxSnsClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = defaultSettings.RequestTimeout;
		return (IAmazonSimpleNotificationService)(object)new RobloxSnsClient(credentials, config);
	}

	/// <summary>
	/// Creates Amazon SNS client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	public IAmazonSimpleNotificationService Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, endpoint, clientInstanceName);
	}

	/// <summary>
	/// Creates Amazon SNS client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Sns.RobloxSnsClientConfig" />.</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	public IAmazonSimpleNotificationService Create(string awsAccessKey, string awsSecretKey, RobloxSnsClientConfig config)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		BasicAWSCredentials credentials = new BasicAWSCredentials(awsAccessKey, awsSecretKey);
		return Create((AWSCredentials)(object)credentials, config);
	}

	/// <inheritdoc cref="M:Roblox.Amazon.Sns.IRobloxSnsClientFactory.GetDefaultSettings" />
	public RobloxSnsClientDefaultSettings GetDefaultSettings()
	{
		return _CurrentDefaultSettings;
	}

	/// <summary>
	/// Gets the default settings from source.
	/// </summary>
	private static RobloxSnsClientDefaultSettings GetDefaultSettingsFromSource()
	{
		return new RobloxSnsClientDefaultSettings(Settings.Default.IsSnsClientCircuitBreakerEnabledByDefault, Settings.Default.IsSnsClientAsyncRequestTimeoutEnabledByDefault, Settings.Default.IsSnsClientThrottleRetriesEnabled, Settings.Default.SnsClientDefaultRequestTimeout, Settings.Default.SnsClientDefaultReadWriteTimeout, Settings.Default.SnsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip, Settings.Default.SnsClientDefaultCircuitBreakerRetryInterval, Settings.Default.SnsClientDefaultMaxErrorRetry);
	}

	private void InitSettingsMonitors()
	{
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.SnsClientDefaultMaxErrorRetry), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSnsClientCircuitBreakerEnabledByDefault), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SnsClientDefaultCircuitBreakerRetryInterval), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.SnsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SnsClientDefaultReadWriteTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.SnsClientDefaultRequestTimeout), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSnsClientThrottleRetriesEnabled), (Action)OnDefaultSettingsChanged);
		Settings.Default.MonitorChanges<Settings, bool>((Expression<Func<Settings, bool>>)((Settings s) => s.IsSnsClientAsyncRequestTimeoutEnabledByDefault), (Action)OnDefaultSettingsChanged);
	}

	private void OnDefaultSettingsChanged()
	{
		RobloxSnsClientDefaultSettings changedSettings = GetDefaultSettingsFromSource();
		if (!_CurrentDefaultSettings.Equals(changedSettings))
		{
			_CurrentDefaultSettings = changedSettings;
			this.DefaultClientSettingsChanged?.Invoke(GetDefaultSettings());
		}
	}
}
