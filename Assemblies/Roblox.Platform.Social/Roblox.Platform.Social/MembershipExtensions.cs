using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Presence;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social;

public static class MembershipExtensions
{
	public static IEnumerable<IUser> GetFriends(this IUserIdentifier user, int offset, int count, IFriendshipFactory friendshipFactory, IUserFactory userFactory)
	{
		user.VerifyIsNotNull();
		IReadOnlyCollection<IFriend> apiClientFriends = friendshipFactory.GetFriends(user.Id, offset, count);
		if (!Settings.Default.IsUserFactoryMultiGetEnabled)
		{
			return apiClientFriends.Select((IFriend friend) => GetUser(friend, userFactory));
		}
		return MultiGetUsers(apiClientFriends, userFactory);
	}

	public static IEnumerable<IPresence> GetFriendsOnline(this IUser user, IPresenceReader presenceReader, IFriendshipFactory friendshipFactory, IUserFactory userFactory)
	{
		user.VerifyIsNotNull();
		IEnumerable<IFriend> friends = from u in friendshipFactory.GetAllFriends(user)
			where u != null
			select u;
		IReadOnlyCollection<IUser> readOnlyCollection2;
		if (!Settings.Default.IsUserFactoryMultiGetEnabled)
		{
			IReadOnlyCollection<IUser> readOnlyCollection = friends.Select((IFriend u) => userFactory.GetUser(u.UserId)).ToList();
			readOnlyCollection2 = readOnlyCollection;
		}
		else
		{
			readOnlyCollection2 = MultiGetUsers(friends, userFactory);
		}
		IReadOnlyCollection<IUser> friendUsers = readOnlyCollection2;
		return from presence in presenceReader.MultiGetPresence(friendUsers)
			where presence?.IsOnline ?? false
			select presence;
	}

	private static IUser GetUser(IFriend friend, IUserFactory userFactory)
	{
		return userFactory.GetUser(friend.UserId);
	}

	private static IReadOnlyCollection<IUser> MultiGetUsers(IEnumerable<IFriend> friends, IUserFactory userFactory)
	{
		long[] userIds = friends.Select((IFriend f) => f.UserId).ToArray();
		IReadOnlyDictionary<long, IUser> users = userFactory.MultiGetUsers(userIds);
		return userIds.Select((long uid) => users[uid]).ToList();
	}
}
