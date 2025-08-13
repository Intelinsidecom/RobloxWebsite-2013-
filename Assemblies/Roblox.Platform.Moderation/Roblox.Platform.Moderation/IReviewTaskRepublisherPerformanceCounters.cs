using Roblox.Instrumentation;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskRepublisherPerformanceCounters
{
	/// <summary>
	/// A counter that monitors the rate at which requests are made to republish to a queue
	/// </summary>
	IRateOfCountsPerSecondCounter RepublishRequestsPerSecond { get; }

	/// <summary>
	/// A rate per second counter of the task republishing occurrences
	/// </summary>
	IRateOfCountsPerSecondCounter ReviewTasksRepublishedPerSecond { get; }

	/// <summary>
	/// Returns a raw value counter that can be used to state how many tasks for a specific locale were republished
	/// </summary>
	/// <param name="localeIdentifier"></param>
	/// <returns></returns>
	IRawValueCounter GetNumberOfRepublishedTasksForLocaleCounter(ISupportedLocaleIdentifier localeIdentifier);
}
