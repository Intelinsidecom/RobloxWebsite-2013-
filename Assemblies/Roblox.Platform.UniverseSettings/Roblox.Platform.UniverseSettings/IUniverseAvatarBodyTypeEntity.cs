using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarBodyTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
