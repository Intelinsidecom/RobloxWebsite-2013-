using System;
using System.Threading;

namespace Roblox.Sentinels;

public class ThresholdExecutionCircuitBreaker : ExecutionCircuitBreakerBase
{
	private readonly Func<Exception, bool> _FailureDetector;

	private readonly Func<TimeSpan> _RetryIntervalCalculator;

	private readonly Func<int> _ExceptionCountForTripping;

	private readonly Func<TimeSpan> _ExceptionIntervalForTripping;

	private readonly Func<DateTime> _UtcNowGetter;

	private DateTime _ExceptionCountIntervalEnd = DateTime.MinValue;

	private int _ExceptionCount;

	protected internal override string Name { get; }

	protected override TimeSpan RetryInterval => _RetryIntervalCalculator();

	protected override DateTime Now => _UtcNowGetter();

	public ThresholdExecutionCircuitBreaker(string name, Func<Exception, bool> failureDetector, Func<TimeSpan> retryIntervalCalculator, Func<int> exceptionCountForTripping, Func<TimeSpan> exceptionIntervalForTripping)
		: this(name, failureDetector, retryIntervalCalculator, exceptionCountForTripping, exceptionIntervalForTripping, () => DateTime.UtcNow)
	{
	}

	internal ThresholdExecutionCircuitBreaker(string name, Func<Exception, bool> failureDetector, Func<TimeSpan> retryIntervalCalculator, Func<int> exceptionCountForTripping, Func<TimeSpan> exceptionIntervalForTripping, Func<DateTime> utcNowGetter)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Cannot be null, empty or whitespace", "name");
		}
		Name = name;
		_FailureDetector = failureDetector ?? throw new ArgumentNullException("failureDetector");
		_RetryIntervalCalculator = retryIntervalCalculator ?? throw new ArgumentNullException("retryIntervalCalculator");
		_ExceptionCountForTripping = exceptionCountForTripping ?? throw new ArgumentNullException("exceptionCountForTripping");
		_ExceptionIntervalForTripping = exceptionIntervalForTripping ?? throw new ArgumentNullException("exceptionIntervalForTripping");
		_UtcNowGetter = utcNowGetter ?? throw new ArgumentNullException("utcNowGetter");
	}

	private void ResetExceptionCount()
	{
		Interlocked.Exchange(ref _ExceptionCount, 0);
		_ExceptionCountIntervalEnd = Now.Add(_ExceptionIntervalForTripping());
	}

	protected override bool ShouldTrip(Exception ex)
	{
		if (ex == null)
		{
			throw new ArgumentNullException("ex");
		}
		if (_FailureDetector(ex))
		{
			if (_ExceptionCountIntervalEnd < Now)
			{
				ResetExceptionCount();
			}
			Interlocked.Increment(ref _ExceptionCount);
			if (_ExceptionCount > _ExceptionCountForTripping())
			{
				return true;
			}
		}
		return false;
	}
}
