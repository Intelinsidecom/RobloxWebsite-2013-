namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_zh_tw : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "接受";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "尋找好友";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "追蹤";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "忽略";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "全部忽略";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "取消追蹤";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "刪除好友";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "我的好友";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "錯誤";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "追蹤者";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "追蹤中";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "好友邀請";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "好友";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "離線";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "確定";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在線";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "邀請";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "搜尋好友";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "已取消追蹤";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "此動作不被允許";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "已存在。";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "參數無效。";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "您的好友人數已達上限。請移除一位好友，再開始接受好友邀請。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "發生錯誤。";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "您執行此動作過於頻繁，請稍後再試。";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "選擇追蹤您的使用者。";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "您選擇追蹤的使用者。";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "發生錯誤。";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "請稍後再回來查看。";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "無法處理請求，您的好友人數已達上限。 ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "請刪除一位好友，再開始接受好友邀請。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "無法處理請求，該使用者已達允許的好友人數上限。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "對方必須移除一位好友，您才能接受此好友邀請。";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "好友邀請不存在";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "超過好友人數上限。";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "當一位 Roblox 使用者接受另一位使用者的好友邀請，雙方就會成為好友。";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "您不是此好友邀請的接收人。";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "超過好友人數上限。";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "當您接受一位 Roblox 使用者的好友邀請，雙方就會成為好友。";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Roblox 跟好友一起同樂更好玩！";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "您不可以追蹤自己。";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "您不可以與自己成為好友。";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "無法使用好友與追蹤者系統。";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN 已鎖定。";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "使用者遭到封鎖";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "您需要通過 Captcha 驗證。";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "使用者需要在同一個遊戲中。";

	public FriendsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "接受";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "尋找好友";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "追蹤";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "忽略";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "全部忽略";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "取消追蹤";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "刪除好友";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"輕觸上方的放大鏡圖示，搜尋使用者或{startLink}玩遊戲{endLink}結交好友。";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "輕觸上方的放大鏡圖示，搜尋使用者或{startLink}玩遊戲{endLink}結交好友。";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "我的好友";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username} 的好友";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username} 的好友";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "追蹤者";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "追蹤中";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "好友邀請";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "好友";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"您沒有待處理的好友邀請。若要新增好友，請查看{startSpan}附近{endSpan}。";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "您沒有待處理的好友邀請。若要新增好友，請查看{startSpan}附近{endSpan}。";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "離線";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在線";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "邀請";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "搜尋好友";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "已取消追蹤";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "此動作不被允許";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "已存在。";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "參數無效。";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "您的好友人數已達上限。請移除一位好友，再開始接受好友邀請。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "發生錯誤。";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "您執行此動作過於頻繁，請稍後再試。";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "選擇追蹤您的使用者。";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "您選擇追蹤的使用者。";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "發生錯誤。";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "請稍後再回來查看。";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "無法處理請求，您的好友人數已達上限。 ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "請刪除一位好友，再開始接受好友邀請。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "無法處理請求，該使用者已達允許的好友人數上限。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "對方必須移除一位好友，您才能接受此好友邀請。";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "好友邀請不存在";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "超過好友人數上限。";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "當一位 Roblox 使用者接受另一位使用者的好友邀請，雙方就會成為好友。";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "您不是此好友邀請的接收人。";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "超過好友人數上限。";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "當您接受一位 Roblox 使用者的好友邀請，雙方就會成為好友。";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox 跟好友一起同樂更好玩！";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "您不可以追蹤自己。";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "您不可以與自己成為好友。";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "無法使用好友與追蹤者系統。";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN 已鎖定。";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "使用者遭到封鎖";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "您需要通過 Captcha 驗證。";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "使用者需要在同一個遊戲中。";
	}
}
