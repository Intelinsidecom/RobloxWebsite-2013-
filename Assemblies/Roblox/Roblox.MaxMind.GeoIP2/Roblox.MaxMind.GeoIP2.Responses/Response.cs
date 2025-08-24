using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class Response
{
	[JsonProperty("country")]
	public CountryResponse Country;

	[JsonProperty("continent")]
	public ContinentResponse Continent;

	[JsonProperty("city")]
	public CityResponse City;

	[JsonProperty("subdivisions")]
	public IReadOnlyCollection<RegionResponse> Subdivisions;

	[JsonProperty("location")]
	public LocationResponse Location;

	[JsonProperty("registered_country")]
	public CountryResponse RegisteredCountry;

	[JsonProperty("represented_country")]
	public CountryResponse RepresentedCountry;

	[JsonProperty("traits")]
	public TraitsResponse Traits;

	[JsonProperty("maxmind")]
	public MaxMindResponse Maxmind;

	[JsonProperty("postal")]
	public PostalResponse Postal;

	/// <summary>
	///     The attribute code only show up when error exists
	///     It is a indicator of the error, not related to postal code
	/// </summary>
	[JsonProperty("code")]
	public string Code;
}
