using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

internal class ReviewTaskRepublisherFactory : IReviewTaskRepublisherFactory
{
	private readonly Func<int> _GetMaximumNumberOfOpenTasksToRepublish;

	private readonly ILogger _Logger;

	private readonly IModerationLocaleFactory _ModerationLocaleFactory;

	private readonly ICounterRegistry _CounterRegistry;

	public ReviewTaskRepublisherFactory(ILogger logger, IModerationLocaleFactory moderationLocaleFactory, ICounterRegistry counterRegistry, Func<int> getsMaximumNumberOfOpenTasksToRepublish)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ModerationLocaleFactory = moderationLocaleFactory ?? throw new ArgumentNullException("moderationLocaleFactory");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_GetMaximumNumberOfOpenTasksToRepublish = getsMaximumNumberOfOpenTasksToRepublish ?? throw new ArgumentNullException("getsMaximumNumberOfOpenTasksToRepublish");
	}

	public IReviewTaskRepublisher<TTask> Create<TTask>(IReviewTaskFactory<TTask> reviewTaskFactory, IReviewTaskPublisher<TTask> reviewTaskPublisher, ISupportedLocaleIdentifier localeIdentifier, ModerationTaskType taskType, ModerationTaskPriority priority) where TTask : IReviewTask
	{
		if (reviewTaskFactory == null)
		{
			throw new ArgumentNullException("reviewTaskFactory");
		}
		if (reviewTaskPublisher == null)
		{
			throw new ArgumentNullException("reviewTaskPublisher");
		}
		if (localeIdentifier == null)
		{
			throw new ArgumentNullException("localeIdentifier");
		}
		return new ReviewTaskRepublisher<TTask>(_Logger, reviewTaskFactory, _ModerationLocaleFactory, reviewTaskPublisher, new ReviewTaskRepublisherPerformanceCounters(_CounterRegistry, taskType), priority, localeIdentifier, _GetMaximumNumberOfOpenTasksToRepublish);
	}
}
