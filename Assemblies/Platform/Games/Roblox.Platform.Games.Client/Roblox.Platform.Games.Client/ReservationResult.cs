using System;

namespace Roblox.Games.Client;

public class ReservationResult
{
	public GameConnection GameConnection { get; set; }

	public Guid GameId { get; set; }

	public string JoinStatus { get; set; }

	public DateTime? ReservationExpiry { get; set; }

	public JoinType JoinType { get; set; }
}
