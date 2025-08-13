using System;
using Roblox.Instrumentation;

namespace Roblox.Web.ElevatedActions.Base;

internal class RobloxElevatedActionPerformanceCounters : IRobloxElevatedActionPerformanceCounters
{
	private const string _PerformanceCategory = "Roblox.Web.ElevatedActions.Base";

	public IRateOfCountsPerSecondCounter ElevatedActionInstancesCreatedPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionIsAuthorizedCallsPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionCanPerformActionCallsPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionExecuteActionCallsPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionIsThrottledOccurrencesPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionExecutionSuccessesPerSecond { get; }

	public IRateOfCountsPerSecondCounter ElevatedActionExecutionFailuresPerSecond { get; }

	public RobloxElevatedActionPerformanceCounters(ICounterRegistry registry, Type robloxElevatedActionType)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		if (robloxElevatedActionType == null)
		{
			throw new ArgumentNullException("robloxElevatedActionType");
		}
		string instanceName = robloxElevatedActionType.FullName;
		if (string.IsNullOrEmpty(instanceName))
		{
			throw new ArgumentException("robloxElevatedActionType.FullName cannot be null or empty.", "instanceName");
		}
		ElevatedActionInstancesCreatedPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionInstancesCreatedPerSecond", instanceName);
		ElevatedActionIsAuthorizedCallsPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionIsAuthorizedCallsPerSecond", instanceName);
		ElevatedActionCanPerformActionCallsPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionCanPerformActionCallsPerSecond", instanceName);
		ElevatedActionExecuteActionCallsPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionExecuteActionCallsPerSecond", instanceName);
		ElevatedActionIsThrottledOccurrencesPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionIsThrottledOccurrencesPerSecond", instanceName);
		ElevatedActionExecutionSuccessesPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionExecutionSuccessesPerSecond", instanceName);
		ElevatedActionExecutionFailuresPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Web.ElevatedActions.Base", "ElevatedActionExecutionFailuresPerSecond", instanceName);
	}
}
