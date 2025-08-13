using System;

namespace Roblox.Sentinels.CircuitBreakerPolicy;

public abstract class CircuitBreakerPolicyBase<TExecutionContext> : ICircuitBreakerPolicy<TExecutionContext>, IDisposable
{
	private readonly ITripReasonAuthority<TExecutionContext> _TripReasonAuthority;

	private bool _Disposed;

	public event Action RequestIntendingToOpenCircuitBreaker;

	public event Action CircuitBreakerTerminatingRequest;

	protected CircuitBreakerPolicyBase(ITripReasonAuthority<TExecutionContext> tripReasonAuthority)
	{
		_TripReasonAuthority = tripReasonAuthority ?? throw new ArgumentNullException("tripReasonAuthority");
	}

	public void NotifyRequestFinished(TExecutionContext executionContext, Exception exception)
	{
		try
		{
			if (_TripReasonAuthority.IsReasonForTrip(executionContext, exception))
			{
				this.RequestIntendingToOpenCircuitBreaker?.Invoke();
				TryToTripCircuitBreaker(executionContext);
			}
			else
			{
				OnSuccessfulRequest(executionContext);
			}
		}
		finally
		{
			OnNotified(executionContext);
		}
	}

	public void ThrowIfTripped(TExecutionContext executionContext)
	{
		if (!IsCircuitBreakerOpened(executionContext, out var exception))
		{
			return;
		}
		this.CircuitBreakerTerminatingRequest?.Invoke();
		throw exception;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected abstract bool IsCircuitBreakerOpened(TExecutionContext executionContext, out CircuitBreakerException exception);

	protected abstract bool TryToTripCircuitBreaker(TExecutionContext executionContext);

	protected abstract void OnSuccessfulRequest(TExecutionContext executionContext);

	protected abstract void OnNotified(TExecutionContext executionContext);

	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (disposing && _TripReasonAuthority is IDisposable)
			{
				((IDisposable)_TripReasonAuthority).Dispose();
			}
			_Disposed = true;
		}
	}
}
