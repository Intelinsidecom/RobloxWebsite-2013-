using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.CommunitySift;

internal class CommunitySiftDoubleChatResponseData
{
	[JsonProperty("risk")]
	public int Risk { get; set; }

	[JsonProperty("trust")]
	public int Trust { get; set; }

	[JsonProperty("escalations")]
	public object Escalations { get; set; }

	[JsonProperty("language")]
	public string Language { get; set; }

	[JsonProperty("primary_rule_response")]
	public bool PrimaryResponse { get; set; }

	[JsonProperty("secondary_rule_response")]
	public bool SecondaryResponse { get; set; }

	[JsonProperty("hashed")]
	public string Hashed { get; set; }

	[JsonProperty("secondary_hashed")]
	public string SecondaryHashed { get; set; }

	[JsonProperty("topics")]
	public Dictionary<int, int> Topics { get; set; }
}
