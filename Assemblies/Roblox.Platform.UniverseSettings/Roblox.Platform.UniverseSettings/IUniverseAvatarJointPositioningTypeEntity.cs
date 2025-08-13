using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarJointPositioningTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
