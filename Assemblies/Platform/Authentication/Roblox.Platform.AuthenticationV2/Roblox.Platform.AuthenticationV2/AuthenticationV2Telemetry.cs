using System;
using Roblox.Instrumentation;

namespace Roblox.AuthenticationV2;

/// <inheritdoc />
public class AuthenticationV2Telemetry : IAuthenticationV2Telemetry
{
	private const string _Category = "Roblox.AuthenticationV2";

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.AuthenticationV2.AuthenticationV2Telemetry" />
	/// </summary>
	/// <param name="counterRegistry">An <see cref="T:Roblox.Instrumentation.ICounterRegistry" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="counterRegistry" /></exception>
	public AuthenticationV2Telemetry(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	/// <inheritdoc />
	public void Increment(Counter counter, Instance instance)
	{
		_CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.AuthenticationV2", counter.ToString(), instance.ToString()).Increment();
	}
}
