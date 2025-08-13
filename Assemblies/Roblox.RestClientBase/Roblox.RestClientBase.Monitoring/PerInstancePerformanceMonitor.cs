using Roblox.Instrumentation;

namespace Roblox.RestClientBase.Monitoring;

public class PerInstancePerformanceMonitor
{
	public IAverageValueCounter AverageResponseTime { get; set; }

	public IRateOfCountsPerSecondCounter FailuresPerSecond { get; set; }

	public IRawValueCounter RequestsOutstanding { get; set; }

	public IRateOfCountsPerSecondCounter RequestsPerSecond { get; set; }

	public PerInstancePerformanceMonitor(IRateOfCountsPerSecondCounter requestsPerSecond, IRateOfCountsPerSecondCounter failuresPerSecond, IRawValueCounter requestsOutstanding, IAverageValueCounter averageResponseTime)
	{
		RequestsPerSecond = requestsPerSecond;
		FailuresPerSecond = failuresPerSecond;
		RequestsOutstanding = requestsOutstanding;
		AverageResponseTime = averageResponseTime;
	}
}
