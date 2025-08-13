using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class GameNameDescriptionChangeEventFactory : IGameNameDescriptionChangeEventFactory
{
	private readonly IEventStreamer _EventStreamer;

	public GameNameDescriptionChangeEventFactory(IEventStreamer eventStreamer)
	{
		_EventStreamer = eventStreamer.AssignOrThrowIfNull("eventStreamer");
	}

	public GameNameDescriptionChangeEvent CreateEvent(long? userId, long universeId, string languageCode, bool isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum userType, GameNameDescriptionChangeEventActionTypeEnum actionType, GameNameDescriptionChangeEventFieldEnum field)
	{
		GameNameDescriptionChangeEventArgs gameNameDescriptionChangeEventArgs = new GameNameDescriptionChangeEventArgs
		{
			UserId = userId,
			UniverseId = universeId,
			LanguageCode = languageCode,
			IsSourceLanguage = isSourceLanguage,
			UserType = userType.ToString(),
			ActionType = actionType.ToString(),
			Field = field.ToString()
		};
		return new GameNameDescriptionChangeEvent(_EventStreamer, gameNameDescriptionChangeEventArgs);
	}
}
