using System;
using Roblox.ApiClientBase;
using Roblox.PermissionResolution.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Platform.Studio;
using Roblox.Platform.Universes;
using Roblox.TeamCreate.Client;

namespace Roblox.Platform.TeamCreate;

internal class TeamCreatePermissionsVerifier : ITeamCreatePermissionsVerifier
{
	private readonly ITeamCreateClient _TeamCreateClient;

	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IUniverseCloudEditStatusProvider _UniverseCloudEditStatusProvider;

	private readonly IPermissionResolutionClient _PermissionResolutionClient;

	private const string _UniverseResourceType = "Universe";

	private const string _EditAction = "Edit";

	internal TeamCreatePermissionsVerifier(ITeamCreateClient teamCreateClient, IUniversePermissionsVerifier universePermissionsVerifier, IFriendshipFactory friendshipFactory, IUniverseCloudEditStatusProvider universeCloudEditStatusProvider, IPermissionResolutionClient permissionResolutionClient)
	{
		_TeamCreateClient = teamCreateClient ?? throw new ArgumentNullException("teamCreateClient");
		_UniversePermissionsVerifier = universePermissionsVerifier ?? throw new ArgumentNullException("universePermissionsVerifier");
		_FriendshipFactory = friendshipFactory ?? throw new ArgumentNullException("friendshipFactory");
		_UniverseCloudEditStatusProvider = universeCloudEditStatusProvider ?? throw new ArgumentNullException("universeCloudEditStatusProvider");
		_PermissionResolutionClient = permissionResolutionClient ?? throw new ArgumentNullException("permissionResolutionClient");
	}

	public bool IsUserTeamCreateMember(IUser user, IUniverse universe, bool? canUserManageUniverse = null)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (!IsTeamCreateEnabled(universe))
		{
			return false;
		}
		if (canUserManageUniverse.HasValue && canUserManageUniverse.Value)
		{
			return true;
		}
		if (_UniversePermissionsVerifier.CanUserManageUniverse(user, universe))
		{
			return true;
		}
		try
		{
			return _TeamCreateClient.IsTeamCreateMember(user.ToMembershipTarget(), universe.ToUniverseIdentifier()).IsMember;
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service call failed", e);
		}
	}

	public bool CanUserAddTeamCreateMember(IUser user, IUser targetUser, IUniverse universe)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (targetUser == null)
		{
			throw new PlatformArgumentNullException("targetUser");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (user.Id == targetUser.Id)
		{
			return false;
		}
		try
		{
			return _UniversePermissionsVerifier.CanUserManageUniverse(user, universe) && _FriendshipFactory.AreFriends(user.Id, targetUser.Id);
		}
		catch (Exception e)
		{
			throw new PlatformOperationUnavailableException("Friendship check failed", e);
		}
	}

	public bool CanUserRemoveTeamCreateMember(IUser user, IUser targetUser, IUniverse universe)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (targetUser == null)
		{
			throw new PlatformArgumentNullException("targetUser");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (user.Id == targetUser.Id)
		{
			return true;
		}
		if (!_UniversePermissionsVerifier.CanUserManageUniverse(targetUser, universe))
		{
			return _UniversePermissionsVerifier.CanUserManageUniverse(user, universe);
		}
		return false;
	}

	/// <summary>
	/// Checks whether or not an <see cref="T:Roblox.Platform.Universes.IUniverse" /> is enabled for team create.
	/// </summary>
	/// <remarks>
	/// This is currently excluded from code coverage because it is just a wrapper for external functionality.
	/// When the underlying code is moved into this platform the attribute should be removed, and unit tests added.
	/// </remarks>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><c>true</c> if the <see cref="T:Roblox.Platform.Universes.IUniverse" /> has team create enabled</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">universe</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Service request failed</exception>
	public bool IsTeamCreateEnabled(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		try
		{
			return _UniverseCloudEditStatusProvider.IsCloudEditEnabled(universe.Id) == true;
		}
		catch (Exception e)
		{
			throw new PlatformOperationUnavailableException("Service request failed", e);
		}
	}
}
