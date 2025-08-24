using Roblox.Platform.Membership;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

public interface IContentValidationRules
{
	bool IsTextAppropriateToSend(FilterLiveTextResult filterLiveTextResult, IUser sender, IConversationWithParticipants conversation);

	bool IsTextMoreStrictlyFilteredForOtherViewers(FilterLiveTextResult filterLiveTextResult, IUser sender, IConversationWithParticipants conversation);

	string GetTextForOver13Viewers(FilterLiveTextResult filterLiveTextResult, IUser sender);

	string GetTextForUnder13Viewers(FilterLiveTextResult filterLiveTextResult);
}
