using System.Collections.Generic;
using Roblox.Platform.Presence;

namespace Roblox.Platform.Social.Recommendations.Entities;

internal class FriendRecommendationsModel
{
	public IDictionary<PresenceType, List<IPresence>> FriendsGroupedAndSortedOnPresenceType { get; }

	public int TotalFriendsCount { get; }

	public FriendRecommendationsModel(int totalFriendsCount, IDictionary<PresenceType, List<IPresence>> friendsGroupedAndSortedOnPresenceType)
	{
		FriendsGroupedAndSortedOnPresenceType = friendsGroupedAndSortedOnPresenceType;
		TotalFriendsCount = totalFriendsCount;
	}
}
