namespace Roblox.Platform.EventStream.WebEvents;

public class SessionValidationFailureEvent : WebEventBase
{
	private const string _Name = "sessionValidationFailure";

	public SessionValidationFailureEvent(IEventStreamer streamer, SessionValidationFailureEventArgs args)
		: base(streamer, "sessionValidationFailure", args)
	{
		AddEventArg("status", args.CookieValidationStatus.ToString());
	}
}
