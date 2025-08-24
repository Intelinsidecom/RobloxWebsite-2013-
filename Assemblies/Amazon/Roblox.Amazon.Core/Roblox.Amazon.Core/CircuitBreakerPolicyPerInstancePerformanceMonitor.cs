using System;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Core;

internal sealed class CircuitBreakerPolicyPerInstancePerformanceMonitor : ICircuitBreakerPolicyPerformanceMonitor
{
	private IRateOfCountsPerSecondCounter RequestsTrippedByCircuitBreakerPerSecond { get; set; }

	private IRateOfCountsPerSecondCounter RequestsThatTripCircuitBreakerPerSecond { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Core.CircuitBreakerPolicyPerInstancePerformanceMonitor" /> class.
	/// </summary>
	/// <param name="categoryName">Name of the performance category.</param>
	/// <param name="instanceName">Name of the client instance</param>
	/// <exception cref="T:System.ArgumentException">Cannot be null, empty or whitespaces - instanceName</exception>
	public CircuitBreakerPolicyPerInstancePerformanceMonitor(ICounterRegistry counterRegistry, string categoryName, string instanceName)
	{
		if (string.IsNullOrWhiteSpace(categoryName))
		{
			throw new ArgumentException("Cannot be null, empty or whitespaces", "categoryName");
		}
		if (string.IsNullOrWhiteSpace(instanceName))
		{
			throw new ArgumentException("Cannot be null, empty or whitespaces", "categoryName");
		}
		RequestsTrippedByCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "RequestsTrippedByCircuitBreakerPerSecond", instanceName);
		RequestsThatTripCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "RequestsThatTripCircuitBreakerPerSecond", instanceName);
	}

	/// <summary>
	/// Increments the requests that trip circuit breaker (per second).
	/// </summary>
	public void IncrementRequestsThatTripCircuitBreakerPerSecond()
	{
		RequestsThatTripCircuitBreakerPerSecond.Increment();
	}

	/// <summary>
	/// Increments the requests that tripped by circuit breaker (per second).
	/// </summary>
	public void IncrementRequestsTrippedByCircuitBreakerPerSecond()
	{
		RequestsTrippedByCircuitBreakerPerSecond.Increment();
	}
}
