using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Permissions.Client;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServerPermissionsFactory : IPrivateServerPermissionsFactory
{
	internal const string _PrivateServerAccessActionType = "AccessPrivateServer";

	private const string _IsInListPermissionType = "IsInList";

	private const string _IsFriendPermissionType = "IsFriend";

	private const string _IsInClanPermissionType = "IsInClan";

	private const int _MaximumNumberOfAllowedClanIds = 2;

	private static readonly IReadOnlyCollection<long> _EmptyClanIdsCollection = new List<long>();

	internal IPermissionsClient _PermissionsClient { get; }

	internal PrivateServerDomainFactories _PrivateServerDomainFactories { get; }

	internal IPermissionGroupFactory _PermissionGroupFactory { get; }

	internal ICustomListFactory _CustomListFactory { get; }

	internal ActionFactory _ActionFactory { get; }

	/// <summary>
	/// Constructor for <see cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerPermissionsFactory" />.
	/// </summary>
	/// <param name="permissionsClient">An <see cref="T:Roblox.Permissions.Client.IPermissionsClient" /></param>
	/// <param name="privateServerDomainFactories">A <see cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerDomainFactories" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="permissionsClient" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="privateServerDomainFactories" /></exception>
	public PrivateServerPermissionsFactory(IPermissionsClient permissionsClient, PrivateServerDomainFactories privateServerDomainFactories)
		: this(permissionsClient, privateServerDomainFactories, new PermissionGroupFactory(permissionsClient), new CustomListFactory(permissionsClient), new ActionFactory(permissionsClient))
	{
	}

	internal PrivateServerPermissionsFactory(IPermissionsClient permissionsClient, PrivateServerDomainFactories privateServerDomainFactories, IPermissionGroupFactory permissionGroupFactory, ICustomListFactory customListFactory, ActionFactory actionFactory)
	{
		_PermissionsClient = permissionsClient ?? throw new ArgumentNullException("permissionsClient");
		_PrivateServerDomainFactories = privateServerDomainFactories ?? throw new ArgumentNullException("privateServerDomainFactories");
		_PermissionGroupFactory = permissionGroupFactory ?? new PermissionGroupFactory(_PermissionsClient);
		_CustomListFactory = customListFactory ?? new CustomListFactory(_PermissionsClient);
		_ActionFactory = actionFactory ?? new ActionFactory(_PermissionsClient);
	}

	/// <inheritdoc />
	public IPermissionGroup GetPrivateServerPermissionGroup(long privateServerId)
	{
		List<IPermissionGroup> permissionGroups = _PermissionGroupFactory.GetPermissionGroupsByAction("AccessPrivateServer", privateServerId).ToList();
		if (!permissionGroups.Any())
		{
			return null;
		}
		if (permissionGroups.Count > 1)
		{
			throw new PrivateServerPermissionGroupException($"Private Server (ID={privateServerId}) has {permissionGroups.Count} permission groups, should never have more than one");
		}
		return permissionGroups.FirstOrDefault();
	}

	/// <inheritdoc />
	public IPermissionGroup CreatePrivateServerPermissions(long privateServerId, long ownerUserId)
	{
		IPermissionGroup permissionGroup = _PermissionGroupFactory.CreatePermissionGroup(evaluateByAND: false, $"Private Server {privateServerId}", ownerUserId, "User");
		_PermissionsClient.ApplyPermissionGroupToAction("AccessPrivateServer", permissionGroup.Id, ownerUserId, "User", (long?)privateServerId);
		ICustomList customList = _CustomListFactory.CreateList($"Private Server {privateServerId} Whitelist ", ownerUserId, "User");
		permissionGroup.AddPermission(allowAccess: true, "IsInList", customList.Id);
		return permissionGroup;
	}

	/// <inheritdoc />
	public void AddPrivateServerFriendsAccess(long privateServerId, long ownerUserId)
	{
		IPermissionGroup permissionGroup = GetPrivateServerPermissionGroup(privateServerId);
		if (GetPrivateServerFriendsAccessPermission(permissionGroup) == null)
		{
			permissionGroup.AddPermission(allowAccess: true, "IsFriend", ownerUserId);
		}
	}

	/// <inheritdoc />
	public void RemovePrivateServerFriendsAccess(long privateServerId, long ownerUserId)
	{
		GetPrivateServerPermissionGroup(privateServerId)?.RemovePermission(allowAccess: true, "IsFriend", ownerUserId);
	}

	/// <inheritdoc />
	public bool DoesPrivateServerAllowFriends(long privateServerId)
	{
		IPermissionGroup permissionGroup = GetPrivateServerPermissionGroup(privateServerId);
		if (permissionGroup == null)
		{
			return false;
		}
		return GetPrivateServerFriendsAccessPermission(permissionGroup) != null;
	}

	/// <inheritdoc />
	public IReadOnlyCollection<long> GetPrivateServerClanIdsWithAccess(long privateServerId, IPermissionGroup permissionGroup = null)
	{
		if (permissionGroup == null)
		{
			permissionGroup = GetPrivateServerPermissionGroup(privateServerId);
		}
		if (permissionGroup == null)
		{
			return _EmptyClanIdsCollection;
		}
		return (IReadOnlyCollection<long>)(object)(from p in GetPrivateServerClanAccessPermissions(permissionGroup)
			where p.PermissionTypeTargetId.HasValue
			select p.PermissionTypeTargetId.Value).ToArray().ToArray();
	}

	/// <inheritdoc />
	public bool SetPrivateServerClanAccess(long privateServerId, IReadOnlyCollection<long> allowedClanIds, IPermissionGroup permissionGroup = null)
	{
		if (allowedClanIds.Count() > 2)
		{
			throw new ArgumentException("Number of allowed clan IDs exceeds maximum of " + 2);
		}
		if (permissionGroup == null)
		{
			permissionGroup = GetPrivateServerPermissionGroup(privateServerId);
		}
		long[] existingIds = GetPrivateServerClanIdsWithAccess(privateServerId, permissionGroup).ToArray();
		HashSet<long> existingIdsHashSet = new HashSet<long>(existingIds);
		HashSet<long> allowedIdsHashSet = new HashSet<long>(allowedClanIds);
		bool changedClans = false;
		foreach (long allowId in allowedClanIds.Where((long i) => !existingIdsHashSet.Contains(i)))
		{
			permissionGroup.AddPermission(allowAccess: true, "IsInClan", allowId);
			changedClans = true;
		}
		foreach (long existingId in existingIds.Where((long i) => !allowedIdsHashSet.Contains(i)))
		{
			permissionGroup.RemovePermission(allowAccess: true, "IsInClan", existingId);
			changedClans = true;
		}
		return changedClans;
	}

	/// <inheritdoc />
	public ICustomList GetPrivateServerWhitelist(long privateServerId)
	{
		IPermissionGroup permissionGroup = GetPrivateServerPermissionGroup(privateServerId);
		if (permissionGroup == null)
		{
			return null;
		}
		IPermission permission = GetPrivateServerWhitelistPermission(permissionGroup);
		if (permission == null)
		{
			return null;
		}
		return _CustomListFactory.GetCustomList(permission.PermissionTypeTargetId);
	}

	/// <inheritdoc />
	public void ClearPrivateServerWhitelist(long privateServerId)
	{
		ICustomList whitelist = GetPrivateServerWhitelist(privateServerId);
		if (whitelist == null)
		{
			return;
		}
		int page = 1;
		List<long> members;
		do
		{
			members = whitelist.GetMembers(page++).ToList();
			foreach (long member in members)
			{
				whitelist.RemoveMember(member);
			}
		}
		while (members.Any());
	}

	/// <inheritdoc />
	public bool DoesUserHaveAccessToPrivateServerInPlace(IUser user, IPrivateServer privateServer, IPlace place, IUserPermissionsChecker userPermissionsChecker, IUniverseFactory universeFactory, IGroupFactory groupFactory, bool userCanManage, string linkCode = null)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (privateServer == null)
		{
			throw new ArgumentNullException("privateServer");
		}
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (userPermissionsChecker == null)
		{
			throw new ArgumentNullException("userPermissionsChecker");
		}
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		if (groupFactory == null)
		{
			throw new ArgumentNullException("groupFactory");
		}
		IUniverse privateServerUniverse = universeFactory.GetUniverse(privateServer.UniverseId);
		IUniverse placeUniverse = universeFactory.GetPlaceUniverse(place);
		if (privateServerUniverse == null || placeUniverse == null || placeUniverse.Id != privateServerUniverse.Id)
		{
			return false;
		}
		PlayabilityResultEnum result;
		if (userCanManage)
		{
			if (!place.IsPlaceUniverseRooted(groupFactory, universeFactory, out result))
			{
				return false;
			}
		}
		else if (!place.IsPlaceUniverseRootedAndPublic(groupFactory, universeFactory, out result))
		{
			return false;
		}
		if (privateServer.StatusType != PrivateServerStatusType.Active || privateServer.ExpirationDate < DateTime.Now)
		{
			return false;
		}
		if (privateServer.OwnerUserId == user.Id || user.IsSoothSayer())
		{
			return true;
		}
		if (!string.IsNullOrEmpty(linkCode) && !string.IsNullOrEmpty(privateServer.LinkCode) && linkCode == privateServer.LinkCode)
		{
			return true;
		}
		return TestUserPrivateServerPermissions(user, privateServer.Id, userPermissionsChecker);
	}

	/// <inheritdoc />
	public bool TestUserPrivateServerPermissions(IUser user, long privateServerId, IUserPermissionsChecker userPermissionsChecker)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (userPermissionsChecker == null)
		{
			throw new ArgumentNullException("userPermissionsChecker");
		}
		PermissionsStatus permissionStatus = user.CheckPermissions(userPermissionsChecker, "AccessPrivateServer", privateServerId);
		if (permissionStatus.WasTested)
		{
			return permissionStatus.IsSuccess;
		}
		return false;
	}

	/// <inheritdoc />
	public bool DoesUserHavePermissionToInviteUserToPrivateServer(IUserPermissionsChecker userPermissionsChecker, IUser ownerUser, IUser invitedUser)
	{
		if (ownerUser == null)
		{
			return false;
		}
		if (invitedUser == null)
		{
			throw new ArgumentException("invitedUser");
		}
		_PrivateServerDomainFactories.PrivateServerPrivacySettingFactory.GetOrCreate(invitedUser);
		PermissionsStatus permissionStatus = ownerUser.CheckPermissions(userPermissionsChecker, UserPrivacySettingType.SendPrivateServerInvite.ToString(), invitedUser.Id);
		if (permissionStatus.WasTested)
		{
			return permissionStatus.IsSuccess;
		}
		return false;
	}

	/// <inheritdoc />
	public IReadOnlyCollection<long> GetPrivateServerIdsClanHasAccessTo(long clanId, long exclusiveStartId, out long nextPageExclusiveStartId)
	{
		long nextPageExclusiveStartId2;
		return (IReadOnlyCollection<long>)(object)(from pg in _PermissionGroupFactory.GetPermissionGroupsByPermission("IsInClan", clanId, allowAccess: true, exclusiveStartId, out nextPageExclusiveStartId)
			select _ActionFactory.GetActionsForPermissionGroup(pg.Id, 0L, out nextPageExclusiveStartId2) into a
			select a.First() into a
			where a.ActionTargetId.HasValue
			select a.ActionTargetId.Value).ToArray();
	}

	private static IPermission GetPrivateServerWhitelistPermission(IPermissionGroup permissionGroup)
	{
		foreach (IPermission perm in permissionGroup.GetPermissions(1))
		{
			if (Enum.TryParse<PermissionType>(perm.PermissionType, out var permissionType) && permissionType == PermissionType.IsInList)
			{
				return perm;
			}
		}
		return null;
	}

	private static IPermission GetPrivateServerFriendsAccessPermission(IPermissionGroup permissionGroup)
	{
		IEnumerable<IPermission> permissions = permissionGroup?.GetPermissions(1);
		if (permissions == null)
		{
			return null;
		}
		foreach (IPermission perm in permissions)
		{
			if (Enum.TryParse<PermissionType>(perm.PermissionType, out var permissionType) && permissionType == PermissionType.IsFriend)
			{
				return perm;
			}
		}
		return null;
	}

	/// <summary>
	/// Get the clan access permissions from an <see cref="T:Roblox.Platform.Permissions.Core.IPermissionGroup" />.
	/// </summary>
	/// <param name="permissionGroup">An <see cref="T:Roblox.Platform.Permissions.Core.IPermissionGroup" /></param>
	/// <returns>A list of clan acess <see cref="T:Roblox.Platform.Permissions.Core.IPermission" />s within <paramref name="permissionGroup" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="permissionGroup" /></exception>
	private static IEnumerable<IPermission> GetPrivateServerClanAccessPermissions(IPermissionGroup permissionGroup)
	{
		if (permissionGroup == null)
		{
			throw new ArgumentNullException("permissionGroup");
		}
		IEnumerable<IPermission> permissions = permissionGroup.GetPermissions(1);
		foreach (IPermission perm in permissions)
		{
			if (perm.PermissionTypeTargetId.HasValue && Enum.TryParse<PermissionType>(perm.PermissionType, out var permissionType) && permissionType == PermissionType.IsInClan)
			{
				yield return perm;
			}
		}
	}
}
