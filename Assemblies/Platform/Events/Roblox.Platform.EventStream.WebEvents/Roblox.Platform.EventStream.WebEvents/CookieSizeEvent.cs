using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an EventStream event for CookieSizeEvent.
/// </summary>
public class CookieSizeEvent : WebEventBase
{
	private const string _Name = "cookieSize";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.CookieSizeEvent" /> class.
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
	public CookieSizeEvent(EventStreamer streamer, CookieSizeEventArgs args)
		: base(streamer, "cookieSize", args)
	{
		if (args.RawCookies == null)
		{
			throw new ArgumentNullException("args.RawCookies");
		}
		if (args.Target != EventTarget.Diagnostic)
		{
			throw new ArgumentException("args.Target is not EventTarget.Diagnostic");
		}
		AddEventArg("cookieSizeThreshold", args.CookieSizeThreshold.ToString());
		AddEventArg("actualCookieSize", args.ActualCookieSize.ToString());
		AddEventArg("rawCookies", args.RawCookies);
	}
}
