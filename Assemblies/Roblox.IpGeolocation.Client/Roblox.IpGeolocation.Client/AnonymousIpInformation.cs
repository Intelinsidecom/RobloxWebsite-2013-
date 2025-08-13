using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v12.0.0.0)")]
public class AnonymousIpInformation
{
	[JsonProperty("is_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public bool? Is_anonymous { get; set; }

	[JsonProperty("is_anonymous_vpn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public bool? Is_anonymous_vpn { get; set; }

	[JsonProperty("is_hosting_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public bool? Is_hosting_provider { get; set; }

	[JsonProperty("is_public_proxy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public bool? Is_public_proxy { get; set; }

	[JsonProperty("is_tor_exit_node", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
	public bool? Is_tor_exit_node { get; set; }

	public string ToJson()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static AnonymousIpInformation FromJson(string data)
	{
		return JsonConvert.DeserializeObject<AnonymousIpInformation>(data);
	}
}
