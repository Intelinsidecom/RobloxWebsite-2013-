using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Register event handlers on events related to CloudEdit instances 
/// </summary>
public interface ICloudEditEventHandlerRegistrar
{
	/// <summary>
	/// Handles the event for when a user is invited to a <see cref="T:Roblox.Platform.Universes.IUniverse" /> TeamCreate list
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="invitingUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> inviting <paramref name="addedUser" />.</param>
	/// <param name="addedUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> being added.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	void OnUserAddedToCloudEdit(IUniverse universe, IUser invitingUser, IUser addedUser);
}
