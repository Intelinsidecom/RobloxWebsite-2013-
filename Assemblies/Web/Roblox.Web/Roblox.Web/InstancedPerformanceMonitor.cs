using System;
using Roblox.Instrumentation;

namespace Roblox.Web;

/// <summary>
/// Class to create <see cref="T:Roblox.Web.InstancedPerformanceMonitor" />s for API requests.
/// </summary>
public class InstancedPerformanceMonitor
{
	public IRateOfCountsPerSecondCounter ThrottledGameServerRequestsPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter ThrottledRequestsByUserIdPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter ThrottledRequestsByIpPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter TotalGameServerRequestsPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter TotalRequestsByUserIdPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter TotalRequestsByIpPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter TotalRequestsPerSecond { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.InstancedPerformanceMonitor" /> class.
	/// </summary>
	/// <param name="counterRegistry">Counter registry injected</param>
	/// <param name="performanceCategory">The performance category.</param>
	/// <param name="instanceName">Name of the instance.</param>
	public InstancedPerformanceMonitor(ICounterRegistry counterRegistry, string performanceCategory, string instanceName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (performanceCategory == null)
		{
			throw new ArgumentNullException("performanceCategory");
		}
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		ThrottledGameServerRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "ThrottledGameServerRequestsPerSecond", instanceName);
		ThrottledRequestsByUserIdPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "ThrottledRequestsByUserIdPerSecond", instanceName);
		ThrottledRequestsByIpPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "ThrottledRequestsByIpPerSecond", instanceName);
		TotalGameServerRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "TotalGameServerRequestsPerSecond", instanceName);
		TotalRequestsByUserIdPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "TotalRequestsByUserIdPerSecond", instanceName);
		TotalRequestsByIpPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "TotalRequestsByIpPerSecond", instanceName);
		TotalRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "TotalRequestsPerSecond", instanceName);
	}
}
