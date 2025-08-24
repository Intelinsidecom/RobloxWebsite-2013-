using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IParticipantUtilities
{
	bool IsUser(IParticipant participant);

	bool IsUserUnder13(IParticipant participant);

	IParticipant ToParticipant(IUser user);

	IUser ToUser(IParticipant participant);

	IReadOnlyDictionary<long, IUser> BatchGetUsersForConversation(IConversationWithParticipants conversation);

	IReadOnlyDictionary<long, IUser> BatchGetUsersForConversations(IEnumerable<IConversationWithParticipants> conversations);
}
