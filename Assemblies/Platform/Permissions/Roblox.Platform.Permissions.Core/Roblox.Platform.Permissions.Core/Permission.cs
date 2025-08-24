namespace Roblox.Platform.Permissions.Core;

internal class Permission : IPermission
{
	public long Id { get; }

	public bool AllowAccess { get; }

	public string PermissionType { get; }

	public long? PermissionTypeTargetId { get; }

	internal Permission(long id, bool allowAccess, string permissionType, long? permissionTypeTargetId)
	{
		Id = id;
		AllowAccess = allowAccess;
		PermissionType = permissionType;
		PermissionTypeTargetId = permissionTypeTargetId;
	}
}
