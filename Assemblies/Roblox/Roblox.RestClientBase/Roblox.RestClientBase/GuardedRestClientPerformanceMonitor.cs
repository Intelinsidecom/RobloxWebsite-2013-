using Roblox.Instrumentation;

namespace Roblox.RestClientBase;

/// <summary>
/// Maintains failed request and circuit breaker trips per-second counters for use by the GuardedRestClientBase. 
/// </summary>
/// <seealso cref="T:System.IDisposable" />
internal sealed class GuardedRestClientPerformanceMonitor
{
	private const string _CategoryName = "Roblox.GuardedRestClient";

	internal IRateOfCountsPerSecondCounter RequestsTrippedByCircuitBreakerPerSecond { get; }

	internal IRateOfCountsPerSecondCounter FailedRequestsThatTripCircuitBreakerPerSecond { get; }

	internal IRateOfCountsPerSecondCounter RequestsExceedingTimeoutPerSecond { get; }

	internal GuardedRestClientPerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		RequestsTrippedByCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedRestClient", "RequestsTrippedByCircuitBreakerPerSecond", instanceName);
		FailedRequestsThatTripCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedRestClient", "FailedRequestsThatTripCircuitBreakerPerSecond", instanceName);
		RequestsExceedingTimeoutPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedRestClient", "RequestsExceedingTimeoutPerSecond", instanceName);
	}
}
