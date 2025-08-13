using Roblox.Entities;

namespace Roblox.Platform.Avatar;

public interface IRecentItemTypeEntity : IEntity<byte>
{
	string Value { get; }

	void Update();
}
