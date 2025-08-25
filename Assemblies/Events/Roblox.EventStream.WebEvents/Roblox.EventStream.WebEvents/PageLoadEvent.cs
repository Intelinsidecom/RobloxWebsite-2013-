using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event for when a page is loaded.
/// </summary>
public class PageLoadEvent : WebEventBase
{
	private const string _Name = "pageLoad";

	private const string _Ctx = "ctx";

	private const string _Effloc = "effloc";

	private const string _Url = "url";

	public PageLoadEvent(IEventStreamer streamer, PageLoadEventArgs eventArgs)
		: base(streamer, "pageLoad", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.PageUrl))
		{
			throw new ArgumentException("eventArgs.PageURL is required");
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.InternalPageName))
		{
			AddEventArg("ctx", eventArgs.InternalPageName);
		}
		if (!string.IsNullOrWhiteSpace(eventArgs.EffectiveLocale))
		{
			AddEventArg("effloc", eventArgs.EffectiveLocale);
		}
		AddEventArg("url", eventArgs.PageUrl);
	}
}
