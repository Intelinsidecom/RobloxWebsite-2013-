using System;
using System.Collections.Generic;
using Roblox.Localization.Core;

namespace Roblox.Moderation
{
    public class ReviewTaskRepublishResult<TTask> : IReviewTaskRepublishResult<TTask> where TTask : IReviewTask
    {
        public bool Success { get; }

        public IReadOnlyCollection<TTask> TasksRepublishedForDesiredLocale { get; }

        public IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> AllTasksRepublishedByLocaleIdentifier { get; }

        public ReviewTaskRepublishResult(bool success,
            IReadOnlyCollection<TTask> tasksRepublishedForDesiredLocale,
            IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> allTasksRepublishedByLocaleIdentifier)
        {
            Success = success;
            TasksRepublishedForDesiredLocale = tasksRepublishedForDesiredLocale ?? Array.Empty<TTask>();
            AllTasksRepublishedByLocaleIdentifier = allTasksRepublishedByLocaleIdentifier ?? new Dictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>>();
        }
    }
}
