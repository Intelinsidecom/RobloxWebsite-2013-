using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User.Admin;

/// <summary>
/// DO NOT USE AccountEmailEntityVerifier
///
/// This class exists to support customer service, admin, and low level email verification. 
/// Normal usage MUST go through <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />.
/// </summary>
public static class AccountEmailEntityVerifier
{
	/// <summary>
	/// DO NOT USE TryVerifyEmail
	///
	/// Attempts to verify the current email address for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	///
	/// This method exists to support customer service, admin, and low level email verification. 
	/// Normal usage MUST go through <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	[ExcludeFromCodeCoverage]
	public static void TryVerifyEmail(IUser user)
	{
		AccountEmailAddress accountEmailAddress = AccountEmailAddress.GetCurrent(user.AccountId);
		if (!accountEmailAddress.IsVerified || !accountEmailAddress.IsValid)
		{
			accountEmailAddress.IsVerified = true;
			accountEmailAddress.IsValid = true;
			accountEmailAddress.Save();
		}
	}
}
