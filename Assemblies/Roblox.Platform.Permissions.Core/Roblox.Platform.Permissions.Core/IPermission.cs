namespace Roblox.Platform.Permissions.Core;

public interface IPermission
{
	long Id { get; }

	bool AllowAccess { get; }

	string PermissionType { get; }

	long? PermissionTypeTargetId { get; }
}
