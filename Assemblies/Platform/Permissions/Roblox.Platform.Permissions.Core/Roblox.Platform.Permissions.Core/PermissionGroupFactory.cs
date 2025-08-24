using System;
using System.Collections.Generic;
using System.Linq;
using Api = Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public class PermissionGroupFactory : IPermissionGroupFactory
{
	private readonly Api.IPermissionsClient _PermissionsApiClient;

	/// <summary>
	/// Constructor for <see cref="T:Roblox.Platform.Permissions.Core.PermissionGroupFactory" />
	/// </summary>
	/// <param name="permissionsApiClient">An <see cref="T:Roblox.Permissions.Client.IPermissionsClient" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="permissionsApiClient" /></exception>
	public PermissionGroupFactory(Api.IPermissionsClient permissionsApiClient)
	{
		_PermissionsApiClient = permissionsApiClient ?? throw new ArgumentNullException("permissionsApiClient");
	}

	/// <inheritdoc />
	public IPermissionGroup CheckedGetPermissionGroup(long? id)
	{
		IPermissionGroup permissionGroup = GetPermissionGroup(id);
		permissionGroup.VerifyIsNotNull();
		return permissionGroup;
	}

	/// <inheritdoc />
	public IPermissionGroup GetPermissionGroup(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return _PermissionsApiClient.GetPermissionGroup(id.Value, (int?)null).Translate(_PermissionsApiClient);
	}

	/// <inheritdoc />
	public IEnumerable<IPermissionGroup> GetPermissionGroupsByAction(string actionType, long actionTargetId)
	{
		return from g in _PermissionsApiClient.GetPermissions(actionType, (long?)actionTargetId)
			select g.Translate(_PermissionsApiClient);
	}

	/// <inheritdoc />
	public IEnumerable<IPermissionGroup> GetPermissionGroupsByPermission(string permissionType, long? permissionTypeTargetId, bool allowAccess, long exclusiveStartId, out long nextPageExclusiveStartId)
	{
		Api.EnumerativePageResult<long, long, Api.PermissionGroup> result = _PermissionsApiClient.GetPermissionGroupsByPermission(permissionType, permissionTypeTargetId, allowAccess, exclusiveStartId);
		nextPageExclusiveStartId = result.NextPageExclusiveStartId;
		return result.PageItems.Select((Api.PermissionGroup pg) => pg.Translate(_PermissionsApiClient));
	}

	/// <inheritdoc />
	public IPermissionGroup CreatePermissionGroup(bool evaluateByAND, string name, long creatorId, string creatorType)
	{
		return _PermissionsApiClient.CreatePermissionGroup(evaluateByAND, name, creatorId, creatorType).Translate(_PermissionsApiClient);
	}
}
