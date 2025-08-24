namespace Roblox.Platform.AccountPins.Interfaces;

/// <summary>
/// A validator for validating the format of the pin.
/// </summary>
internal interface IAccountPinFormatValidator
{
	/// <summary>
	/// Validates the pin.
	/// </summary>
	/// <param name="pin">The pin.</param>
	/// <returns>
	/// True if the pin is in the exprected format, false otherwise.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if passed in pin is null empty or whitespace</exception>
	bool ValidatePin(string pin);
}
