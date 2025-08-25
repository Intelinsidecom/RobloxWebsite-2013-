namespace Roblox.Platform.EventStream.WebEvents;

public class LogoutEvent : WebEventBase
{
	private const string _Name = "logout";

	public LogoutEvent(IEventStreamer streamer, LogoutEventArgs eventArgs)
		: base(streamer, "logout", eventArgs)
	{
		AddEventArg("allSessions", eventArgs.IsFromAllSessions.ToString());
		AddEventArg("reason", eventArgs.LogoutReason.ToString());
	}
}
