using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class MaxMindResponse
{
	[JsonProperty("queries_remaining")]
	public int? QueriesRemaining { get; internal set; }
}
