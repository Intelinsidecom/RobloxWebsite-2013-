using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Produces <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />s
/// </summary>
internal interface ITwoStepVerificationSessionCollectionFactory
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />s for <paramref name="user" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>All <see cref="T:System.Collections.Generic.IEnumerable`1" /> for <paramref name="user" /></returns>
	IEnumerable<ITwoStepVerificationSession> GetSessionsByUser(IUser user);
}
