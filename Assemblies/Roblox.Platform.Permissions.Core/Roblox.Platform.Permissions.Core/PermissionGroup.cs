using System.Collections.Generic;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

internal class PermissionGroup : IPermissionGroup
{
	private readonly IPermissionsClient _PermissionsApiClient;

	public long Id { get; }

	public string Name { get; private set; }

	public string CreatorType { get; }

	public long CreatorTargetId { get; }

	public bool EvaluateByAND { get; private set; }

	internal PermissionGroup(IPermissionsClient permissionsApiClient, long id, string name, string creatorType, long creatorTargetId, bool evaluateByAND)
	{
		_PermissionsApiClient = permissionsApiClient;
		Id = id;
		Name = name;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		EvaluateByAND = evaluateByAND;
	}

	public void AddPermission(bool allowAccess, string permissionType, long? permissionTypeTargetId = null)
	{
		_PermissionsApiClient.AddPermissionToPermissionGroup(Id, permissionType, allowAccess, CreatorTargetId, CreatorType, permissionTypeTargetId);
	}

	public void Delete()
	{
		_PermissionsApiClient.DeletePermissionGroup(Id, CreatorTargetId, CreatorType);
	}

	public IEnumerable<IPermission> GetPermissions(int pageNumber)
	{
		PermissionGroup permissionGroup = _PermissionsApiClient.GetPermissionGroup(Id, (int?)pageNumber);
		foreach (Permission apiClientPermission in permissionGroup.Permissions)
		{
			yield return new Permission(apiClientPermission.ID, apiClientPermission.AllowAccess, apiClientPermission.PermissionType, apiClientPermission.PermissionTypeTargetId);
		}
	}

	public void RemovePermission(bool allowAccess, string permissionType, long? permissionTypeTargetId = null)
	{
		_PermissionsApiClient.RemovePermissionFromPermissionGroup(Id, permissionType, allowAccess, CreatorTargetId, CreatorType, permissionTypeTargetId);
	}

	public void Update(string name, bool evaluateByAND)
	{
		_PermissionsApiClient.UpdatePermissionGroup(Id, evaluateByAND, name, CreatorTargetId, CreatorType);
		Name = name;
		EvaluateByAND = evaluateByAND;
	}
}
