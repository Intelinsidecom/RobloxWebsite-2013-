namespace Roblox.Platform.EventStream.WebEvents;

public class UserLoggedInEvent : WebEventBase
{
	private const string _Name = "userLoggedIn";

	public UserLoggedInEvent(IEventStreamer streamer, UserLoggedInEventArgs args)
		: base(streamer, "userLoggedIn", args)
	{
		AddEventArg("username", args.Username);
	}
}
