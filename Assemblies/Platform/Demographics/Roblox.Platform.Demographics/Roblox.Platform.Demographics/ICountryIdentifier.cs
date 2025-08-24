namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that uniquely identifies a country.
/// </summary>
public interface ICountryIdentifier
{
	/// <summary>
	/// Gets the ID of the country.
	/// </summary>
	/// <value>
	/// The ID of the country.
	/// </value>
	int Id { get; }
}
