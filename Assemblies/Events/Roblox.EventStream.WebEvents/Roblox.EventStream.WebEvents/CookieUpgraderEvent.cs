using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an Event stream event for Cookie upgrade.
/// </summary>
public class CookieUpgraderEvent : WebEventBase
{
	private const string _Name = "CookieUpgrader";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.CookieUpgraderEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.CookieUpgraderEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformArgumentNullException">
	/// streamer
	/// or 
	/// args
	/// or
	/// args.CookieName
	/// </exception>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Diagnostic" />.</exception>
	public CookieUpgraderEvent(IEventStreamer streamer, CookieUpgraderEventArgs args)
		: base(streamer, "CookieUpgrader", args)
	{
		if (args.CookieName == null)
		{
			throw new ArgumentNullException("args.CookieName");
		}
		if (args.Target != EventTarget.Diagnostic)
		{
			throw new ArgumentException("args.Target is not EventTarget.Diagnostic");
		}
		AddEventArg("ctx", args.Ctx.ToString());
		AddEventArg("cookieName", args.CookieName);
		AddEventArg("cookieValue", args.CookieValue);
		if (args.Ctx == CookieUpgraderContextTypes.ConvertedCookie)
		{
			if (args.NewCookieName == null)
			{
				throw new ArgumentNullException("args.NewCookieName");
			}
			AddEventArg("newCookieName", args.NewCookieName);
		}
	}
}
