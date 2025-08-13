using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public class PermissionGroupFactory : IPermissionGroupFactory
{
	private readonly IPermissionsClient _PermissionsApiClient;

	/// <summary>
	/// Constructor for <see cref="T:Roblox.Platform.Permissions.Core.PermissionGroupFactory" />
	/// </summary>
	/// <param name="permissionsApiClient">An <see cref="T:Roblox.Permissions.Client.IPermissionsClient" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="permissionsApiClient" /></exception>
	public PermissionGroupFactory(IPermissionsClient permissionsApiClient)
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
		return ((IPermissionGroup)(object)_PermissionsApiClient.GetPermissionGroup(id.Value, (int?)null)).Translate(_PermissionsApiClient);
	}

	/// <inheritdoc />
	public IEnumerable<IPermissionGroup> GetPermissionGroupsByAction(string actionType, long actionTargetId)
	{
		return from g in _PermissionsApiClient.GetPermissions(actionType, (long?)actionTargetId)
			select ((IPermissionGroup)(object)g).Translate(_PermissionsApiClient);
	}

	/// <inheritdoc />
	public IEnumerable<IPermissionGroup> GetPermissionGroupsByPermission(string permissionType, long? permissionTypeTargetId, bool allowAccess, long exclusiveStartId, out long nextPageExclusiveStartId)
	{
		EnumerativePageResult<long, long, PermissionGroup> result = _PermissionsApiClient.GetPermissionGroupsByPermission(permissionType, permissionTypeTargetId, allowAccess, exclusiveStartId);
		nextPageExclusiveStartId = result.NextPageExclusiveStartId;
		return result.PageItems.Select((PermissionGroup pg) => ((IPermissionGroup)(object)pg).Translate(_PermissionsApiClient));
	}

	/// <inheritdoc />
	public IPermissionGroup CreatePermissionGroup(bool evaluateByAND, string name, long creatorId, string creatorType)
	{
		return ((IPermissionGroup)(object)_PermissionsApiClient.CreatePermissionGroup(evaluateByAND, name, creatorId, creatorType)).Translate(_PermissionsApiClient);
	}
}
