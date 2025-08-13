using System.Collections.Generic;

namespace Roblox.Platform.Permissions.Core;

public interface IPermissionGroupFactory
{
	/// <summary>
	/// Verifies that PermissionGroup is exist and returns it
	/// </summary>
	/// <param name="id">Id of permission group</param>
	/// <returns>Corresponding PermissionGroup</returns>
	IPermissionGroup CheckedGetPermissionGroup(long? id);

	/// <summary>
	/// Returns permission group for specified id or null (if it's not exist)
	/// </summary>
	/// <param name="id">Id of custom list</param>
	/// <returns>Corresponding CustomList</returns>
	IPermissionGroup GetPermissionGroup(long? id);

	/// <summary>
	/// Returns permission group for specified action
	/// </summary>
	/// <param name="actionType">Action type</param>
	/// <param name="actionTargetId">Action target id</param>
	/// <returns>Corresponding Permission Group</returns>
	IEnumerable<IPermissionGroup> GetPermissionGroupsByAction(string actionType, long actionTargetId);

	/// <summary>
	/// Returns permission groups for specified persmission
	/// </summary>
	/// <param name="permissionType">Permission Type</param>
	/// <param name="permissionTypeTargetId">Permission Type Target Id</param>
	/// <param name="allowAccess"></param>
	/// <param name="exclusiveStartId"></param>
	/// <param name="nextPageExclusiveStartId"></param>
	/// <returns>Corresponding permission groups</returns>
	IEnumerable<IPermissionGroup> GetPermissionGroupsByPermission(string permissionType, long? permissionTypeTargetId, bool allowAccess, long exclusiveStartId, out long nextPageExclusiveStartId);

	/// <summary>
	/// Creates a new permission group
	/// </summary>
	/// <param name="evaluateByAND"></param>
	/// <param name="name">Name of the group</param>
	/// <param name="creatorId">Id of creator</param>
	/// <param name="creatorType">Type of creater</param>
	/// <returns>New instance of IPermissionGroup</returns>
	IPermissionGroup CreatePermissionGroup(bool evaluateByAND, string name, long creatorId, string creatorType);
}
