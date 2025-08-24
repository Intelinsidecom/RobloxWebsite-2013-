using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// An interface for a class that verifies emails for <see cref="T:Roblox.Platform.Membership.IUser" />s
/// </summary>
public interface IUserEmailVerifier
{
	/// <summary>
	/// Gets the <see cref="T:System.TimeSpan" /> for how long an email verification ticket is valid for from creation.
	/// </summary>
	TimeSpan EmailVerificationTicketExpiration { get; }

	/// <summary>
	/// Generates an email verification ticket for an <see cref="T:Roblox.Platform.Membership.IUser" />, and sends it
	/// in a verification email to the <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="emailAddress">The email address to be verified by the <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="freeItem">Determines whether user will see messaging that they received a free item after verifying their email</param>
	/// <param name="ticket">Use account security token if provided</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="emailAddress" /> was null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidEmailAddressException">Email is in an invalid format, or is blacklisted.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException"><paramref name="emailAddress" /> is current email, and already verified.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Email verification, or email change feature disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Email.Delivery.EmailQueueingException">Failed to send email to the user at no fault of the caller.</exception>
	void SendVerificationEmail(IUser user, string emailAddress, bool freeItem = false, string ticket = "");

	/// <summary>
	/// Validates an email verification ticket, and verifies an email for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// If the email is not the current one on the account it will be added to the <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// After verification will email old email with link to revert back.
	/// </summary>
	/// <param name="ticket">The verification ticket.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// <paramref name="ticket" /> was null or empty.
	/// OR
	/// Ticket does not have valid user and/or email.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFormatException">Ticket is not a valid verification ticket.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformExpiredException">Ticket is valid, but expired.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Email verification, or email change feature disabled.</exception>
	UserEmailVerificationResult VerifyUserEmailWithTicket(string ticket);

	/// <summary>
	/// Validates an email verification ticket, and verifies an email for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// If the email is not the current one on the account it will be added to the <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// After verification will email old email with link to revert back.
	/// </summary>
	/// <param name="ticket">The verification ticket.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// <paramref name="ticket" /> was null or empty.
	/// OR
	/// Ticket does not have valid user and/or email.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFormatException">Ticket is not a valid verification ticket.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformExpiredException">Ticket is valid, but expired.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Email verification, or email change feature disabled.</exception>
	UserEmailVerificationResult VerifyUserEmailWithAccountSecurityTicket(string ticket);
}
