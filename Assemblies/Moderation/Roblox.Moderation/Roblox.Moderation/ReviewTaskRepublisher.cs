using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

internal class ReviewTaskRepublisher<TTask> : IReviewTaskRepublisher<TTask> where TTask : IReviewTask
{
	private readonly ILogger _Logger;

	private readonly IReviewTaskFactory<TTask> _ReviewTaskFactory;

	private readonly IModerationLocaleFactory _ModerationLocaleFactory;

	private readonly IReviewTaskPublisher<TTask> _ReviewTaskPublisher;

	private readonly Func<int> _GetMaximumNumberOfOpenTasksToRepublish;

	private readonly IReviewTaskRepublisherPerformanceCounters _PerformanceCounters;

	private readonly ModerationTaskPriority _TaskPriority;

	private readonly ISupportedLocaleIdentifier _TargetLocaleIdentifier;

	public ReviewTaskRepublisher(ILogger logger, IReviewTaskFactory<TTask> reviewTaskFactory, IModerationLocaleFactory moderationLocaleFactory, IReviewTaskPublisher<TTask> reviewTaskPublisher, IReviewTaskRepublisherPerformanceCounters performanceCounters, ModerationTaskPriority taskPriority, ISupportedLocaleIdentifier targetLocaleIdentifier, Func<int> getsMaximumNumberOfOpenTasksToRepublish)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ReviewTaskFactory = reviewTaskFactory ?? throw new ArgumentNullException("reviewTaskFactory");
		_ModerationLocaleFactory = moderationLocaleFactory ?? throw new ArgumentNullException("moderationLocaleFactory");
		_ReviewTaskPublisher = reviewTaskPublisher ?? throw new ArgumentNullException("reviewTaskPublisher");
		_PerformanceCounters = performanceCounters ?? throw new ArgumentNullException("performanceCounters");
		_TaskPriority = taskPriority;
		_TargetLocaleIdentifier = targetLocaleIdentifier ?? throw new ArgumentNullException("targetLocaleIdentifier");
		_GetMaximumNumberOfOpenTasksToRepublish = getsMaximumNumberOfOpenTasksToRepublish ?? throw new ArgumentNullException("getsMaximumNumberOfOpenTasksToRepublish");
	}

	public IReviewTaskRepublishResult<TTask> RepublishOldestTasksInQueue()
	{
		_PerformanceCounters.RepublishRequestsPerSecond.Increment();
		int countOfTasksRepublished = 0;
		IDictionary<int, ICollection<TTask>> mapOfOtherLocaleIdentifierIdToTasks = new Dictionary<int, ICollection<TTask>>();
		try
		{
			foreach (TTask reviewTask in _ReviewTaskFactory.GetUnreviewedUnassignedTasksPaged(0, _GetMaximumNumberOfOpenTasksToRepublish()))
			{
				IModerationLocale locale = _ModerationLocaleFactory.GetActiveByLocalizationLocale(reviewTask.LocaleIdentifier);
				_ReviewTaskPublisher.Publish(reviewTask, locale?.SupportedLocale, _TaskPriority);
				countOfTasksRepublished++;
				int localeId = reviewTask.LocaleIdentifier?.Id ?? 0;
				if (!mapOfOtherLocaleIdentifierIdToTasks.ContainsKey(localeId))
				{
					mapOfOtherLocaleIdentifierIdToTasks[localeId] = new List<TTask>();
				}
				mapOfOtherLocaleIdentifierIdToTasks[localeId].Add(reviewTask);
			}
			if (countOfTasksRepublished > 0)
			{
				int targetLocaleId = _TargetLocaleIdentifier.Id;
				IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> allRepublishedTasks = ((IEnumerable<KeyValuePair<int, ICollection<TTask>>>)mapOfOtherLocaleIdentifierIdToTasks).ToDictionary((Func<KeyValuePair<int, ICollection<TTask>>, ISupportedLocaleIdentifier>)((KeyValuePair<int, ICollection<TTask>> kvp) => new SupportedLocaleIdentifier(kvp.Key)), (Func<KeyValuePair<int, ICollection<TTask>>, IReadOnlyCollection<IReviewTask>>)((KeyValuePair<int, ICollection<TTask>> kvp) => ((IEnumerable<TTask>)kvp.Value).Select((Func<TTask, IReviewTask>)((TTask t) => t)).ToList()));
				IReadOnlyCollection<TTask> republishedReviewTasks = (mapOfOtherLocaleIdentifierIdToTasks.ContainsKey(targetLocaleId) ? mapOfOtherLocaleIdentifierIdToTasks[targetLocaleId].ToList() : new List<TTask>());
				ReviewTaskRepublishResult<TTask> result = new ReviewTaskRepublishResult<TTask>(success: true, republishedReviewTasks, allRepublishedTasks);
				InstrumentResult(result);
				return result;
			}
			return new ReviewTaskRepublishResult<TTask>(success: false, new List<TTask>(), new Dictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>>());
		}
		finally
		{
			_PerformanceCounters.ReviewTasksRepublishedPerSecond.IncrementBy(countOfTasksRepublished);
		}
	}

	private void InstrumentResult(IReviewTaskRepublishResult<TTask> result)
	{
		if (!result.Success)
		{
			return;
		}
		foreach (KeyValuePair<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> tasksForLocaleIdentifier in result.AllTasksRepublishedByLocaleIdentifier)
		{
			_PerformanceCounters.GetNumberOfRepublishedTasksForLocaleCounter(tasksForLocaleIdentifier.Key).Set(tasksForLocaleIdentifier.Value.Count);
			_Logger.Info($"There were {tasksForLocaleIdentifier.Value.Count} tasks republished for the locale: {tasksForLocaleIdentifier.Key}");
		}
	}
}
