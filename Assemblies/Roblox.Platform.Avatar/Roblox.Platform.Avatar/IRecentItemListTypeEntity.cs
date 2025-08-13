using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal interface IRecentItemListTypeEntity : IEntity<byte>
{
	string Value { get; }

	void Update();
}
