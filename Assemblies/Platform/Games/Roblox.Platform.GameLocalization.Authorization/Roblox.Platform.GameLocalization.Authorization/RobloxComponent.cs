using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Authorization;

public class RobloxComponent : IRobloxComponent
{
	public string Name { get; }

	public string Description { get; }

	public long Id { get; }

	public RobloxComponent(string name, string description, long id)
	{
		Name = name ?? throw new PlatformArgumentNullException("name");
		Description = description ?? throw new PlatformArgumentNullException("description");
		Id = id;
	}
}
