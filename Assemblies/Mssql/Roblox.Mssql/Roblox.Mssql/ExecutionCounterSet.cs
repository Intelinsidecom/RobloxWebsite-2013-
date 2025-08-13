using Roblox.Instrumentation;

namespace Roblox.Mssql;

internal sealed class ExecutionCounterSet
{
	public IAverageValueCounter AverageResponseTime { get; }

	public IRateOfCountsPerSecondCounter FailuresPerSecond { get; }

	public IRawValueCounter RequestsOutstanding { get; }

	public IRateOfCountsPerSecondCounter RequestsPerSecond { get; }

	public ExecutionCounterSet(IRateOfCountsPerSecondCounter requestsPerSecond, IRateOfCountsPerSecondCounter failuresPerSecond, IRawValueCounter requestsOutstanding, IAverageValueCounter averageResponseTime)
	{
		RequestsPerSecond = requestsPerSecond;
		FailuresPerSecond = failuresPerSecond;
		RequestsOutstanding = requestsOutstanding;
		AverageResponseTime = averageResponseTime;
	}
}
