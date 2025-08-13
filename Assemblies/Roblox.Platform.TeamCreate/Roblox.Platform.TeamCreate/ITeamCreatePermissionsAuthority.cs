using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// An interface for a class that performs actions around team create
/// </summary>
public interface ITeamCreatePermissionsAuthority
{
	/// <summary>
	/// Adds an <see cref="T:Roblox.Platform.Membership.IUser" /> to have permission to team create an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> inviting <paramref name="targetUser" /> to team create.</param>
	/// <param name="targetUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> being added to team create.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to team create service failed.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException"><paramref name="user" /> does not have permission to add <paramref name="targetUser" /> to team create.</exception>
	void AddTeamCreateMember(IUser user, IUser targetUser, IUniverse universe);

	/// <summary>
	/// Removes an <see cref="T:Roblox.Platform.Membership.IUser" />'s permission to team create an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> removing <paramref name="targetUser" />.</param>
	/// <param name="targetUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> being removed from team create.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to team create service failed.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException"><paramref name="user" /> does not have permission to remove <paramref name="targetUser" /> from team create.</exception>
	void RemoveTeamCreateMember(IUser user, IUser targetUser, IUniverse universe);

	/// <summary>
	/// Enables an <see cref="T:Roblox.Platform.Universes.IUniverse" /> for team create.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Internal service call failed.</exception>
	void EnableTeamCreate(IUniverse universe);

	/// <summary>
	/// Disables an <see cref="T:Roblox.Platform.Universes.IUniverse" /> for team create.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Internal service call failed.</exception>
	void DisableTeamCreate(IUniverse universe);
}
