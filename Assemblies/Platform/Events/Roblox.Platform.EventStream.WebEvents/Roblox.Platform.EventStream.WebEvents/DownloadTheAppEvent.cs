using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class DownloadTheAppEvent : WebEventBase
{
	private const string _Name = "downloadTheApp";

	public DownloadTheAppEvent(EventStreamer streamer, DownloadTheAppEventArgs eventArgs)
		: base(streamer, "downloadTheApp", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Context))
		{
			throw new ArgumentException("eventArgs.Context cannot be empty");
		}
		AddEventArg("ctx", eventArgs.Context);
	}
}
