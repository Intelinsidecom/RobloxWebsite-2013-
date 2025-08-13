using System;
using Roblox.Instrumentation;

namespace Roblox.ApiClientBase;

internal sealed class GuardedApiClientPerformanceMonitor
{
	private const string _CategoryName = "Roblox.GuardedApiClientV2";

	internal IRateOfCountsPerSecondCounter RequestsTrippedByCircuitBreakerPerSecond { get; }

	internal IRateOfCountsPerSecondCounter FailedRequestsThatTripCircuitBreakerPerSecond { get; }

	internal IRateOfCountsPerSecondCounter RequestsExceedingTimeoutPerSecond { get; }

	internal GuardedApiClientPerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		RequestsTrippedByCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedApiClientV2", "RequestsTrippedByCircuitBreakerPerSecond", instanceName);
		FailedRequestsThatTripCircuitBreakerPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedApiClientV2", "FailedRequestsThatTripCircuitBreakerPerSecond", instanceName);
		RequestsExceedingTimeoutPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.GuardedApiClientV2", "RequestsExceedingTimeoutPerSecond", instanceName);
	}
}
