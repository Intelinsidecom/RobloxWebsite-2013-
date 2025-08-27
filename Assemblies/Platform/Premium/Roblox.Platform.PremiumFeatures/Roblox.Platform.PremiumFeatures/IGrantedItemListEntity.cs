using Roblox.Entities;
namespace Roblox.Platform.PremiumFeatures
{
    public interface IGrantedItemListEntity : IUpdateableEntity<long>, IEntity<long>

{
	string Name { get; set; }
}


}
