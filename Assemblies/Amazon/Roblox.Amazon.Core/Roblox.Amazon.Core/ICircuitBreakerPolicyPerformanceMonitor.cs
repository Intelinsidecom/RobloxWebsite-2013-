namespace Roblox.Amazon.Core;

/// <summary>
/// Performance monitoring for <see cref="!:ICircuitBreakerPolicy" />
/// </summary>
public interface ICircuitBreakerPolicyPerformanceMonitor
{
	/// <summary>
	/// Increments requests that trip circuit breaker (per second).
	/// </summary>
	void IncrementRequestsThatTripCircuitBreakerPerSecond();

	/// <summary>
	/// Increments the requests tripped by circuit breaker (per second).
	/// </summary>
	void IncrementRequestsTrippedByCircuitBreakerPerSecond();
}
