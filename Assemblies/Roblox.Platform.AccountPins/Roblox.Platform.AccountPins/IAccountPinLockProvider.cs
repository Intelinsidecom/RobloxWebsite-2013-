using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// An interface for providing the current state of account lock.
/// </summary>
public interface IAccountPinLockProvider
{
	/// <summary>
	/// Determines whether the specified account for the passed in <paramref name="user" /> is locked.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="authenticationSession">The authentication session.</param>
	/// <returns></returns>
	bool IsLocked(IUser user, string authenticationSession);
}
