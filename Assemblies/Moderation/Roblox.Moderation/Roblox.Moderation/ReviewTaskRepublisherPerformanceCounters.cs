using System;
using System.Collections.Concurrent;
using Roblox.Instrumentation;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

internal class ReviewTaskRepublisherPerformanceCounters : IReviewTaskRepublisherPerformanceCounters
{
	private const string _PerformanceCategory = "Roblox.Platform.Moderation.ReviewTaskRepublisher";

	private readonly ICounterRegistry _CounterRegistry;

	private readonly ModerationTaskType _TaskType;

	private readonly ConcurrentDictionary<int, IRawValueCounter> _LocaleToNumberOfRepublishedTasksMap;

	public IRateOfCountsPerSecondCounter RepublishRequestsPerSecond { get; }

	public IRateOfCountsPerSecondCounter ReviewTasksRepublishedPerSecond { get; }

	public IRateOfCountsPerSecondCounter InsufficientTasksFoundForLocalePerSecond { get; }

	public IRateOfCountsPerSecondCounter InsufficientTasksFoundForLocaleWithMultiplierPerSecond { get; }

	public ReviewTaskRepublisherPerformanceCounters(ICounterRegistry registry, ModerationTaskType taskType)
	{
		string instanceName = GetInstanceName(taskType);
		_TaskType = taskType;
		_CounterRegistry = registry ?? throw new ArgumentNullException("registry");
		RepublishRequestsPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Moderation.ReviewTaskRepublisher", "RepublishRequestsPerSecond", instanceName);
		ReviewTasksRepublishedPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Moderation.ReviewTaskRepublisher", "ReviewTasksRepublishedPerSecond", instanceName);
		InsufficientTasksFoundForLocalePerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Moderation.ReviewTaskRepublisher", "InsufficientTasksFoundForLocalePerSecond", instanceName);
		InsufficientTasksFoundForLocaleWithMultiplierPerSecond = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Moderation.ReviewTaskRepublisher", "InsufficientTasksFoundForLocaleWithMultiplierPerSecond", instanceName);
		_LocaleToNumberOfRepublishedTasksMap = new ConcurrentDictionary<int, IRawValueCounter>();
	}

	public IRawValueCounter GetNumberOfRepublishedTasksForLocaleCounter(ISupportedLocaleIdentifier localeIdentifier)
	{
		int locale = localeIdentifier?.Id ?? 0;
		return _LocaleToNumberOfRepublishedTasksMap.GetOrAdd(locale, (int i) => _CounterRegistry.GetRawValueCounter("Roblox.Platform.Moderation.ReviewTaskRepublisher", "NumberOfRepublishedTasksForLocaleCounter", GetInstanceName(_TaskType, locale)));
	}

	private static string GetInstanceName(ModerationTaskType taskType)
	{
		return $"taskType:{taskType.ToString()}";
	}

	private static string GetInstanceName(ModerationTaskType taskType, int locale)
	{
		return $"taskType:{taskType.ToString()}_locale:{locale}";
	}
}
