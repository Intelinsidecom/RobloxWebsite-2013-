using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.Friends.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.PolicyLookup;
using Roblox.Platform.Social.Properties;
using Roblox.Platform.UserBlock.Core;
using Roblox.RequestContext;
using Roblox.Sentinels;

namespace Roblox.Platform.Social;

public class FriendshipCreator : FriendshipProducerBase, IFriendshipCreator
{
	private const string _SendFriendRequestActionType = "SendFriendRequest";

	private readonly IPermissionsChecker _PermissionsChecker;

	private readonly IUserFactory _UserFactory;

	private readonly IRequestContextLoader _RequestContextLoader;

	private readonly IUserPolicyLookup _UserPolicyLookup;

	internal virtual bool _IsPermissionsCheckForSendFriendRequestEnabled => Settings.Default.IsPermissionsCheckForSendFriendRequestEnabled;

	internal virtual bool _ShouldUseRequestContextToCheckSendFriendRequestPermission => Settings.Default.ShouldUseRequestContextToCheckSendFriendRequestPermission;

	public event FriendRequestSent OnFriendRequestSent;

	public FriendshipCreator(IFriendsClient client, IUserBlockAuthority userBlockAuthority, IPermissionsChecker permissionsChecker, IUserFactory userFactory, IRequestContextLoader requestContextLoader, IUserPolicyLookup userPolicyLookup)
		: base(client, userBlockAuthority)
	{
		_PermissionsChecker = permissionsChecker ?? throw new ArgumentNullException("permissionsChecker");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_RequestContextLoader = requestContextLoader ?? throw new ArgumentNullException("requestContextLoader");
		_UserPolicyLookup = userPolicyLookup ?? throw new ArgumentNullException("userPolicyLookup");
	}

	public void SendFriendRequest(long userId, long recipientId, AntiAbuseFlags antiAbuseFlags, string message = "", FriendshipOriginSourceType friendshipOriginSourceType = 0)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		if (userId <= 0 || recipientId <= 0)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to SendFriendRequest. UserId:{userId},RecipientId:{recipientId}");
		}
		IUser user = _UserFactory.GetUser(userId);
		IUser recipientUser = _UserFactory.GetUser(recipientId);
		if (user == null || recipientUser == null)
		{
			throw new PlatformArgumentException($"Invalid parameters passed to SendFriendRequest. UserId:{userId},RecipientId:{recipientId}");
		}
		if (BlockExistsBetweenUsers(user, recipientUser))
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.BlockedUser, "Block exists between the two users.");
		}
		FriendshipOperationErrorType? friendsErrorType = antiAbuseFlags.CheckIfSendFriendRequestIsAllowed();
		if (friendsErrorType.HasValue)
		{
			switch (friendsErrorType.Value)
			{
			case FriendshipOperationErrorType.UsersAreNotInSameGame:
				throw new FriendshipOperationException(FriendshipOperationErrorType.UsersAreNotInSameGame, "Users are not in the same game");
			case FriendshipOperationErrorType.UserHasNotPassedCaptcha:
				throw new FriendshipOperationException(FriendshipOperationErrorType.UserHasNotPassedCaptcha, "Friendship requestor has not passed Captcha");
			}
		}
		VerifySendFriendRequestPoliciesAndPermissions(userId, recipientId);
		try
		{
			base.Client.SendFriendRequest(userId, recipientId, message, friendshipOriginSourceType);
			if (Settings.Default.FriendshipSendEventEnabled)
			{
				this.OnFriendRequestSent?.Invoke(userId, recipientId, antiAbuseFlags.IsRecipientInSameGameAsUser, antiAbuseFlags.IsUserInApp);
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

	private void VerifySendFriendRequestPoliciesAndPermissions(long userId, long recipientId)
	{
		try
		{
			if (_ShouldUseRequestContextToCheckSendFriendRequestPermission)
			{
				IRequestContext currentContext = _RequestContextLoader.GetCurrentContext();
				ICollection<Policy> targetUserPolicies = _UserPolicyLookup.GetApplicablePoliciesForTargetUser(currentContext, recipientId);
				if (currentContext.ApplicablePolicies.Contains(Policy.CommercialChina))
				{
					if (!targetUserPolicies.Contains(Policy.CommercialChina))
					{
						throw new FriendshipOperationException(FriendshipOperationErrorType.PolicyCheckUnsuccessful, $"SendFriendRequest not permitted from userId {userId} to userId {recipientId} due to policy violation.");
					}
				}
				else if (targetUserPolicies.Contains(Policy.CommercialChina))
				{
					throw new FriendshipOperationException(FriendshipOperationErrorType.PolicyCheckUnsuccessful, $"SendFriendRequest not permitted from userId {userId} to userId {recipientId} due to policy violation.");
				}
			}
			if (_IsPermissionsCheckForSendFriendRequestEnabled)
			{
				PermissionsStatus permissionsStatus = _PermissionsChecker.CheckPermissions("SendFriendRequest", new Dictionary<string, object>
				{
					{ "subjectUserId", userId },
					{ "targetUserId", recipientId }
				});
				if (!permissionsStatus.WasTested || !permissionsStatus.IsSuccess)
				{
					throw new FriendshipOperationException(FriendshipOperationErrorType.PermissionsCheckUnsuccessful, $"SendFriendRequest not permitted from userId {userId} to userId {recipientId}; Permissions Service returned {permissionsStatus}");
				}
			}
		}
		catch (ArgumentException e)
		{
			throw new FriendshipOperationException(FriendshipOperationErrorType.PermissionsCheckUnsuccessful, $"Exception verifying SendFriendRequest permissions from userId {userId} to userId {recipientId}: {e}");
		}
	}
}
