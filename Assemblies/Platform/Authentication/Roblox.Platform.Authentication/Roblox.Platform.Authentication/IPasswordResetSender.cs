using System;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public interface IPasswordResetSender
{
	/// <summary>
	/// Sends the specified user the url for resetting password.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="resetUrl">The reset URL.</param>
	/// <param name="emailSender">The email sender.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">User, resetUrl or emailClient is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Reset url is invalid (must be absolute, not a file uri)</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidEmailAddressException">User does not have an email associated with account</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidAccountStatusException">Account status is not ok</exception>
	void Send(IUser user, Uri resetUrl, IEmailSender emailSender);
}
