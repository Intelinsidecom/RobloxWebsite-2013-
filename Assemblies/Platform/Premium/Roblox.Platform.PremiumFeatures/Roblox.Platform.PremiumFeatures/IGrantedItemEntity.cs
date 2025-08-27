using Roblox.Entities;
namespace Roblox.Platform.PremiumFeatures {
    public interface IGrantedItemEntity : IUpdateableEntity<long>, IEntity<long>
    {
        long GrantedItemListId { get; set; }

        long GrantedItemTargetId { get; set; }

        byte GrantedItemTypeId { get; set; }
    }
}
