using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.Caching.Shared;
using Roblox.Friends.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social;

public interface IFriendshipFactory
{
	event FriendRequestAccepted OnFriendRequestAccepted;

	event FollowRequestSent OnFollowRequestSent;

	event FriendRequestAccept OnFriendRequestAccept;

	event FriendRequestIgnore OnFriendRequestIgnore;

	event FriendRequestUnfriend OnFriendRequestUnfriend;

	long GetFollowersCount(long userId);

	long GetFollowingsCount(long userId);

	bool HasFollower(long userId, long followerUserId);

	IFollowing GetFollowing(long userId, long followerUserId);

	[Obsolete("Use GetFollowersEnumerative")]
	IReadOnlyCollection<IFollowing> GetFollowers(long userId, int startRowIndex, int maximumRows);

	[Obsolete("Use GetFollowingsEnumerative")]
	IReadOnlyCollection<IFollowing> GetFollowings(long userId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets followers of a user.
	/// </summary>
	IReadOnlyCollection<IFollowing> GetFollowersEnumerative(long userId, ExclusiveStartInfo<long?> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets a user's followings.
	/// </summary>
	IReadOnlyCollection<IFollowing> GetFollowingsEnumerative(long userId, ExclusiveStartInfo<long?> exclusiveStartKeyInfo);

	/// <summary>
	/// Creates a following on <paramref name="user" /> from <paramref name="follower" />
	/// </summary>
	/// <param name="user">The user to follow.</param>
	/// <param name="follower">The follower.</param>
	/// <param name="isFollowerInGame">Is user to be followed currently in a game</param>
	/// <param name="isUserInSameGameAsFollower">Is the user to be followed in the same game as the follower.</param>
	/// <param name="isFollowerInApp">Is the follower in an app</param>
	/// <param name="hasFollowerFilledACaptcha">Has the follower filled a captcha</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="user" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="follower" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Social.FriendshipOperationException">Friendship client failure</exception>
	/// <exception cref="T:Roblox.Platform.Social.FriendshipOperationUnavailableException">Friendship service unavailable</exception>
	void CreateFollowing(IUser user, IUser follower, bool isFollowerInGame, bool isUserInSameGameAsFollower, bool isFollowerInApp, bool hasFollowerFilledACaptcha);

	/// <summary>
	/// Deletes the following of <paramref name="follower" /> from <paramref name="user" />
	/// </summary>
	/// <param name="user">The user currently being followed.</param>
	/// <param name="follower">The follower.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="user" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="follower" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Social.FriendshipOperationException">Friendship client failure</exception>
	/// <exception cref="T:Roblox.Platform.Social.FriendshipOperationUnavailableException">Friendship service unavailable</exception>
	void DeleteFollowing(IUser user, IUser follower);

	IReadOnlyCollection<IFollowingDetails> MultigetFollowingDetails(long userId, IReadOnlyCollection<long> otherUserIds);

	IReadOnlyCollection<IFriendRequest> GetFriendRequests(long userId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets pending friend requests for a user.
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="exclusiveStartKeyInfo"></param>
	/// <returns></returns>
	IReadOnlyCollection<IFriendRequest> GetFriendRequestsEnumerative(long userId, ExclusiveStartInfo<FriendRequestExclusiveStartKey> exclusiveStartKeyInfo);

	int GetFriendRequestsCount(long userId);

	IFriendRequest GetFriendRequest(long? friendRequestId, long? senderUserId = null, long? accepterUserId = null);

	bool AttemptFriendshipHandshake(long senderUserId, long recipientId, bool isInGame, bool isInApp, FriendshipOriginSourceType senderFriendshipOriginSourceType);

	void AcceptFriendRequest(long accepterUserId, long friendRequestId, long senderUserId, bool isInGame, bool isInApp, FriendshipOriginSourceType friendshipOriginSourceType = 0);

	void DeclineFriendRequest(long declinerUserId, long friendRequestId, bool isInGame, bool isInApp, long? senderUserId = null);

	MultigetPendingFriendRequestResponse MultigetPendingFriendRequests(long userId, IReadOnlyCollection<long> otherUserIds);

	bool HasRequest(long userId, long friendId);

	FriendshipStatus GetFriendshipStatus(long userId, long friendId);

	IReadOnlyCollection<IUsersFriendshipStatus> MultigetFriendshipStatus(long userId, IReadOnlyCollection<long> otherUserIds);

	IReadOnlyCollection<IFriend> GetFriends(long userId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Get all friends
	/// </summary>
	/// <param name="user">The user whose friends will be fetched</param>
	/// <returns></returns>
	IReadOnlyCollection<IFriend> GetAllFriends(IUser user);

	int GetFriendsCount(long userId);

	IFriend GetFriendship(long userId, long friendId);

	void RemoveFriend(long userId, long friendId, bool isInGame, bool isInApp);

	void CreateFriendship(long userId, long friendId);

	bool AreFriends(long userId, long friendId);

	IReadOnlyCollection<IUser> GetUsersOfInterestPaged(IUser user, int startRowIndex, int maximumRows, ISharedCacheClient cacheClient, Func<IUser, bool> onlineStatusGetter);
}
