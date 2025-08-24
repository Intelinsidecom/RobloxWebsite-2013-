using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarAnimationTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
