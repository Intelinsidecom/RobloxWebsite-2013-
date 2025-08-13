using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal interface IConversationTitleBuilder
{
	IConversationTitle BuildConversationTitleForViewer(IConversationWithParticipants conversation, IUser viewer);
}
