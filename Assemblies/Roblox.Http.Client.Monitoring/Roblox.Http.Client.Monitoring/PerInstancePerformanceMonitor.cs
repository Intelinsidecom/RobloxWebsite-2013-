using System;
using Roblox.Instrumentation;

namespace Roblox.Http.Client.Monitoring;

internal sealed class PerInstancePerformanceMonitor
{
	private const string _AverageResponseTimeCounterName = "Avg Response Time";

	private const string _FailuresPerSecondCounterName = "Failures/s";

	private const string _RequestsOutstandingCounterName = "Requests Outstanding";

	private const string _SuccessesPerSecondCounterName = "Requests/s";

	public IAverageValueCounter AverageResponseTime { get; }

	public IRateOfCountsPerSecondCounter FailuresPerSecond { get; }

	public IRawValueCounter RequestsOutstanding { get; }

	public IRateOfCountsPerSecondCounter SuccessesPerSecond { get; }

	public PerInstancePerformanceMonitor(ICounterRegistry registry, string categoryName, string instanceName)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		AverageResponseTime = registry.GetAverageValueCounter(categoryName, "Avg Response Time", instanceName);
		FailuresPerSecond = registry.GetRateOfCountsPerSecondCounter(categoryName, "Failures/s", instanceName);
		RequestsOutstanding = registry.GetRawValueCounter(categoryName, "Requests Outstanding", instanceName);
		SuccessesPerSecond = registry.GetRateOfCountsPerSecondCounter(categoryName, "Requests/s", instanceName);
	}
}
