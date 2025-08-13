namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents a unique identifier for a country.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Demographics.ICountryIdentifier" />
public class CountryIdentifier : ICountryIdentifier
{
	public int Id { get; }

	public CountryIdentifier(int id)
	{
		Id = id;
	}
}
