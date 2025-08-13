using System.ComponentModel;

namespace Roblox.Web.Authentication.Usernames;

/// <summary>
/// Response codes for username recovery.
/// </summary>
public enum UsernameResponseCodes
{
	/// <summary>
	/// Reserved for base error code, or unknown exception.
	/// </summary>
	[Description("Unknown error with request.")]
	Unknown,
	/// <summary>
	/// The phone number entered by the user is malformed
	/// </summary>
	[Description("Invalid phone number")]
	InvalidPhoneNumber,
	/// <summary>
	/// The phone number is not connected to any account
	/// </summary>
	[Description("No account found. Please use a different phone number.")]
	UnknownPhoneNumber,
	/// <summary>
	/// A floodcheck was hit
	/// </summary>
	[Description("Too many attempts. Please try again later.")]
	Flooded,
	/// <summary>
	/// The username recovery feature is disabled
	/// </summary>
	[Description("Feature temporarily disabled. Please try again later.")]
	FeatureDisabled,
	/// <summary>
	/// The request was successful
	/// </summary>
	[Description("Ok")]
	Ok
}
