using Roblox.Instrumentation;

namespace Roblox.ApiClientBase.Monitoring;

public class PerInstancePerformanceMonitor
{
	private const string _AverageResponseTimeCounterName = "Avg Response Time";

	private const string _FailuresPerSecondCounterName = "Failures/s";

	private const string _RequestsOutstandingCounterName = "Requests Outstanding";

	private const string _RequestsPerSecondCounterName = "Requests/s";

	public IAverageValueCounter AverageResponseTime { get; }

	public IRateOfCountsPerSecondCounter FailuresPerSecond { get; }

	public IRawValueCounter RequestsOutstanding { get; }

	public IRateOfCountsPerSecondCounter RequestsPerSecond { get; }

	public PerInstancePerformanceMonitor(ICounterRegistry counterRegistry, string categoryName, string instanceName)
	{
		AverageResponseTime = counterRegistry.GetAverageValueCounter(categoryName, "Avg Response Time", instanceName);
		FailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "Failures/s", instanceName);
		RequestsOutstanding = counterRegistry.GetRawValueCounter(categoryName, "Requests Outstanding", instanceName);
		RequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "Requests/s", instanceName);
	}
}
