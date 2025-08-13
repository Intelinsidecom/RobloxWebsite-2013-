using System.Collections.Generic;

namespace Roblox.Platform.Permissions.Core;

/// <summary>
/// Interface for checking permissions
/// </summary>
public interface IPermissionsChecker
{
	/// <summary>
	/// Checks whether a given action is permitted or not.
	/// </summary>
	/// <param name="action">string representing an action to be performed</param>
	/// <param name="args">IDictionary specifying action-related parameters (E.g., target userId for an attempted friend request.)</param>
	/// <returns>PermissionsStatus instance that specifies Success or Failure or whether permissions could be tested.</returns>
	PermissionsStatus CheckPermissions(string action, IDictionary<string, object> args);
}
