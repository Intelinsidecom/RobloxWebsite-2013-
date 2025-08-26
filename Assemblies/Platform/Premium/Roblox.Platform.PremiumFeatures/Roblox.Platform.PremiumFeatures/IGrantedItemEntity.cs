using Roblox.Entities;
namespace Roblox.Platform.PremiumFeaturespublic {
    interface IGrantedItemEntity : IUpdateableEntity<long>, IEntity<long>

{
	long GrantedItemListId { get; set; }

	long GrantedItemTargetId { get; set; }

	byte GrantedItemTypeId { get; set; }
}


}
