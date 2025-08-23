using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Platform.Social;
using Roblox.TranslationResources.Common;
using Roblox.Web.Presence;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code.Util;

public class GameInstanceHelper
{
	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly PresenceResponseFilter _PresenceResponseFilter;

	private readonly IGameInstanceFactory _GameInstanceFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IPresenceReader _PresenceReader;

	public GameInstanceHelper(IFriendshipFactory friendshipFactory, PresenceResponseFilter presenceResponseFilter, IGameInstanceFactory gameInstanceFactory, IUserFactory userFactory, IPresenceReader presenceReader)
	{
		if (friendshipFactory == null || presenceResponseFilter == null || gameInstanceFactory == null || userFactory == null)
		{
			throw new ArgumentNullException();
		}
		_FriendshipFactory = friendshipFactory;
		_PresenceResponseFilter = presenceResponseFilter;
		_GameInstanceFactory = gameInstanceFactory;
		_UserFactory = userFactory;
		_PresenceReader = presenceReader ?? throw new ArgumentNullException("presenceReader");
	}

	public ICollection<IGameInstance> GetFriendsGameInstances(IUser User, long placeId, IPresenceResources presenceResources, out List<IPresence> friendsInGame)
	{
		List<long> friendIds = (from friend in _FriendshipFactory.GetAllFriends(User)
			select friend.UserId).ToList();
		if (Settings.Default.DisplayJoinedServersInGameInstances && User != null)
		{
			friendIds.Add(User.Id);
		}
		ICollection<IUser> friends = _UserFactory.GetUsers(friendIds);
		IEnumerable<IPresence> prioritizedPresenceReports = _PresenceReader.MultiGetPrioritizedPresence((IReadOnlyCollection<IUser>)(object)friends.ToArray());
		IList<IPresence> friendPresences = _PresenceResponseFilter.FilterInGamePresences(prioritizedPresenceReports, presenceResources).ToList();
		friendsInGame = friendPresences.Where((IPresence el) => el.PlaceId == placeId).ToList();
		Guid[] gameInstanceIds = (from presence in friendPresences
			where presence.PlaceId.HasValue && presence.PlaceId == placeId && presence.GameId.HasValue
			select presence.GameId.Value).ToArray();
		if (gameInstanceIds.Length != 0)
		{
			return _GameInstanceFactory.GetGameInstancesByIds(placeId, gameInstanceIds);
		}
		return Enumerable.Empty<IGameInstance>().ToList();
	}
}
