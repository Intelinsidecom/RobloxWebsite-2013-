using System.Collections.Generic;
using System.Linq;
using Api = Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public class ActionFactory
{
	private readonly Api.IPermissionsClient _PermissionsApiClient;

	public ActionFactory(Api.IPermissionsClient permissionsApiClient)
	{
		_PermissionsApiClient = permissionsApiClient;
	}

	public IEnumerable<IAction> GetActionsForPermissionGroup(long permissionGroupId, long exclusiveStartId, out long nextPageExclusiveStartId)
	{
		Api.EnumerativePageResult<long, long, Api.Action> result = _PermissionsApiClient.GetActionsForPermissionGroup(permissionGroupId, exclusiveStartId);
		nextPageExclusiveStartId = result.NextPageExclusiveStartId;
		return result.PageItems.Select((Api.Action a) => a.Translate());
	}
}
