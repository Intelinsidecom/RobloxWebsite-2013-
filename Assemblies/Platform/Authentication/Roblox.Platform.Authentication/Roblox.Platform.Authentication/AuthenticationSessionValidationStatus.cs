namespace Roblox.Platform.Authentication;

public enum AuthenticationSessionValidationStatus
{
	Success,
	InvalidUser,
	InvalidSessionForUser,
	InvalidSessionToken,
	SessionTokenMissing,
	SessionTokenExpired,
	SessionTokenMissingOnExtend
}
