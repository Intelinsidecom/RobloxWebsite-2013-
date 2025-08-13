namespace Roblox.Web.Authentication.Passwords;

/// <summary>
/// The result (success or failure) of sending a forgot password <see cref="T:Roblox.Platform.Verification.Email.IEmailChallenge`1">email challenge</see>
/// </summary>
public interface ISendPasswordChangeEmailResult
{
	/// <summary>
	/// Indicates whether the password change email was successfully sent.
	/// </summary>
	bool Success { get; }

	/// <summary>
	/// The result of the send. Will indicate either success or a reason for failure.
	/// </summary>
	PasswordResponseCodes Result { get; }
}
