namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents a web event that can be streamed.
/// </summary>
public abstract class WebEventBase : EventBase
{
	private const string _PageId = "pageId";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventBase" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" /> used to stream the event.</param>
	/// <param name="eventName">The name of the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> containing event info.</param>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="streamer" />, <paramref name="eventName" />, or <paramref name="args" /> is null.</exception>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not a supported <see cref="T:Roblox.Platform.EventStream.WebEvents.EventTarget" />.</exception>
	protected WebEventBase(IEventStreamer streamer, string eventName, WebEventArgs args)
		: base(streamer, eventName, args)
	{
		if (args.PageId.HasValue)
		{
			AddEventArg("pageId", args.PageId.Value);
		}
		if (args.BrowserTrackerId.HasValue)
		{
			AddEventArg("btid", args.BrowserTrackerId.Value.ToString());
		}
		if (args.PlatformTypeId.HasValue)
		{
			AddEventArg("ptid", args.PlatformTypeId.Value.ToString());
		}
		if (args.ReferrerUrl != null)
		{
			AddEventArg("refurl", args.ReferrerUrl);
		}
		if (args.SessionId != null)
		{
			AddEventArg("sid", args.SessionId);
		}
		if (args.UserId.HasValue)
		{
			AddEventArg("uid", args.UserId.Value.ToString());
		}
		if (args.UserAgent != null)
		{
			AddEventArg("ua", args.UserAgent);
		}
		if (args.GuestId.HasValue)
		{
			AddEventArg("gid", args.GuestId.Value.ToString());
		}
	}
}
