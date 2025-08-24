using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

public interface IUserPermissionTest
{
	PermissionType PermissionType { get; }

	long? AuthenticatedUserId { get; }

	long? PermissionTargetId { get; }

	long? ActionTargetId { get; }

	bool Test();
}
