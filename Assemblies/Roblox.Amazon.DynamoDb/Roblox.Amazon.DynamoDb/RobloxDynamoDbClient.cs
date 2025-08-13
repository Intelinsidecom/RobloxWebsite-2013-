using System;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Roblox.Amazon.Core;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// AmazonDynamoDBClient client extended with configurable circuit breaker and async invoke timeout handlers. 
/// </summary>
public sealed class RobloxDynamoDbClient : AmazonDynamoDBClient
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClient" /> class.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <exception cref="T:System.ArgumentNullException">config</exception>
	public RobloxDynamoDbClient(AWSCredentials credentials, RobloxDynamoDbClientConfig config)
		: base(credentials, (AmazonDynamoDBConfig)(object)config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
	}

	/// <inheritdoc />
	protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
	{
		if (!(((AmazonServiceClient)this).Config is RobloxDynamoDbClientConfig robloxDynamoDbClientConfig))
		{
			throw new ArgumentException("Configuration cannot be converted to RobloxDynamoDbClientConfig.");
		}
		((AmazonDynamoDBClient)this).CustomizeRuntimePipeline(pipeline);
		if (robloxDynamoDbClientConfig.IsAsyncRequestTimeoutEnabled && ((ClientConfig)robloxDynamoDbClientConfig).Timeout.HasValue)
		{
			AsyncInvokeTimeoutHandler asyncInvokeTimeoutHandler = new AsyncInvokeTimeoutHandler(new AsyncInvokeTimeoutHandlerConfig(((ClientConfig)robloxDynamoDbClientConfig).Timeout.Value));
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)asyncInvokeTimeoutHandler);
		}
		if (robloxDynamoDbClientConfig.IsCircuitBreakerEnabled)
		{
			DefaultTripReasonAuthority tripReasonAuthority = new DefaultTripReasonAuthority();
			DefaultCircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext>($"{RobloxAwsClientType.DynamoDb}_{robloxDynamoDbClientConfig.ClientInstanceName}", robloxDynamoDbClientConfig.CircuitBreakerPolicyConfig, tripReasonAuthority);
			new AwsCircuitBreakerPolicyMetricsEventHandler().RegisterEvents(circuitBreakerPolicy, robloxDynamoDbClientConfig.ClientInstanceName, RobloxAwsClientType.DynamoDb);
			CircuitBreakerHandler circuitBreakerHandler = new CircuitBreakerHandler(circuitBreakerPolicy);
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)circuitBreakerHandler);
		}
	}
}
