using Roblox.Instrumentation;

namespace Roblox.Web.ElevatedActions.Base;

public interface IRobloxElevatedActionPerformanceCounters
{
	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions are instantiated
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionInstancesCreatedPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions have their IsAuthorized methods called
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionIsAuthorizedCallsPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions have their _CanPerformAction methods called
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionCanPerformActionCallsPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions have their ExecuteAction methods called
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionExecuteActionCallsPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions are throttled by the flood checker
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionIsThrottledOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions succeed at being executed
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionExecutionSuccessesPerSecond { get; }

	/// <summary>
	/// A counter that keeps track of the rate at which instances of the various types of Roblox Elevated Actions fails at being executed
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionExecutionFailuresPerSecond { get; }
}
