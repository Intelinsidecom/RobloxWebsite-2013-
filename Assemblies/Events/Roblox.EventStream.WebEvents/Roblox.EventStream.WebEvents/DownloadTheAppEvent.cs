using Roblox.EventStream.WebEvents.EventArgs;
using System;
namespace Roblox.EventStream.WebEvents {
    public class DownloadTheAppEvent : WebEventBase

{
	private const string _Name = "downloadTheApp";

	public DownloadTheAppEvent(IEventStreamer streamer, DownloadTheAppEventArgs eventArgs)
		: base(streamer, "downloadTheApp", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Context))
		{
			throw new ArgumentException("eventArgs.Context cannot be empty");
		}
		AddEventArg("ctx", eventArgs.Context);
	}
}


}






