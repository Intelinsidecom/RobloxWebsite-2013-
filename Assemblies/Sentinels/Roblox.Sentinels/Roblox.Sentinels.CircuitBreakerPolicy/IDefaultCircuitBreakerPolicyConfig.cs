using System;

namespace Roblox.Sentinels.CircuitBreakerPolicy;

public interface IDefaultCircuitBreakerPolicyConfig
{
	TimeSpan RetryInterval { get; }

	int FailuresAllowedBeforeTrip { get; }
}
