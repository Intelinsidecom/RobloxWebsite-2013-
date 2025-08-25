using Roblox.Common;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// An event fired whenever points are awarded in a game.
/// </summary>
public class PointsAwardedEvent : EventBase
{
	private const string _Name = "pointsAwarded";

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.EventStream.WebEvents.PointsAwardedEvent" />.
	/// </summary>
	/// <param name="eventStreamer">An <see cref="T:Roblox.Platform.EventStream.IEventStreamer" />.</param>
	/// <param name="eventArgs">The arguments describing the event.</param>
	public PointsAwardedEvent(IEventStreamer eventStreamer, PointsAwardedEventArgs eventArgs)
		: base(eventStreamer, "pointsAwarded", eventArgs)
	{
		AddEventArg("uid", eventArgs.RecipientUserId.ToString());
		AddEventArg("pid", eventArgs.PlaceId.ToString());
		AddEventArg("gid", eventArgs.UniverseId.ToString());
		AddEventArg("amount", eventArgs.Amount.ToString());
		AddEventArg("utcTime", eventArgs.EventTime.ToUnixEpochTime().TotalSeconds.ToString());
	}
}
