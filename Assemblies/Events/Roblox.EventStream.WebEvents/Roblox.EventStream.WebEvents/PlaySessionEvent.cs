namespace Roblox.Platform.EventStream.WebEvents;

public class PlaySessionEvent : WebEventBase
{
	private const string _Name = "playSession";

	public PlaySessionEvent(EventStreamer streamer, PlaySessionEventArgs args)
		: base(streamer, "playSession", args)
	{
		AddEventArg("pid", args.PlaceId.ToString());
		AddEventArg("gameid", args.GameId.ToString());
		AddEventArg("started", args.SessionStarted.ToUniversalTime().ToString("o"));
		AddEventArg("ctx", args.Context);
		if (args.Latitude.HasValue && args.Longitude.HasValue)
		{
			AddEventArg("latitude", args.Latitude.Value.ToString());
			AddEventArg("longitude", args.Longitude.Value.ToString());
		}
		if (args.CountryId.HasValue)
		{
			AddEventArg("countryCode", args.CountryId.Value.ToString());
		}
	}
}
