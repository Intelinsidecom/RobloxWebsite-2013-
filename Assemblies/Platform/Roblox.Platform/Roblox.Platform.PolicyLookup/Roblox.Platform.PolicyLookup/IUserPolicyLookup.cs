using System.Collections.Generic;
using Roblox.RequestContext;

namespace Roblox.Platform.PolicyLookup;

/// <summary>
/// The interface for a class that is able to look up the list of <see cref="T:Roblox.RequestContext.Policy" /> that are applicable to a target user.
/// </summary>
public interface IUserPolicyLookup
{
	/// <summary>
	/// Looking up the list of applicable policies on the specified user.
	/// </summary>
	/// <param name="requestContext">The <see cref="T:Roblox.RequestContext.IRequestContext" /> associated with this request.</param>
	/// <param name="targetUserId">The Id of the target user.</param>
	/// <returns>A collection of <see cref="T:Roblox.RequestContext.Policy" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">When requestContext is null.</exception>
	ICollection<Policy> GetApplicablePoliciesForTargetUser(IRequestContext requestContext, long targetUserId);
}
