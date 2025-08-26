using Roblox.Entities;
namespace Roblox.Moderation.Entitiesinternal {
    interface IExpressionEntity : IUpdateableEntity<long>, IEntity<long>

{
	string Value { get; }
}


}
