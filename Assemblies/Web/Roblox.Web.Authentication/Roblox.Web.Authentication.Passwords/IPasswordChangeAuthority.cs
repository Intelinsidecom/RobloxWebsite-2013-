using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication.Passwords;

/// <summary>
/// This authority is responsible for changing user passwords.
/// </summary>
public interface IPasswordChangeAuthority
{
	/// <summary>
	/// Changes an <see cref="T:Roblox.Platform.Membership.IUser" />'s password.
	/// Accepts options to check password, and send <see cref="T:Roblox.Platform.Membership.IUser" /> reset email.
	/// Will sign out all user sessions if the password successfully changes.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="newPassword">The <see cref="T:Roblox.Platform.Membership.IUser" />'s new password.</param>
	/// <param name="sendRevertEmail">
	/// If <c>true</c> sends password reset email to <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// If the user does not have an email set it will not send one.
	/// </param>
	/// <param name="checkPasswordRules">If <c>true</c> will check password rules before allowing change.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	/// <exception cref="T:Roblox.Web.Authentication.Passwords.InvalidPasswordException">The password is not valid. (Does not meet password requirements)</exception>
	void ChangePassword(IUser user, string newPassword, bool sendRevertEmail, bool checkPasswordRules);

	/// <summary>
	/// Decrypts a secure blob into the underlying revert ticket
	/// </summary>
	/// <param name="ticket"> The SecureBlob ticket </param>
	/// <exception cref="!:FormatException"> The ticket can't be parsed as a secure blob </exception>
	PasswordRevertTicket GetRevertTicketFromSecureBlob(string ticket);
}
