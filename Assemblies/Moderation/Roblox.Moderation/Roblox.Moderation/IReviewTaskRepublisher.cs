namespace Roblox.Platform.Moderation;

/// <summary>
/// Interface for a review task republisher that accepts a type parameter for the type of review task that it republishes
/// </summary>
/// <typeparam name="TTask"></typeparam>
public interface IReviewTaskRepublisher<out TTask> where TTask : IReviewTask
{
	/// <summary>
	/// Returns true if republishing was successful. In that case all republished tasks, keyed by the task's supported locale Id are sent as an out var.
	/// Returns false if republishing was not successful
	/// </summary>
	/// <returns></returns>
	IReviewTaskRepublishResult<TTask> RepublishOldestTasksInQueue();
}
