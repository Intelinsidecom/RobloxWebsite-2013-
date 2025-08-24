using System;
using Roblox.MaxMind.GeoIP2.Properties;
using Roblox.Sentinels;

namespace Roblox.MaxMind.GeoIP2;

internal class MaxMindCircuitBreaker : ExecutionCircuitBreakerBase
{
	protected override string Name => "MaxMindCircuitBreaker";

	protected override TimeSpan RetryInterval => Settings.Default.GeoIP2CircuitBreakerRetryInterval;

	protected override bool ShouldTrip(Exception ex)
	{
		return true;
	}
}
