namespace Roblox.Platform.EventStream.WebEvents;

public class GamesPageLoadEvent : WebEventBase
{
	private const string _Name = "gamesPageLoad";

	public GamesPageLoadEvent(IEventStreamer streamer, GamesPageLoadEventArgs eventArgs)
		: base(streamer, "gamesPageLoad", eventArgs)
	{
		if (!string.IsNullOrWhiteSpace(eventArgs.Referrer))
		{
			AddEventArg("referrer", eventArgs.Referrer);
		}
	}
}
