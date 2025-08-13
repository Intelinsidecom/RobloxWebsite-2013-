using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

/// <summary>
/// Represents an event for BrowserTracker creation.
/// </summary>
public class BrowserTrackerCreatedEvent : WebEventBase
{
	private const string _Name = "btCreated";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.Events.BrowserTrackerCreatedEvent" /> class.
	/// </summary>
	/// <param name="streamer">The streamer.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BrowserTrackerCreatedEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformArgumentException">args.RequestUrl cannot be null or empty.</exception>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="streamer" /> or <paramref name="args" /> is null.</exception>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Diagnostic" />.</exception>
	public BrowserTrackerCreatedEvent(IEventStreamer streamer, BrowserTrackerCreatedEventArgs args)
		: base(streamer, "btCreated", args)
	{
		if (string.IsNullOrEmpty(args.RequestUrl))
		{
			throw new ArgumentException("args.RequestUrl is required");
		}
		if (args.Target != EventTarget.Diagnostic)
		{
			throw new ArgumentException("args.Target is not EventTarget.Diagnostic");
		}
		AddEventArg("requestUrl", args.RequestUrl);
	}
}
