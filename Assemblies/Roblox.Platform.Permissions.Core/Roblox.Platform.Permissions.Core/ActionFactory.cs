using System.Collections.Generic;
using System.Linq;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public class ActionFactory
{
	private readonly IPermissionsClient _PermissionsApiClient;

	public ActionFactory(IPermissionsClient permissionsApiClient)
	{
		_PermissionsApiClient = permissionsApiClient;
	}

	public IEnumerable<IAction> GetActionsForPermissionGroup(long permissionGroupId, long exclusiveStartId, out long nextPageExclusiveStartId)
	{
		EnumerativePageResult<long, long, Action> result = _PermissionsApiClient.GetActionsForPermissionGroup(permissionGroupId, exclusiveStartId);
		nextPageExclusiveStartId = result.NextPageExclusiveStartId;
		return result.PageItems.Select((Action a) => a.Translate());
	}
}
