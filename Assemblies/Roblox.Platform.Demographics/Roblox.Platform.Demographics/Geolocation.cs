namespace Roblox.Platform.Demographics;

internal class Geolocation : IGeolocation
{
	public double? Latitude { get; internal set; }

	public double? Longitude { get; internal set; }

	public int? CountryId { get; internal set; }

	public bool IsGeopositionLookupAttempted { get; internal set; }

	public bool IsCountryLookupAttempted { get; internal set; }
}
