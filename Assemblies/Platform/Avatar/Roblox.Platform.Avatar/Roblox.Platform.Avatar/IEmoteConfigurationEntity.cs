using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal interface IEmoteConfigurationEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AssetId { get; set; }

	long UserId { get; set; }

	byte Position { get; set; }
}
