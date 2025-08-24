using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class CityResponse
{
	/// <summary>
	///     A value from 0-100 indicating MaxMind's confidence that the city
	///     is correct. This attribute is only available from the Insights web
	///     service end point.
	/// </summary>
	[JsonProperty("confidence")]
	public int? Confidence { get; internal set; }

	/// <summary>
	///     The GeoName ID for the city.
	/// </summary>
	[JsonProperty("geoname_id")]
	public int? GeoNameId { get; internal set; }

	/// <summary>
	///     The name is a json formated dictionary including key and value for city
	///     eg: name : {
	///           "de":    "Los Angeles",
	///           "en":    "Los Angeles"
	///     }
	/// </summary>
	[JsonProperty("names")]
	public Dictionary<string, string> Names { get; internal set; }
}
