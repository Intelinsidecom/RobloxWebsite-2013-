using System.Collections.Generic;
using System.Linq;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public static class Extensions
{
	internal static IPermissionGroup Translate(this IPermissionGroup apiClientPermissionGroup, IPermissionsClient permissionsApiClient)
	{
		if (apiClientPermissionGroup == null)
		{
			return null;
		}
		return new PermissionGroup(permissionsApiClient, apiClientPermissionGroup.ID, apiClientPermissionGroup.Name, apiClientPermissionGroup.CreatorType, apiClientPermissionGroup.CreatorId, apiClientPermissionGroup.EvaluateByAND);
	}

	internal static IAction Translate(this Action apiAction)
	{
		return new Action(apiAction.ActionType, apiAction.ActionTargetId);
	}

	internal static ICustomList Translate(this List apiList, IPermissionsClient permissionsApiClient)
	{
		if (apiList == null)
		{
			return null;
		}
		return new CustomList(permissionsApiClient, apiList.ID, apiList.Name, apiList.CreatorType, apiList.CreatorId);
	}

	public static void AddPermissionGroup(this IActionType actionType, IPermissionGroup permissionGroup, IPermissionsClient permissionsApiClient, long? actionTargetTypeId = null)
	{
		permissionGroup.VerifyIsNotNull();
		permissionsApiClient.ApplyPermissionGroupToAction(actionType.Value, permissionGroup.Id, permissionGroup.CreatorTargetId, permissionGroup.CreatorType, actionTargetTypeId);
	}

	public static IEnumerable<IPermissionGroup> GetPermissionGroups(this IActionType actionType, long? targetId, IPermissionsClient permissionsApiClient)
	{
		return from apiPermissionGroup in permissionsApiClient.GetPermissions(actionType.Value, targetId)
			select ((IPermissionGroup)(object)apiPermissionGroup).Translate(permissionsApiClient);
	}

	public static void RemovePermissionGroup(this IActionType actionType, IPermissionGroup permissionGroup, IPermissionsClient permissionsApiClient, long? actionTargetTypeId = null)
	{
		permissionGroup.VerifyIsNotNull();
		permissionsApiClient.RemovePermissionGroupFromAction(actionType.Value, permissionGroup.Id, permissionGroup.CreatorTargetId, permissionGroup.CreatorType, actionTargetTypeId);
	}

	public static bool IsCustomList(this IPermission permission, IPermissionsClient permissionsApiClient)
	{
		return permission.PermissionType == PermissionType.IsInList.ToString();
	}

	public static void VerifyIsNotNull(this ICustomList customList, long? id = null)
	{
		if (customList == null)
		{
			if (id.HasValue)
			{
				throw new UnknownCustomListException(id.Value);
			}
			throw new UnknownCustomListException();
		}
	}

	public static void VerifyIsNotNull(this IPermissionGroup permissionGroup, long? id = null)
	{
		if (permissionGroup == null)
		{
			if (id.HasValue)
			{
				throw new UnknownPermissionGroupException(id.Value);
			}
			throw new UnknownPermissionGroupException();
		}
	}
}
