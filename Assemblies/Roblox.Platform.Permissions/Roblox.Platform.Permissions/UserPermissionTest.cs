using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal abstract class UserPermissionTest : IUserPermissionTest
{
	public PermissionType PermissionType { get; internal set; }

	public long? AuthenticatedUserId { get; private set; }

	public long? PermissionTargetId { get; private set; }

	public long? ActionTargetId { get; private set; }

	protected UserPermissionTest(long? userId = null, long? permissionTargetId = null, long? actionTargetId = null)
	{
		AuthenticatedUserId = userId;
		PermissionTargetId = permissionTargetId;
		ActionTargetId = actionTargetId;
	}

	public abstract bool Test();
}
