namespace Roblox.Platform.Membership.Commands;

public enum UsernameValidatorResultCode : byte
{
	UserNameValid,
	UserNameAlreadyInUseErrorCode,
	UserNameModerationErrorCode,
	UserNameLengthErrorCode,
	UserNameStartEndUnderscoreErrorCode,
	UserNameAtMostUnderscoreErrorCode,
	UserNameNoSpaceErrorCode,
	UserNameAllowedCharErrorCode,
	UnknownErrorCode,
	UsernameNull,
	UsernameContainsPii,
	InvalidBirthDateForUsername,
	UsernameContainsReservedUsername
}
