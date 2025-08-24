using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
