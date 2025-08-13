using Roblox.Entities;

namespace Roblox.PremiumFeatures;

public interface IGrantedItemListEntity : IUpdateableEntity<long>, IEntity<long>
{
	string Name { get; set; }
}
