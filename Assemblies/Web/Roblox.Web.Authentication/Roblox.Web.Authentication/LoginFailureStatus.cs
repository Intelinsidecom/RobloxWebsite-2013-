namespace Roblox.Web.Authentication;

/// <summary>
/// An enum with login failure status.
/// </summary>
public enum LoginFailureStatus
{
	UserNotFound,
	Flooded,
	CaptchaFailed,
	UserWithNullPassword,
	InvalidCredentials,
	PasswordResetRequired,
	MultipleUsersPerCredentials,
	UnverifiedCredentials,
	UnverifiedCredentialsMultipleUsers,
	TwoStepVerificationFailed,
	TwoStepVerificationServiceUnavailable,
	TooManyUsersPerCredentials,
	CredentialsCollision,
	LoginSessionAlreadyExists
}
