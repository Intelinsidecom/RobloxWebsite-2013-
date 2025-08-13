using System;
using ProtoBuf;

namespace Roblox.GameInstances.Client;

[ProtoContract]
public class GameIdentifier
{
	[ProtoMember(1)]
	public Guid GameId { get; set; }

	[ProtoMember(2)]
	public long PlaceId { get; set; }
}
