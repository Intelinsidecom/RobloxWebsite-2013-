using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v12.0.0.0)")]
public class Location
{
	[JsonProperty("continent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Continent { get; set; }

	[JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Country { get; set; }

	[JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Country_code { get; set; }

	[JsonProperty("subdivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public ICollection<IDictionary<string, object>> Subdivision { get; set; }

	[JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string City { get; set; }

	[JsonProperty("accuracy_radius", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public int? Accuracy_radius { get; set; }

	[JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public double? Latitude { get; set; }

	[JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public double? Longitude { get; set; }

	[JsonProperty("metro_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public int? Metro_code { get; set; }

	[JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Postal_code { get; set; }

	public string ToJson()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static Location FromJson(string data)
	{
		return JsonConvert.DeserializeObject<Location>(data);
	}
}
