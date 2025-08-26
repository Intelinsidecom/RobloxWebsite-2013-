namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAccept => "æŽ¥å—";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "å°‹æ‰¾å¥½å‹";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "è¿½è¹¤";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "å¿½ç•¥";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "å…¨éƒ¨å¿½ç•¥";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "å–æ¶ˆè¿½è¹¤";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "åˆªé™¤å¥½å‹";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "æˆ‘çš„å¥½å‹";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "è¿½è¹¤è€…";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "è¿½è¹¤ä¸­";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "å¥½å‹é‚€è«‹";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "å¥½å‹";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "é›¢ç·š";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨ç·š";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "é‚€è«‹";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "æœå°‹å¥½å‹";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "å·²å–æ¶ˆè¿½è¹¤";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "æ­¤å‹•ä½œä¸è¢«å…è¨±";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "å·²å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "åƒæ•¸ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "æ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚è«‹ç§»é™¤ä¸€ä½å¥½å‹ï¼Œå†é–‹å§‹æŽ¥å—å¥½å‹é‚€è«‹ã€‚";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "æ‚¨åŸ·è¡Œæ­¤å‹•ä½œéŽæ–¼é »ç¹ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "é¸æ“‡è¿½è¹¤æ‚¨çš„ä½¿ç”¨è€…ã€‚";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "æ‚¨é¸æ“‡è¿½è¹¤çš„ä½¿ç”¨è€…ã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "è«‹ç¨å¾Œå†å›žä¾†æŸ¥çœ‹ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œæ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚ ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "è«‹åˆªé™¤ä¸€ä½å¥½å‹ï¼Œå†é–‹å§‹æŽ¥å—å¥½å‹é‚€è«‹ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œè©²ä½¿ç”¨è€…å·²é”å…è¨±çš„å¥½å‹äººæ•¸ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "å°æ–¹å¿…é ˆç§»é™¤ä¸€ä½å¥½å‹ï¼Œæ‚¨æ‰èƒ½æŽ¥å—æ­¤å¥½å‹é‚€è«‹ã€‚";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "å¥½å‹é‚€è«‹ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "è¶…éŽå¥½å‹äººæ•¸ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "ç•¶ä¸€ä½ Roblox ä½¿ç”¨è€…æŽ¥å—å¦ä¸€ä½ä½¿ç”¨è€…çš„å¥½å‹é‚€è«‹ï¼Œé›™æ–¹å°±æœƒæˆç‚ºå¥½å‹ã€‚";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "æ‚¨ä¸æ˜¯æ­¤å¥½å‹é‚€è«‹çš„æŽ¥æ”¶äººã€‚";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "è¶…éŽå¥½å‹äººæ•¸ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "ç•¶æ‚¨æŽ¥å—ä¸€ä½ Roblox ä½¿ç”¨è€…çš„å¥½å‹é‚€è«‹ï¼Œé›™æ–¹å°±æœƒæˆç‚ºå¥½å‹ã€‚";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Roblox è·Ÿå¥½å‹ä¸€èµ·åŒæ¨‚æ›´å¥½çŽ©ï¼";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "æ‚¨ä¸å¯ä»¥è¿½è¹¤è‡ªå·±ã€‚";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "æ‚¨ä¸å¯ä»¥èˆ‡è‡ªå·±æˆç‚ºå¥½å‹ã€‚";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "ç„¡æ³•ä½¿ç”¨å¥½å‹èˆ‡è¿½è¹¤è€…ç³»çµ±ã€‚";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN å·²éŽ–å®šã€‚";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "ä½¿ç”¨è€…é­åˆ°å°éŽ–";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "æ‚¨éœ€è¦é€šéŽ Captcha é©—è­‰ã€‚";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "ä½¿ç”¨è€…éœ€è¦åœ¨åŒä¸€å€‹éŠæˆ²ä¸­ã€‚";

	public FriendsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æŽ¥å—";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "å°‹æ‰¾å¥½å‹";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "è¿½è¹¤";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "å¿½ç•¥";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "å…¨éƒ¨å¿½ç•¥";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "å–æ¶ˆè¿½è¹¤";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "åˆªé™¤å¥½å‹";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"è¼•è§¸ä¸Šæ–¹çš„æ”¾å¤§é¡åœ–ç¤ºï¼Œæœå°‹ä½¿ç”¨è€…æˆ–{startLink}çŽ©éŠæˆ²{endLink}çµäº¤å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "è¼•è§¸ä¸Šæ–¹çš„æ”¾å¤§é¡åœ–ç¤ºï¼Œæœå°‹ä½¿ç”¨è€…æˆ–{startLink}çŽ©éŠæˆ²{endLink}çµäº¤å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "æˆ‘çš„å¥½å‹";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username} çš„å¥½å‹";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username} çš„å¥½å‹";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "è¿½è¹¤è€…";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "è¿½è¹¤ä¸­";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "å¥½å‹é‚€è«‹";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "å¥½å‹";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"æ‚¨æ²’æœ‰å¾…è™•ç†çš„å¥½å‹é‚€è«‹ã€‚è‹¥è¦æ–°å¢žå¥½å‹ï¼Œè«‹æŸ¥çœ‹{startSpan}é™„è¿‘{endSpan}ã€‚";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "æ‚¨æ²’æœ‰å¾…è™•ç†çš„å¥½å‹é‚€è«‹ã€‚è‹¥è¦æ–°å¢žå¥½å‹ï¼Œè«‹æŸ¥çœ‹{startSpan}é™„è¿‘{endSpan}ã€‚";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "é›¢ç·š";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨ç·š";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "é‚€è«‹";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "æœå°‹å¥½å‹";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "å·²å–æ¶ˆè¿½è¹¤";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "æ­¤å‹•ä½œä¸è¢«å…è¨±";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "å·²å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "åƒæ•¸ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "æ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚è«‹ç§»é™¤ä¸€ä½å¥½å‹ï¼Œå†é–‹å§‹æŽ¥å—å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "æ‚¨åŸ·è¡Œæ­¤å‹•ä½œéŽæ–¼é »ç¹ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "é¸æ“‡è¿½è¹¤æ‚¨çš„ä½¿ç”¨è€…ã€‚";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "æ‚¨é¸æ“‡è¿½è¹¤çš„ä½¿ç”¨è€…ã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "è«‹ç¨å¾Œå†å›žä¾†æŸ¥çœ‹ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œæ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚ ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "è«‹åˆªé™¤ä¸€ä½å¥½å‹ï¼Œå†é–‹å§‹æŽ¥å—å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œè©²ä½¿ç”¨è€…å·²é”å…è¨±çš„å¥½å‹äººæ•¸ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "å°æ–¹å¿…é ˆç§»é™¤ä¸€ä½å¥½å‹ï¼Œæ‚¨æ‰èƒ½æŽ¥å—æ­¤å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "å¥½å‹é‚€è«‹ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "è¶…éŽå¥½å‹äººæ•¸ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "ç•¶ä¸€ä½ Roblox ä½¿ç”¨è€…æŽ¥å—å¦ä¸€ä½ä½¿ç”¨è€…çš„å¥½å‹é‚€è«‹ï¼Œé›™æ–¹å°±æœƒæˆç‚ºå¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "æ‚¨ä¸æ˜¯æ­¤å¥½å‹é‚€è«‹çš„æŽ¥æ”¶äººã€‚";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "è¶…éŽå¥½å‹äººæ•¸ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "ç•¶æ‚¨æŽ¥å—ä¸€ä½ Roblox ä½¿ç”¨è€…çš„å¥½å‹é‚€è«‹ï¼Œé›™æ–¹å°±æœƒæˆç‚ºå¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox è·Ÿå¥½å‹ä¸€èµ·åŒæ¨‚æ›´å¥½çŽ©ï¼";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "æ‚¨ä¸å¯ä»¥è¿½è¹¤è‡ªå·±ã€‚";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "æ‚¨ä¸å¯ä»¥èˆ‡è‡ªå·±æˆç‚ºå¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "ç„¡æ³•ä½¿ç”¨å¥½å‹èˆ‡è¿½è¹¤è€…ç³»çµ±ã€‚";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN å·²éŽ–å®šã€‚";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "ä½¿ç”¨è€…é­åˆ°å°éŽ–";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "æ‚¨éœ€è¦é€šéŽ Captcha é©—è­‰ã€‚";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "ä½¿ç”¨è€…éœ€è¦åœ¨åŒä¸€å€‹éŠæˆ²ä¸­ã€‚";
	}
}


}
