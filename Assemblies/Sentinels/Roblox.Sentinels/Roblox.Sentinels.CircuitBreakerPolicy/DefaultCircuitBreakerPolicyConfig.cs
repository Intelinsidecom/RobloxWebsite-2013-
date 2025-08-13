using System;

namespace Roblox.Sentinels.CircuitBreakerPolicy;

public class DefaultCircuitBreakerPolicyConfig : IDefaultCircuitBreakerPolicyConfig
{
	private int _FailuresAllowedBeforeTrip;

	public TimeSpan RetryInterval { get; set; } = TimeSpan.FromMilliseconds(250.0);


	public int FailuresAllowedBeforeTrip
	{
		get
		{
			return _FailuresAllowedBeforeTrip;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("FailuresAllowedBeforeTrip", "Has to be bigger than or equal to zero.");
			}
			_FailuresAllowedBeforeTrip = value;
		}
	}
}
