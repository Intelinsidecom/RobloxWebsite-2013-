using System;

namespace Roblox.Platform.Membership.Commands;

internal struct UsernameTextFilterCheckResult : IEquatable<UsernameTextFilterCheckResult>
{
	/// <summary>
	/// Error code for the UsernameValidator to pass back to the consumer.
	/// </summary>
	public readonly UsernameValidatorResultCode? ValidatorErrorCode;

	/// <summary>
	/// Whether the username is clean (passes the text filter).
	/// </summary>
	public bool IsClean => !ValidatorErrorCode.HasValue;

	public UsernameTextFilterCheckResult(UsernameValidatorResultCode validatorErrorCode)
	{
		switch (validatorErrorCode)
		{
		case UsernameValidatorResultCode.UserNameModerationErrorCode:
		case UsernameValidatorResultCode.UnknownErrorCode:
		case UsernameValidatorResultCode.UsernameContainsPii:
		case UsernameValidatorResultCode.UsernameContainsReservedUsername:
			ValidatorErrorCode = validatorErrorCode;
			break;
		default:
			throw new ArgumentException($"Username text filter check does not support the validator error code {validatorErrorCode}");
		}
	}

	public UsernameTextFilterCheckResult(bool isClean)
	{
		if (isClean)
		{
			ValidatorErrorCode = null;
		}
		else
		{
			ValidatorErrorCode = UsernameValidatorResultCode.UnknownErrorCode;
		}
	}

	public bool Equals(UsernameTextFilterCheckResult other)
	{
		return ValidatorErrorCode == other.ValidatorErrorCode;
	}
}
