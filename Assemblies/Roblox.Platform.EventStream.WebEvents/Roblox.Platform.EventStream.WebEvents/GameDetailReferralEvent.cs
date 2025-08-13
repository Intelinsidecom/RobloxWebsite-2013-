namespace Roblox.Platform.EventStream.WebEvents;

public class GameDetailReferralEvent : WebEventBase
{
	private const string _Name = "gameDetailReferral";

	public GameDetailReferralEvent(IEventStreamer streamer, GameDetailReferralEventArgs extendedArgs)
		: base(streamer, "gameDetailReferral", extendedArgs)
	{
		AddEventArg("pg", extendedArgs.Page ?? string.Empty);
		AddEventArg("lt", extendedArgs.LocalTimestamp ?? string.Empty);
		AddEventArg("tis", extendedArgs.TotalInSort?.ToString() ?? string.Empty);
		AddEventArg("pid", extendedArgs.PlaceId.ToString());
		AddEventArg("ctx", extendedArgs.Context ?? string.Empty);
		AddEventArg("ad", extendedArgs.IsNativeAd.ToString());
		AddEventArg("expctx", extendedArgs.ExperimentalContext ?? string.Empty);
	}
}
