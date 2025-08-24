using System.Collections.Generic;
using Roblox.Platform.CallContext;

namespace Roblox.Platform.Permissions;

/// <summary>
/// Interface for an evaluator of a specific test.
/// </summary>
public interface IPermissionTester
{
	/// <summary>
	/// Evaluate test and return true or false.
	/// </summary>
	/// <param name="callContext">ICallContext that provides session context under which to evaluate test.</param>
	/// <param name="actionParams">IDictionary that specifies any action-specific parameters.</param>
	/// <param name="permissionTypeTargetId">Reserved for future use.</param>
	/// <returns>bool: true if test succeeds, false if test fails.</returns>
	bool Test(ICallContext callContext, IDictionary<string, object> actionParams, long? permissionTypeTargetId);
}
