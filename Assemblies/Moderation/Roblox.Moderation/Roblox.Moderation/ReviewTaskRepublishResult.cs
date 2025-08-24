using System;
using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

internal class ReviewTaskRepublishResult<TTask> : IReviewTaskRepublishResult<TTask> where TTask : IReviewTask
{
	public bool Success { get; }

	public IReadOnlyCollection<TTask> TasksRepublishedForDesiredLocale { get; }

	public IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> AllTasksRepublishedByLocaleIdentifier { get; }

	public ReviewTaskRepublishResult(bool success, IReadOnlyCollection<TTask> tasksRepublishedForDesiredLocale, IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> allTasksRepublishedByLocaleIdentifier)
	{
		Success = success;
		TasksRepublishedForDesiredLocale = tasksRepublishedForDesiredLocale ?? throw new ArgumentNullException("tasksRepublishedForDesiredLocale");
		AllTasksRepublishedByLocaleIdentifier = allTasksRepublishedByLocaleIdentifier ?? throw new ArgumentNullException("allTasksRepublishedByLocaleIdentifier");
	}
}
