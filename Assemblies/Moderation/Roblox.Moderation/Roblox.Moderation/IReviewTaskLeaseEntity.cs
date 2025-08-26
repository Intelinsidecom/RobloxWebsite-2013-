using System;
using Roblox.Entities;
namespace Roblox.Moderationpublic {
    interface IReviewTaskLeaseEntity : IUpdateableEntity<long>, IEntity<long>

{
	long ReviewTaskId { get; }

	long ModeratorId { get; set; }

	DateTime Expiration { get; set; }
}


}
