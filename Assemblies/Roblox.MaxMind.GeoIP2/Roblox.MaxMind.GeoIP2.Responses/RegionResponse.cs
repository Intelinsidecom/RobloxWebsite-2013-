using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class RegionResponse
{
	/// <summary>
	///     A value from 0-100 indicating MaxMind's confidence that the region
	///     is correct. This attribute is only available from the Insights web
	///     service end point.
	/// </summary>
	[JsonProperty("confidence")]
	public int? Confidence { get; internal set; }

	/// <summary>
	///     The
	///     <a href="http://en.wikipedia.org/wiki/ISO_3166-1">
	///         two-character ISO
	///         3166-1 alpha code
	///     </a>
	///     for the country.
	/// </summary>
	[JsonProperty("iso_code")]
	public string IsoCode { get; internal set; }

	/// <summary>
	///     The GeoName ID for the region.
	/// </summary>
	[JsonProperty("geoname_id")]
	public int? GeoNameId { get; internal set; }

	/// <summary>
	///     The name is a json formated dictionary including key and value for region
	///     eg: name : {
	///           "de":    "Kalifornien",
	///           "en":    "California"
	///     }
	/// </summary>
	[JsonProperty("names")]
	public Dictionary<string, string> Names { get; internal set; }
}
