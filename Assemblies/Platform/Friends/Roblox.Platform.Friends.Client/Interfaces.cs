// Temporary minimal implementations to unblock build; replace with real Roblox.Friends.Client library when available.
using System;
using System.Collections.Generic;

namespace Roblox.Friends.Client
{
    public interface IFriendsClient
    {
        // Following APIs
        long GetFollowersCount(long userId);
        long GetFollowingsCount(long userId);
        bool FollowingExists(long userId, long followerUserId);
        IReadOnlyCollection<FollowingDetails> MultigetFollowingDetails(long userId, IReadOnlyCollection<long> otherUserIds);
        Following GetFollowing(long userId, long followerUserId);
        IReadOnlyCollection<Following> GetFollowers(long userId, int startRowIndex, int maximumRows);
        IReadOnlyCollection<Following> GetFollowings(long userId, int startRowIndex, int maximumRows);
        GetFollowersEnumerativeResponse GetFollowersEnumerative(GetFollowersEnumerativeRequest request);
        GetFollowingsEnumerativeResponse GetFollowingsEnumerative(GetFollowingsEnumerativeRequest request);
        void CreateFollowing(long userId, long followerUserId);
        void DeleteFollowing(long userId, long followerUserId);

        // Friendship APIs
        bool FriendRequestExists(long userId, long friendId);
        IEnumerable<Friend> GetAllFriends(long userId);
        IEnumerable<FriendRequestExists> MultigetFriendRequestExists(long userId, IReadOnlyCollection<long> otherUserIds);
        Friend GetFriend(long userId, long friendId);
        IReadOnlyCollection<FriendRequest> GetFriendRequests(long userId, int startRowIndex, int maximumRows);
        IEnumerable<FriendRequest> GetFriendRequestsEnumerative(GetFriendRequestsEnumerativeRequest request);
        int GetFriendRequestsCount(long userId);
        FriendRequest GetFriendRequest(long? friendRequestId, long? senderUserId, long? accepterUserId);
        FriendRequestOriginSourceResponse GetFriendRequestOriginSource(long friendRequestId);
        void SendFriendRequest(long senderUserId, long recipientUserId, string message, FriendshipOriginSourceType friendshipOriginSourceType);
        void AcceptFriendRequest(long accepterUserId, long friendRequestId, long? senderUserId, FriendshipOriginSourceType friendshipOriginSourceType);
        void DeclineFriendRequest(long declinerUserId, long friendRequestId, long? senderUserId);
        MultigetPendingFriendRequestResponse MultigetPendingFriendRequests(long userId, IReadOnlyCollection<long> otherUserIds);
        void RemoveFriend(long userId, long friendId);
        void CreateFriendship(long userId, long friendId, FriendshipOriginSourceType sourceType);
    }

    public interface IFollowing
    {
        long Id { get; set; }
        long UserId { get; set; }
        long FollowerUserId { get; set; }
        DateTime FollowerSince { get; set; }
    }

    public interface IFollowingDetails
    {
        long UserId1 { get; }
        long UserId2 { get; }
        bool User1FollowsUser2 { get; }
        bool User2FollowsUser1 { get; }
    }

    public interface IFriend
    {
        long UserId { get; set; }
        DateTime FriendsSince { get; set; }
    }

    public interface IFriendRequest
    {
        long Id { get; set; }
        long SenderId { get; set; }
        long RecipientId { get; set; }
        string Subject { get; set; }
        string Body { get; set; }
        DateTime SentAt { get; set; }
        bool IsAccepted { get; set; }
    }
}
