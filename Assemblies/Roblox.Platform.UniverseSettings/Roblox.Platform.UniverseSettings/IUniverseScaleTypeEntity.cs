using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseScaleTypeEntity : IEntity<byte>
{
	string Value { get; }
}
