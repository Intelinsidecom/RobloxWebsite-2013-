using System.Linq;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortsDisplayEvent : WebEventBase
{
	private const string _Name = "gameSortsDisplay";

	public GameSortsDisplayEvent(IEventStreamer streamer, GameSortsDisplayEventArgs extendedArgs)
		: base(streamer, "gameSortsDisplay", extendedArgs)
	{
		AddEventArg("version", extendedArgs?.VersionId?.ToString() ?? string.Empty);
		AddEventArg("variation", extendedArgs?.VariationValue?.ToString() ?? string.Empty);
		AddEventArg("gameSets", GetGameSetIds(extendedArgs));
	}

	private string GetGameSetIds(GameSortsDisplayEventArgs args)
	{
		string csv = ((args?.GameSetIds?.Any() ?? false) ? string.Join(",", args.GameSetIds.Select((int id) => id.ToString())) : string.Empty);
		return $"[{csv}]";
	}
}
