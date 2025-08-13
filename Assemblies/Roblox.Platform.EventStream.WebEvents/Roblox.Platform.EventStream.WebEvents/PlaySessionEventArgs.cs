using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class PlaySessionEventArgs : WebEventArgs
{
	public Guid GameId { get; set; }

	public long PlaceId { get; set; }

	public DateTime SessionStarted { get; set; }

	public string Context { get; set; }

	public double? Latitude { get; set; }

	public double? Longitude { get; set; }

	public int? CountryId { get; set; }
}
