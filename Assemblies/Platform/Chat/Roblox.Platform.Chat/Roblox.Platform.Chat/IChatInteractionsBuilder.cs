using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IChatInteractionsBuilder
{
	/// <summary>
	/// update chat participants cache for each participant, with all other participants, in the newly created conversation
	/// </summary>
	/// <param name="conversationId">conversation Id</param>
	void UpdateCacheForNewConversationCreated(long conversationId);

	/// <summary>
	/// update chat participants cache for the new participant(s) added to the conversation with every other existing participant entry,
	/// and update each existing participant's cache with an entry for the newly added participant(s)
	/// </summary>
	/// <param name="conversationId"> conversation Id</param>
	/// <param name="newUsersAddedToConversation">new participants <see cref="T:Roblox.Platform.Membership.IUser" /> added to conversation</param>
	void UpdateCacheForNewUsersAddedToConversation(long conversationId, IReadOnlyCollection<IUser> newUsersAddedToConversation);

	/// <summary>
	/// update cache entry for both the removed participant(s) and every other participant in the conversation, 
	/// if they have any other common group conversation between them, else remove the cache entries
	/// </summary>
	/// <param name="conversationId">conversation id</param>
	/// <param name="usersRemovedFromConversation">participants <see cref="T:Roblox.Platform.Membership.IUser" /> removed from the conversation</param>
	void UpdateCacheForUsersRemovedFromConversation(long conversationId, IReadOnlyCollection<IUser> usersRemovedFromConversation);

	/// <summary>
	/// update cache entries for the two participants (no longer friends), if they have any common group conversation between them
	/// </summary>
	/// <param name="firstUser"><see cref="T:Roblox.Platform.Membership.IUser" />first participant</param>
	/// <param name="secondUser"><see cref="T:Roblox.Platform.Membership.IUser" /> second participant</param>
	void RestoreCacheForFrienshipRevokedEvent(IUser firstUser, IUser secondUser);

	/// <summary>
	/// remove the cache entries (exists if they have a common group conversation) for the two participants, once they become friends
	/// </summary>
	/// <param name="firstUser"><see cref="T:Roblox.Platform.Membership.IUser" />first participant</param>
	/// <param name="secondUser"><see cref="T:Roblox.Platform.Membership.IUser" /> second participant</param>
	void RestoreCacheForFrienshipFormedEvent(IUser firstUser, IUser secondUser);
}
