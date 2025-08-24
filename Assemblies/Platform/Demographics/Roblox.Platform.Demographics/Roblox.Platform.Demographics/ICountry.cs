namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that contains information about a country.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Demographics.ICountryIdentifier" />
public interface ICountry : ICountryIdentifier
{
	/// <summary>
	/// Gets the name of the country.
	/// </summary>
	/// <value>
	/// The name of the country.
	/// </value>
	string Name { get; }

	/// <summary>
	/// Gets the country's code.
	/// </summary>
	/// <value>
	/// The country's code.
	/// </value>
	/// <example>US, CA, GB</example>
	string Code { get; }

	/// <summary>
	/// Gets a value indicating whether the country is active.
	/// </summary>
	/// <value>
	///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
	/// </value>
	bool IsActive { get; }
}
