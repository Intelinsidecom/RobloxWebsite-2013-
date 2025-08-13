using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an EventStream event for app session/crash reporter events.
/// </summary>
public class AppSessionReporterEvent : WebEventBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.AppSessionReporterEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> used to stream the event.</param>
	/// <param name="eventName">The event identifier.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.AppSessionReporterEventArgs" /> containing event info.</param>
	/// <exception cref="T:System.ArgumentException">Thrown if a non-empty PageUrl is not provided with <paramref name="args" />.</exception>
	public AppSessionReporterEvent(IEventStreamer streamer, string eventName, AppSessionReporterEventArgs args)
		: base(streamer, eventName, args)
	{
		if (string.IsNullOrWhiteSpace(args.PageUrl))
		{
			throw new ArgumentException(string.Format("{0} is required", "PageUrl"));
		}
		AddEventArg("pid", args.PlaceId.ToString());
		AddEventArg("url", args.PageUrl);
		AddEventArg("lt", args.EventTime.ToUniversalTime().ToString("o"));
	}
}
