using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class WallFactory : IWallFactory
{
	private readonly IWallPostEntityFactory _WallPostEntityFactory;

	public WallFactory()
	{
		_WallPostEntityFactory = new WallPostEntityFactory();
	}

	/// <inheritdoc />
	public IWall GetGroupWall(IGroup group)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
		return new Wall(_WallPostEntityFactory, group);
	}
}
