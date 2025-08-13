using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.SimpleNotificationService;
using Roblox.Amazon.Core;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Sns;

/// <summary>
/// AmazonSimpleNotificationServiceClient extended with configurable circuit breaker and async invoke timeout handlers.
/// </summary>
internal sealed class RobloxSnsClient : AmazonSimpleNotificationServiceClient
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sns.RobloxSnsClient" /> class.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <exception cref="T:System.ArgumentNullException">config</exception>
	public RobloxSnsClient(AWSCredentials credentials, RobloxSnsClientConfig config)
		: base(credentials, (AmazonSimpleNotificationServiceConfig)(object)config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
	}

	/// <inheritdoc />
	protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
	{
		if (!(((AmazonServiceClient)this).Config is RobloxSnsClientConfig robloxSnsClientConfig))
		{
			throw new ArgumentException("Configuration cannot be converted to RobloxSnsClientConfig.");
		}
		((AmazonServiceClient)this).CustomizeRuntimePipeline(pipeline);
		if (robloxSnsClientConfig.IsAsyncRequestTimeoutEnabled && ((ClientConfig)robloxSnsClientConfig).Timeout.HasValue)
		{
			AsyncInvokeTimeoutHandler asyncInvokeTimeoutHandler = new AsyncInvokeTimeoutHandler(new AsyncInvokeTimeoutHandlerConfig(((ClientConfig)robloxSnsClientConfig).Timeout.Value));
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)asyncInvokeTimeoutHandler);
		}
		if (robloxSnsClientConfig.IsCircuitBreakerEnabled)
		{
			DefaultTripReasonAuthority tripReasonAuthority = new DefaultTripReasonAuthority();
			DefaultCircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext>($"{RobloxAwsClientType.Sns}_{robloxSnsClientConfig.ClientInstanceName}", robloxSnsClientConfig.CircuitBreakerPolicyConfig, tripReasonAuthority);
			new AwsCircuitBreakerPolicyMetricsEventHandler().RegisterEvents(circuitBreakerPolicy, robloxSnsClientConfig.ClientInstanceName, RobloxAwsClientType.Sns);
			CircuitBreakerHandler circuitBreakerHandler = new CircuitBreakerHandler(circuitBreakerPolicy);
			pipeline.AddHandlerAfter<RetryHandler>((IPipelineHandler)(object)circuitBreakerHandler);
		}
	}
}
