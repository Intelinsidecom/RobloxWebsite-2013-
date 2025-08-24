using System.Collections.Generic;

namespace Roblox.Platform.Chat;

public interface IUniqueConversationCache
{
	/// <summary>
	/// Adds a new cache entry for new conversation created
	/// </summary>
	/// <param name="conversationId"></param>
	void UpdateCacheForNewConversationCreated(long conversationId);

	/// <summary>
	/// Updates the unique conversation cache when participant/s is added to conversation
	/// </summary>
	/// <param name="conversationId"></param>
	/// <param name="addedUserIds"></param>
	void UpdateCacheForConversationParticipantsAdded(long conversationId, IReadOnlyCollection<long> addedUserIds);

	/// <summary>
	/// Updates the unique conversation cache when participant/s are removed from conversation
	/// </summary>
	/// <param name="conversationId"></param>
	/// <param name="removedUserIds"></param>
	void UpdateCacheForConversationParticipantsRemoved(long conversationId, IReadOnlyCollection<long> removedUserIds);

	/// <summary>
	/// Updates the unique conversation cache when conversation title is changed
	/// </summary>
	/// <param name="conversationId"></param>
	void UpdateCacheForConversationTitleChanged(long conversationId);

	/// <summary>
	/// Indicates whether a similar conversation was previously created and exists in the cache
	/// </summary>
	/// <param name="initiatorParticipant"></param>
	/// <param name="participants"></param>
	/// <param name="existingConversationId"></param>
	/// <returns></returns>
	bool ConversationExistsInCache(IParticipant initiatorParticipant, IParticipant[] participants, out long? existingConversationId);
}
