using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsAssetCreatorPermissionTest : UserPermissionTest
{
	internal IsAssetCreatorPermissionTest(long? userId, long? actionTargetId)
		: base(userId, null, actionTargetId)
	{
		base.PermissionType = PermissionType.IsAssetCreator;
	}

	public override bool Test()
	{
		if (!base.ActionTargetId.HasValue)
		{
			return false;
		}
		if (base.AuthenticatedUserId.HasValue)
		{
			Asset asset = Asset.Get(base.ActionTargetId);
			User user = User.Get(base.AuthenticatedUserId.Value);
			if (asset == null || user == null)
			{
				return false;
			}
			return asset.IsCreator(user);
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
