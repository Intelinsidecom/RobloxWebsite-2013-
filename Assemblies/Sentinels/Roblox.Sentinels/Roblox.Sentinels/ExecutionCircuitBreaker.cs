using System;

namespace Roblox.Sentinels;

public class ExecutionCircuitBreaker : ExecutionCircuitBreakerBase
{
	private readonly Func<Exception, bool> _FailureDetector;

	private readonly Func<TimeSpan> _RetryIntervalCalculator;

	protected internal override string Name { get; }

	protected override TimeSpan RetryInterval => _RetryIntervalCalculator();

	public ExecutionCircuitBreaker(string name, Func<Exception, bool> failureDetector, Func<TimeSpan> retryIntervalCalculator)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Cannot be null, empty or whitespace", "name");
		}
		_FailureDetector = failureDetector ?? throw new ArgumentNullException("failureDetector");
		_RetryIntervalCalculator = retryIntervalCalculator ?? throw new ArgumentNullException("retryIntervalCalculator");
		Name = name;
	}

	protected override bool ShouldTrip(Exception ex)
	{
		return _FailureDetector(ex);
	}
}
