using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal interface IChatFloodCheckerFactory
{
	IFloodChecker GetFloodCheckerForSetConversationUniverse(string category, IUser currentUser);

	IFloodChecker GetFloodCheckerForUpdateUserTypingStatus(string category, IUser currentUser);
}
