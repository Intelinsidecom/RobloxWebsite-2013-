using System;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgePermissionsVerifier" />
internal class BadgePermissionsVerifier : IBadgePermissionsVerifier
{
	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly IGroupFactory _GroupFactory;

	private readonly IGroupMembershipFactory _GroupMembershipFactory;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IAssetPermissionsVerifier _AssetPermissionsVerifier;

	private readonly IUniverseFactory _UniverseFactory;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgePermissionsVerifier" />
	/// </summary>
	/// <param name="universePermissionsVerifier">An <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" />.</param>
	/// <param name="groupMembershipFactory">An <see cref="T:Roblox.Platform.Groups.IGroupMembershipFactory" />.</param>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="assetPermissionsVerifier">An <see cref="T:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier" />.</param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="universePermissionsVerifier" />,
	/// <paramref name="groupFactory" />, 
	/// <paramref name="groupMembershipFactory" />
	/// <paramref name="placeFactory" />, 
	/// <paramref name="assetPermissionsVerifier" />,
	/// <paramref name="universeFactory" />
	/// </exception>
	public BadgePermissionsVerifier(IUniversePermissionsVerifier universePermissionsVerifier, IGroupFactory groupFactory, IGroupMembershipFactory groupMembershipFactory, IPlaceFactory placeFactory, IAssetPermissionsVerifier assetPermissionsVerifier, IUniverseFactory universeFactory)
	{
		_UniversePermissionsVerifier = universePermissionsVerifier ?? throw new ArgumentNullException("universePermissionsVerifier");
		_GroupFactory = groupFactory ?? throw new ArgumentNullException("groupFactory");
		_GroupMembershipFactory = groupMembershipFactory ?? throw new ArgumentNullException("groupMembershipFactory");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_AssetPermissionsVerifier = assetPermissionsVerifier ?? throw new ArgumentNullException("assetPermissionsVerifier");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgePermissionsVerifier.CanUserCreateBadgeForUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserCreateBadgeForUniverse(IUser user, IUniverse universe)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (universe.CreatorType.Equals(Roblox.Platform.Core.CreatorType.Group.ToString()))
		{
			IGroup group = _GroupFactory.GetById(universe.CreatorTargetId);
			if (group != null)
			{
				IGroupMembership groupMembership = _GroupMembershipFactory.Get(group, user);
				if (!groupMembership.RoleSet.HasPermission(Roblox.Platform.Groups.GroupRoleSetPermissionType.CanSpendGroupFunds) || !groupMembership.RoleSet.HasPermission(Roblox.Platform.Groups.GroupRoleSetPermissionType.CanManageItems))
				{
					return false;
				}
			}
		}
		return _UniversePermissionsVerifier.CanUserManageUniverse(user, universe);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgePermissionsVerifier.CanAwardBadge(Roblox.Platform.Assets.IPlace,Roblox.Platform.Badges.Badge)" />
	public bool CanAwardBadge(IPlace place, Badge badge)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (badge.IsEnabled)
		{
			IBadgeAwarder awarder = badge.Awarder;
			if (awarder != null && awarder.Type == BadgeAwarderType.Place)
			{
				if (badge.Awarder.Id == place.Id)
				{
					return true;
				}
				IUniverse badgeUniverse = _UniverseFactory.GetPlaceUniverse(badge.Awarder.Id);
				if (badgeUniverse == null)
				{
					return false;
				}
				if (badgeUniverse.RootPlaceId == place.Id)
				{
					return true;
				}
				return _UniverseFactory.GetPlaceUniverse(place)?.Id == badgeUniverse.Id;
			}
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgePermissionsVerifier.CanUserManageBadge(Roblox.Platform.Membership.IUser,Roblox.Platform.Badges.Badge)" />
	public bool CanUserManageBadge(IUser user, Badge badge)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		IBadgeAwarder badgeAwarder = badge.Awarder;
		if (badgeAwarder == null || badgeAwarder.Type != BadgeAwarderType.Place)
		{
			return false;
		}
		IPlace place = _PlaceFactory.Get(badgeAwarder.Id);
		if (place == null)
		{
			return false;
		}
		return _AssetPermissionsVerifier.CanManage(user, place);
	}
}
