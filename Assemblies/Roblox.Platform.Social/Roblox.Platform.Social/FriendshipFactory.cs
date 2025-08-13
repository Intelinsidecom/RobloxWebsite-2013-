using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.Caching.Shared;
using Roblox.Friends.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Properties;
using Roblox.Platform.UserBlock.Core;
using Roblox.Sentinels;

namespace Roblox.Platform.Social;

/// <summary>
/// All friendship Apis should go through this class
/// </summary>
public class FriendshipFactory : FriendshipProducerBase, IFriendshipFactory
{
	private readonly IUserFactory _UserFactory;

	private static int DesiredResultsUserIdsOfInterest => Settings.Default.UserIdsOfInterestCount;

	private static double InteractionBiasTopFriendship => Settings.Default.TopFriendshipInteractionBias;

	private static double InteractionBiasMessagesSentUltimate => Settings.Default.MessagesSentUltimateInteractionBias;

	private static double InteractionBiasMessagesSentPenultimate => Settings.Default.MessagesSentPenultimateInteractionBias;

	private static double InteractionBiasMessagesSentAntepenultimate => Settings.Default.MessagesSentAntepenultimate;

	private static int MaxPageSizeAllowedForFriendshipOperations => Settings.Default.MaxPageSizeAllowedForFriendshipOperations;

	public event FriendRequestAccepted OnFriendRequestAccepted;

	public event FollowRequestSent OnFollowRequestSent;

	public event FriendRequestAccept OnFriendRequestAccept;

	public event FriendRequestIgnore OnFriendRequestIgnore;

	public event FriendRequestUnfriend OnFriendRequestUnfriend;

	public FriendshipFactory(IFriendsClient client, IUserBlockAuthority userBlockAuthority, IUserFactory userFactory)
		: base(client, userBlockAuthority)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public long GetFollowersCount(long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFollowersCount. UserId:{userId}");
		}
		try
		{
			return base.Client.GetFollowersCount(userId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public long GetFollowingsCount(long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFollowingsCount. UserId:{userId}");
		}
		try
		{
			return base.Client.GetFollowingsCount(userId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public bool HasFollower(long userId, long followerUserId)
	{
		if (userId <= 0 || followerUserId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to HasFollower. UserId:{userId},FollowerUserId:{followerUserId}");
		}
		try
		{
			return base.Client.FollowingExists(userId, followerUserId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFollowingDetails> MultigetFollowingDetails(long userId, IReadOnlyCollection<long> otherUserIds)
	{
		if (otherUserIds.Count > Settings.Default.MaxMultigetFollowingExistsCount)
		{
			throw new PlatformArgumentException("You cannot request more than " + Settings.Default.MaxMultigetFollowingExistsCount + " following exists at once.");
		}
		if (userId <= 0 || otherUserIds.Any((long id) => id <= 0))
		{
			throw new PlatformArgumentException("Invalid parameters passed to MultigetFollowingDetails. All UserIds must be positive.");
		}
		try
		{
			return Translate(base.Client.MultigetFollowingDetails(userId, otherUserIds));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IFollowing GetFollowing(long userId, long followerUserId)
	{
		if (userId <= 0 || followerUserId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFollowing. UserId:{userId},FollowerUserId:{followerUserId}");
		}
		try
		{
			return Translate(base.Client.GetFollowing(userId, followerUserId));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	[Obsolete("Use GetFollowersEnumerative")]
	public IReadOnlyCollection<IFollowing> GetFollowers(long userId, int startRowIndex, int maximumRows)
	{
		if (userId <= 0 || startRowIndex < 0 || maximumRows < 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFollowers. UserId:{userId},StartRowIndex:{startRowIndex},MaximumRows:{maximumRows}");
		}
		maximumRows = ((maximumRows > MaxPageSizeAllowedForFriendshipOperations) ? MaxPageSizeAllowedForFriendshipOperations : maximumRows);
		try
		{
			return Translate(base.Client.GetFollowers(userId, startRowIndex, maximumRows));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	[Obsolete("Use GetFollowingsEnumerative")]
	public IReadOnlyCollection<IFollowing> GetFollowings(long userId, int startRowIndex, int maximumRows)
	{
		if (userId <= 0 || startRowIndex < 0 || maximumRows < 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFollowings. UserId:{userId},StartRowIndex:{startRowIndex},MaximumRows:{maximumRows}");
		}
		maximumRows = ((maximumRows > MaxPageSizeAllowedForFriendshipOperations) ? MaxPageSizeAllowedForFriendshipOperations : maximumRows);
		try
		{
			return Translate(base.Client.GetFollowings(userId, startRowIndex, maximumRows));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFollowing> GetFollowersEnumerative(long userId, ExclusiveStartInfo<long?> exclusiveStartKeyInfo)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid userId: {userId}");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		try
		{
			GetFollowersEnumerativeRequest request = new GetFollowersEnumerativeRequest
			{
				UserId = userId,
				ExclusiveStartInfo = exclusiveStartKeyInfo
			};
			return (IReadOnlyCollection<IFollowing>)(object)base.Client.GetFollowersEnumerative(request).Followings.Select(Translate).ToArray();
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFollowing> GetFollowingsEnumerative(long userId, ExclusiveStartInfo<long?> exclusiveStartKeyInfo)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid userId: {userId}");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		try
		{
			GetFollowingsEnumerativeRequest request = new GetFollowingsEnumerativeRequest
			{
				FollowerUserId = userId,
				ExclusiveStartInfo = exclusiveStartKeyInfo
			};
			return (IReadOnlyCollection<IFollowing>)(object)base.Client.GetFollowingsEnumerative(request).Followings.Select(Translate).ToArray();
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Social.IFriendshipFactory.CreateFollowing(Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser,System.Boolean,System.Boolean,System.Boolean,System.Boolean)" />
	public void CreateFollowing(IUser user, IUser follower, bool isFollowerInGame = false, bool isUserInSameGameAsFollower = false, bool isFollowerInApp = false, bool hasFollowerFilledACaptcha = false)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (follower == null)
		{
			throw new PlatformArgumentNullException("follower");
		}
		if (BlockExistsBetweenUsers(user, follower))
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.BlockedUser, "Block exists between the two users.");
		}
		if (user.IsPermanentlyBanned())
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.BannedUser, "User is banned");
		}
		if (isFollowerInGame)
		{
			if (!isUserInSameGameAsFollower)
			{
				FriendshipOperationException ex = new FriendshipOperationException(FriendshipOperationErrorType.UsersAreNotInSameGame, "Users are not in the same game");
				ExceptionHandler.LogException(ex);
				throw ex;
			}
		}
		else if (!isFollowerInApp && !hasFollowerFilledACaptcha)
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.UserHasNotPassedCaptcha, "Follower has not passed Captcha");
		}
		try
		{
			base.Client.CreateFollowing(user.Id, follower.Id);
			this.OnFollowRequestSent?.Invoke(follower.Id, user.Id, isUserInSameGameAsFollower, isFollowerInApp);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Social.IFriendshipFactory.DeleteFollowing(Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser)" />
	public void DeleteFollowing(IUser user, IUser follower)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (follower == null)
		{
			throw new PlatformArgumentNullException("follower");
		}
		try
		{
			base.Client.DeleteFollowing(user.Id, follower.Id);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <summary>
	/// Determines whether or not there is a pending friend request sent from a user to its friend.
	/// </summary>
	/// <param name="userId">The user ID of the first user.</param>
	/// <param name="friendId">The user ID of the friend.</param>
	/// <returns>Whether or not there is a pending friend request.</returns>
	public bool HasRequest(long userId, long friendId)
	{
		if (userId <= 0 || friendId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to HasRequest. UserId:{userId},FriendId:{friendId}");
		}
		try
		{
			return base.Client.FriendRequestExists(userId, friendId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <summary>
	/// Gets the FriendshipStatus of the users.
	/// </summary>
	/// <remarks>The parameters are not commutitative.</remarks>
	/// <param name="userId">The user ID of the first user.</param>
	/// <param name="friendId">The user ID of the second user.</param>
	/// <returns>The FriendshipStatus that describes the relationship between the two users.</returns>
	public FriendshipStatus GetFriendshipStatus(long userId, long friendId)
	{
		if (userId <= 0 || friendId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriendshipStatus. UserId:{userId},FriendId:{friendId}");
		}
		if (HasRequest(userId, friendId))
		{
			return FriendshipStatus.PendingOnOtherUser;
		}
		if (HasRequest(friendId, userId))
		{
			return FriendshipStatus.PendingOnCurrentUser;
		}
		if (AreFriends(userId, friendId))
		{
			return FriendshipStatus.Friends;
		}
		return FriendshipStatus.NoFriendship;
	}

	/// <summary>
	/// Gets the FriendshipStatus of the specified user for each of the other users.
	/// </summary>
	/// <remarks>The parameters are not commutitative.</remarks>
	/// <param name="userId">The user ID of the first user.</param>
	/// <param name="otherUserIds">The collection of other users to get the FriendshipStatuses of.</param>
	/// <returns>The FriendshipStatus that describes the relationship between the two users.</returns>
	public IReadOnlyCollection<IUsersFriendshipStatus> MultigetFriendshipStatus(long userId, IReadOnlyCollection<long> otherUserIds)
	{
		if (userId <= 0 || otherUserIds.Any((long ui) => ui <= 0))
		{
			throw new PlatformArgumentException(string.Format("Invalid parameters passed to MultigetFriendshipStatus. UserId: {0}, OtherUserIds: {1}", userId, string.Join(",", otherUserIds)));
		}
		if (otherUserIds.Count > Settings.Default.MaxMultigetFriendshipExistsCount)
		{
			throw new PlatformArgumentException($"Too many userIds provided to MultigetFriendshipStatus. Count: {otherUserIds.Count}");
		}
		try
		{
			List<IUsersFriendshipStatus> results = new List<IUsersFriendshipStatus>(otherUserIds.Count);
			HashSet<long> friendsLookup = new HashSet<long>(from f in base.Client.GetAllFriends(userId)
				select f.UserId);
			long[] remainingUserIds = otherUserIds.Where((long u) => !friendsLookup.Contains(u)).ToArray();
			Dictionary<long, FriendRequestExists> friendRequestLookups = new Dictionary<long, FriendRequestExists>();
			if (remainingUserIds.Any())
			{
				friendRequestLookups = base.Client.MultigetFriendRequestExists(userId, (IReadOnlyCollection<long>)(object)remainingUserIds).ToDictionary((FriendRequestExists x) => x.UserId2);
			}
			foreach (long otherUserId in otherUserIds)
			{
				FriendshipStatus status = FriendshipStatus.NoFriendship;
				if (friendsLookup.Contains(otherUserId))
				{
					status = FriendshipStatus.Friends;
				}
				else if (friendRequestLookups.ContainsKey(otherUserId))
				{
					FriendRequestExists friendRequestStatus = friendRequestLookups[otherUserId];
					if (friendRequestStatus.User2SentRequestToUser1)
					{
						status = FriendshipStatus.PendingOnCurrentUser;
					}
					else if (friendRequestStatus.User1SentRequestToUser2)
					{
						status = FriendshipStatus.PendingOnOtherUser;
					}
				}
				results.Add(new UsersFriendshipStatus(userId, otherUserId, status));
			}
			return results;
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFriend> GetFriends(long userId, int startRowIndex, int maximumRows)
	{
		if (userId <= 0 || startRowIndex < 0 || maximumRows < 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriends. UserId:{userId},StartRowIndex:{startRowIndex},MaximumRows:{maximumRows}");
		}
		maximumRows = ((maximumRows > MaxPageSizeAllowedForFriendshipOperations) ? MaxPageSizeAllowedForFriendshipOperations : maximumRows);
		try
		{
			return Translate(base.Client.GetAllFriends(userId).Skip(startRowIndex).Take(maximumRows));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFriend> GetAllFriends(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentException("User cannot be null in call to getall friends");
		}
		try
		{
			return Translate(base.Client.GetAllFriends(user.Id));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IFriend GetFriendship(long userId, long friendId)
	{
		if (userId <= 0 || friendId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriendship. UserId:{userId},FriendId:{friendId}");
		}
		try
		{
			return Translate(base.Client.GetFriend(userId, friendId));
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public int GetFriendsCount(long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriendsCount. UserId:{userId}");
		}
		try
		{
			return base.Client.GetAllFriends(userId).Count();
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFriendRequest> GetFriendRequests(long userId, int startRowIndex, int maximumRows)
	{
		if (userId <= 0 || startRowIndex < 0 || maximumRows < 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriendRequests. UserId:{userId},StartRowIndex:{startRowIndex},MaximumRows:{maximumRows}");
		}
		maximumRows = ((maximumRows > MaxPageSizeAllowedForFriendshipOperations) ? MaxPageSizeAllowedForFriendshipOperations : maximumRows);
		try
		{
			return Translate(base.Client.GetFriendRequests(userId, startRowIndex, maximumRows));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IReadOnlyCollection<IFriendRequest> GetFriendRequestsEnumerative(long userId, ExclusiveStartInfo<FriendRequestExclusiveStartKey> exclusiveStartKeyInfo)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid userId: {userId}");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		try
		{
			GetFriendRequestsEnumerativeRequest request = new GetFriendRequestsEnumerativeRequest
			{
				UserId = userId,
				ExclusiveStartInfo = exclusiveStartKeyInfo
			};
			return (IReadOnlyCollection<IFriendRequest>)(object)base.Client.GetFriendRequestsEnumerative(request)?.Select(Translate).ToArray();
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public int GetFriendRequestsCount(long userId)
	{
		if (userId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to GetFriendRequestsCount. UserId:{userId}");
		}
		try
		{
			return base.Client.GetFriendRequestsCount(userId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public IFriendRequest GetFriendRequest(long? friendRequestId, long? senderUserId = null, long? accepterUserId = null)
	{
		if (((accepterUserId ?? 0) <= 0 || (senderUserId ?? 0) <= 0) && (friendRequestId ?? 0) <= 0)
		{
			throw new PlatformArgumentException(string.Format("Invalid parameters passed to {0}. {1}:{2},{3}:{4},{5}:{6}", "GetFriendRequest", "friendRequestId", friendRequestId, "senderUserId", senderUserId, "accepterUserId", accepterUserId));
		}
		try
		{
			return Translate(base.Client.GetFriendRequest(friendRequestId, senderUserId, accepterUserId));
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public bool AttemptFriendshipHandshake(long senderUserId, long recipientId, bool isInGame, bool isInApp, FriendshipOriginSourceType senderFriendshipOriginSourceType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FriendshipOriginSourceType val = (FriendshipOriginSourceType)3;
			if (!((object)(FriendshipOriginSourceType)(ref val)).Equals((object)senderFriendshipOriginSourceType))
			{
				return false;
			}
			if (!base.Client.FriendRequestExists(recipientId, senderUserId))
			{
				return false;
			}
			FriendRequest friendRequest = base.Client.GetFriendRequest((long?)null, (long?)recipientId, (long?)senderUserId);
			FriendRequestOriginSourceResponse friendRequestSource = base.Client.GetFriendRequestOriginSource(friendRequest.Id);
			if (!((object)(FriendshipOriginSourceType)(ref senderFriendshipOriginSourceType)).Equals((object)friendRequestSource.FriendshipOriginSourceType))
			{
				return false;
			}
			AcceptFriendRequest(senderUserId, friendRequest.Id, recipientId, isInGame, isInApp, senderFriendshipOriginSourceType);
			return true;
		}
		catch (FriendsClientException val2)
		{
			throw new FriendshipOperationException(val2.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public void AcceptFriendRequest(long accepterUserId, long friendRequestId, long senderUserId, bool isInGame, bool isInApp, FriendshipOriginSourceType friendshipOriginSourceType = 0)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if ((accepterUserId <= 0 || senderUserId <= 0) && friendRequestId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to AcceptFriendRequest. AccepterUserId:{accepterUserId},FriendRequestId:{friendRequestId},SenderUserId:{senderUserId}");
		}
		IUser accepterUser = _UserFactory.GetUser(accepterUserId);
		IUser senderUser = _UserFactory.GetUser(senderUserId);
		if (accepterUser == null || senderUser == null)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to AcceptFriendRequest. AccepterUserId:{accepterUserId},SenderUserId:{senderUserId}");
		}
		if (BlockExistsBetweenUsers(accepterUser, senderUser))
		{
			DeclineFriendRequest(accepterUserId, friendRequestId, isInGame, isInApp, senderUserId);
			throw new FriendshipOperationException(FriendshipOperationErrorType.BlockedUser, "Block exists between the two users.");
		}
		try
		{
			base.Client.AcceptFriendRequest(accepterUserId, friendRequestId, (long?)senderUserId, friendshipOriginSourceType);
			this.OnFriendRequestAccepted?.Invoke(friendRequestId, accepterUserId, senderUserId);
			if (Settings.Default.FriendshipSendEventEnabled)
			{
				this.OnFriendRequestAccept?.Invoke(senderUserId, accepterUserId, isInGame, isInApp);
			}
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public void DeclineFriendRequest(long declinerUserId, long friendRequestId, bool isInGame, bool isInApp, long? senderUserId = null)
	{
		if ((declinerUserId <= 0 || (senderUserId ?? 0) <= 0) && friendRequestId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to DeclineFriendRequest. DeclinerUserId:{declinerUserId},FriendRequestId:{friendRequestId}");
		}
		try
		{
			base.Client.DeclineFriendRequest(declinerUserId, friendRequestId, senderUserId);
			if (Settings.Default.FriendshipSendEventEnabled)
			{
				this.OnFriendRequestIgnore?.Invoke(senderUserId.GetValueOrDefault(), declinerUserId, isInGame, isInApp);
			}
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public MultigetPendingFriendRequestResponse MultigetPendingFriendRequests(long userId, IReadOnlyCollection<long> otherUserIds)
	{
		if (userId <= 0 || otherUserIds.Any((long ui) => ui <= 0))
		{
			throw new PlatformArgumentException(string.Format("Invalid parameters passed to MultigetPendingFriendRequests. UserId: {0}, OtherUserIds: {1}", userId, string.Join(",", otherUserIds)));
		}
		if (otherUserIds.Count > Settings.Default.MaxMultigetFriendRequestsCount)
		{
			throw new PlatformArgumentException($"Too many userIds provided to MultigetPendingFriendRequests. Count: {otherUserIds.Count}");
		}
		try
		{
			return base.Client.MultigetPendingFriendRequests(userId, otherUserIds);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public void RemoveFriend(long userId, long friendId, bool isInGame, bool isInApp)
	{
		if (userId <= 0 || friendId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to RemoveFriend. UserId:{userId},FriendId:{friendId}");
		}
		try
		{
			base.Client.RemoveFriend(userId, friendId);
			if (Settings.Default.FriendshipSendEventEnabled)
			{
				this.OnFriendRequestUnfriend?.Invoke(userId, friendId, isInGame, isInApp);
			}
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	public void CreateFriendship(long userId, long friendId)
	{
		if (userId <= 0 || friendId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to CreateFriendship. UserId:{userId},FriendId:{friendId}");
		}
		IUser user = _UserFactory.GetUser(userId);
		IUser friendUser = _UserFactory.GetUser(friendId);
		if (user == null || friendUser == null)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to CreateFriendship. UserId:{userId},FriendId:{friendId}");
		}
		if (BlockExistsBetweenUsers(user, friendUser))
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.BlockedUser, "Block exists between the two users.");
		}
		try
		{
			base.Client.CreateFriendship(userId, friendId, (FriendshipOriginSourceType)0);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <summary>
	/// Determines whether or not the users with the given user IDs are friends.
	/// </summary>
	/// <param name="userId">The user ID of the first user.</param>
	/// <param name="friendId">The user ID of the second user.</param>
	/// <returns>Whether or not the users with the given user IDs are friends.</returns>
	public bool AreFriends(long userId, long friendId)
	{
		if (userId <= 0)
		{
			return false;
		}
		if (friendId <= 0)
		{
			return false;
		}
		if (userId == friendId)
		{
			return true;
		}
		try
		{
			return base.Client.GetAllFriends(userId).Any((Friend f) => f.UserId == friendId);
		}
		catch (FriendsClientException val)
		{
			throw new FriendshipOperationException(val.ErrorMetaData);
		}
		catch (ApiClientException e)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", e);
		}
		catch (CircuitBreakerException cbe)
		{
			throw new FriendshipOperationUnavailableException("Friends Service Unavailable", cbe);
		}
	}

	/// <summary>
	/// Moved from SCL.
	/// </summary>
	/// <param name="user"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <param name="cacheClient"></param>
	/// <param name="onlineStatusGetter"></param>
	/// <returns></returns>
	public IReadOnlyCollection<IUser> GetUsersOfInterestPaged(IUser user, int startRowIndex, int maximumRows, ISharedCacheClient cacheClient, Func<IUser, bool> onlineStatusGetter)
	{
		maximumRows = ((maximumRows > MaxPageSizeAllowedForFriendshipOperations) ? MaxPageSizeAllowedForFriendshipOperations : maximumRows);
		string key = "Roblox.UserIdsOfInterest_UserID:" + user.Id;
		if (!cacheClient.Query(key, out List<long> userIdsOfInterest))
		{
			userIdsOfInterest = BuildUserIdsOfInterest(user);
			cacheClient.Set(key, userIdsOfInterest, Settings.Default.UserIdsOfInterestCacheTimeSpan);
		}
		List<IUser> usersOfInterest = (from userId in userIdsOfInterest
			select _UserFactory.GetUser(userId) into userOfInterest
			where userOfInterest != null
			select userOfInterest).ToList();
		usersOfInterest = usersOfInterest.OrderByDescending(onlineStatusGetter).ToList();
		if (usersOfInterest.Count >= startRowIndex + maximumRows)
		{
			return usersOfInterest.GetRange(startRowIndex, maximumRows);
		}
		if (usersOfInterest.Count < startRowIndex + 1)
		{
			return new List<IUser>();
		}
		return usersOfInterest.GetRange(startRowIndex, usersOfInterest.Count - startRowIndex);
	}

	/// <summary>
	/// Moved from SCL.
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	private List<long> BuildUserIdsOfInterest(IUser user)
	{
		IDictionary<long, int> source = BuildTopFriendsInteractionDimension(user);
		IDictionary<long, int> messagesSentDimension = BuildMessagesSentInteractionDimension(user);
		Dictionary<long, int> superSet = source.ToDictionary((KeyValuePair<long, int> entry) => entry.Key, (KeyValuePair<long, int> entry) => entry.Value);
		foreach (KeyValuePair<long, int> entry2 in messagesSentDimension)
		{
			if (superSet.TryGetValue(entry2.Key, out var value))
			{
				superSet[entry2.Key] = Math.Min(value + entry2.Value, int.MaxValue);
			}
			else
			{
				superSet.Add(entry2.Key, entry2.Value);
			}
		}
		List<long> userIdsOfInterest = (from x in superSet
			orderby x.Value descending
			select x into keyValuePair
			select keyValuePair.Key).ToList();
		if (userIdsOfInterest.Count > DesiredResultsUserIdsOfInterest)
		{
			return userIdsOfInterest.GetRange(0, DesiredResultsUserIdsOfInterest);
		}
		return userIdsOfInterest;
	}

	/// <summary>
	/// Moved from SCL.
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	private IDictionary<long, int> BuildTopFriendsInteractionDimension(IUser user)
	{
		Dictionary<long, int> dimension = new Dictionary<long, int>();
		foreach (Friend topFriendship in base.Client.GetAllFriends(user.Id).Take(DesiredResultsUserIdsOfInterest))
		{
			dimension[topFriendship.UserId] = (int)InteractionBiasTopFriendship;
		}
		return dimension;
	}

	/// <summary>
	/// Moved from SCL.
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	private IDictionary<long, int> BuildMessagesSentInteractionDimension(IUser user)
	{
		Dictionary<long, int> dimension = new Dictionary<long, int>();
		byte messagesSentIdUltimate = InteractionCounterType.GetUltimateID_MessageSent();
		foreach (InteractionCounter interactionCounter3 in InteractionCounter.GetUserInteractionCountersByTypePaged(user.Id, messagesSentIdUltimate, 0, DesiredResultsUserIdsOfInterest))
		{
			int score = (int)Math.Min((double)interactionCounter3.Value * InteractionBiasMessagesSentUltimate, 2147483647.0);
			dimension.Add(interactionCounter3.OtherUserID, score);
		}
		byte messagesSentIdPenultimate = InteractionCounterType.GetPenultimateID_MessageSent();
		int value;
		foreach (InteractionCounter interactionCounter2 in InteractionCounter.GetUserInteractionCountersByTypePaged(user.Id, messagesSentIdPenultimate, 0, DesiredResultsUserIdsOfInterest))
		{
			int score = (int)Math.Min((double)interactionCounter2.Value * InteractionBiasMessagesSentPenultimate, 2147483647.0);
			if (dimension.TryGetValue(interactionCounter2.OtherUserID, out value))
			{
				dimension[interactionCounter2.OtherUserID] = value + score;
			}
			else
			{
				dimension.Add(interactionCounter2.OtherUserID, score);
			}
		}
		byte messagesSentIdAntepenultimate = InteractionCounterType.GetAntepenultimateID_MessageSent();
		foreach (InteractionCounter interactionCounter in InteractionCounter.GetUserInteractionCountersByTypePaged(user.Id, messagesSentIdAntepenultimate, 0, DesiredResultsUserIdsOfInterest))
		{
			int score = (int)Math.Min((double)interactionCounter.Value * InteractionBiasMessagesSentAntepenultimate, 2147483647.0);
			if (dimension.TryGetValue(interactionCounter.OtherUserID, out value))
			{
				dimension[interactionCounter.OtherUserID] = value + score;
			}
			else
			{
				dimension.Add(interactionCounter.OtherUserID, score);
			}
		}
		return dimension;
	}

	private static IFollowing Translate(Following following)
	{
		if (following != null)
		{
			return new Following
			{
				Id = following.Id,
				UserId = following.UserId,
				FollowerUserId = following.FollowerUserId,
				FollowerSince = following.Created
			};
		}
		return null;
	}

	private static IReadOnlyCollection<IFollowingDetails> Translate(IReadOnlyCollection<FollowingDetails> followingDetails)
	{
		List<FollowingDetails> list = new List<FollowingDetails>(followingDetails.Count);
		list.AddRange(followingDetails.Select((FollowingDetails followingDetail) => new FollowingDetails(followingDetail.UserId1, followingDetail.UserId2, followingDetail.User1FollowsUser2, followingDetail.User2FollowsUser1)));
		return list;
	}

	private static IReadOnlyCollection<IFollowing> Translate(IEnumerable<Following> followings)
	{
		return followings?.Select(Translate).ToList();
	}

	private static IFriend Translate(Friend friend)
	{
		if (friend != null)
		{
			return new Friend
			{
				FriendsSince = friend.FriendsSince,
				UserId = friend.UserId
			};
		}
		return null;
	}

	private static IReadOnlyCollection<IFriend> Translate(IEnumerable<Friend> friends)
	{
		return friends?.Select(Translate).ToList();
	}

	private static IFriendRequest Translate(FriendRequest friendRequest)
	{
		if (friendRequest == null)
		{
			return null;
		}
		return new FriendRequest
		{
			Body = friendRequest.Body,
			Id = friendRequest.Id,
			RecipientId = friendRequest.RecipientId,
			SenderId = friendRequest.SenderId,
			SentAt = friendRequest.SentAt,
			Subject = friendRequest.Subject,
			IsAccepted = friendRequest.IsAccepted
		};
	}

	private static IReadOnlyCollection<IFriendRequest> Translate(IEnumerable<FriendRequest> friendRequests)
	{
		return friendRequests?.Select(Translate).ToList();
	}

	private static int GetRandomRolloutPercentage()
	{
		return new Random(new object().GetHashCode()).Next(100);
	}
}
