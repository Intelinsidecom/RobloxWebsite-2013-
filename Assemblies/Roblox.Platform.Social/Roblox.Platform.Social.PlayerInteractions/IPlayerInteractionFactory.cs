using System;
using System.Collections.Generic;
using Roblox.Paging;

namespace Roblox.Platform.Social.PlayerInteractions;

public interface IPlayerInteractionFactory
{
	IPagedResult<long, IPlayerInteraction> GetRecentPlayerInteractions(long userId, int startIndex, int maxRows);

	void UpdateRecentPlayerInteractions(long userId, IReadOnlyCollection<long> otherUserIds, long placeId, DateTime interactionTime);
}
