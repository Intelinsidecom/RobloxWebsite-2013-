using System.Collections.Generic;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskFactory<out TTask> where TTask : IReviewTask
{
	IReadOnlyCollection<TTask> GetUnreviewedUnassignedTasksPaged(int startRowIndex, int maximumRows);
}
