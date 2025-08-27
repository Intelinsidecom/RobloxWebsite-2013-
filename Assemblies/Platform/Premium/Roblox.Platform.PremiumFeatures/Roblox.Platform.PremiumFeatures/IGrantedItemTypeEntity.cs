using Roblox.Entities;
namespace Roblox.Platform.PremiumFeatures {
    public interface IGrantedItemTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
    {
        string Value { get; set; }
    }
}
