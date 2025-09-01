using Roblox.Entities;
namespace Roblox.Moderation.Entities {
    interface IExpressionEntity : IUpdateableEntity<long>, IEntity<long>

{
	string Value { get; }
}


}
