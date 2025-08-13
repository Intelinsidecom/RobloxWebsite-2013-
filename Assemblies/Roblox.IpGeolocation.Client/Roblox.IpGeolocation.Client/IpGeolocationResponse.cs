using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v12.0.0.0)")]
public class IpGeolocationResponse
{
	[JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public Location Location { get; set; }

	[JsonProperty("traits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public Traits Traits { get; set; }

	public string ToJson()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static IpGeolocationResponse FromJson(string data)
	{
		return JsonConvert.DeserializeObject<IpGeolocationResponse>(data);
	}
}
