using System.Collections.Generic;
namespace Roblox.Moderationpublic {
    interface IReviewTaskFactory<out TTask> where TTask : IReviewTask

{
	IReadOnlyCollection<TTask> GetUnreviewedUnassignedTasksPaged(int startRowIndex, int maximumRows);
}


}
