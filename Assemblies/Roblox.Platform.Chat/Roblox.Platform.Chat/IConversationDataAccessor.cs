using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

internal interface IConversationDataAccessor
{
	IConversationWithParticipants GetOneToOneConversation(IParticipant participant1, IParticipant participant2);

	IConversationWithParticipants GetCloudEditConversation(long placeId);

	IConversationWithParticipants GetConversationWithParticipants(long conversationId, IReadOnlyCollection<ConversationType> conversationTypesToQuery = null);

	ConversationType? GetConversationType(long conversationId);

	IReadOnlyCollection<ConversationWithParticipantsAndStatus> GetConversationsForParticipant(IParticipant participant, int startIndex, int maxRows);

	IReadOnlyCollection<IConversationWithParticipants> GetConversationsWithParticipantsForParticipant(IParticipant participant, int startIndex, int maxRows, out int conversationIdsQueried, IReadOnlyCollection<ConversationType> conversationTypesToQuery = null);

	long GetParticipantUnreadConversationCount(IParticipant participant);

	long GetParticipantConversationCount(IParticipant participant);

	long? GetCloudEditConversationPlaceId(long conversationId);

	int GetMaxParticipantsInConversation(ConversationType conversationType);

	bool DoesContainParticipant(long conversationId, IParticipant participant);

	bool TryToMarkConversationAsReadForParticipant(long conversationId, IParticipant participant);

	long? ArchiveOneToOneConversation(IParticipant participant1, IParticipant participant2);

	long? RestoreOneToOneConversation(IParticipant participant1, IParticipant participant2);

	bool RemoveConversation(long conversationId);

	bool RemoveConversationUniverse(long conversationId);

	IConversationWithParticipants UpdateConversationForNewMessage(long conversationId, IParticipant messageSender);

	IConversationWithParticipants CreateSocialConversation(IParticipant initiator, IReadOnlyCollection<IParticipant> participants, ConversationType conversationType);

	IConversationWithParticipants CreateCloudEditConversation(IParticipant initiator, IReadOnlyCollection<IParticipant> participants, long placeId);

	void AddParticipantsToConversation(long conversationId, IReadOnlyCollection<IParticipant> newParticipants);

	bool RemoveConversationParticipant(long conversationId, IParticipant participantToBeRemoved);

	IConversationWithParticipants RenameSocialConversation(long conversationId, string over13Title, string under13Title);

	bool UpdateConversationTimeStamp(long conversationId);

	void SetConversationUniverse(long conversationId, long universeId, out DateTime? conversationUniverseChangedDateTime);

	void ResetConversationUniverse(long conversationId);

	IReadOnlyCollection<ConversationIdWithScore> GetCacheMissParticipantConversationsEligibleForScoreUpdate(IParticipant participant, ConversationsMissingInCache conversationsMissingInCache);

	void UpdateParticipantConversationScoreInCache(IParticipant participant, long conversationId, long score);

	long? GetConversationUniverseId(long conversationId);

	IConversation GetConversationWithoutParticipants(long conversationId);
}
