using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class ContinentResponse
{
	/// <summary>
	///     A two character continent code like "NA" (North America) or "OC"
	///     (Oceania).
	/// </summary>
	[JsonProperty("code")]
	public string Code { get; internal set; }

	[JsonProperty("geoname_id")]
	public int? GeoNameId { get; internal set; }

	[JsonProperty("names")]
	public Dictionary<string, string> Names { get; internal set; }
}
