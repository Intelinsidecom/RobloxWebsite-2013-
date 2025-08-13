using System;
using ProtoBuf;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

[ProtoContract]
public class Game : IGame
{
	[ProtoMember(1)]
	public Guid Id { get; set; }

	[ProtoMember(2)]
	public long PlaceId { get; set; }

	[ProtoMember(3)]
	public double Fps { get; set; }

	[ProtoMember(4)]
	public int Ping { get; set; }

	[ProtoMember(5)]
	public long[] PlayerIds { get; set; }

	[ProtoMember(6)]
	public int ServerPort { get; set; }

	[ProtoMember(7)]
	public string ServerIpAddress { get; set; }

	[ProtoMember(8)]
	public byte Capacity { get; set; }

	[ProtoMember(9)]
	public int GameTime { get; set; }

	[ProtoMember(10)]
	public DateTime Started { get; set; }

	[ProtoMember(11)]
	public DateTime Updated { get; set; }

	[ProtoMember(12)]
	public PlaySession[] PlaySessions { get; set; }

	[ProtoMember(13)]
	public long UniverseId { get; set; }

	[ProtoMember(14)]
	public Guid? GameCode { get; set; }

	[ProtoMember(15)]
	public int MatchmakingContextId { get; set; }

	[ProtoMember(16)]
	public double HeartbeatRate { get; set; }

	[ProtoMember(17)]
	public bool IsStreamingEnabled { get; set; }

	[ProtoMember(18)]
	public double CpuUsage { get; set; }

	[ProtoMember(19)]
	public long UsedMemoryBytes { get; set; }

	[ProtoMember(20)]
	public long LastSequenceNumber { get; set; }
}
