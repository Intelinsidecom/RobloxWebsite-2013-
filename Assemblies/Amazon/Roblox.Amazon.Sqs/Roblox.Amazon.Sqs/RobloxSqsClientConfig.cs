using System;
using Amazon.SQS;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Configuration for <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClient" />
/// </summary>
public sealed class RobloxSqsClientConfig : AmazonSQSConfig
{
	/// <summary>
	/// Gets the circuit breaker policy configuration.
	/// Default value is ConsecutiveCircuitBreakerPolicyConfig with properties initialized from settings.
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
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientConfig" /> class.
	/// </summary>
	/// <param name="clientInstanceName">Name of the client instance. 
	/// Examples: BadgeAwardsRepository, PlatformChat, etc.
	/// Data Storage prefix will be added automatically.
	/// </param>
	/// <exception cref="T:System.ArgumentException">Cannot be null or empty or whitespaces. - clientInstanceName</exception>
	public RobloxSqsClientConfig(string clientInstanceName)
	{
		if (string.IsNullOrWhiteSpace(clientInstanceName))
		{
			throw new ArgumentException("Cannot be null or empty or whitespaces.", "clientInstanceName");
		}
		ClientInstanceName = clientInstanceName;
	}
}
