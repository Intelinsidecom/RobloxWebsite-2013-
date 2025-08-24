namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for validation of <see cref="T:Roblox.Gigya.IGigyaValidatable" />s.
/// </summary>
internal interface IGigyaValidator
{
	/// <summary>
	/// Determines whether the given <see cref="T:Roblox.Gigya.IGigyaValidatable" /> is valid.
	/// </summary>
	/// <param name="validatable">The <see cref="T:Roblox.Gigya.IGigyaValidatable" /> to validate.</param>
	/// <param name="errorMessage">The error with validation if any.</param>
	/// <returns>True if valid, false otherwise.</returns>
	/// <exception cref="!:ArgumentNullException">Thrown if <paramref name="validatable" /> is null.</exception>
	bool Validate(IGigyaValidatable validatable, out string errorMessage);
}
