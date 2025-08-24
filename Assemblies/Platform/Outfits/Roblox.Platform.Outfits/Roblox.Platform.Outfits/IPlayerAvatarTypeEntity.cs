using Roblox.Entities;

namespace Roblox.Platform.Outfits;

public interface IPlayerAvatarTypeEntity : IEntity<byte>
{
	string Value { get; }

	void Update();
}
