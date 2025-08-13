using System;
using Amazon.KinesisFirehose;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Roblox.Amazon.Core;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Firehose;

/// <summary>
/// AmazonKinesisFirehoseClient extended with configurable circuit breaker and async invoke timeout handlers. 
/// </summary>
internal sealed class RobloxFirehoseClient : AmazonKinesisFirehoseClient
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClient" /> class.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <exception cref="T:System.ArgumentNullException">config</exception>
	public RobloxFirehoseClient(AWSCredentials credentials, RobloxFirehoseClientConfig config)
		: base(credentials, (AmazonKinesisFirehoseConfig)(object)config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
	}

	/// <inheritdoc />
	protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
	{
		if (!(((AmazonServiceClient)this).Config is RobloxFirehoseClientConfig robloxFirehoseClientConfig))
		{
			throw new ArgumentException("Configuration cannot be converted to RobloxDynamoDbClientConfig.");
		}
		((AmazonServiceClient)this).CustomizeRuntimePipeline(pipeline);
		if (robloxFirehoseClientConfig.IsAsyncRequestTimeoutEnabled && ((ClientConfig)robloxFirehoseClientConfig).Timeout.HasValue)
		{
			AsyncInvokeTimeoutHandler asyncInvokeTimeoutHandler = new AsyncInvokeTimeoutHandler(new AsyncInvokeTimeoutHandlerConfig(((ClientConfig)robloxFirehoseClientConfig).Timeout.Value));
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)asyncInvokeTimeoutHandler);
		}
		if (robloxFirehoseClientConfig.IsCircuitBreakerEnabled)
		{
			DefaultTripReasonAuthority tripReasonAuthority = new DefaultTripReasonAuthority();
			DefaultCircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext>($"{RobloxAwsClientType.Firehose}_{robloxFirehoseClientConfig.ClientInstanceName}", robloxFirehoseClientConfig.CircuitBreakerPolicyConfig, tripReasonAuthority);
			new AwsCircuitBreakerPolicyMetricsEventHandler().RegisterEvents(circuitBreakerPolicy, robloxFirehoseClientConfig.ClientInstanceName, RobloxAwsClientType.Firehose);
			CircuitBreakerHandler circuitBreakerHandler = new CircuitBreakerHandler(circuitBreakerPolicy);
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)circuitBreakerHandler);
		}
	}
}
