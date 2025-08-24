using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Deletes existing <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />s
/// </summary>
public interface ITwoStepVerificationSessionPurger
{
	/// <summary>
	/// Deletes all existing <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />s for <paramref name="user" />.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	void DeleteSessionsForUser(IUser user);
}
