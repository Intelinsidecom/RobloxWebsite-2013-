using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class FriendsResources_en_us : TranslationResourcesBase, IFriendsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public virtual string ActionAccept => "Accept";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public virtual string ActionFindFriends => "Find Friends";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public virtual string ActionFollow => "Follow";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public virtual string ActionIgnore => "Ignore";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public virtual string ActionIgnoreAll => "Ignore All";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public virtual string ActionUnfollow => "Unfollow";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public virtual string ActionUnfriend => "Unfriend";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public virtual string HeadingMyFriends => "My Friends";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public virtual string LabelErrorTitle => "Error";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public virtual string LabelFollowers => "Followers";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public virtual string LabelFollowing => "Following";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public virtual string LabelFriendRequests => "Friend Requests";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public virtual string LabelFriends => "Friends";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public virtual string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public virtual string LabelOk => "Ok";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public virtual string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public virtual string LabelRequests => "Requests";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public virtual string LabelSearchFriends => "Search for Friends";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public virtual string LabelUnfollowed => "Unfollowed";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public virtual string MessageActionNotAllowedError => "Action not allowed";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public virtual string MessageAlreadyExistsError => "Already exists.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public virtual string MessageCurrentInvalidParametersError => "Invalid parameters.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public virtual string MessageCurrentUserFriendsLimitExceededError => "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public virtual string MessageDefaultError => "An error ocurred.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public virtual string MessageFloodLimitExceededError => "You are performing this action too often. Please wait a minute and try again.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public virtual string MessageFollowerTabTooltip => "People who have chosen to follow your activity.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public virtual string MessageFollowingTabTooltip => "People whose activity you have chosen to follow.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public virtual string MessageForGeneralError => "Something went wrong.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public virtual string MessageForGeneralFooter => "Please check back in few minutes.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public virtual string MessageForMaxFriendsError => "Unable to process Request.You currently have the max number of Friends allowed. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public virtual string MessageForMaxFriendsFooter => "Unfriend someone before accepting any more Friend Requests.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public virtual string MessageForMaxRequestsError => "Unable to process Request. That user currently has the max number of Friends allowed.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public virtual string MessageForMaxRequestsFooter => "You can not accept their Friend Request until they remove a Friend.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public virtual string MessageFriendRequestNotExistError => "Friend request does not exist";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public virtual string MessageFriendsLimitExceededError => "Friends limit exceeded.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public virtual string MessageFriendsTabTooltip => "Friends are established when two Roblox users mutually agree to friendship.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public virtual string MessageNotRecipientError => "You are not the recipient of this friend request.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public virtual string MessageOtherUserFriendsLimitExceededError => "Friends limit exceeded.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public virtual string MessageRequestsTabTooltip => "Friends are established when two Roblox users mutually agree to friendship.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public virtual string MessageRobloxIsMoreFunWithFriends => "Roblox is more fun with friends!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public virtual string MessageSelfFollowingAttemptError => "You cannot follow yourself.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public virtual string MessageSelfFriendingAttemptError => "You cannot be friends with yourself.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public virtual string MessageSystemUnavailableError => "Friends and Followers system is unavailable.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public virtual string MessageUnblockUserPinLockedError => "Pin is locked.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public virtual string MessageUserBlockedError => "User is blocked";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public virtual string MessageUserHasNotPassedCaptchaError => "You need to pass Captcha.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public virtual string MessageUsersAreNotInSameGameError => "Users need to be in the same game.";

	public FriendsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Accept",
				_GetTemplateForActionAccept()
			},
			{
				"Action.FindFriends",
				_GetTemplateForActionFindFriends()
			},
			{
				"Action.Follow",
				_GetTemplateForActionFollow()
			},
			{
				"Action.Ignore",
				_GetTemplateForActionIgnore()
			},
			{
				"Action.IgnoreAll",
				_GetTemplateForActionIgnoreAll()
			},
			{
				"Action.Unfollow",
				_GetTemplateForActionUnfollow()
			},
			{
				"Action.Unfriend",
				_GetTemplateForActionUnfriend()
			},
			{
				"Description.SearchFriends",
				_GetTemplateForDescriptionSearchFriends()
			},
			{
				"Heading.MyFriends",
				_GetTemplateForHeadingMyFriends()
			},
			{
				"Heading.UsersFriends",
				_GetTemplateForHeadingUsersFriends()
			},
			{
				"Label.ErrorTitle",
				_GetTemplateForLabelErrorTitle()
			},
			{
				"Label.Followers",
				_GetTemplateForLabelFollowers()
			},
			{
				"Label.Following",
				_GetTemplateForLabelFollowing()
			},
			{
				"Label.FriendRequests",
				_GetTemplateForLabelFriendRequests()
			},
			{
				"Label.Friends",
				_GetTemplateForLabelFriends()
			},
			{
				"Label.NearbyUpsell",
				_GetTemplateForLabelNearbyUpsell()
			},
			{
				"Label.Offline",
				_GetTemplateForLabelOffline()
			},
			{
				"Label.Ok",
				_GetTemplateForLabelOk()
			},
			{
				"Label.Online",
				_GetTemplateForLabelOnline()
			},
			{
				"Label.Requests",
				_GetTemplateForLabelRequests()
			},
			{
				"Label.SearchFriends",
				_GetTemplateForLabelSearchFriends()
			},
			{
				"Label.Unfollowed",
				_GetTemplateForLabelUnfollowed()
			},
			{
				"Message.ActionNotAllowedError",
				_GetTemplateForMessageActionNotAllowedError()
			},
			{
				"Message.AlreadyExistsError",
				_GetTemplateForMessageAlreadyExistsError()
			},
			{
				"Message.CurrentInvalidParametersError",
				_GetTemplateForMessageCurrentInvalidParametersError()
			},
			{
				"Message.CurrentUserFriendsLimitExceededError",
				_GetTemplateForMessageCurrentUserFriendsLimitExceededError()
			},
			{
				"Message.DefaultError",
				_GetTemplateForMessageDefaultError()
			},
			{
				"Message.FloodLimitExceededError",
				_GetTemplateForMessageFloodLimitExceededError()
			},
			{
				"Message.FollowerTabTooltip",
				_GetTemplateForMessageFollowerTabTooltip()
			},
			{
				"Message.FollowingTabTooltip",
				_GetTemplateForMessageFollowingTabTooltip()
			},
			{
				"Message.ForGeneralError",
				_GetTemplateForMessageForGeneralError()
			},
			{
				"Message.ForGeneralFooter",
				_GetTemplateForMessageForGeneralFooter()
			},
			{
				"Message.ForMaxFriendsError",
				_GetTemplateForMessageForMaxFriendsError()
			},
			{
				"Message.ForMaxFriendsFooter",
				_GetTemplateForMessageForMaxFriendsFooter()
			},
			{
				"Message.ForMaxRequestsError",
				_GetTemplateForMessageForMaxRequestsError()
			},
			{
				"Message.ForMaxRequestsFooter",
				_GetTemplateForMessageForMaxRequestsFooter()
			},
			{
				"Message.FriendRequestNotExistError",
				_GetTemplateForMessageFriendRequestNotExistError()
			},
			{
				"Message.FriendsLimitExceededError",
				_GetTemplateForMessageFriendsLimitExceededError()
			},
			{
				"Message.FriendsTabTooltip",
				_GetTemplateForMessageFriendsTabTooltip()
			},
			{
				"Message.NotRecipientError",
				_GetTemplateForMessageNotRecipientError()
			},
			{
				"Message.OtherUserFriendsLimitExceededError",
				_GetTemplateForMessageOtherUserFriendsLimitExceededError()
			},
			{
				"Message.RequestsTabTooltip",
				_GetTemplateForMessageRequestsTabTooltip()
			},
			{
				"Message.RobloxIsMoreFunWithFriends",
				_GetTemplateForMessageRobloxIsMoreFunWithFriends()
			},
			{
				"Message.SelfFollowingAttemptError",
				_GetTemplateForMessageSelfFollowingAttemptError()
			},
			{
				"Message.SelfFriendingAttemptError",
				_GetTemplateForMessageSelfFriendingAttemptError()
			},
			{
				"Message.SystemUnavailableError",
				_GetTemplateForMessageSystemUnavailableError()
			},
			{
				"Message.UnblockUserPinLockedError",
				_GetTemplateForMessageUnblockUserPinLockedError()
			},
			{
				"Message.UserBlockedError",
				_GetTemplateForMessageUserBlockedError()
			},
			{
				"Message.UserHasNotPassedCaptchaError",
				_GetTemplateForMessageUserHasNotPassedCaptchaError()
			},
			{
				"Message.UsersAreNotInSameGameError",
				_GetTemplateForMessageUsersAreNotInSameGameError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Friends";
	}

	protected virtual string _GetTemplateForActionAccept()
	{
		return "Accept";
	}

	protected virtual string _GetTemplateForActionFindFriends()
	{
		return "Find Friends";
	}

	protected virtual string _GetTemplateForActionFollow()
	{
		return "Follow";
	}

	protected virtual string _GetTemplateForActionIgnore()
	{
		return "Ignore";
	}

	protected virtual string _GetTemplateForActionIgnoreAll()
	{
		return "Ignore All";
	}

	protected virtual string _GetTemplateForActionUnfollow()
	{
		return "Unfollow";
	}

	protected virtual string _GetTemplateForActionUnfriend()
	{
		return "Unfriend";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public virtual string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people.";
	}

	protected virtual string _GetTemplateForDescriptionSearchFriends()
	{
		return "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people.";
	}

	protected virtual string _GetTemplateForHeadingMyFriends()
	{
		return "My Friends";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public virtual string HeadingUsersFriends(string username)
	{
		return $"{username}'s Friends";
	}

	protected virtual string _GetTemplateForHeadingUsersFriends()
	{
		return "{username}'s Friends";
	}

	protected virtual string _GetTemplateForLabelErrorTitle()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForLabelFollowers()
	{
		return "Followers";
	}

	protected virtual string _GetTemplateForLabelFollowing()
	{
		return "Following";
	}

	protected virtual string _GetTemplateForLabelFriendRequests()
	{
		return "Friend Requests";
	}

	protected virtual string _GetTemplateForLabelFriends()
	{
		return "Friends";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public virtual string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}.";
	}

	protected virtual string _GetTemplateForLabelNearbyUpsell()
	{
		return "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}.";
	}

	protected virtual string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected virtual string _GetTemplateForLabelOk()
	{
		return "Ok";
	}

	protected virtual string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected virtual string _GetTemplateForLabelRequests()
	{
		return "Requests";
	}

	protected virtual string _GetTemplateForLabelSearchFriends()
	{
		return "Search for Friends";
	}

	protected virtual string _GetTemplateForLabelUnfollowed()
	{
		return "Unfollowed";
	}

	protected virtual string _GetTemplateForMessageActionNotAllowedError()
	{
		return "Action not allowed";
	}

	protected virtual string _GetTemplateForMessageAlreadyExistsError()
	{
		return "Already exists.";
	}

	protected virtual string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "Invalid parameters.";
	}

	protected virtual string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests.";
	}

	protected virtual string _GetTemplateForMessageDefaultError()
	{
		return "An error ocurred.";
	}

	protected virtual string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "You are performing this action too often. Please wait a minute and try again.";
	}

	protected virtual string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "People who have chosen to follow your activity.";
	}

	protected virtual string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "People whose activity you have chosen to follow.";
	}

	protected virtual string _GetTemplateForMessageForGeneralError()
	{
		return "Something went wrong.";
	}

	protected virtual string _GetTemplateForMessageForGeneralFooter()
	{
		return "Please check back in few minutes.";
	}

	protected virtual string _GetTemplateForMessageForMaxFriendsError()
	{
		return "Unable to process Request.You currently have the max number of Friends allowed. ";
	}

	protected virtual string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "Unfriend someone before accepting any more Friend Requests.";
	}

	protected virtual string _GetTemplateForMessageForMaxRequestsError()
	{
		return "Unable to process Request. That user currently has the max number of Friends allowed.";
	}

	protected virtual string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "You can not accept their Friend Request until they remove a Friend.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "Friend request does not exist";
	}

	protected virtual string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "Friends limit exceeded.";
	}

	protected virtual string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Friends are established when two Roblox users mutually agree to friendship.";
	}

	protected virtual string _GetTemplateForMessageNotRecipientError()
	{
		return "You are not the recipient of this friend request.";
	}

	protected virtual string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "Friends limit exceeded.";
	}

	protected virtual string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Friends are established when two Roblox users mutually agree to friendship.";
	}

	protected virtual string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox is more fun with friends!";
	}

	protected virtual string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "You cannot follow yourself.";
	}

	protected virtual string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "You cannot be friends with yourself.";
	}

	protected virtual string _GetTemplateForMessageSystemUnavailableError()
	{
		return "Friends and Followers system is unavailable.";
	}

	protected virtual string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "Pin is locked.";
	}

	protected virtual string _GetTemplateForMessageUserBlockedError()
	{
		return "User is blocked";
	}

	protected virtual string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "You need to pass Captcha.";
	}

	protected virtual string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "Users need to be in the same game.";
	}
}
