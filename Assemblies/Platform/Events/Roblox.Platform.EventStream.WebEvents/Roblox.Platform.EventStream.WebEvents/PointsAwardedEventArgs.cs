using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// All arguments for the <see cref="T:Roblox.Platform.EventStream.WebEvents.PointsAwardedEvent" /> event.
/// </summary>
public class PointsAwardedEventArgs : BasicEventArgs
{
	/// <summary>
	/// The id of the user who recieved the points.
	/// </summary>
	public long RecipientUserId { get; set; }

	/// <summary>
	/// The universes where the points were awarded.
	/// </summary>
	public long UniverseId { get; set; }

	/// <summary>
	/// The place where the points were awarded.
	/// </summary>
	public long PlaceId { get; set; }

	/// <summary>
	/// How many points were awarded.
	/// </summary>
	public int Amount { get; set; }

	/// <summary>
	/// When the points were awarded.
	/// </summary>
	public DateTime EventTime { get; set; }
}
