using Newtonsoft.Json;

namespace Roblox.Kickbox;

internal class VerifyDomainResponseData
{
	/// <summary>
	/// true if the API request was successful (i.e., no authentication or unexpected errors occurred)
	/// </summary>
	[JsonProperty("disposable")]
	public bool Disposable { get; set; }
}
