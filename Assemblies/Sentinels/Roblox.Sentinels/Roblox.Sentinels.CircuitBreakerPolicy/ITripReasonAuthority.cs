using System;

namespace Roblox.Sentinels.CircuitBreakerPolicy;

public interface ITripReasonAuthority<in TExecutionContext>
{
	bool IsReasonForTrip(TExecutionContext executionContext, Exception exception);
}
