using Roblox.Entities;

namespace Roblox.PremiumFeatures;

public interface IGrantedItemEntity : IUpdateableEntity<long>, IEntity<long>
{
	long GrantedItemListId { get; set; }

	long GrantedItemTargetId { get; set; }

	byte GrantedItemTypeId { get; set; }
}
