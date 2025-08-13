using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.SQS;
using Roblox.Amazon.Core;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// AmazonSQSClient extended with configurable circuit breaker and async invoke timeout handlers. 
/// </summary>
internal sealed class RobloxSqsClient : AmazonSQSClient
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClient" /> class.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	public RobloxSqsClient(AWSCredentials credentials, RobloxSqsClientConfig config)
		: base(credentials, (AmazonSQSConfig)(object)config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
	}

	/// <inheritdoc />
	protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
	{
		if (!(((AmazonServiceClient)this).Config is RobloxSqsClientConfig robloxSqsClientConfig))
		{
			throw new ArgumentException("Configuration cannot be converted to RobloxSqsClientConfig.");
		}
		((AmazonSQSClient)this).CustomizeRuntimePipeline(pipeline);
		if (robloxSqsClientConfig.IsAsyncRequestTimeoutEnabled && ((ClientConfig)robloxSqsClientConfig).Timeout.HasValue)
		{
			AsyncInvokeTimeoutHandler asyncInvokeTimeoutHandler = new AsyncInvokeTimeoutHandler(new AsyncInvokeTimeoutHandlerConfig(((ClientConfig)robloxSqsClientConfig).Timeout.Value));
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)asyncInvokeTimeoutHandler);
		}
		if (robloxSqsClientConfig.IsCircuitBreakerEnabled)
		{
			DefaultTripReasonAuthority tripReasonAuthority = new DefaultTripReasonAuthority();
			DefaultCircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext>($"{RobloxAwsClientType.Sqs}_{robloxSqsClientConfig.ClientInstanceName}", robloxSqsClientConfig.CircuitBreakerPolicyConfig, tripReasonAuthority);
			new AwsCircuitBreakerPolicyMetricsEventHandler().RegisterEvents(circuitBreakerPolicy, robloxSqsClientConfig.ClientInstanceName, RobloxAwsClientType.Sqs);
			CircuitBreakerHandler circuitBreakerHandler = new CircuitBreakerHandler(circuitBreakerPolicy);
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)circuitBreakerHandler);
		}
	}
}
