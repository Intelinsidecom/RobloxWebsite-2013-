namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that describes a physical address.
/// </summary>
public interface IAddress
{
	int Id { get; }

	string Line1 { get; }

	string Line2 { get; }

	string City { get; }

	string StateProvince { get; }

	ICountry Country { get; }

	string ZipPostal { get; }
}
