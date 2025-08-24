using Roblox.Entities;

namespace Roblox.PremiumFeatures;

public interface IGrantedItemTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
