using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class DeviceHandleRequestedEvent : WebEventBase
{
	private const string _Name = "deviceHandle";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.DeviceHandleRequestedEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.DeviceHandleRequestedEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformArgumentException">Throw if <paramref name="args.PageUrl.PageUrl" /> is not provided.</exception>
	public DeviceHandleRequestedEvent(IEventStreamer streamer, DeviceHandleRequestedEventArgs args)
		: base(streamer, "deviceHandle", args)
	{
		if (args.PageUrl == null)
		{
			throw new ArgumentException("args.PageUrl");
		}
		AddEventArg("url", args.PageUrl);
		AddEventArg("valid", args.Valid.ToString());
		AddEventArg("suppliedInHeader", args.SuppliedInHeader.ToString());
		AddEventArg("suppliedInCookie", args.SuppliedInCookie.ToString());
		AddEventArg("notSupplied", args.NotSupplied.ToString());
		AddEventArg("diagInvalid", args.Invalid.ToString());
		AddEventArg("diagFailed", args.Failed.ToString());
	}
}
