namespace Roblox.Platform.EventStream.WebEvents;

public class LogoutProcessorLogoutEvent : WebEventBase
{
	private const string _Name = "logoutProcessorLogout";

	public LogoutProcessorLogoutEvent(IEventStreamer streamer, LogoutProcessorLogoutEventArgs eventArgs)
		: base(streamer, "logoutProcessorLogout", eventArgs)
	{
		AddEventArg("success", eventArgs.Success.ToString());
	}
}
