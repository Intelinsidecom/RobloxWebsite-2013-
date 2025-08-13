namespace Roblox.Platform.Demographics;

/// <summary>
/// Geolocation
/// </summary>
public interface IGeolocation
{
	/// <summary>
	/// Latitude
	/// </summary>
	double? Latitude { get; }

	/// <summary>
	/// Longitude
	/// </summary>
	double? Longitude { get; }

	/// <summary>
	/// Id of the <see cref="T:Roblox.Platform.Demographics.ICountry" />
	/// </summary>
	int? CountryId { get; }

	/// <summary>
	/// Is Geoposition lookup attempted
	/// </summary>
	bool IsGeopositionLookupAttempted { get; }

	/// <summary>
	/// Is country lookup attempted
	/// </summary>
	bool IsCountryLookupAttempted { get; }
}
