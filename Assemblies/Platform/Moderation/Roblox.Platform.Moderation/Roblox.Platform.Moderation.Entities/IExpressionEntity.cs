using Roblox.Entities;

namespace Roblox.Platform.Moderation.Entities;

internal interface IExpressionEntity : IUpdateableEntity<long>, IEntity<long>
{
	string Value { get; }
}
