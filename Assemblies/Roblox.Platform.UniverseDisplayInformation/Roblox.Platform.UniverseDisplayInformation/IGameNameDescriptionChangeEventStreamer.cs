using Roblox.Platform.Localization.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IGameNameDescriptionChangeEventStreamer
{
	void StreamGameNameDescriptionChangeEvent(IUserIdentifier user, IUniverse universe, ILanguageFamily language, bool isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum userType, GameNameDescriptionChangeEventActionTypeEnum actionType, GameNameDescriptionChangeEventFieldEnum field);
}
