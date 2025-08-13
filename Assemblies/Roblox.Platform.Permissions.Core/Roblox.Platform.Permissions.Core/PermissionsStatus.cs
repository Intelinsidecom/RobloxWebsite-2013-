namespace Roblox.Platform.Permissions.Core;

/// <summary>
/// A struct of triplet data representing the status of a permission test.
/// </summary>
public struct PermissionsStatus
{
	private static readonly PermissionsStatus _Success = new PermissionsStatus(wasTested: true, isSuccess: true);

	private static readonly PermissionsStatus _Unavailable = new PermissionsStatus(wasTested: false, isSuccess: false);

	public PermissionType? PermissionType { get; }

	public bool IsSuccess { get; }

	public bool WasTested { get; }

	private PermissionsStatus(bool wasTested, bool isSuccess, PermissionType? permissionType = null)
	{
		WasTested = wasTested;
		IsSuccess = isSuccess;
		PermissionType = permissionType;
	}

	public static PermissionsStatus Failure(PermissionType permissionType)
	{
		return new PermissionsStatus(wasTested: true, isSuccess: false, permissionType);
	}

	public static PermissionsStatus Success()
	{
		return _Success;
	}

	public static PermissionsStatus Unavailable()
	{
		return _Unavailable;
	}

	/// <summary>
	/// Returns a string representation of the struct.
	/// </summary>
	public override string ToString()
	{
		if (!WasTested)
		{
			return string.Format("{0}.Unavailable", "PermissionsStatus");
		}
		if (IsSuccess)
		{
			return string.Format("{0}.Success", "PermissionsStatus");
		}
		return string.Format("{0}.Failure.{1}", "PermissionsStatus", PermissionType);
	}
}
