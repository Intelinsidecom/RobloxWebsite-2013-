namespace Roblox.MaxMind.GeoIP2;

/// <summary>
/// An IP lookup result with geo information from MaxMind API
/// </summary>
public interface IIPLookupResult
{
	/// <summary>
	/// The IP City eg: San Mateo
	/// </summary>
	string City { get; }

	/// <summary>
	/// The IP Country eg: United States
	/// </summary>
	string Country { get; }

	/// <summary>
	/// The IP CountryCode eg: US
	/// </summary>
	string CountryCode { get; }

	/// <summary>
	/// The IPLookupErrorType has three types : Bad
	/// </summary>
	IPLookupErrorType? IPLookupErrorType { get; }

	/// <summary>
	/// The IP Latitude 
	/// </summary>
	double? Latitude { get; }

	/// <summary>
	/// The IP Longitude
	/// </summary>
	double? Longitude { get; }

	/// <summary>
	/// The IP Provider eg: Sprint
	/// </summary>
	string Provider { get; }

	/// <summary>
	/// The IP Subdivision eg: California
	/// </summary>
	string Subdivision { get; }

	/// <summary>
	/// The IP Zipcode eg: 91040
	/// </summary>
	string ZipCode { get; }
}
