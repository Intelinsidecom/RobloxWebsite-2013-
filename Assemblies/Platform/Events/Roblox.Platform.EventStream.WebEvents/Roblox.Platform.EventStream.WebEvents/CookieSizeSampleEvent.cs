using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an EventStream event for CookieSizeV2Event. Does not use the cookieSizeThreshold parameter.
/// </summary>
public class CookieSizeSampleEvent : WebEventBase
{
	private const string _Name = "cookieSizeSample";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.CookieSizeSampleEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.CookieSizeEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformArgumentNullException">
	/// streamer
	/// or 
	/// args
	/// or
	/// args.RawCookies
	/// </exception>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Diagnostic" />.</exception>
	public CookieSizeSampleEvent(EventStreamer streamer, CookieSizeEventArgs args)
		: base(streamer, "cookieSizeSample", args)
	{
		if (args.RawCookies == null)
		{
			throw new ArgumentNullException("args.RawCookies");
		}
		if (args.Target != EventTarget.Diagnostic)
		{
			throw new ArgumentException("args.Target is not EventTarget.Diagnostic");
		}
		AddEventArg("actualCookieSize", args.ActualCookieSize.ToString());
		AddEventArg("rawCookies", args.RawCookies);
	}
}
