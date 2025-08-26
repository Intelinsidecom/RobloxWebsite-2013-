using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
namespace Roblox.Moderationpublic {
    interface IReviewTaskRepublishResult<out TTask> where TTask : IReviewTask

{
	/// <summary>
	/// Indicates if any items were republished, regardless of their locale
	/// </summary>
	bool Success { get; }

	IReadOnlyCollection<TTask> TasksRepublishedForDesiredLocale { get; }

	IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> AllTasksRepublishedByLocaleIdentifier { get; }
}


}
