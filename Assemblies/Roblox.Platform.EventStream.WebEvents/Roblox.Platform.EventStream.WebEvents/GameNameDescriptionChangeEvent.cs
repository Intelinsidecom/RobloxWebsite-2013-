namespace Roblox.Platform.EventStream.WebEvents;

public class GameNameDescriptionChangeEvent : WebEventBase
{
	private const string _Name = "gameNameDescriptionChange";

	public GameNameDescriptionChangeEvent(IEventStreamer streamer, GameNameDescriptionChangeEventArgs args)
		: base(streamer, "gameNameDescriptionChange", args)
	{
		AddEventArg("universeId", args.UniverseId.ToString());
		if (args.LanguageCode != null)
		{
			AddEventArg("languageCode", args.LanguageCode);
		}
		AddEventArg("isSourceLanguage", args.IsSourceLanguage.ToString());
		AddEventArg("userType", args.UserType);
		AddEventArg("actionType", args.ActionType);
		AddEventArg("field", args.Field);
	}
}
