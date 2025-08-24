namespace Roblox.Platform.EventStream.WebEvents;

public class WebAuthenticatorLoginEvent : WebEventBase
{
	private const string _Name = "webAuthenticatorLogin";

	public WebAuthenticatorLoginEvent(IEventStreamer streamer, WebAuthenticatorLoginEventArgs args)
		: base(streamer, "webAuthenticatorLogin", args)
	{
		AddEventArg("url", args.Url);
	}
}
