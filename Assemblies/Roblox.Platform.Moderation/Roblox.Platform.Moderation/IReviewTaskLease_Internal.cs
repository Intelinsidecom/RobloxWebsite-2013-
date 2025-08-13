namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface for <see cref="T:Roblox.Platform.Moderation.IReviewTaskLease" /> that is only exposed internally.
/// </summary>
internal interface IReviewTaskLease_Internal : IReviewTaskLease
{
	/// <summary>
	/// Deletes the lease from the database.  This action should only be done as part of closing a task, or cleaning up inconsistent lease.
	/// </summary>
	/// <exception><inheritdoc cref="M:Roblox.Entities.IEntity`1.Delete" /></exception>
	void Delete();
}
