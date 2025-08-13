using System.Collections.Generic;

namespace Roblox.Platform.Permissions.Core;

public interface IPermissionGroup
{
	long Id { get; }

	string Name { get; }

	string CreatorType { get; }

	long CreatorTargetId { get; }

	bool EvaluateByAND { get; }

	void AddPermission(bool allowAccess, string permissionType, long? permissionTypeTargetId = null);

	void Delete();

	IEnumerable<IPermission> GetPermissions(int pageNumber);

	void Update(string name, bool evaluateByAND);

	void RemovePermission(bool allowAccess, string permissionType, long? permissionTypeTargetId = null);
}
