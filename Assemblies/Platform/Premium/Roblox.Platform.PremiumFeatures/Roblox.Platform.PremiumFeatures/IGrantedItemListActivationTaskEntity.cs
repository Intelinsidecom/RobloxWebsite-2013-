using System;
using Roblox.Entities;

namespace Roblox.Platform.PremiumFeatures
{
    public interface IGrantedItemListActivationTaskEntity : IUpdateableEntity<long>, IEntity<long>
    {
        void ProcessTaskAndMarkComplete(PremiumFeatureActivationTask premiumFeatureActivationTask);

        byte GrantedItemTypeId { get; set; }

        long PremiumFeatureActivationTaskId { get; set; }

        Guid? WorkerId { get; set; }
	DateTime? Completed { get; set; }

	DateTime? LeaseExpiration { get; set; }
}


}
