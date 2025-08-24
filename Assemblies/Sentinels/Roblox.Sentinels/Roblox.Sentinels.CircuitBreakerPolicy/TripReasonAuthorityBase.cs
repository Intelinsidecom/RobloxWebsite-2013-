using System;

namespace Roblox.Sentinels.CircuitBreakerPolicy;

public abstract class TripReasonAuthorityBase<TExecutionContext> : ITripReasonAuthority<TExecutionContext>
{
	public abstract bool IsReasonForTrip(TExecutionContext executionContext, Exception exception);

	protected static bool TryGetInnerExceptionOfType<T>(Exception exception, out T inner) where T : Exception
	{
		inner = null;
		Exception ex = exception;
		while (ex.InnerException != null)
		{
			inner = ex.InnerException as T;
			if (inner != null)
			{
				return true;
			}
			ex = ex.InnerException;
		}
		return false;
	}
}
