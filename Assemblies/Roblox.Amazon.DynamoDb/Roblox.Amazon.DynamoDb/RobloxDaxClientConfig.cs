using System;
using Amazon.DAX;
using Amazon.Runtime;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Our wrapper extending the <see cref="T:Amazon.DAX.AmazonDAXConfig" /> to provide the configuration options for the extended <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClient" />.
/// </summary>
public class RobloxDaxClientConfig : AmazonDAXConfig
{
	/// <summary>
	/// Gets the name of the client instance.
	/// </summary>
	public string ClientInstanceName { get; }

	/// <summary>
	/// Gets the circuit breaker policy configuration.
	/// Default value is ConsecutiveCircuitBreakerPolicyConfig with properties initialized from settings.
	/// </summary>
	public DefaultCircuitBreakerPolicyConfig CircuitBreakerPolicyConfig { get; } = new DefaultCircuitBreakerPolicyConfig();


	/// <summary>
	/// Gets or sets a value indicating whether circuit breaker is enabled.
	/// Enabled by default.
	/// </summary>
	public bool IsCircuitBreakerEnabled { get; set; } = true;


	/// <summary>
	/// Gets or sets a value indicating whether asynchronous request timeout is enabled.
	/// Enabled by default.
	/// </summary>
	public bool IsAsyncRequestTimeoutEnabled { get; set; } = true;


	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientConfig" /> class.
	/// </summary>
	/// <param name="clientInstanceName">Name of the client instance.
	/// Examples: BadgeAwardsRepository, PlatformChat, etc.
	/// Data Storage prefix will be added automatically.
	/// </param>
	/// <exception cref="T:System.ArgumentException">Cannot be null or empty or whitespaces. - <paramref name="clientInstanceName" /></exception>
	public RobloxDaxClientConfig(string clientInstanceName)
	{
		if (string.IsNullOrWhiteSpace(clientInstanceName))
		{
			throw new ArgumentException("Cannot be null or empty or whitespaces.", "clientInstanceName");
		}
		ClientInstanceName = clientInstanceName;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientConfig" /> class.
	/// </summary>
	/// <param name="clientInstanceName">Name of the client instance.
	/// Examples: BadgeAwardsRepository, PlatformChat, etc.
	/// Data Storage prefix will be added automatically.
	/// </param>
	/// <param name="settings">The <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings" /> used to populate the config.</param>
	/// <exception cref="T:System.ArgumentException">Cannot be null or empty or whitespaces. - <paramref name="clientInstanceName" /></exception>
	internal RobloxDaxClientConfig(string clientInstanceName, RobloxDaxClientDefaultSettings settings)
		: this(clientInstanceName)
	{
		IsCircuitBreakerEnabled = settings.IsCircuitBreakerEnabled;
		((ClientConfig)this).MaxErrorRetry = settings.MaxErrorRetry;
		((ClientConfig)this).RegionEndpoint = settings.RegionEndpoint;
		((ClientConfig)this).ThrottleRetries = settings.IsThrottleRetriesEnabled;
		IsAsyncRequestTimeoutEnabled = settings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)this).ReadWriteTimeout = settings.ReadWriteTimeout;
		((ClientConfig)this).Timeout = settings.RequestTimeout;
		CircuitBreakerPolicyConfig.RetryInterval = settings.CircuitBreakerRetryInterval;
		CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = settings.FailuresAllowedBeforeCircuitBreakerTrip;
	}
}
