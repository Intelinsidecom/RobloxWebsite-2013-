namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAccept => "æŽ¥å—";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "æŸ¥æ‰¾å¥½å‹";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "å…³æ³¨";

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
	public override string ActionUnfollow => "å–æ¶ˆå…³æ³¨";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "åˆ é™¤å¥½å‹";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "æˆ‘çš„å¥½å‹";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "é”™è¯¯";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "ç²‰ä¸";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "å…³æ³¨ä¸­";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "å¥½å‹é‚€è¯·";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "å¥½å‹";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ç¦»çº¿";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "å¥½";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨çº¿";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "è¯·æ±‚";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "æœç´¢å¥½å‹";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "å·²å–æ¶ˆå…³æ³¨";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "æ­¤æ“ä½œä¸å…è®¸";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "å·²å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "å‚æ•°æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "ä½ çš„å¥½å‹äººæ•°å·²è¾¾ä¸Šé™ã€‚è¯·å…ˆç§»é™¤ä¸€ä½å¥½å‹ï¼Œæ‰èƒ½æŽ¥å—æ›´å¤šå¥½å‹é‚€è¯·ã€‚";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "å‘ç”Ÿé”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "ä½ æ‰§è¡Œæ­¤æ“ä½œçš„æ¬¡æ•°å¤ªè¿‡é¢‘ç¹ã€‚è¯·ç¨ç­‰ä¸€åˆ†é’ŸåŽå†é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "é€‰æ‹©å…³æ³¨ä½ çš„ç”¨æˆ·ã€‚";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "ä½ é€‰æ‹©å…³æ³¨çš„ç”¨æˆ·ã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "å‘ç”Ÿé”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "è¯·è¿‡å‡ åˆ†é’Ÿå†å›žæ¥æŸ¥çœ‹ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "æ— æ³•å¤„ç†é‚€è¯·ã€‚ä½ çš„å¥½å‹äººæ•°å·²è¾¾ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "è¯·å…ˆå’Œä¸€äº›äººè§£é™¤å¥½å‹å…³ç³»ï¼Œæ‰èƒ½æŽ¥å—æ›´å¤šå¥½å‹é‚€è¯·ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "æ— æ³•å¤„ç†é‚€è¯·ã€‚è¯¥ç”¨æˆ·çš„å¥½å‹äººæ•°å·²è¾¾å…è®¸çš„ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "å¯¹æ–¹å¿…é¡»ç§»é™¤ä¸€ä½å¥½å‹ï¼Œä½ æ‰èƒ½æŽ¥å—æ­¤å¥½å‹é‚€è¯·ã€‚";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "å¥½å‹é‚€è¯·ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "è¶…è¿‡å¥½å‹äººæ•°ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "å¥½å‹å…³ç³»æ˜¯ç”±ä¸¤ä½ Roblox ç”¨æˆ·äº’ç›¸åŒæ„å¥½å‹é‚€è¯·è€Œå»ºç«‹ã€‚";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "ä½ ä¸æ˜¯æ­¤å¥½å‹é‚€è¯·çš„æŽ¥æ”¶äººã€‚";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "è¶…è¿‡å¥½å‹äººæ•°ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "å¥½å‹å…³ç³»æ˜¯ç”±ä¸¤ä½ Roblox ç”¨æˆ·äº’ç›¸åŒæ„å¥½å‹é‚€è¯·è€Œå»ºç«‹ã€‚";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "å’Œå¥½å‹ä¸€èµ·çŽ© Roblox æ›´å¼€å¿ƒï¼";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "ä½ ä¸èƒ½å…³æ³¨è‡ªå·±ã€‚";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "ä½ ä¸èƒ½ä¸Žè‡ªå·±æˆä¸ºå¥½å‹ã€‚";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "å¥½å‹å’Œå…³æ³¨è€…ç³»ç»Ÿä¸å¯ç”¨ã€‚";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "Pin è¢«é”å®šã€‚";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "ç”¨æˆ·è¢«å±è”½";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "ä½ éœ€è¦é€šè¿‡éªŒè¯ç æµ‹è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "ç”¨æˆ·éœ€è¦åœ¨åŒä¸€æ¸¸æˆä¸­ã€‚";

	public FriendsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æŽ¥å—";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "æŸ¥æ‰¾å¥½å‹";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "å…³æ³¨";
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
		return "å–æ¶ˆå…³æ³¨";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "åˆ é™¤å¥½å‹";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"è½»æŒ‰ä¸Šæ–¹æ”¾å¤§é•œå›¾æ ‡ï¼Œé€šè¿‡æœç´¢ç”¨æˆ·æˆ–{startLink}åŠ å…¥æ¸¸æˆ{endLink}æ¥è®¤è¯†æ›´å¤šçš„æœ‹å‹ã€‚";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "è½»æŒ‰ä¸Šæ–¹æ”¾å¤§é•œå›¾æ ‡ï¼Œé€šè¿‡æœç´¢ç”¨æˆ·æˆ–{startLink}åŠ å…¥æ¸¸æˆ{endLink}æ¥è®¤è¯†æ›´å¤šçš„æœ‹å‹ã€‚";
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
		return $"â€œ{username}â€çš„å¥½å‹";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "â€œ{username}â€çš„å¥½å‹";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "ç²‰ä¸";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "å…³æ³¨ä¸­";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "å¥½å‹é‚€è¯·";
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
		return $"ä½ æ²¡æœ‰å¾…å¤„ç†çš„å¥½å‹é‚€è¯·ã€‚è‹¥è¦æ·»åŠ å¥½å‹ï¼Œè¯·æŸ¥çœ‹{startSpan}é™„è¿‘{endSpan}ã€‚";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "ä½ æ²¡æœ‰å¾…å¤„ç†çš„å¥½å‹é‚€è¯·ã€‚è‹¥è¦æ·»åŠ å¥½å‹ï¼Œè¯·æŸ¥çœ‹{startSpan}é™„è¿‘{endSpan}ã€‚";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ç¦»çº¿";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨çº¿";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "è¯·æ±‚";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "æœç´¢å¥½å‹";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "å·²å–æ¶ˆå…³æ³¨";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "æ­¤æ“ä½œä¸å…è®¸";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "å·²å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "å‚æ•°æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "ä½ çš„å¥½å‹äººæ•°å·²è¾¾ä¸Šé™ã€‚è¯·å…ˆç§»é™¤ä¸€ä½å¥½å‹ï¼Œæ‰èƒ½æŽ¥å—æ›´å¤šå¥½å‹é‚€è¯·ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "å‘ç”Ÿé”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "ä½ æ‰§è¡Œæ­¤æ“ä½œçš„æ¬¡æ•°å¤ªè¿‡é¢‘ç¹ã€‚è¯·ç¨ç­‰ä¸€åˆ†é’ŸåŽå†é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "é€‰æ‹©å…³æ³¨ä½ çš„ç”¨æˆ·ã€‚";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "ä½ é€‰æ‹©å…³æ³¨çš„ç”¨æˆ·ã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "å‘ç”Ÿé”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "è¯·è¿‡å‡ åˆ†é’Ÿå†å›žæ¥æŸ¥çœ‹ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "æ— æ³•å¤„ç†é‚€è¯·ã€‚ä½ çš„å¥½å‹äººæ•°å·²è¾¾ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "è¯·å…ˆå’Œä¸€äº›äººè§£é™¤å¥½å‹å…³ç³»ï¼Œæ‰èƒ½æŽ¥å—æ›´å¤šå¥½å‹é‚€è¯·ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "æ— æ³•å¤„ç†é‚€è¯·ã€‚è¯¥ç”¨æˆ·çš„å¥½å‹äººæ•°å·²è¾¾å…è®¸çš„ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "å¯¹æ–¹å¿…é¡»ç§»é™¤ä¸€ä½å¥½å‹ï¼Œä½ æ‰èƒ½æŽ¥å—æ­¤å¥½å‹é‚€è¯·ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "å¥½å‹é‚€è¯·ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "è¶…è¿‡å¥½å‹äººæ•°ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "å¥½å‹å…³ç³»æ˜¯ç”±ä¸¤ä½ Roblox ç”¨æˆ·äº’ç›¸åŒæ„å¥½å‹é‚€è¯·è€Œå»ºç«‹ã€‚";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "ä½ ä¸æ˜¯æ­¤å¥½å‹é‚€è¯·çš„æŽ¥æ”¶äººã€‚";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "è¶…è¿‡å¥½å‹äººæ•°ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "å¥½å‹å…³ç³»æ˜¯ç”±ä¸¤ä½ Roblox ç”¨æˆ·äº’ç›¸åŒæ„å¥½å‹é‚€è¯·è€Œå»ºç«‹ã€‚";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "å’Œå¥½å‹ä¸€èµ·çŽ© Roblox æ›´å¼€å¿ƒï¼";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "ä½ ä¸èƒ½å…³æ³¨è‡ªå·±ã€‚";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "ä½ ä¸èƒ½ä¸Žè‡ªå·±æˆä¸ºå¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "å¥½å‹å’Œå…³æ³¨è€…ç³»ç»Ÿä¸å¯ç”¨ã€‚";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "Pin è¢«é”å®šã€‚";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "ç”¨æˆ·è¢«å±è”½";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "ä½ éœ€è¦é€šè¿‡éªŒè¯ç æµ‹è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "ç”¨æˆ·éœ€è¦åœ¨åŒä¸€æ¸¸æˆä¸­ã€‚";
	}
}


}
