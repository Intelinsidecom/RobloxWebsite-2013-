using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents the event arguments for an <see cref="T:Roblox.Platform.EventStream.WebEvents.AppSessionReporterEvent" />.
/// </summary>
public class AppSessionReporterEventArgs : WebEventArgs
{
	/// <summary>
	/// The url the app used in order to inform the platform layer of the event.
	/// </summary>
	public string PageUrl { get; set; }

	/// <summary>
	/// The roblox place id.
	/// </summary>
	public long PlaceId { get; set; }

	/// <summary>
	/// The event time (timestamp on platform layer host).
	/// </summary>
	public DateTime EventTime { get; set; }
}
