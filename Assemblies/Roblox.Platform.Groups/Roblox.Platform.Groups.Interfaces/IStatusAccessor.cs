namespace Roblox.Platform.Groups.Interfaces;

/// <summary>
/// Interface for a class that accesses <see cref="T:Roblox.Platform.Groups.IStatus" />
/// </summary>
public interface IStatusAccessor
{
	/// <summary>
	/// Gets the latest group status for an <see cref="T:Roblox.Platform.Groups.IGroup" />
	/// </summary>
	/// <param name="group">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Groups.IStatus" /></returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if group is null.</exception>
	IStatus GetStatus(IGroup group);
}
