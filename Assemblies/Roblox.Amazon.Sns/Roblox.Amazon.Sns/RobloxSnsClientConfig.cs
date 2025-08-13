using System;
using Amazon.SimpleNotificationService;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Sns;

/// <summary>
/// Configuration for <see cref="T:Roblox.Amazon.Sns.RobloxSnsClient" />
/// </summary>
public sealed class RobloxSnsClientConfig : AmazonSimpleNotificationServiceConfig
{
	/// <summary>
	/// Gets the circuit breaker policy configuration.
	/// Default value is ConsecutiveCircuitBreakerPolicyConfig with properties intialized from settings.
	/// </summary>
	public DefaultCircuitBreakerPolicyConfig CircuitBreakerPolicyConfig { get; } = new DefaultCircuitBreakerPolicyConfig();


	/// <summary>
	/// Gets the name of the client instance.
	/// </summary>
	public string ClientInstanceName { get; }

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
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sns.RobloxSnsClientConfig" /> class.
	/// </summary>
	/// <param name="clientInstanceName">Name of the client instance.
	/// Examples: BadgeAwardsRepository, PlatformChat, etc.
	/// Data Storage prefix will be added automatically.
	/// </param>
	/// <exception cref="T:System.ArgumentException">Cannot be null or empty or whitespaces. - clientInstanceName</exception>
	public RobloxSnsClientConfig(string clientInstanceName)
	{
		if (string.IsNullOrWhiteSpace(clientInstanceName))
		{
			throw new ArgumentException("Cannot be null or empty or whitespaces.", "clientInstanceName");
		}
		ClientInstanceName = clientInstanceName;
	}
}
