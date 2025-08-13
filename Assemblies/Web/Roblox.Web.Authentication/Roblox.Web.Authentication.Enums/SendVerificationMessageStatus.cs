namespace Roblox.Web.Authentication.Enums;

public enum SendVerificationMessageStatus
{
	Success,
	UserNotFound,
	Flooded,
	MultipleUsersPerCredentials,
	UnverifiedCredentials,
	TooManyUsersPerCredentials,
	InvalidCredentialValue,
	VerificationUnavailable,
	CredentialAlreadyVerified,
	SendVerificationMessageFailed
}
