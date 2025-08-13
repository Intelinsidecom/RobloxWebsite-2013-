namespace Roblox.Gigya;

/// <summary>
/// Represents a class to wrap responses to Gigya API calls.
/// Includes information common to all API calls; such as whether the call succeeded and any error messages.
/// </summary>
public interface IGigyaResponse
{
	/// <summary>
	/// The error message describing any errors.
	/// </summary>
	string ErrorMessage { get; }

	/// <summary>
	/// Whether the request was successful.
	/// </summary>
	bool IsSuccess { get; }

	/// <summary>
	/// True if validation was not attempted or was passed; false if validation was attempted and not passed.
	/// </summary>
	bool IsValid { get; }
}
