namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_ja_jp : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "æ‰¿èªã™ã‚‹";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "å‹é”ã‚’è¦‹ã¤ã‘ã‚‹";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "ãƒ•ã‚©ãƒ­ãƒ¼";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "ç„¡è¦–ã™ã‚‹";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "ã™ã¹ã¦ç„¡è¦–ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "å‹é”è§£é™¤";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "ã‚ãªãŸã®å‹é”";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "ãƒ•ã‚©ãƒ­ãƒ¯ãƒ¼";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "ãƒ•ã‚©ãƒ­ãƒ¼ä¸­";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "å‹é”";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "å‹é”ã‚’æ¤œç´¢";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "ã‚¢ã‚¯ã‚·ãƒ§ãƒ³ãŒè¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "ã™ã§ã«ã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "ç„¡åŠ¹ãªãƒ‘ãƒ©ãƒ¡ãƒ¼ã‚¿ã§ã™ã€‚";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹å‰ã«ã€ã»ã‹ã®å‹é”ã‚’å‰Šé™¤ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "ã“ã®æ“ä½œã‚’ä½•åº¦ã‚‚å®Ÿè¡Œã—ã¦ã„ã¾ã™ã€‚1åˆ†ã»ã©å¾…ã£ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "ã‚ãªãŸã®ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã€‚";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "ã‚ãªãŸãŒã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã€‚ç¾åœ¨ã€ç™»éŒ²ã§ãã‚‹å‹é”ã®æ•°ãŒä¸Šé™ã«é”ã—ã¦ã„ã¾ã™ã€‚ ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "ã“ã‚Œä»¥ä¸Šã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹ã«ã¯ã€èª°ã‹ã‚’å‹é”è§£é™¤ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã€‚ç¾åœ¨ã€ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ç™»éŒ²ã§ãã‚‹å‹é”ã®æ•°ãŒä¸Šé™ã«é”ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "ã»ã‹ã®å‹é”ã‚’å‰Šé™¤ã™ã‚‹ã¾ã§ã€æ–°ã—ã„å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå­˜åœ¨ã—ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼äºŒäººãŒãŠäº’ã„ã«åŒæ„ã™ã‚Œã°ã€å‹é”ã«ãªã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "ã“ã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã€ã‚ãªãŸå®›ã¦ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼äºŒäººãŒãŠäº’ã„ã«åŒæ„ã™ã‚Œã°ã€å‹é”ã«ãªã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Robloxã¯ã€å‹é”ã¨ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚Œã°ã€ã‚‚ã£ã¨ãŠæ¥½ã—ã¿ã„ãŸã ã‘ã¾ã™ï¼";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "è‡ªåˆ†ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "è‡ªåˆ†ã¨å‹é”ã«ãªã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "å‹é”ãŠã‚ˆã³ãƒ•ã‚©ãƒ­ãƒ¯ãƒ¼ã®ã‚·ã‚¹ãƒ†ãƒ ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PINã¯ãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ãƒ–ãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "ã‚­ãƒ£ãƒ—ãƒãƒ£ã‚’å®Œäº†ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒåŒã˜ã‚²ãƒ¼ãƒ å†…ã«ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	public FriendsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æ‰¿èªã™ã‚‹";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "å‹é”ã‚’è¦‹ã¤ã‘ã‚‹";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "ç„¡è¦–ã™ã‚‹";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "ã™ã¹ã¦ç„¡è¦–ã™ã‚‹";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "å‹é”è§£é™¤";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"ä¸Šéƒ¨ã®è™«çœ¼é¡ã‚¢ã‚¤ã‚³ãƒ³ã‚’ã‚¿ãƒƒãƒ—ã—ã¦ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚’æ¤œç´¢ã™ã‚‹ã‹ã€{startLink}ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤{endLink}ã—ã¦ã€çŸ¥ã‚Šåˆã„ã«ãªã‚Šã¾ã—ã‚‡ã†ã€‚";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "ä¸Šéƒ¨ã®è™«çœ¼é¡ã‚¢ã‚¤ã‚³ãƒ³ã‚’ã‚¿ãƒƒãƒ—ã—ã¦ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚’æ¤œç´¢ã™ã‚‹ã‹ã€{startLink}ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤{endLink}ã—ã¦ã€çŸ¥ã‚Šåˆã„ã«ãªã‚Šã¾ã—ã‚‡ã†ã€‚";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "ã‚ãªãŸã®å‹é”";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username} ã•ã‚“ã®å‹é”";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username} ã•ã‚“ã®å‹é”";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¯ãƒ¼";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼ä¸­";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "å‹é”";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"ä¿ç•™ä¸­ã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã‚ã‚Šã¾ã›ã‚“ã€‚å‹é”ã‚’è¿½åŠ ã™ã‚‹ã«ã¯ã€ {startSpan}å‘¨è¾º{endSpan} ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "ä¿ç•™ä¸­ã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã‚ã‚Šã¾ã›ã‚“ã€‚å‹é”ã‚’è¿½åŠ ã™ã‚‹ã«ã¯ã€ {startSpan}å‘¨è¾º{endSpan} ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "å‹é”ã‚’æ¤œç´¢";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "ã‚¢ã‚¯ã‚·ãƒ§ãƒ³ãŒè¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "ã™ã§ã«ã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "ç„¡åŠ¹ãªãƒ‘ãƒ©ãƒ¡ãƒ¼ã‚¿ã§ã™ã€‚";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹å‰ã«ã€ã»ã‹ã®å‹é”ã‚’å‰Šé™¤ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "ã“ã®æ“ä½œã‚’ä½•åº¦ã‚‚å®Ÿè¡Œã—ã¦ã„ã¾ã™ã€‚1åˆ†ã»ã©å¾…ã£ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "ã‚ãªãŸã®ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã€‚";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "ã‚ãªãŸãŒã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã€‚ç¾åœ¨ã€ç™»éŒ²ã§ãã‚‹å‹é”ã®æ•°ãŒä¸Šé™ã«é”ã—ã¦ã„ã¾ã™ã€‚ ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "ã“ã‚Œä»¥ä¸Šã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹ã«ã¯ã€èª°ã‹ã‚’å‹é”è§£é™¤ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã€‚ç¾åœ¨ã€ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ç™»éŒ²ã§ãã‚‹å‹é”ã®æ•°ãŒä¸Šé™ã«é”ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "ã»ã‹ã®å‹é”ã‚’å‰Šé™¤ã™ã‚‹ã¾ã§ã€æ–°ã—ã„å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå­˜åœ¨ã—ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼äºŒäººãŒãŠäº’ã„ã«åŒæ„ã™ã‚Œã°ã€å‹é”ã«ãªã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "ã“ã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã€ã‚ãªãŸå®›ã¦ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "å‹é”ã®æ•°ãŒä¸Šé™ã‚’è¶…ãˆã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼äºŒäººãŒãŠäº’ã„ã«åŒæ„ã™ã‚Œã°ã€å‹é”ã«ãªã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Robloxã¯ã€å‹é”ã¨ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚Œã°ã€ã‚‚ã£ã¨ãŠæ¥½ã—ã¿ã„ãŸã ã‘ã¾ã™ï¼";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "è‡ªåˆ†ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "è‡ªåˆ†ã¨å‹é”ã«ãªã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "å‹é”ãŠã‚ˆã³ãƒ•ã‚©ãƒ­ãƒ¯ãƒ¼ã®ã‚·ã‚¹ãƒ†ãƒ ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PINã¯ãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ãƒ–ãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "ã‚­ãƒ£ãƒ—ãƒãƒ£ã‚’å®Œäº†ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒåŒã˜ã‚²ãƒ¼ãƒ å†…ã«ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}
}


}
