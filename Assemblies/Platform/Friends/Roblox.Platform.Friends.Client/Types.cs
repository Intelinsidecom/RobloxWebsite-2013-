// Temporary minimal implementations to unblock build; replace with real Roblox.Friends.Client library when available.
using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;

namespace Roblox.Friends.Client
{
    public class Following : IFollowing
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long FollowerUserId { get; set; }
        public DateTime FollowerSince { get; set; }
        public DateTime Created => FollowerSince;
    }

    public class FollowingDetails : IFollowingDetails
    {
        public long UserId1 { get; }
        public long UserId2 { get; }
        public bool User1FollowsUser2 { get; }
        public bool User2FollowsUser1 { get; }

        public FollowingDetails(long userId1, long userId2, bool user1FollowsUser2, bool user2FollowsUser1)
        {
            UserId1 = userId1;
            UserId2 = userId2;
            User1FollowsUser2 = user1FollowsUser2;
            User2FollowsUser1 = user2FollowsUser1;
        }
    }

    public class Friend : IFriend
    {
        public long UserId { get; set; }
        public DateTime FriendsSince { get; set; }
    }

    public class FriendRequest : IFriendRequest
    {
        public long Id { get; set; }
        public long SenderId { get; set; }
        public long RecipientId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsAccepted { get; set; }
    }

    public class FriendRequestExists
    {
        public long UserId2 { get; set; }
        public bool User2SentRequestToUser1 { get; set; }
        public bool User1SentRequestToUser2 { get; set; }
    }

    public enum FriendshipOriginSourceType
    {
        Unknown = 0,
        // The Social code compares to (FriendshipOriginSourceType)3
        // Keep value 3 present to satisfy equality checks.
        Handshake = 3
    }

    public class GetFollowersEnumerativeRequest
    {
        public long UserId { get; set; }
        public ExclusiveStartInfo<long?> ExclusiveStartInfo { get; set; }
    }

    public class GetFollowersEnumerativeResponse
    {
        public IReadOnlyCollection<Following> Followings { get; set; }
    }

    public class GetFollowingsEnumerativeRequest
    {
        public long FollowerUserId { get; set; }
        public ExclusiveStartInfo<long?> ExclusiveStartInfo { get; set; }
    }

    public class GetFollowingsEnumerativeResponse
    {
        public IReadOnlyCollection<Following> Followings { get; set; }
    }

    public class FriendRequestExclusiveStartKey
    {
        public long? Id { get; set; }
    }

    public class GetFriendRequestsEnumerativeRequest
    {
        public long UserId { get; set; }
        public ExclusiveStartInfo<FriendRequestExclusiveStartKey> ExclusiveStartInfo { get; set; }
    }

    public class MultigetPendingFriendRequestResponse
    {
        public IReadOnlyCollection<long> PendingUserIds { get; set; }
    }

    public class FriendRequestOriginSourceResponse
    {
        public FriendshipOriginSourceType FriendshipOriginSourceType { get; set; }
    }

    public class FriendsErrorMetadata
    {
        public string ErrorMessage { get; set; }
        // Social casts this to FriendshipOperationErrorType; keep it as int for compatibility
        public int ErrorType { get; set; }
    }

    public class FriendsClientException : Exception
    {
        public FriendsErrorMetadata ErrorMetaData { get; }
        public FriendsClientException(string message, FriendsErrorMetadata errorMetaData = null, Exception inner = null)
            : base(message, inner)
        {
            ErrorMetaData = errorMetaData;
        }
    }
}
