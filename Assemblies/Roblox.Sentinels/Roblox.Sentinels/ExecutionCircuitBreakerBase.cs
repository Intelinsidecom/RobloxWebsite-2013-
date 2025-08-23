using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Sentinels;

public abstract class ExecutionCircuitBreakerBase : CircuitBreakerBase
{
	private DateTime _NextRetry = DateTime.MinValue;

	private int _ShouldRetrySignal;

	private bool IsTimeForRetry => Now >= _NextRetry;

	protected abstract TimeSpan RetryInterval { get; }

	private bool ShouldRetry()
	{
		return Interlocked.CompareExchange(ref _ShouldRetrySignal, 1, 0) == 0;
	}

	private void AttemptToProceed()
	{
		try
		{
			Test();
		}
		catch (CircuitBreakerException)
		{
			if (IsTimeForRetry && ShouldRetry())
			{
				return;
			}
			throw;
		}
	}

	protected abstract bool ShouldTrip(Exception ex);

	public void Execute(Action action)
	{
		AttemptToProceed();
		try
		{
			action();
		}
		catch (Exception ex)
		{
			if (ShouldTrip(ex))
			{
				_NextRetry = Now.Add(RetryInterval);
				Trip();
			}
			throw;
		}
		finally
		{
			Interlocked.Exchange(ref _ShouldRetrySignal, 0);
		}
		Reset();
	}

	public async Task ExecuteAsync(Func<CancellationToken, Task> action, CancellationToken cancellationToken = default(CancellationToken))
	{
		AttemptToProceed();
		try
		{
			await action(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			if (ShouldTrip(ex))
			{
				_NextRetry = Now.Add(RetryInterval);
				Trip();
			}
			throw;
		}
		finally
		{
			Interlocked.Exchange(ref _ShouldRetrySignal, 0);
		}
		Reset();
	}

	public override bool Reset()
	{
		bool result = base.Reset();
		_NextRetry = DateTime.MinValue;
		return result;
	}
}
