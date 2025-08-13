using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

/// <summary>
/// Creates/gets <see cref="T:Roblox.Platform.Permissions.Core.IPermissionGroup" />s and <see cref="T:Roblox.Platform.Permissions.Core.IPermission" />s for private servers.
/// Exposes helper methods for working with private server permissions and permission groups.
/// </summary>
public interface IPrivateServerPermissionsFactory
{
	/// <summary>
	/// Get a private server's permission group.
	/// </summary>
	/// <param name="privateServerId">ID of private server to get the permission group for.</param>
	/// <returns>Permission group for private server <paramref name="privateServerId" /> or null if private server has no permission group.</returns>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	IPermissionGroup GetPrivateServerPermissionGroup(long privateServerId);

	/// <summary>
	/// Create permission group for private server given the ID of the server's owner.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to create a permission group for.</param>
	/// <param name="ownerUserId">ID of the user that owns the private server.</param>
	/// <returns>Newly created permission group for private server <paramref name="privateServerId" /> owned by <paramref name="ownerUserId" /></returns>
	IPermissionGroup CreatePrivateServerPermissions(long privateServerId, long ownerUserId);

	/// <summary>
	/// Adds friends access to private server.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to add friends access to.</param>
	/// <param name="ownerUserId">ID of the user that owns the private server.</param>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	void AddPrivateServerFriendsAccess(long privateServerId, long ownerUserId);

	/// <summary>
	/// Remove friends access from private server.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to remove friends access from.</param>
	/// <param name="ownerUserId">ID of the user that owns the private server.</param>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	void RemovePrivateServerFriendsAccess(long privateServerId, long ownerUserId);

	/// <summary>
	/// Returns whether private server has friends access enabled.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to check for friends access.</param>
	/// <returns>Whether private server <paramref name="privateServerId" /> has friends access enabled.</returns>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	bool DoesPrivateServerAllowFriends(long privateServerId);

	/// <summary>
	/// Get the clan IDs for that have access to private server.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to find clan IDs which have access.</param>
	/// <param name="permissionGroup">Permission group to use instead of the private server <paramref name="privateServerId" />'s current permission group.</param>
	/// <returns>A collection of clan IDs that have access to private server <paramref name="privateServerId" /> given a non-null <paramref name="permissionGroup" />. Otherwise, determines the clan IDs based on the existing permission groups associated with private server <paramref name="privateServerId" />.</returns>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if <paramref name="permissionGroup" /> is <c>null</c> and private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	IReadOnlyCollection<long> GetPrivateServerClanIdsWithAccess(long privateServerId, IPermissionGroup permissionGroup = null);

	/// <summary>
	/// Set clan access to private server.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to set clan access for.</param>
	/// <param name="allowedClanIds">Collection of clan IDs to give access to private server <paramref name="privateServerId" />.</param>
	/// <param name="permissionGroup">Permission group to use instead of private server <paramref name="privateServerId" />'s current permission group.</param>
	/// <returns><c>true</c> if the set of allowed clans on private server <paramref name="privateServerId" /> changed, <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="allowedClanIds" /> exceeds the maximum number of allowed clan IDs for private servers.</exception>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	bool SetPrivateServerClanAccess(long privateServerId, IReadOnlyCollection<long> allowedClanIds, IPermissionGroup permissionGroup = null);

	/// <summary>
	/// Gets whitelist for private server.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to get the whitelist of.</param>
	/// <returns>Whitelist for private server <paramref name="privateServerId" /> unless server does not have a permission group or a whitelist permission, in which case <c>null</c> is returned.</returns>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	ICustomList GetPrivateServerWhitelist(long privateServerId);

	/// <summary>
	/// Removes all existing members from private server whitelist.
	/// </summary>
	/// <param name="privateServerId">ID of the private server to clear the whitelist of.</param>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionGroupException">Thrown if private server <paramref name="privateServerId" /> has more than one permission group.</exception>
	void ClearPrivateServerWhitelist(long privateServerId);

	/// <summary>
	/// Returns whether an <see cref="T:Roblox.Platform.Membership.IUser" /> can access an <see cref="T:Roblox.Platform.Games.PrivateServer.IPrivateServer" />.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="privateServer">An <see cref="T:Roblox.Platform.Games.PrivateServer.IPrivateServer" /></param>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="userPermissionsChecker">An <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="userCanManage">A <c>bool</c> indicating whether <paramref name="user" /> (if provided) can manage <paramref name="privateServer" />.</param>
	/// <param name="linkCode">A special <c>string</c> that gives <paramref name="user" /> access to <paramref name="privateServer" /> even if they wouldn't have access otherwise (optional).</param>
	/// <returns><c>true</c> if <paramref name="user" /> has access to <paramref name="privateServer" />, <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="privateServer" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userPermissionsChecker" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	bool DoesUserHaveAccessToPrivateServerInPlace(IUser user, IPrivateServer privateServer, IPlace place, IUserPermissionsChecker userPermissionsChecker, IUniverseFactory universeFactory, IGroupFactory groupFactory, bool userCanManage, string linkCode = null);

	/// <summary>
	/// Returns whether an <see cref="T:Roblox.Platform.Membership.IUser" /> has private server access permissions.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="privateServerId">ID of the private server to check <paramref name="user" />'s access to.</param>
	/// <param name="userPermissionsChecker">An <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" /></param>
	/// <returns><c>true</c> if <paramref name="user" /> has private server access for private server <paramref name="privateServerId" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userPermissionsChecker" /></exception>
	bool TestUserPrivateServerPermissions(IUser user, long privateServerId, IUserPermissionsChecker userPermissionsChecker);

	/// <summary>
	/// Returns whether an <see cref="T:Roblox.Platform.Membership.IUser" /> has permission to invite another user to their private servers.
	/// </summary>
	/// <param name="userPermissionsChecker">An <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" /></param>
	/// <param name="ownerUser">Owner <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="invitedUser">Invited <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns><c>true</c> if <paramref name="ownerUser" /> is non-null and has permission to invite <paramref name="invitedUser" />, <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="invitedUser" /></exception>
	bool DoesUserHavePermissionToInviteUserToPrivateServer(IUserPermissionsChecker userPermissionsChecker, IUser ownerUser, IUser invitedUser);

	/// <summary>
	/// Gets a collection of private server IDs that a clan has access to.
	/// </summary>
	/// <param name="clanId">Clan ID</param>
	/// <param name="exclusiveStartId">Page ID to start the query on.</param>
	/// <param name="nextPageExclusiveStartId">Output parameter indicating the next page to query.</param>
	/// <returns>A collections of private server IDs.</returns>
	IReadOnlyCollection<long> GetPrivateServerIdsClanHasAccessTo(long clanId, long exclusiveStartId, out long nextPageExclusiveStartId);
}
