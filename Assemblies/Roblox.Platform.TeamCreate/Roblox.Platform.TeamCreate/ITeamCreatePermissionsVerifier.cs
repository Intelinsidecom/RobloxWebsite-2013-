using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// An interface for a class that verifies permissions around team create
/// </summary>
public interface ITeamCreatePermissionsVerifier
{
	/// <summary>
	/// Checks whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> is allowed to join a team create
	/// session for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="canUserManageUniverse">(Optional) Whether the user has permissions to manage the universe.</param>
	/// <returns><c>true</c> if the <see cref="T:Roblox.Platform.Membership.IUser" /> is allowed to team create <see cref="T:Roblox.Platform.Universes.IUniverse" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to team create service failed.</exception>
	bool IsUserTeamCreateMember(IUser user, IUniverse universe, bool? canUserManageUniverse = null);

	/// <summary>
	/// Determines whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> can add another <see cref="T:Roblox.Platform.Membership.IUser" /> to team create an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> adding the target user.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="targetUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> being added to team create.</param>
	/// <returns><c>true</c> if <paramref name="user" /> can add <paramref name="targetUser" /> to the <see cref="T:Roblox.Platform.Universes.IUniverse" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to friendship service failed.</exception>
	bool CanUserAddTeamCreateMember(IUser user, IUser targetUser, IUniverse universe);

	/// <summary>
	/// Determines whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> can remove another <see cref="T:Roblox.Platform.Membership.IUser" /> from team create on an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> removing the target user.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="targetUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> being removed from team create.</param>
	/// <returns><c>true</c> if <paramref name="user" /> can remove <paramref name="targetUser" /> from the <see cref="T:Roblox.Platform.Universes.IUniverse" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	bool CanUserRemoveTeamCreateMember(IUser user, IUser targetUser, IUniverse universe);

	/// <summary>
	/// Checks whether or not an <see cref="T:Roblox.Platform.Universes.IUniverse" /> is enabled for team create.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><c>true</c> if the <see cref="T:Roblox.Platform.Universes.IUniverse" /> has team create enabled</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Internal service request failed.</exception>
	bool IsTeamCreateEnabled(IUniverse universe);
}
