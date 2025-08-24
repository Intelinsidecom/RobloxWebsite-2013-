namespace Roblox.Platform.IpAddresses;

/// <summary>
/// An IP Location with Geo Information from which someone at some point accessed Roblox
/// </summary>
public interface IIpLocation
{
	/// <summary>
	/// The IP Region eg: California
	/// </summary>
	string Region { get; }

	/// <summary>
	/// The IP City eg: San Mateo
	/// </summary>
	string City { get; }

	/// <summary>
	/// The IP Country eg: United States
	/// </summary>
	string Country { get; }

	/// <summary>
	/// The Postal or Zipcode eg: 91040
	/// </summary>
	string Postal { get; }

	/// <summary>
	/// The IP Type
	/// </summary>
	IpType IpType { get; }

	/// <summary>
	/// String value of the IP eg: 127.0.0.1
	/// </summary>
	string Value { get; }
}
