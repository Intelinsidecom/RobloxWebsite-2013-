namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// An interface that holds the result of username validation.
/// </summary>
public interface IUsernameValidationResult
{
	/// <summary>
	///   This holds whether the username validation is valid.
	/// </summary>
	/// <value>
	///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
	/// </value>
	bool IsValid { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.Commands.UsernameValidatorResultCode" />.
	/// </summary>
	/// <value>
	/// The <see cref="T:Roblox.Platform.Membership.Commands.UsernameValidatorResultCode" />.
	/// </value>
	UsernameValidatorResultCode ResultCode { get; }

	/// <summary>
	/// Gets the error message in American English.
	/// </summary>
	/// <value>
	/// The error message.
	/// </value>
	string ErrorMessage { get; }
}
