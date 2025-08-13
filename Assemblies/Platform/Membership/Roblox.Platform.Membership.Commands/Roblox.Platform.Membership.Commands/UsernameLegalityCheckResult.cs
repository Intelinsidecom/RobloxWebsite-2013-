using System;

namespace Roblox.Platform.Membership.Commands;

internal struct UsernameLegalityCheckResult : IEquatable<UsernameLegalityCheckResult>
{
	/// <summary>
	/// Error code for the UsernameValidator to pass back to the consumer.
	/// </summary>
	public readonly UsernameValidatorResultCode? ValidatorErrorCode;

	/// <summary>
	/// Whether the username is legal.
	/// </summary>
	public bool IsLegal => !ValidatorErrorCode.HasValue;

	public UsernameLegalityCheckResult(UsernameValidatorResultCode validatorErrorCode)
	{
		if (validatorErrorCode - 3 <= UsernameValidatorResultCode.UserNameStartEndUnderscoreErrorCode)
		{
			ValidatorErrorCode = validatorErrorCode;
			return;
		}
		throw new ArgumentException($"Username legality check does not support the validator error code {validatorErrorCode}");
	}

	public UsernameLegalityCheckResult(bool isLegal)
	{
		if (isLegal)
		{
			ValidatorErrorCode = null;
		}
		else
		{
			ValidatorErrorCode = UsernameValidatorResultCode.UnknownErrorCode;
		}
	}

	public bool Equals(UsernameLegalityCheckResult other)
	{
		return ValidatorErrorCode == other.ValidatorErrorCode;
	}
}
