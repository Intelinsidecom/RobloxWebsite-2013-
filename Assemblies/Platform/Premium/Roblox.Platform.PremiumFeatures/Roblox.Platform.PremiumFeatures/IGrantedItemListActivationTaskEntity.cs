using System;
using Roblox.Entities;
namespace Roblox.Platform.PremiumFeaturespublic {
    interface IGrantedItemListActivationTaskEntity : IUpdateableEntity<long>, IEntity<long>

{
	byte GrantedItemTypeId { get; set; }

	long PremiumFeatureActivationTaskId { get; set; }

	Guid? WorkerId { get; set; }

	DateTime? Completed { get; set; }

	DateTime? LeaseExpiration { get; set; }
}


}
