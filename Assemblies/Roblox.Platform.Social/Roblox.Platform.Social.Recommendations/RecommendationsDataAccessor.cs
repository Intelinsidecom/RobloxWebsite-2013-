using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.EventLog;
using Roblox.Paging;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Platform.Social.Comparers;
using Roblox.Platform.Social.PlayerInteractions;
using Roblox.Platform.Social.Properties;
using Roblox.Platform.Social.Recommendations.Entities;
using Roblox.Platform.Social.Recommendations.Interfaces;

namespace Roblox.Platform.Social.Recommendations;

public class RecommendationsDataAccessor : IRecommendationsDataAccessor
{
	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IPlayerInteractionFactory _PlayerInteractionFactory;

	private readonly IPresenceReader _PresenceReader;

	private readonly UserPresenceTypeComparer _PresenceTypeComparer;

	private readonly ILogger _Logger;

	public RecommendationsDataAccessor(IFriendshipFactory friendshipFactory, IUserFactory userFactory, IPlayerInteractionFactory playerInteractionFactory, IPresenceReader presenceReader, UserPresenceTypeComparer presenceTypeComparer, ILogger logger)
	{
		_FriendshipFactory = friendshipFactory ?? throw new ArgumentNullException("friendshipFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_PlayerInteractionFactory = playerInteractionFactory ?? throw new ArgumentNullException("playerInteractionFactory");
		_PresenceReader = presenceReader ?? throw new ArgumentNullException("presenceReader");
		_PresenceTypeComparer = presenceTypeComparer ?? throw new ArgumentNullException("presenceTypeComparer");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IReadOnlyCollection<IPresence> GetPeopleRecommendationsForUser(long userId)
	{
		FriendRecommendationsModel friends = null;
		IReadOnlyCollection<IPresence> suggestions = null;
		IUser user = _UserFactory.GetUser(userId);
		Parallel.Invoke(delegate
		{
			friends = GetFriendsRecommendationsGroupedAndSortedOnPresence(user);
		}, delegate
		{
			suggestions = GetRecentPlayerInteractionsSortedOnPresence(user);
		});
		return BuildRecommendationsOrderFromFriendsAndSuggestions(friends, suggestions);
	}

	internal IReadOnlyCollection<IPresence> BuildRecommendationsOrderFromFriendsAndSuggestions(FriendRecommendationsModel friends, IReadOnlyCollection<IPresence> suggestions)
	{
		int recommendationsSize = (friends?.TotalFriendsCount ?? 0) + (suggestions?.Count ?? 0);
		if (recommendationsSize < 1)
		{
			return null;
		}
		List<IPresence> result = new List<IPresence>(recommendationsSize);
		if (friends?.FriendsGroupedAndSortedOnPresenceType != null && friends.FriendsGroupedAndSortedOnPresenceType.TryGetValue(PresenceType.InGame, out var friendsForPresenceType) && friendsForPresenceType != null && friendsForPresenceType.Count > 0)
		{
			result.AddRange(friendsForPresenceType);
		}
		if (friends?.FriendsGroupedAndSortedOnPresenceType != null && friends.FriendsGroupedAndSortedOnPresenceType.TryGetValue(PresenceType.Online, out friendsForPresenceType) && friendsForPresenceType != null && friendsForPresenceType.Count > 0)
		{
			result.AddRange(friendsForPresenceType);
		}
		if (suggestions != null && suggestions.Count > 0)
		{
			result.AddRange(suggestions);
		}
		if (friends?.FriendsGroupedAndSortedOnPresenceType != null && friends.FriendsGroupedAndSortedOnPresenceType.TryGetValue(PresenceType.InStudio, out friendsForPresenceType) && friendsForPresenceType != null && friendsForPresenceType.Count > 0)
		{
			result.AddRange(friendsForPresenceType);
		}
		if (friends?.FriendsGroupedAndSortedOnPresenceType != null && friends.FriendsGroupedAndSortedOnPresenceType.TryGetValue(PresenceType.Offline, out friendsForPresenceType) && friendsForPresenceType != null && friendsForPresenceType.Count > 0)
		{
			result.AddRange(friendsForPresenceType);
		}
		return result;
	}

	internal FriendRecommendationsModel GetFriendsRecommendationsGroupedAndSortedOnPresence(IUser user)
	{
		IReadOnlyCollection<IFriend> friends;
		try
		{
			friends = _FriendshipFactory.GetAllFriends(user);
		}
		catch (FriendshipOperationUnavailableException e)
		{
			_Logger.Error(e);
			return null;
		}
		if (friends == null || friends.Count < 1)
		{
			return null;
		}
		IEnumerable<IPresence> userPresences = _PresenceReader.MultiGetPrioritizedPresence(friends.Select((IFriend friend) => _UserFactory.GetUser(friend.UserId)).ToList());
		return BuildFriendsRecommendationModelOnSortedPresences((IReadOnlyCollection<IPresence>)(object)userPresences.ToArray(), Settings.Default.FriendsLimitInRecommendationsResponse);
	}

	internal FriendRecommendationsModel BuildFriendsRecommendationModelOnSortedPresences(IReadOnlyCollection<IPresence> userPresences, int maxFriendsInResponse)
	{
		Dictionary<PresenceType, IEnumerable<IPresence>> friendsGroupedByPresence = (from x in userPresences
			group x by x.PresenceType).ToDictionary((IGrouping<PresenceType, IPresence> pair) => pair.Key, (IGrouping<PresenceType, IPresence> pair) => pair.AsEnumerable());
		int friendsLimit = Math.Min(userPresences.Count, maxFriendsInResponse);
		Dictionary<PresenceType, List<IPresence>> friendsGroupedAndSortedOnPresence = new Dictionary<PresenceType, List<IPresence>>();
		int totalFriendsCount = 0;
		PresenceType[] presenceOrder = UserPresenceTypeComparer.PresenceOrder;
		foreach (PresenceType presenceType in presenceOrder)
		{
			if (friendsGroupedByPresence.TryGetValue(presenceType, out var recommendationGroup))
			{
				List<IPresence> list = recommendationGroup?.OrderBy((IPresence presence) => presence, _PresenceTypeComparer)?.Take(friendsLimit).ToList();
				if (list != null && list.Count > 0)
				{
					friendsGroupedAndSortedOnPresence.Add(presenceType, list);
					totalFriendsCount += list.Count;
					friendsLimit -= list.Count;
				}
			}
			if (friendsLimit <= 0)
			{
				return new FriendRecommendationsModel(totalFriendsCount, friendsGroupedAndSortedOnPresence);
			}
		}
		return new FriendRecommendationsModel(totalFriendsCount, friendsGroupedAndSortedOnPresence);
	}

	internal IReadOnlyCollection<IPresence> GetRecentPlayerInteractionsSortedOnPresence(IUser user)
	{
		if (!Settings.Default.IsGetRecentPlayerInteractionsForRecommendationsEnabled)
		{
			return null;
		}
		int start = 0;
		List<IPresence> recentPlayerInteractionsSortedOnPresence = new List<IPresence>();
		int recentPlayerInteractionsPagedItemsCount = 0;
		HashSet<long> friendsIds;
		try
		{
			friendsIds = new HashSet<long>(from friend in _FriendshipFactory.GetAllFriends(user)
				where friend != null
				select friend.UserId);
		}
		catch (Exception e2)
		{
			_Logger.Error(e2);
			return null;
		}
		long num;
		long? num2;
		do
		{
			IPagedResult<long, IPlayerInteraction> recentPlayerInteractions = _PlayerInteractionFactory.GetRecentPlayerInteractions(user.Id, start, 50);
			recentPlayerInteractionsPagedItemsCount = 0;
			if (recentPlayerInteractions?.PageItems != null && recentPlayerInteractions != null && recentPlayerInteractions.Count > 0)
			{
				List<IUser> playerInteractionsWithFriendsFilteredOut = new List<IUser>();
				foreach (IPlayerInteraction playerInteraction in recentPlayerInteractions.PageItems)
				{
					try
					{
						if (!friendsIds.Contains(playerInteraction.UserId))
						{
							IUser playerInteractionUser = _UserFactory.GetUser(playerInteraction.UserId);
							if (playerInteractionUser != null)
							{
								playerInteractionsWithFriendsFilteredOut.Add(playerInteractionUser);
							}
						}
					}
					catch (Exception e)
					{
						_Logger.Error(e);
					}
					recentPlayerInteractionsPagedItemsCount++;
				}
				IOrderedEnumerable<IPresence> sortedPlayerInteractions = (_PresenceReader.MultiGetPrioritizedPresence(playerInteractionsWithFriendsFilteredOut)?.Where((IPresence presence) => PresenceType.Online.Equals(presence.PresenceType) || PresenceType.InGame.Equals(presence.PresenceType)))?.OrderBy((IPresence presence) => presence, _PresenceTypeComparer);
				if (sortedPlayerInteractions != null)
				{
					recentPlayerInteractionsSortedOnPresence.AddRange(sortedPlayerInteractions);
				}
				start += recentPlayerInteractionsPagedItemsCount;
			}
			if (recentPlayerInteractionsPagedItemsCount < 0)
			{
				break;
			}
			num = start;
			num2 = recentPlayerInteractions?.Count;
		}
		while (num < num2.GetValueOrDefault() && num2.HasValue && recentPlayerInteractionsSortedOnPresence.Count < Settings.Default.SuggestedNonFriendsLimitInRecommendationsResponse);
		return recentPlayerInteractionsSortedOnPresence;
	}
}
