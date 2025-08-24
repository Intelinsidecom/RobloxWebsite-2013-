using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal interface IUniverseScaleTypeEntity : IEntity<byte>
{
	string Value { get; }

	void Update();
}
