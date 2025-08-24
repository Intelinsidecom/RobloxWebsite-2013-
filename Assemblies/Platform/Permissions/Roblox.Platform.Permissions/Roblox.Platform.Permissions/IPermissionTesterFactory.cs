using System;
using Roblox.Permissions.Client;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

/// <summary>
/// Interface for a factory of IPermissionTester instances.
/// </summary>
public interface IPermissionTesterFactory
{
	/// <summary>
	/// Register a Func&lt;IPermissionTester&gt; that creates evaluators (IPermissionTester objects) for the given PermissionType.
	/// Throws ArgumentException if given PermissionType has previously been registered.
	/// </summary>
	/// <param name="permissionType">PermissionType for which registration is being done.</param>
	/// <param name="permissionTester">Func&lt;IPermissionTester&gt;</param>
	void Register(PermissionType permissionType, Func<IPermissionTester> permissionTester);

	/// <summary>
	/// Create an IPermissionTester object that can evaluate the test for the given IPermission
	/// </summary>
	/// <param name="permissionDefinition">Roblox.Permissions.Client.IPermission instance.</param>
	/// <returns>Fresh IPermissionTester instance that is an evaluator for given permissionDefinition, or null if one cannot be created.</returns>
	IPermissionTester GetPermissionTester(IPermission permissionDefinition);
}
