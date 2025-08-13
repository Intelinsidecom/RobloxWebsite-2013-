using Newtonsoft.Json;

namespace Roblox.Configuration;

internal class Payload<T>
{
	[JsonProperty("data")]
	public T Data { get; set; }

	public Payload(T data)
	{
		Data = data;
	}

	public Payload()
	{
	}
}
