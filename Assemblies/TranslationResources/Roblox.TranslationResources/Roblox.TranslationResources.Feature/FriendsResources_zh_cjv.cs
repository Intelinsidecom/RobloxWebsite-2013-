namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_zh_cjv : FriendsResources_en_us, IFriendsResources, ITranslationResources
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
	public override string ActionFindFriends => "查找好友";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "关注";

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
	public override string ActionUnfollow => "取消关注";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "删除好友";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "我的好友";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "错误";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "粉丝";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "关注中";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "好友邀请";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "好友";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "离线";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "好";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在线";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "请求";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "搜索好友";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "已取消关注";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "此操作不允许";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "已存在。";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "参数无效。";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "你的好友人数已达上限。请先移除一位好友，才能接受更多好友邀请。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "发生错误。";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "你执行此操作的次数太过频繁。请稍等一分钟后再重试。";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "选择关注你的用户。";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "你选择关注的用户。";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "发生错误。";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "请过几分钟再回来查看。";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "无法处理邀请。你的好友人数已达上限。";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "请先和一些人解除好友关系，才能接受更多好友邀请。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "无法处理邀请。该用户的好友人数已达允许的上限。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "对方必须移除一位好友，你才能接受此好友邀请。";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "好友邀请不存在";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "超过好友人数上限。";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "好友关系是由两位 Roblox 用户互相同意好友邀请而建立。";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "你不是此好友邀请的接收人。";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "超过好友人数上限。";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "好友关系是由两位 Roblox 用户互相同意好友邀请而建立。";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "和好友一起玩 Roblox 更开心！";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "你不能关注自己。";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "你不能与自己成为好友。";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "好友和关注者系统不可用。";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "Pin 被锁定。";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "用户被屏蔽";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "你需要通过验证码测试。";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "用户需要在同一游戏中。";

	public FriendsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "接受";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "查找好友";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "关注";
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
		return "取消关注";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "删除好友";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"轻按上方放大镜图标，通过搜索用户或{startLink}加入游戏{endLink}来认识更多的朋友。";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "轻按上方放大镜图标，通过搜索用户或{startLink}加入游戏{endLink}来认识更多的朋友。";
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
		return $"“{username}”的好友";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "“{username}”的好友";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "错误";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "粉丝";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "关注中";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "好友邀请";
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
		return $"你没有待处理的好友邀请。若要添加好友，请查看{startSpan}附近{endSpan}。";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "你没有待处理的好友邀请。若要添加好友，请查看{startSpan}附近{endSpan}。";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "离线";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在线";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "请求";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "搜索好友";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "已取消关注";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "此操作不允许";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "已存在。";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "参数无效。";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "你的好友人数已达上限。请先移除一位好友，才能接受更多好友邀请。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "发生错误。";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "你执行此操作的次数太过频繁。请稍等一分钟后再重试。";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "选择关注你的用户。";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "你选择关注的用户。";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "发生错误。";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "请过几分钟再回来查看。";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "无法处理邀请。你的好友人数已达上限。";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "请先和一些人解除好友关系，才能接受更多好友邀请。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "无法处理邀请。该用户的好友人数已达允许的上限。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "对方必须移除一位好友，你才能接受此好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "好友邀请不存在";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "超过好友人数上限。";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "好友关系是由两位 Roblox 用户互相同意好友邀请而建立。";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "你不是此好友邀请的接收人。";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "超过好友人数上限。";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "好友关系是由两位 Roblox 用户互相同意好友邀请而建立。";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "和好友一起玩 Roblox 更开心！";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "你不能关注自己。";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "你不能与自己成为好友。";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "好友和关注者系统不可用。";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "Pin 被锁定。";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "用户被屏蔽";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "你需要通过验证码测试。";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "用户需要在同一游戏中。";
	}
}
