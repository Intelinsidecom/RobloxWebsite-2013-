using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IConversationFactory
{
	IConversation GetConversation(long conversationId);

	IConversation GetConversationWithoutParticipants(long conversationId);

	IReadOnlyCollection<IConversation> GetConversations(IUser user, int startIndex, int maxRows);

	IReadOnlyCollection<IConversation> GetConversations(IUser user, long[] conversationIds);

	long GetUnreadConversationCount(IUser user);

	IReadOnlyCollection<IUser> GetConversationParticipantUsers(long conversationId, IUser user);

	bool DoesConversationContainsUser(IUser user, long conversationId);
}
