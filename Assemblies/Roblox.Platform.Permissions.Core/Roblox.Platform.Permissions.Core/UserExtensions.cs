using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.Permissions.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Permissions.Core;

public static class UserExtensions
{
	public static IEnumerable<IPermissionGroup> GetPermissionGroups(this IUserIdentifier user, IPermissionsClient permissionsApiClient, int page)
	{
		return permissionsApiClient.GetPermissionGroups(user.Id, "User", (int?)page).PageItems.Select((PermissionGroup apiPermissionGroup) => ((IPermissionGroup)(object)apiPermissionGroup).Translate(permissionsApiClient));
	}

	public static IPermissionGroup CreatePermissionGroup(this IUserIdentifier user, bool evaluateByAND, string name, IPermissionsClient permissionsApiClient)
	{
		return ((IPermissionGroup)(object)permissionsApiClient.CreatePermissionGroup(evaluateByAND, name, user.Id, "User")).Translate(permissionsApiClient);
	}

	/// <summary>
	/// Gets Custom Lists for the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> provided.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <param name="permissionsApiClient">The <see cref="T:Roblox.Permissions.Client.IPermissionsClient" /> client.</param>
	/// <returns>An <see cref="T:System.Collections.IEnumerable" /> of lists.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation is not available, but may become available later.</exception>
	public static IEnumerable<ICustomList> GetCustomLists(this IUserIdentifier user, IPermissionsClient permissionsApiClient)
	{
		IEnumerable<List> apiLists;
		try
		{
			apiLists = permissionsApiClient.GetLists(user.Id, "User", (int?)1).PageItems;
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("Operation not available", e);
		}
		foreach (List apiList in apiLists)
		{
			yield return apiList.Translate(permissionsApiClient);
		}
	}

	public static ICustomList CreateCustomList(this IUserIdentifier user, string name, IPermissionsClient permissionsApiClient)
	{
		return permissionsApiClient.CreateList(name, user.Id, "User").Translate(permissionsApiClient);
	}

	public static void DeleteCustomList(this IUserIdentifier user, ICustomList customList)
	{
		user.VerifyIsNotNull();
		user.VerifyIsCreator(customList);
		customList.Delete();
	}

	public static void AddListMember(this IUserIdentifier user, long listId, long userId, IPermissionsClient permissionsApiClient)
	{
		permissionsApiClient.CreateListMember(listId, userId, user.Id, "User");
	}

	public static void DeleteListMember(this IUserIdentifier user, long listId, long userId, IPermissionsClient permissionsApiClient)
	{
		permissionsApiClient.DeleteListMember(listId, userId, user.Id, "User");
	}

	public static bool IsCreator(this IUserIdentifier user, IPermissionGroup permissionGroup)
	{
		user.VerifyIsNotNull();
		permissionGroup.VerifyIsNotNull();
		if (permissionGroup.CreatorType == "User")
		{
			return permissionGroup.CreatorTargetId == user.Id;
		}
		return false;
	}

	public static bool IsCreator(this IUserIdentifier user, ICustomList customList)
	{
		user.VerifyIsNotNull();
		customList.VerifyIsNotNull();
		if (customList.CreatorType == "User")
		{
			return customList.CreatorTargetId == user.Id;
		}
		return false;
	}

	public static void VerifyIsCreator(this IUserIdentifier user, IPermissionGroup permissionGroup)
	{
		if (!user.IsCreator(permissionGroup))
		{
			throw new InvalidCreatorException(permissionGroup, user);
		}
	}

	public static void VerifyIsCreator(this IUserIdentifier user, ICustomList customList)
	{
		if (!user.IsCreator(customList))
		{
			throw new InvalidCreatorException(customList, user);
		}
	}

	public static void AddPermissionGroup(this IUserIdentifier user, IActionType actionType, IPermissionGroup permissionGroup, IPermissionsClient permissionsApiClient, long? actionTargetTypeId = null)
	{
		user.VerifyIsNotNull();
		user.VerifyIsCreator(permissionGroup);
		actionType.AddPermissionGroup(permissionGroup, permissionsApiClient, actionTargetTypeId);
	}

	public static void RemovePermissionGroup(this IUserIdentifier user, IActionType actionType, IPermissionGroup permissionGroup, IPermissionsClient permissionsApiClient, long? actionTargetTypeId = null)
	{
		permissionGroup.VerifyIsNotNull();
		user.VerifyIsCreator(permissionGroup);
		actionType.RemovePermissionGroup(permissionGroup, permissionsApiClient, actionTargetTypeId);
	}
}
