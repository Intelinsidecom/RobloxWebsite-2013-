using System.ComponentModel;

namespace Roblox.Web.Authentication.Passwords;

/// <summary>
/// Response codes for password reset/change
/// </summary>
public enum PasswordResponseCodes
{
	/// <summary>
	/// Reserved for base error code, or unknown exception. Keeping for backwards compatibility, should not be used for new code.
	/// </summary>
	[Description("Unknown error with request.")]
	Unknown = 0,
	/// <summary>
	/// A floodcheck was hit.
	/// </summary>
	[Description("Too many attempts. Please try again later.")]
	Flooded = 2,
	/// <summary>
	/// Invalid password
	/// </summary>
	[Description("The password is invalid.")]
	InvalidPassword = 7,
	/// <summary>
	/// The current password does not match supplied value
	/// </summary>
	[Description("The current password does not match.")]
	InvalidCurrentPassword = 8,
	/// <summary>
	/// The account pin is locked
	/// </summary>
	[Description("PIN is locked.")]
	PinLocked = 9,
	/// <summary>
	/// The request was successful
	/// </summary>
	[Description("Ok")]
	Ok = 15
}
