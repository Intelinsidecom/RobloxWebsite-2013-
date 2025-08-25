namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortsListEvent : WebEventBase
{
	private const string _Name = "gameSortsList";

	private const string _Version = "version";

	private const string _Variation = "variation";

	private const string _GameSortsContext = "gameSortsContext";

	private const string _GameSets = "gameSets";

	public GameSortsListEvent(IEventStreamer streamer, GameSortsListEventArgs extendedArgs)
		: base(streamer, "gameSortsList", extendedArgs)
	{
		if (extendedArgs != null)
		{
			AddEventArg("version", extendedArgs.VersionId?.ToString() ?? string.Empty);
			AddEventArg("variation", extendedArgs.VariationValue?.ToString() ?? string.Empty);
			AddEventArg("gameSortsContext", extendedArgs.GameSortsContext ?? string.Empty);
			AddEventArg("gameSets", extendedArgs.GameSorts ?? string.Empty);
		}
	}
}
