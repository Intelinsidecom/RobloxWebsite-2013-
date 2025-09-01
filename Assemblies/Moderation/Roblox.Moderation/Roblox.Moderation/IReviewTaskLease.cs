using System;
namespace Roblox.Moderation {
    interface IReviewTaskLease

{
	/// <summary>
	/// The Expiration date time for the lease
	/// </summary>
	DateTime Expiration { get; }

	/// <summary>
	/// Id of the moderator owning the lease
	/// </summary>
	long ModeratorId { get; }

	/// <summary>
	/// The Id of the ReviewTask
	/// </summary>
	long ReviewTaskId { get; }
}


}
