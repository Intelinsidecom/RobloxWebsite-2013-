using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class PostalResponse
{
	/// <summary>
	/// The code for postal is in the following format  
	///   "postal": {
	///      "code":  "90001",
	///     "confidence": 10
	///   }
	/// </summary>
	[JsonProperty("code")]
	public string Code { get; internal set; }
}
