using Roblox.Entities;

namespace Roblox.Platform.Games;

internal interface IGameAttributesEntity : IUpdateableEntity<long>, IEntity<long>
{
	long UniverseId { get; set; }

	bool IsSecure { get; set; }

	bool IsTrusted { get; set; }
}
