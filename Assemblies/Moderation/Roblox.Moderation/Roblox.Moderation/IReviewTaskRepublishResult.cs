using System.Collections.Generic;
using Roblox.Localization.Core;
namespace Roblox.Moderation {
    public interface IReviewTaskRepublishResult<out TTask> where TTask : IReviewTask

{
	/// <summary>
	/// Indicates if any items were republished, regardless of their locale
	/// </summary>
	bool Success { get; }

	IReadOnlyCollection<TTask> TasksRepublishedForDesiredLocale { get; }

	IReadOnlyDictionary<ISupportedLocaleIdentifier, IReadOnlyCollection<IReviewTask>> AllTasksRepublishedByLocaleIdentifier { get; }
}


}
