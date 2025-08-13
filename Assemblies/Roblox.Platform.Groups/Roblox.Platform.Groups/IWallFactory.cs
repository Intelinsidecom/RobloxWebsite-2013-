namespace Roblox.Platform.Groups;

/// <summary>
/// The public interface for the factory producinng <see cref="T:Roblox.Platform.Groups.IWall" />s.
/// </summary>
public interface IWallFactory
{
	/// <summary>
	/// Gets the wall for the specified group.
	/// </summary>
	IWall GetGroupWall(IGroup group);
}
