namespace Roblox.TextFilter;

/// <summary>
/// An interface representing the result of validating text submitted for a username against the <see cref="T:Roblox.TextFilter.IUsernameFilter" />
/// </summary>
public interface IUsernameValidationResult
{
	/// <summary>
	/// Whether the requested name is valid
	/// </summary>
	bool IsValid { get; }

	/// <summary>
	/// If the requested name is invalid, this property indicates whether any of the Personal Identifiable Information filters' probability threshold were exceeded.
	/// If the requested name is valid, this property has no meaning (should be false).
	/// </summary>
	bool IsPotentialPiiViolation { get; }
}
