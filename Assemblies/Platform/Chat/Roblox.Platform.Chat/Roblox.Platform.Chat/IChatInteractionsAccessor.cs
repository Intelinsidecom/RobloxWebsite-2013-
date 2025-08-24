using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal interface IChatInteractionsAccessor
{
	/// <summary>
	/// <see cref="M:Roblox.Platform.Chat.IChatInteractionsFactory.GetUniqueChatParticipantIdsForUser(Roblox.Platform.Membership.IUser,System.Int32,System.Int32)" />
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /></param>
	/// <param name="startIndex">start index for paged result</param>
	/// <param name="maxRows">maximum number of participants in response</param>
	/// <returns>list of unique chat members participant is in conversation with</returns>
	IReadOnlyCollection<IParticipant> GetUniqueChatParticipants(IParticipant participant, int startIndex, int maxRows);

	/// <summary>
	/// get total number of unique non-friend chat participants for a user
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /></param>
	/// <returns>total count of chat participants</returns>
	long GetUniqueChatParticipantsCount(IParticipant participant);

	/// <summary>
	/// updates the chat interactions cache for each participant in the dictionary with the other non friend participants, in a chat conversation with 
	/// </summary>
	/// <param name="usersWithChatInteractions"> <see cref="T:System.Collections.Generic.KeyValuePair`2" />For each participant in a conversation, all other participants in it</param>
	void UpdateChatInteractionsCacheForUsers(KeyValuePair<IParticipant, List<ChatInteraction>>[] usersWithChatInteractions);

	/// <summary>
	/// update chat interaction cache entry (another chat participant) for a participant 
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to update cache for</param>
	/// <param name="chatInteraction"><see cref="T:Roblox.Platform.Chat.ChatInteraction" />chat Interaction value to update in cache</param>
	void CacheChatInteractionForUser(IParticipant participant, ChatInteraction chatInteraction);

	/// <summary>
	/// update chat interaction cache entries (other chat participants) for a participant 
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to update cache for</param>
	/// <param name="chatInteractionsForParticipant"><see cref="T:Roblox.Platform.Chat.ChatInteraction" />chat Interaction entries to update in cache</param>
	void CacheChatInteractionsForUser(IParticipant participant, IReadOnlyCollection<ChatInteraction> chatInteractionsForParticipant);

	/// <summary>
	/// remove a user/participant's chat interaction cache entries for a set of participants, he is no longer in conversation with or became friends with
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to update cache for</param>
	/// <param name="participantInteractionToRemove"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participants whose cache interaction entries are to be removed</param>
	void RemoveCachedChatInteractionsForUser(IParticipant participant, HashSet<IParticipant> participantInteractionToRemove);

	/// <summary>
	/// remove a user/participant's chat interaction cache entries for a participant, he is no longer in conversation with or became friends with
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to update cache for</param>
	/// <param name="participantInteractionToRemove"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant whose cache interaction entry is to be removed</param>
	void RemoveCachedChatInteractionForUser(IParticipant participant, IParticipant participantInteractionToRemove);

	/// <summary>
	/// check if the chat interactions cache for firstParticipant (sorted set) already contains a record for the secondParticipant
	/// this is to avoid querying conversations between the 2 participants, in case of processing duplicated friendship events
	/// </summary>
	/// <param name="firstParticipant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to update cache for</param>
	/// <param name="secondParticipant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant whose cache interaction entry is to be checked against</param>
	/// <returns>score for secondParticipant's chat Interaction entry in first Participant's cache (sorted set)</returns>
	bool AreChatInteractionsAlreadyCachedForParticipants(IParticipant firstParticipant, IParticipant secondParticipant);

	/// <summary>
	/// get all distinct friends (participant objects) for the participant
	/// It returns null if participant is not a user or if friend service throws an exception
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /></param>
	/// <returns>list of friend Ids</returns>
	IReadOnlyCollection<IParticipant> GetFriendsForUserParticipant(IParticipant participant);

	/// <summary>
	/// generic utility method to Get chat interactions for a participant from its conversations
	/// </summary>
	/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" /> participant to query Chat Interactions for</param>
	/// <param name="filterParticipantsCondition"><see cref="T:System.Action" /><see cref="T:Roblox.Platform.Chat.ShouldParticipantBeIncludedInChatInteractions" />Optional Action to filter the participants that should be part of result Chat Interactions</param>
	/// <param name="queryConversationsExitCondition"><see cref="T:System.Action" /><see cref="T:Roblox.Platform.Chat.ShouldQueryMoreParticipantConversationsForChatInteractions" />Optional Action to control iterations of no of participant's conversations to be queried</param>
	/// <returns></returns>
	IReadOnlyCollection<ChatInteraction> GetChatInteractionsForParticipantFromConversations(IParticipant participant, ShouldParticipantBeIncludedInChatInteractions filterParticipantsCondition = null, ShouldQueryMoreParticipantConversationsForChatInteractions queryConversationsExitCondition = null);
}
