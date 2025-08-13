using Roblox.Platform.Chat.Events;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

/// <summary>
/// No authorization checks. These methods should not be used from the user facing sites
/// </summary>
public interface IConversationPruner
{
	void DeleteMessages(long conversationId);

	void RemoveConversationFromUsersLists(long conversationId, long userId);

	/// <summary>
	/// No authorization checks. This method should not be used from the user facing sites
	/// </summary>
	void ArchiveOneToOneConversation(IUser firstUser, IUser secondUser);

	/// <summary>
	/// No authorization checks. This method should not be used from the user facing sites
	/// </summary>
	bool RestoreOneToOneConversation(IUser firstUser, IUser secondUser);

	/// <summary>
	/// No authorization checks. This method should not be used from the user facing sites
	/// Invoked on cache miss events, to restore score for conversations which might not have correct lastUpdated/score values
	/// </summary>
	void UpdateScoreForParticipantConversationsMissingInCache(long userId, ConversationsMissingInCache conversationsMissingInCache);
}
