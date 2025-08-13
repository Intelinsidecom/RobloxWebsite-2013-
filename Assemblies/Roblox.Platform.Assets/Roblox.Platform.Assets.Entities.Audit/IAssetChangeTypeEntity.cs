using Roblox.Entities;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetChangeTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }

	string Description { get; set; }
}
