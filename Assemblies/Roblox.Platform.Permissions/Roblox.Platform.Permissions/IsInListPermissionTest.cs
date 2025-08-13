using Roblox.Permissions.Client;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsInListPermissionTest : UserPermissionTest
{
	private readonly IPermissionsClient _PermissionsClient;

	internal IsInListPermissionTest(IPermissionsClient permissionsClient, long? authenticatedUserId, long? targetId)
		: base(authenticatedUserId, targetId)
	{
		base.PermissionType = PermissionType.IsInList;
		_PermissionsClient = permissionsClient;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			if (User.Get(base.AuthenticatedUserId.Value) == null || !base.PermissionTargetId.HasValue)
			{
				return false;
			}
			return _PermissionsClient.IsListMember(base.PermissionTargetId.Value, base.AuthenticatedUserId.Value);
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
