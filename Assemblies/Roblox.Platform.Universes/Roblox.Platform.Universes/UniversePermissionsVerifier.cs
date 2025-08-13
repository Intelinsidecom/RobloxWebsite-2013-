using System;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Universes;

/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />
public class UniversePermissionsVerifier : IUniversePermissionsVerifier
{
	private readonly IGroupMembershipFactory _GroupMembershipFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.UniversePermissionsVerifier" /> class.
	/// </summary>
	/// <param name="groupMembershipFactory">The <see cref="T:Roblox.Platform.Groups.IGroupMembershipFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Null <paramref name="groupMembershipFactory" />.</exception>
	public UniversePermissionsVerifier(IGroupMembershipFactory groupMembershipFactory)
	{
		_GroupMembershipFactory = groupMembershipFactory.AssignOrThrowIfNull("groupMembershipFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserManageUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserManageUniverse(IUser user, IUniverse universe)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		Roblox.Platform.Core.CreatorType universeCreatorType = (Roblox.Platform.Core.CreatorType)Enum.Parse(typeof(Roblox.Platform.Core.CreatorType), universe.CreatorType);
		if (universeCreatorType.Equals(Roblox.Platform.Core.CreatorType.User))
		{
			return universe.CreatorTargetId == user.Id;
		}
		if (universeCreatorType.Equals(Roblox.Platform.Core.CreatorType.Group))
		{
			return _GroupMembershipFactory.CheckedGet(universe.CreatorTargetId, user.Id).RoleSet.HasPermission(Roblox.Platform.Groups.GroupRoleSetPermissionType.CanManageGroupGames);
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserPlayUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	/// <remarks>Currently only returns false as PermissionResolution will be the source for this information.</remarks>
	public bool CanUserPlayUniverse(IUser user, IUniverse universe)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return false;
	}
}
