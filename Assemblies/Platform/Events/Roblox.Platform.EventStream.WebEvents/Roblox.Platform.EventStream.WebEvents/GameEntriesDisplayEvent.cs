using System.Linq;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameEntriesDisplayEvent : WebEventBase
{
	private const string _Name = "gameEntriesDisplay";

	private const string _SortFilter = "sortFilter";

	private const string _StartRows = "startRows";

	private const string _MaxRows = "maxRows";

	private const string _Version = "version";

	private const string _Variation = "variation";

	private const string _Places = "places";

	public GameEntriesDisplayEvent(IEventStreamer streamer, GameEntriesDisplayEventArgs extendedArgs)
		: base(streamer, "gameEntriesDisplay", extendedArgs)
	{
		AddEventArg("sortFilter", extendedArgs?.SortFilter?.ToString() ?? string.Empty);
		AddEventArg("startRows", extendedArgs?.StartRows?.ToString() ?? string.Empty);
		AddEventArg("maxRows", extendedArgs?.MaxRows?.ToString() ?? string.Empty);
		AddEventArg("version", extendedArgs?.VersionId?.ToString() ?? string.Empty);
		AddEventArg("variation", extendedArgs?.VariationValue?.ToString() ?? string.Empty);
		AddEventArg("places", GetGameEntries(extendedArgs));
	}

	private string GetGameEntries(GameEntriesDisplayEventArgs args)
	{
		string csv = ((args?.PlaceIds?.Any() ?? false) ? string.Join(",", args.PlaceIds.Select((long id) => id.ToString())) : string.Empty);
		return $"[{csv}]";
	}
}
