using System;
using System.Collections.Generic;

namespace Roblox.Platform.Social.PlayerInteractions;

public interface IPlayerInteractionDataAccessor
{
	int MaxPlayerInteractionsToStore { get; }

	IEnumerable<PlayerInteraction> GetRecentPlayerInteractions(long userId, int startIndex, int maxRows);

	int GetTotalRecentPlayerInteractionCount(long userId);

	void UpdateRecentPlayerInteractions(long userId, IReadOnlyCollection<long> otherUserIds, long placeId, DateTime interactionTime);

	void DeleteAllPlayerInteractions(long userId);

	void RefreshKeyExpiry(long userId);
}
