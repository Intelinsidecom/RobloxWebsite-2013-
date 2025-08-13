using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IGameNameDescriptionChangeEventFactory
{
	GameNameDescriptionChangeEvent CreateEvent(long? userId, long universeId, string languageCode, bool isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum userType, GameNameDescriptionChangeEventActionTypeEnum actionType, GameNameDescriptionChangeEventFieldEnum field);
}
