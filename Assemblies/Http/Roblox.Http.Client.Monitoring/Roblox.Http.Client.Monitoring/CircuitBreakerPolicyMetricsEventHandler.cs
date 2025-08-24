using System;
using System.Collections.Concurrent;
using Roblox.Instrumentation;
using Roblox.Pipeline;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Http.Client.Monitoring;

public sealed class CircuitBreakerPolicyMetricsEventHandler
{
	private const string _GlobalCircuitBreakerInstanceName = "_global_";

	private static readonly ConcurrentDictionary<string, Lazy<ICircuitBreakerPolicyPerformanceMonitor>> _Monitors = new ConcurrentDictionary<string, Lazy<ICircuitBreakerPolicyPerformanceMonitor>>();

	private readonly ICounterRegistry _CounterRegistry;

	public CircuitBreakerPolicyMetricsEventHandler(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public void RegisterEvents(ICircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>> circuitBreakerPolicy, string monitorCategory, string instanceIdentifier)
	{
		if (circuitBreakerPolicy == null)
		{
			throw new ArgumentNullException("circuitBreakerPolicy");
		}
		if (string.IsNullOrWhiteSpace(monitorCategory))
		{
			throw new ArgumentException("Value has to be a non-empty string.", "monitorCategory");
		}
		if (string.IsNullOrWhiteSpace(instanceIdentifier))
		{
			throw new ArgumentException("Value has to be a non-empty string.", "instanceIdentifier");
		}
		ICircuitBreakerPolicyPerformanceMonitor globalCircuitBreakerMonitor = GetOrCreate(_CounterRegistry, "_global_", instanceIdentifier);
		ICircuitBreakerPolicyPerformanceMonitor instanceCircuitBreakerMonitor = GetOrCreate(_CounterRegistry, monitorCategory, instanceIdentifier);
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

	private static ICircuitBreakerPolicyPerformanceMonitor GetOrCreate(ICounterRegistry counterRegistry, string monitorCategory, string instanceIdentifier)
	{
		return _Monitors.GetOrAdd($"{monitorCategory}.{instanceIdentifier}", (string x) => new Lazy<ICircuitBreakerPolicyPerformanceMonitor>(() => new CircuitBreakerPolicyPerInstancePerformanceMonitor(counterRegistry, monitorCategory, instanceIdentifier))).Value;
	}
}
