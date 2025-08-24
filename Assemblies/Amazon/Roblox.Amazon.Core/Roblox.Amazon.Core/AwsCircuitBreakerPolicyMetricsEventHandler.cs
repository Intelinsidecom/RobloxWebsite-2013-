using System;
using System.Collections.Concurrent;
using Amazon.Runtime;
using Roblox.Instrumentation;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Core;

/// <summary>
/// CircuitBreakerPolicy event handler which register metrics tracking for AWS circuit breaker policies.
/// </summary>
public class AwsCircuitBreakerPolicyMetricsEventHandler
{
	private const string _PerformanceCategoryNamePrefix = "Roblox.AwsCircuitBreaker";

	private const string _GlobalCircuitBreakerInstanceName = "_global_";

	private readonly ICounterRegistry _counterRegistry = StaticCounterRegistry.Instance;

	private static readonly ConcurrentDictionary<string, Lazy<ICircuitBreakerPolicyPerformanceMonitor>> _Monitors = new ConcurrentDictionary<string, Lazy<ICircuitBreakerPolicyPerformanceMonitor>>();

	/// <summary>
	/// Register events handlers which track metrics.
	/// </summary>
	/// <param name="circuitBreakerPolicy"><see cref="T:Roblox.Sentinels.CircuitBreakerPolicy.DefaultCircuitBreakerPolicy`1" /></param>
	/// <param name="clientInstanceName">Client instance name</param>
	/// <param name="robloxAwsClientType">AWS client type <see cref="T:Roblox.Amazon.Core.RobloxAwsClientType" /></param>
	public void RegisterEvents(ICircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy, string clientInstanceName, RobloxAwsClientType robloxAwsClientType)
	{
		if (circuitBreakerPolicy == null)
		{
			throw new ArgumentNullException("circuitBreakerPolicy");
		}
		if (string.IsNullOrWhiteSpace(clientInstanceName))
		{
			throw new ArgumentException("Value has to be a non-empty string.", "clientInstanceName");
		}
		ICircuitBreakerPolicyPerformanceMonitor globalCircuitBreakerMonitor = GetOrCreate("_global_", robloxAwsClientType);
		ICircuitBreakerPolicyPerformanceMonitor instanceCircuitBreakerMonitor = GetOrCreate(clientInstanceName, robloxAwsClientType);
		circuitBreakerPolicy.RequestIntendingToOpenCircuitBreaker += delegate
		{
			instanceCircuitBreakerMonitor.IncrementRequestsThatTripCircuitBreakerPerSecond();
			globalCircuitBreakerMonitor.IncrementRequestsThatTripCircuitBreakerPerSecond();
		};
		circuitBreakerPolicy.CircuitBreakerTerminatingRequest += delegate
		{
			instanceCircuitBreakerMonitor.IncrementRequestsTrippedByCircuitBreakerPerSecond();
			globalCircuitBreakerMonitor.IncrementRequestsTrippedByCircuitBreakerPerSecond();
		};
	}

	private ICircuitBreakerPolicyPerformanceMonitor GetOrCreate(string clientInstanceName, RobloxAwsClientType robloxAwsClientType)
	{
		string categoryName = string.Format("{0}.{1}", "Roblox.AwsCircuitBreaker", robloxAwsClientType);
		string key = $"{robloxAwsClientType}{clientInstanceName}";
		return _Monitors.GetOrAdd(key, (string x) => new Lazy<ICircuitBreakerPolicyPerformanceMonitor>(() => new CircuitBreakerPolicyPerInstancePerformanceMonitor(_counterRegistry, categoryName, clientInstanceName))).Value;
	}
}
