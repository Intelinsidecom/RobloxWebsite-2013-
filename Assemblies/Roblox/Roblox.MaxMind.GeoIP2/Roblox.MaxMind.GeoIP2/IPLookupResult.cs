namespace Roblox.MaxMind.GeoIP2;

internal class IPLookupResult : IIPLookupResult
{
	public IPLookupErrorType? IPLookupErrorType { get; internal set; }

	public string CountryCode { get; internal set; }

	public double? Latitude { get; internal set; }

	public double? Longitude { get; internal set; }

	public string City { get; internal set; }

	public string Subdivision { get; internal set; }

	public string Country { get; internal set; }

	public string ZipCode { get; internal set; }

	public string Provider { get; internal set; }
}
