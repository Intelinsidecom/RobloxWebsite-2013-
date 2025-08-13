using System;
using ProtoBuf;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

[ProtoContract]
public class PlaySession : IPlaySession
{
	[ProtoMember(1)]
	public long PlayerId { get; set; }

	[ProtoMember(2)]
	public Guid Id { get; set; }

	[ProtoMember(3)]
	public string Ip { get; set; }

	[ProtoMember(4)]
	public int PlatformId { get; set; }

	[ProtoMember(5)]
	public TimeSpan GameDurationWhenJoined { get; set; }

	[ProtoMember(6)]
	public DateTime Started { get; set; }

	[ProtoMember(7)]
	public long BrowserTrackerId { get; set; }

	[ProtoMember(8)]
	public Guid? PartyId { get; set; }

	[ProtoMember(9)]
	public double? Age { get; set; }

	[ProtoMember(10)]
	public bool IsVr { get; set; }

	[ProtoMember(11)]
	public Geolocation Geolocation { get; set; }

	[ProtoMember(12)]
	public int? LanguageId { get; set; }

	[ProtoMember(13)]
	public int? PolicyCountryId { get; set; }

	[ProtoMember(14)]
	public string JoinType { get; set; }

	[ProtoMember(15)]
	public string BotCheckStatus { get; set; }

	[ProtoMember(16)]
	public PlaySessionFlags PlaySessionFlags { get; set; }

	[ProtoMember(17)]
	public DetailedBotCheckSignals DetailedBotCheckSignals { get; set; }
}
