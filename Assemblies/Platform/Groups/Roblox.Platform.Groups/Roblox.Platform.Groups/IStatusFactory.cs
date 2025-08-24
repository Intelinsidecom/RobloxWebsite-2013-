using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// A public interface for the factory class managing <see cref="T:Roblox.Platform.Groups.IStatus" />
/// </summary>
public interface IStatusFactory
{
	/// <summary>
	/// Posts a group status message by a user.
	/// </summary>
	/// <param name="group">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> posting.</param>
	/// <param name="message">The message to set as the status.</param>
	/// <param name="textFilter">The text filter</param>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Status" /> that was posted.</returns>
	/// <exception cref="T:Roblox.Platform.Groups.PostStatusPermissionException">The user does not have permission to post to the group's status.</exception>
	IStatus PostStatus(IGroup group, IUser user, string message);
}
