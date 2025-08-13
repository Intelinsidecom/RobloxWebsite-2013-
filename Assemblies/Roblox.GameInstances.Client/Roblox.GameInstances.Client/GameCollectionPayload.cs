using System.Collections.Generic;
using Newtonsoft.Json;
using ProtoBuf;

namespace Roblox.GameInstances.Client;

[ProtoContract]
public class GameCollectionPayload
{
	[ProtoMember(1)]
	[JsonProperty("data")]
	public IEnumerable<Game> Data { get; set; }

	public GameCollectionPayload()
	{
	}

	public GameCollectionPayload(IEnumerable<Game> games)
	{
		Data = games;
	}
}
