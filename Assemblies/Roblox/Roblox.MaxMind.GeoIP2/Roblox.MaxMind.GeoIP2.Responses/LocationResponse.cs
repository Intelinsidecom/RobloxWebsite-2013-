using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class LocationResponse
{
	/// <summary>
	///     The latitude of the location as a floating point number.
	/// </summary>
	[JsonProperty("latitude")]
	public double? Latitude { get; internal set; }

	/// <summary>
	///     The longitude of the location as a floating point number.
	/// </summary>
	[JsonProperty("longitude")]
	public double? Longitude { get; internal set; }

	/// <summary>
	///     The metro code of the location if the location is in the US.
	///     MaxMind returns the same metro codes as the
	///     <a href="https://developers.google.com/adwords/api/docs/appendix/cities-DMAregions">Google AdWords API</a>.
	/// </summary>
	[JsonProperty("metro_code")]
	public int? MetroCode { get; internal set; }

	/// <summary>
	///     The time zone associated with location, as specified by the
	///     <a href="http://www.iana.org/time-zones">
	///         IANA Time Zone
	///         Database
	///     </a>
	///     , e.g., "America/New_York".
	/// </summary>
	[JsonProperty("time_zone")]
	public string TimeZone { get; internal set; }

	/// <summary>
	///     Returns a <see cref="T:System.String" /> that represents this instance.
	/// </summary>
	/// <returns>
	///     A <see cref="T:System.String" /> that represents this instance.
	/// </returns>
	public override string ToString()
	{
		return "Location [ " + (Latitude.HasValue ? ("Latitude=" + Latitude + ", ") : string.Empty) + (Longitude.HasValue ? ("Longitude=" + Longitude + ", ") : string.Empty) + (MetroCode.HasValue ? ("MetroCode=" + MetroCode + ", ") : string.Empty) + ((TimeZone != null) ? ("TimeZone=" + TimeZone) : "") + "]";
	}
}
