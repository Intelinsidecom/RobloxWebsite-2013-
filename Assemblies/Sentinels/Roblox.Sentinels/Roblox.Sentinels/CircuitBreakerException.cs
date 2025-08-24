using System;

namespace Roblox.Sentinels;

public class CircuitBreakerException : Exception
{
	private readonly string _CircuitBreakerName;

	private readonly DateTime? _CircuitBreakerTripped;

	public override string Message
	{
		get
		{
			DateTime utcNow = DateTime.UtcNow;
			DateTime value = _CircuitBreakerTripped ?? utcNow;
			TimeSpan timeSpan = utcNow.Subtract(value);
			return $"CircuitBreaker Error: {_CircuitBreakerName} has been tripped for {timeSpan.TotalSeconds} seconds.";
		}
	}

	public CircuitBreakerException(CircuitBreakerBase circuitBreaker)
		: this(circuitBreaker.Name, circuitBreaker.Tripped)
	{
	}

	public CircuitBreakerException(string circuitBreakerName, DateTime? circuitBreakerTripped)
	{
		_CircuitBreakerName = circuitBreakerName;
		_CircuitBreakerTripped = circuitBreakerTripped;
	}
}
