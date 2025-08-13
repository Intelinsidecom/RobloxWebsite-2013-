using System.Collections.Generic;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" />.
/// </summary>
/// <seealso cref="!:Roblox.Platform.Membership.IUsernameValidationResult" />
public class UsernameValidationResult : IUsernameValidationResult
{
	internal const string UnknownErrorMessage = "Unknown Error";

	internal readonly IDictionary<UsernameValidatorResultCode, string> ErrorMessages = new Dictionary<UsernameValidatorResultCode, string>
	{
		[UsernameValidatorResultCode.UserNameValid] = "User name is valid",
		[UsernameValidatorResultCode.UserNameAlreadyInUseErrorCode] = "This username is already in use",
		[UsernameValidatorResultCode.UserNameModerationErrorCode] = "Username not appropriate for Roblox",
		[UsernameValidatorResultCode.UserNameLengthErrorCode] = "Usernames can be {0} to {1} characters long",
		[UsernameValidatorResultCode.UserNameStartEndUnderscoreErrorCode] = "Username can’t start or end with _",
		[UsernameValidatorResultCode.UserNameAtMostUnderscoreErrorCode] = "Usernames can have at most one _",
		[UsernameValidatorResultCode.UserNameNoSpaceErrorCode] = "Username cannot contain spaces",
		[UsernameValidatorResultCode.UserNameAllowedCharErrorCode] = "Only a-z, A-Z, 0-9, and _ are allowed",
		[UsernameValidatorResultCode.UnknownErrorCode] = "Unknown Error",
		[UsernameValidatorResultCode.UsernameNull] = "Username invalid",
		[UsernameValidatorResultCode.UsernameContainsPii] = "Username might contain private information",
		[UsernameValidatorResultCode.InvalidBirthDateForUsername] = "Username invalid",
		[UsernameValidatorResultCode.UsernameContainsReservedUsername] = "This username is not available"
	};

	internal virtual int MaxAllowedUsernameLength => Settings.Default.MaxAllowedUsernameLength;

	internal virtual int MinAllowedUsernameLength => Settings.Default.MinAllowedUsernameLength;

	public bool IsValid { get; }

	public UsernameValidatorResultCode ResultCode { get; }

	public string ErrorMessage
	{
		get
		{
			if (!ErrorMessages.TryGetValue(ResultCode, out var message))
			{
				return "Unknown Error";
			}
			UsernameValidatorResultCode resultCode = ResultCode;
			if (resultCode == UsernameValidatorResultCode.UserNameLengthErrorCode)
			{
				return string.Format(message, MinAllowedUsernameLength, MaxAllowedUsernameLength);
			}
			return message;
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Membership.Commands.UsernameValidationResult" /> class.
	/// </summary>
	/// <param name="isValid">if set to <c>true</c> [is valid].</param>
	/// <param name="errorCode">The error code.</param>
	public UsernameValidationResult(bool isValid, UsernameValidatorResultCode errorCode)
	{
		IsValid = isValid;
		ResultCode = errorCode;
	}
}
