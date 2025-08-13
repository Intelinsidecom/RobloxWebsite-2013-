using System;
using Roblox.EphemeralCounters;
using Roblox.Platform.Authentication;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Enums;

namespace Roblox.Web.Authentication.Verification;

/// <summary>
/// A class that verifies email credentials.
/// </summary>
internal class EmailCredentialsVerifier : BaseCredentialsVerifier
{
	private readonly IUserEmailVerifier _UserEmailVerifier;

	/// <summary>
	/// Creates an instance of <see cref="T:Roblox.Web.Authentication.Verification.EmailCredentialsVerifier" />.
	/// </summary>
	/// <param name="userEmailVerifier">The <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />.</param>
	/// <param name="ephemeralCounterFactory">The <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="userEmailVerifier" /> or <paramref name="ephemeralCounterFactory" /> is null.
	/// </exception>
	public EmailCredentialsVerifier(IUserEmailVerifier userEmailVerifier, IEphemeralCounterFactory ephemeralCounterFactory)
		: base(CredentialsType.Email, ephemeralCounterFactory)
	{
		_UserEmailVerifier = userEmailVerifier ?? throw new ArgumentNullException("userEmailVerifier");
	}

	/// <inheritdoc />
	public override SendVerificationMessageStatus SendVerificationMessageToUser(IUser user, string credentialsValue)
	{
		try
		{
			_UserEmailVerifier.SendVerificationEmail(user, credentialsValue);
		}
		catch (PlatformFloodedException)
		{
			return SendVerificationMessageStatus.Flooded;
		}
		catch (PlatformInvalidEmailAddressException)
		{
			return SendVerificationMessageStatus.InvalidCredentialValue;
		}
		catch (PlatformInvalidOperationException)
		{
			return SendVerificationMessageStatus.CredentialAlreadyVerified;
		}
		catch (PlatformOperationUnavailableException)
		{
			return SendVerificationMessageStatus.SendVerificationMessageFailed;
		}
		catch (EmailQueueingException)
		{
			return SendVerificationMessageStatus.SendVerificationMessageFailed;
		}
		return SendVerificationMessageStatus.Success;
	}
}
