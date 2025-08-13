using System;
using Amazon.DAX;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Roblox.Amazon.Core;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Our wrapper around the <see cref="T:Amazon.DAX.AmazonDAXClient" /> - provides additional circuit breaking.
/// </summary>
public class RobloxDaxClient : AmazonDAXClient
{
	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClient" />.
	/// </summary>
	/// <param name="credentials">The <see cref="T:Amazon.Runtime.AWSCredentials" /> to use.</param>
	/// <param name="daxClientConfig">The <see cref="!:RobloxDaxClusterClientConfig" /> to use</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="credentials" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="daxClientConfig" /></exception>
	public RobloxDaxClient(AWSCredentials credentials, RobloxDaxClientConfig daxClientConfig)
		: base(credentials, (AmazonDAXConfig)(object)daxClientConfig)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (daxClientConfig == null)
		{
			throw new ArgumentNullException("daxClientConfig");
		}
	}

	/// <inheritdoc />
	/// <remarks>This logic is replicated in all clients inheriting from <see cref="T:Amazon.Runtime.AmazonServiceClient" /></remarks>
	protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
	{
		if (!(((AmazonServiceClient)this).Config is RobloxDaxClientConfig robloxDynamoDbClientConfig))
		{
			throw new ArgumentException("Configuration cannot be converted to RobloxDaxClientConfig.");
		}
		((AmazonServiceClient)this).CustomizeRuntimePipeline(pipeline);
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
