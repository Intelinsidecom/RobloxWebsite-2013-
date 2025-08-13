using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v12.0.0.0)")]
public class Traits
{
	[JsonProperty("autonomous_system_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public long? Autonomous_system_number { get; set; }

	[JsonProperty("autonomous_system_organization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Autonomous_system_organization { get; set; }

	[JsonProperty("isp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Isp { get; set; }

	[JsonProperty("organization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public string Organization { get; set; }

	[JsonProperty("anonymous_ip_information", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public AnonymousIpInformation Anonymous_ip_information { get; set; }

	public string ToJson()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static Traits FromJson(string data)
	{
		return JsonConvert.DeserializeObject<Traits>(data);
	}
}
