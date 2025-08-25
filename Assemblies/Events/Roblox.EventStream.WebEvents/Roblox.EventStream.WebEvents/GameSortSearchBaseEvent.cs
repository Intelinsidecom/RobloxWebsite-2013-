namespace Roblox.Platform.EventStream.WebEvents;

public abstract class GameSortSearchBaseEvent : WebEventBase
{
	private const string _GamesStartIndex = "GamesStartIndex";

	private const string _MaxGames = "maxGames";

	private const string _Page = "page";

	private const string _FeaturedSearch = "featuredPlaceId";

	private const string _AssetsReturned = "assetsReturned";

	/// <summary>
	/// The event that represents a game search.
	/// </summary>
	protected GameSortSearchBaseEvent(IEventStreamer streamer, string name, GameSortSearchBaseEventArgs eventArgs)
		: base(streamer, name, eventArgs)
	{
		AddEventArg("GamesStartIndex", eventArgs.GamesStartIndex);
		AddEventArg("maxGames", eventArgs.MaxGames);
		AddEventArg("page", eventArgs.Page.ToString());
		if (eventArgs.FeaturedPlaceId.HasValue)
		{
			AddEventArg("featuredPlaceId", eventArgs.FeaturedPlaceId.ToString());
		}
		if (!string.IsNullOrEmpty(eventArgs.AssetsReturned))
		{
			AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		}
	}
}
