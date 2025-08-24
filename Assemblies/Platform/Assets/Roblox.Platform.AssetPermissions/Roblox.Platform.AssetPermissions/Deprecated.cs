using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetPermissions.Properties;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.AssetPermissions;

public static class Deprecated
{
	private static int MaxUsersInWhiteList => Settings.Default.PlaceInviteOnlyUserLimit;

	private static PlaceVisitationPermissionType DoTranslate(this Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroup)
	{
		if (permissionGroup == null)
		{
			return PlaceVisitationPermissionType.Everyone;
		}
		if (permissionGroup.Name == PlaceVisitationPermissionType.Creator.ToString())
		{
			return PlaceVisitationPermissionType.Creator;
		}
		if (permissionGroup.Name == PlaceVisitationPermissionType.Friends.ToString())
		{
			return PlaceVisitationPermissionType.Friends;
		}
		if (permissionGroup.Name.Contains(PlaceVisitationPermissionType.Whitelist.ToString()))
		{
			return PlaceVisitationPermissionType.Whitelist;
		}
		throw new UnknownPlaceVisitationPermissionTypeException();
	}

	private static void AddAccessGroup(this IUser user, IPlace place, IActionType actionType, Roblox.Platform.Permissions.Core.IPermissionGroup newPermissionGroup, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient)
	{
		user.VerifyIsNotNull();
		place.VerifyIsNotNull();
		newPermissionGroup.VerifyIsNotNull();
		if (newPermissionGroup.DoTranslate() == PlaceVisitationPermissionType.Whitelist)
		{
			string whitelistName = PlaceVisitationPermissionType.Whitelist.ToPermissionGroupName(place.Id);
			ICustomList whitelist = user.CreateCustomList(whitelistName, permissionsApiClient);
			newPermissionGroup.AddPermission(allowAccess: true, PermissionType.IsInList.ToString(), whitelist.Id);
		}
		user.AddPermissionGroup(place, actionType, newPermissionGroup, permissionsApiClient);
	}

	private static bool Is(this Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroup, PlaceVisitationPermissionType accessType, long? placeId = null)
	{
		if (permissionGroup == null && accessType == PlaceVisitationPermissionType.Everyone)
		{
			return true;
		}
		if (permissionGroup == null)
		{
			return false;
		}
		if (accessType == PlaceVisitationPermissionType.Whitelist)
		{
			if (placeId.HasValue)
			{
				return permissionGroup.Name.Contains(PlaceVisitationPermissionType.Whitelist.ToString() + " for place " + placeId.Value);
			}
			return permissionGroup.Name.Contains(PlaceVisitationPermissionType.Whitelist.ToString());
		}
		return permissionGroup.Name == accessType.ToString();
	}

	private static void RemoveAccessGroup(this IUser user, IPlace place, IActionType actionType, Roblox.Platform.Permissions.Core.IPermissionGroup currentPermissionGroup, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient, CustomListFactory customListFactory)
	{
		user.VerifyIsNotNull();
		place.VerifyIsNotNull();
		currentPermissionGroup.VerifyIsNotNull();
		if (currentPermissionGroup.DoTranslate() == PlaceVisitationPermissionType.Whitelist)
		{
			ICustomList whitelist = GetPlaceVisitationWhitelist(currentPermissionGroup, customListFactory);
			currentPermissionGroup.RemovePermission(allowAccess: true, PermissionType.IsInList.ToString(), whitelist.Id);
			user.DeleteCustomList(whitelist);
		}
		user.RemovePermissionGroup(place, actionType, currentPermissionGroup, permissionsApiClient);
	}

	private static string ToPermissionGroupName(this PlaceVisitationPermissionType accessType, long? placeId = null)
	{
		return accessType switch
		{
			PlaceVisitationPermissionType.Everyone => throw new InvalidPlaceVisitationPermissionTypeException(PlaceVisitationPermissionType.Everyone), 
			PlaceVisitationPermissionType.Whitelist => PlaceVisitationPermissionType.Whitelist.ToString() + (placeId.HasValue ? (" for place " + placeId.Value) : ""), 
			_ => accessType.ToString(), 
		};
	}

	private static Roblox.Platform.Permissions.Core.IPermissionGroup Translate(this PlaceVisitationPermissionType accessType, IUser user, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient, long? placeId = null)
	{
		user.VerifyIsNotNull();
		return user.GetPermissionGroups(permissionsApiClient, 1).FirstOrDefault((Roblox.Platform.Permissions.Core.IPermissionGroup p) => p.Is(accessType, placeId));
	}

	private static void UpdateWhitelist(this IUser user, ICustomList whitelist, IEnumerable<long> currentUserIds, IEnumerable<long> newUserIds, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient)
	{
		user.VerifyIsNotNull();
		List<long> userIdsToAdd = newUserIds.Except(currentUserIds).ToList();
		List<long> userIdsToDelete = currentUserIds.Except(newUserIds).ToList();
		int numOfUsersWeCanAdd = MaxUsersInWhiteList - (currentUserIds.Count() - userIdsToDelete.Count());
		if (numOfUsersWeCanAdd < userIdsToAdd.Count())
		{
			userIdsToAdd = userIdsToAdd.Take(numOfUsersWeCanAdd).ToList();
		}
		foreach (long userIdToAdd in userIdsToAdd)
		{
			user.AddListMember(whitelist.Id, userIdToAdd, permissionsApiClient);
		}
		foreach (long userIdToDelete in userIdsToDelete)
		{
			user.DeleteListMember(whitelist.Id, userIdToDelete, permissionsApiClient);
		}
	}

	public static Roblox.Platform.Permissions.Core.IPermissionGroup CreateAccessPermissionGroup(this IUser user, PlaceVisitationPermissionType accessType, long placeId, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient)
	{
		if (accessType == PlaceVisitationPermissionType.Everyone)
		{
			return null;
		}
		Roblox.Platform.Permissions.Core.IPermissionGroup newPermissionGroup = user.CreatePermissionGroup(evaluateByAND: false, accessType.ToPermissionGroupName(placeId), permissionsApiClient);
		if (accessType == PlaceVisitationPermissionType.Creator)
		{
			newPermissionGroup.AddPermission(allowAccess: true, PermissionType.IsAssetCreator.ToString(), placeId);
		}
		if (accessType == PlaceVisitationPermissionType.Friends)
		{
			newPermissionGroup.AddPermission(allowAccess: true, PermissionType.IsFriend.ToString(), user.Id);
		}
		return newPermissionGroup;
	}

	public static IEnumerable<Roblox.Platform.Permissions.Core.IPermissionGroup> GetPlaceVisitationPermissionGroups(IUser user, IPlace place, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient)
	{
		user.VerifyIsNotNull();
		place.VerifyIsNotNull();
		user.VerifyIsCreator(place);
		return place.GetPlaceVisitationPermissionGroups(permissionsApiClient);
	}

	public static PlaceVisitationPermissionType GetPlaceVisitationPermissionType(IEnumerable<Roblox.Platform.Permissions.Core.IPermissionGroup> permissionGroups)
	{
		return permissionGroups.FirstOrDefault().DoTranslate();
	}

	public static ICustomList GetPlaceVisitationWhitelist(IEnumerable<Roblox.Platform.Permissions.Core.IPermissionGroup> permissionGroups, CustomListFactory customListFactory)
	{
		return GetPlaceVisitationWhitelist(permissionGroups.FirstOrDefault(), customListFactory);
	}

	public static ICustomList GetPlaceVisitationWhitelist(Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroup, CustomListFactory customListFactory)
	{
		Roblox.Platform.Permissions.Core.IPermission whitelistPermission = permissionGroup.GetPermissions(1).First((Roblox.Platform.Permissions.Core.IPermission p) => p.PermissionType == PermissionType.IsInList.ToString());
		return customListFactory.GetCustomList(whitelistPermission.PermissionTypeTargetId.Value);
	}

	public static bool IsOverWhitelistLengthLimit(int count)
	{
		return count > MaxUsersInWhiteList;
	}

	public static void SetAccess(IUser user, IPlace place, PlaceVisitationPermissionType newAccessType, Roblox.Permissions.Client.IPermissionsClient permissionsApiClient, CustomListFactory customListFactory, IEnumerable<long> whiteListUserIds = null)
	{
		user.VerifyIsNotNull();
		place.VerifyIsNotNull();
		user.VerifyIsCreator(place);
		PlaceVisitationPermissionType currentAccessType = GetPlaceVisitationPermissionType(GetPlaceVisitationPermissionGroups(user, place, permissionsApiClient));
		Roblox.Platform.Permissions.Core.IPermissionGroup newPermissionGroup = newAccessType.Translate(user, permissionsApiClient, place.Id);
		if (currentAccessType != newAccessType)
		{
			Roblox.Platform.Permissions.Core.IPermissionGroup currentPermissionGroup = currentAccessType.Translate(user, permissionsApiClient, place.Id);
			IActionType actionType = ActionTypeFactory.GetActionType("VisitPlace");
			if (newPermissionGroup == null)
			{
				newPermissionGroup = user.CreateAccessPermissionGroup(newAccessType, place.Id, permissionsApiClient);
			}
			if (currentPermissionGroup != null)
			{
				user.RemoveAccessGroup(place, actionType, currentPermissionGroup, permissionsApiClient, customListFactory);
			}
			if (newPermissionGroup != null)
			{
				user.AddAccessGroup(place, actionType, newPermissionGroup, permissionsApiClient);
			}
		}
		if (newAccessType == PlaceVisitationPermissionType.Whitelist)
		{
			if (whiteListUserIds == null)
			{
				whiteListUserIds = new List<long>();
			}
			ICustomList whitelist = GetPlaceVisitationWhitelist(newPermissionGroup, customListFactory);
			IEnumerable<long> currentWhiteListIds = whitelist.GetMembers(1);
			user.UpdateWhitelist(whitelist, currentWhiteListIds, whiteListUserIds, permissionsApiClient);
		}
	}

	public static PlaceVisitationPermissionType Translate(Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroup)
	{
		return permissionGroup.DoTranslate();
	}

	public static bool TryParse(string accessType, out PlaceVisitationPermissionType actualAccessType)
	{
		if (accessType.Contains(PlaceVisitationPermissionType.Whitelist.ToString()))
		{
			actualAccessType = PlaceVisitationPermissionType.Whitelist;
			return true;
		}
		return Enum.TryParse<PlaceVisitationPermissionType>(accessType, out actualAccessType);
	}
}
