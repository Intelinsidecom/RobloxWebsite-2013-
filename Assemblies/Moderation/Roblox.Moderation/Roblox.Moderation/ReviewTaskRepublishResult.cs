using System;
using System.Collections.Generic;
using Roblox.Localization.Core;
using Roblox.Moderation.Interfaces;

namespace Roblox.Moderation
{
    public class ReviewTaskRepublishResult : IReviewTaskRepublishResult<IReviewTask>
    {
        public bool Success { get; set; }
        public Exception Error { get; set; }
        public string ErrorMessage { get; set; }

        public IReadOnlyCollection<IReviewTask> TasksRepublishedForDesiredLocale { get; set; }

        public IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> AllTasksRepublishedByLocaleIdentifier { get; set; }
    }
}
