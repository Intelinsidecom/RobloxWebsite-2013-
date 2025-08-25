using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class RobuxPageClickEvent : WebEventBase
{
	private const string _Name = "RobuxPageClick";

	public RobuxPageClickEvent(EventStreamer streamer, RobuxPageClickEventArgs eventArgs)
		: base(streamer, "RobuxPageClick", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Page))
		{
			throw new ArgumentException("eventArgs.Page is required");
		}
		if (string.IsNullOrWhiteSpace(eventArgs.Context))
		{
			throw new ArgumentException("eventArgs.Context is required");
		}
		AddEventArg("pg", eventArgs.Page);
		AddEventArg("ctx", eventArgs.Context);
	}
}
