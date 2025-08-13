using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// An interface for a class that changes emails for <see cref="T:Roblox.Platform.Membership.IUser" />s.
/// </summary>
public interface IUserEmailChanger
{
	/// <summary>
	/// Validates and optionally sets the email address for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <remarks>
	/// Under most scenarios this should be done by sending a verification email to the user with <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />.
	/// Cases where you might want to bypass and set it directly:
	/// - Customer Service
	/// - First email on the account
	/// </remarks>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="emailAddress">The email address.</param>
	/// <param name="forceSet">force setting the email</param>
	/// <param name="sendRevertEmail">
	/// if <c>true</c> will send revert account email to <see cref="T:Roblox.Platform.Membership.IUser" />'s previous email.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> does not have a previous email, or if the previous email is
	/// unverified, none will be sent.
	/// </param>
	/// <returns>Returns Account Security Token associated with the added email</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="emailAddress" /> was null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidEmailAddressException">Email is in an invalid format, or is blacklisted.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Changing email feature currently unavailable.</exception>
	string ValidateAndSetEmail(IUser user, string emailAddress, bool forceSet, bool sendRevertEmail);

	/// <summary>
	/// Sets the email address for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="emailAddress">The email address.</param>
	/// <param name="forceSet">force setting the email</param>
	/// <param name="sendRevertEmail">
	/// if <c>true</c> will send revert account email to <see cref="T:Roblox.Platform.Membership.IUser" />'s previous email.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> does not have a previous email, or if the previous email is
	/// unverified, none will be sent.
	/// </param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="emailAddress" /> was null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Changing email feature currently unavailable.</exception>
	void SetEmail(IUser user, string emailAddress, bool forceSet, bool sendRevertEmail);

	/// <summary>
	/// Send revert email.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="accountEmailAddressIdToRevert"></param>
	/// <param name="currentEmailAddress">
	/// <param name="emailAddress">The email address.</param>
	/// Send revert account email to <see cref="T:Roblox.Platform.Membership.IUser" />'s previous email.
	/// We should not use this if the <see cref="T:Roblox.Platform.Membership.IUser" /> do not have a previous email, or if the previous email is
	/// unverified.
	/// </param>
	void SendRevertEmail(IUser user, int accountEmailAddressIdToRevert, string currentEmailAddress, string emailAddress);

	/// <summary>
	/// Returns whether the email address has linked to too many accounts.
	/// </summary>
	/// <param name="emailAddress">The email address.</param>
	/// <returns> True if the passed in email address has linked to max accounts, false otherwise. </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="emailAddress" /> was null or empty.</exception>
	bool EmailHasMaxAccounts(string emailAddress);

	/// <summary>
	/// Completely break the link between the account and all associated email addresses (both current and past). This will delete all entries in the db for the given account. Intended to be used to fulfil data privacy laws such as COPPA.
	///
	/// This method will also delete the email entity itself if it is no longer associated with any account.
	/// </summary>
	/// <param name="user"></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null</exception>
	void PurgeEmailAddress(IUser user);

	/// <summary>
	/// Validates the email address
	/// </summary>
	/// <param name="address">email address to validate</param>
	/// <param name="emailAddress">Email address entity associated with the address</param>
	void VerifyEmailByBriteVerify(string address, EmailAddress emailAddress);
}
