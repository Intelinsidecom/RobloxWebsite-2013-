using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public interface IAccountsNeedingPasswordResetFactory
{
	/// <summary>
	/// Gets whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> requires a password reset.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns><c>true</c> if the <see cref="T:Roblox.Platform.Membership.IUser" /> must reset their password.</returns>
	bool GetAccountNeedsPasswordReset(IUser user);

	/// <summary>
	/// Sets whether or not the user will be required to reset their password.
	/// </summary>
	/// <remarks>
	/// Will log out all sessions if <paramref name="needsReset" /> is <c>true</c> and does not match the current value.
	/// </remarks>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> corresponding to the account.</param>
	/// <param name="needsReset">Whether or not the account needs a password reset.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" /></exception>
	void SetAccountNeedsPasswordReset(IUser user, bool needsReset);
}
