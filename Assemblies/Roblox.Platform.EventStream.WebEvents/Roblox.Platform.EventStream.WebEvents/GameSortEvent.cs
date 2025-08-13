namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortEvent : GameSortSearchBaseEvent
{
	private const string _Name = "gameSort";

	private const string _SortPosition = "sortPosition";

	private const string _SortFilter = "sortFilter";

	private const string _GameSetTargetId = "gameSetTargetId";

	private const string _IsSeeAllPage = "isSeeAllPage";

	/// <summary>
	/// The event that represents a game search.
	/// </summary>
	public GameSortEvent(IEventStreamer streamer, GameSortEventArgs eventArgs)
		: base(streamer, "gameSort", eventArgs)
	{
		if (eventArgs.SortPosition.HasValue)
		{
			AddEventArg("sortPosition", eventArgs.SortPosition.Value);
		}
		if (eventArgs.SortFilter.HasValue)
		{
			AddEventArg("sortFilter", eventArgs.SortFilter.Value);
		}
		if (eventArgs.GameSetTargetId.HasValue)
		{
			AddEventArg("gameSetTargetId", eventArgs.GameSetTargetId.Value);
		}
		if (eventArgs.IsSeeAllPage.HasValue)
		{
			AddEventArg("isSeeAllPage", eventArgs.IsSeeAllPage.Value.ToString());
		}
	}
}
