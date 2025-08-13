using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// Handles authorization around <see cref="!:IUniverse" />s
/// </summary>
public interface IGroupPermissionsVerifier
{
	/// <summary>
	/// Checks whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> can manage an <see cref="T:Roblox.Platform.Groups.IGroup" />. Right now, only group owners have permissions to manage group,
	/// but this could be changed to allow different rolesets to have this permission, if desired.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="group">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <returns><c>true</c> if <paramref name="group" /> can be managed by <paramref name="user" />.</returns>
	/// <exception cref="!:ArgumentNullException">Null <paramref name="user" />.</exception>
	/// <exception cref="!:ArgumentNullException">Null <paramref name="group" />.</exception>
	bool CanUserManageGroup(IUser user, IGroup group);
}
