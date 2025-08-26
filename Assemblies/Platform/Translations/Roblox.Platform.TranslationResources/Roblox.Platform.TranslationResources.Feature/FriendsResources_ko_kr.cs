namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_ko_kr : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "ìˆ˜ë½";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "ì¹œêµ¬ ì°¾ê¸°";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "íŒ”ë¡œìš°";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "ê±°ì ˆ";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "ì „ì²´ ê±°ì ˆ";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "íŒ”ë¡œìš° ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "ì¹œêµ¬ ëŠê¸°";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "ë‚´ ì¹œêµ¬";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "íŒ”ë¡œì›Œ";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "íŒ”ë¡œìž‰";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "ì¹œêµ¬ ìš”ì²­";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "ì¹œêµ¬";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ì˜¤í”„ë¼ì¸";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ì˜¨ë¼ì¸";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "ìš”ì²­";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "ì¹œêµ¬ ê²€ìƒ‰";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "íŒ”ë¡œìš° ì·¨ì†Œë¨";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "í—ˆìš©ë˜ì§€ ì•Šì€ ìž‘ì—…";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "ì´ë¯¸ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "ìœ íš¨í•˜ì§€ ì•Šì€ ë§¤ê°œë³€ìˆ˜.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ì¹œêµ¬ ìš”ì²­ì„ ë” ë°›ìœ¼ë ¤ë©´ ë¨¼ì € ë‹¤ë¥¸ ë¶„ê³¼ ì¹œêµ¬ë¥¼ ëŠìœ¼ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "ê°™ì€ ìž‘ì—…ì„ ë„ˆë¬´ ìžì£¼ ë°˜ë³µí•˜ì…¨ë„¤ìš”. ìž ì‹œ ê¸°ë‹¤ë ¸ë‹¤ê°€ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "íšŒì›ë‹˜ì„ íŒ”ë¡œìš°í•˜ëŠ” ì‚¬ëžŒë“¤ì´ì—ìš”.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "íšŒì›ë‹˜ì´ íŒ”ë¡œìš°í•˜ëŠ” ì‚¬ëžŒë“¤ì´ì—ìš”.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "ëª‡ ë¶„ í›„ ë‹¤ì‹œ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "ìš”ì²­ ì²˜ë¦¬ ë¶ˆê°€. ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "ì¹œêµ¬ ìš”ì²­ì„ ë” ë°›ê³  ì‹¶ìœ¼ì‹œë©´ ë¨¼ì € ë‹¤ë¥¸ ë¶„ê³¼ ì¹œêµ¬ ëŠê¸°ë¥¼ í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "ìš”ì²­ ì²˜ë¦¬ ë¶ˆê°€. í•´ë‹¹ ì‚¬ìš©ìžê°€ ë“±ë¡í•œ ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í•˜ë ¤ë©´ ë¨¼ì € ìƒëŒ€ë°©ì´ ì¹œêµ¬ë¥¼ ì‚­ì œí•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "ì¹œêµ¬ ìš”ì²­ì´ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Roblox ì‚¬ìš©ìž ë‘ ëª…ì´ ì„œë¡œ ì¹œêµ¬ ë§ºê¸°ì— ë™ì˜í•´ì•¼ ì¹œêµ¬ ê´€ê³„ê°€ ì„±ë¦½ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "íšŒì›ë‹˜ì€ ë³¸ ì¹œêµ¬ ìš”ì²­ì˜ ìˆ˜ì‹ ìžê°€ ì•„ë‹™ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ë¥¼ ì´ˆê³¼í–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Roblox ì‚¬ìš©ìž ë‘ ëª…ì´ ì„œë¡œ ì¹œêµ¬ ë§ºê¸°ì— ë™ì˜í•´ì•¼ ì¹œêµ¬ ê´€ê³„ê°€ ì„±ë¦½ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "ì¹œêµ¬ì™€ í•¨ê»˜í•  ë•Œ ë”ìš± ì¦ê±°ìš´ Roblox!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "ìžê¸° ìžì‹ ì„ íŒ”ë¡œìš°í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "ìžê¸° ìžì‹ ê³¼ëŠ” ì¹œêµ¬ë¥¼ ë§ºì„ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "ì¹œêµ¬ ë° íŒ”ë¡œì›Œ ì‹œìŠ¤í…œì„ ì´ìš©í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN ì‚¬ìš©ì´ ì¤‘ì§€ë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "ì°¨ë‹¨ëœ ì‚¬ìš©ìžìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "ë³´ì•ˆ ë¬¸ìž ìž…ë ¥ì„ í†µê³¼í•´ì•¼ í•´ìš”.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "ì‚¬ìš©ìžë“¤ì´ ê°™ì€ ê²Œìž„ì— ì°¸ì—¬í•´ì•¼ í•´ìš”.";

	public FriendsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "ìˆ˜ë½";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "ì¹œêµ¬ ì°¾ê¸°";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "íŒ”ë¡œìš°";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "ê±°ì ˆ";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "ì „ì²´ ê±°ì ˆ";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "ì¹œêµ¬ ëŠê¸°";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"ìƒë‹¨ì˜ ë‹ë³´ê¸° ì•„ì´ì½˜ì„ ëˆŒëŸ¬ ì‚¬ìš©ìžë¥¼ ê²€ìƒ‰í•˜ê±°ë‚˜ {startLink}ê²Œìž„ í”Œë ˆì´{endLink}ë¥¼ í•˜ë©´ì„œ ì‚¬ëžŒë“¤ì„ ë§Œë‚˜ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "ìƒë‹¨ì˜ ë‹ë³´ê¸° ì•„ì´ì½˜ì„ ëˆŒëŸ¬ ì‚¬ìš©ìžë¥¼ ê²€ìƒ‰í•˜ê±°ë‚˜ {startLink}ê²Œìž„ í”Œë ˆì´{endLink}ë¥¼ í•˜ë©´ì„œ ì‚¬ëžŒë“¤ì„ ë§Œë‚˜ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "ë‚´ ì¹œêµ¬";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username}ë‹˜ì˜ ì¹œêµ¬";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username}ë‹˜ì˜ ì¹œêµ¬";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "íŒ”ë¡œì›Œ";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "íŒ”ë¡œìž‰";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "ì¹œêµ¬ ìš”ì²­";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "ì¹œêµ¬";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"ëŒ€ê¸° ì¤‘ì¸ ì¹œêµ¬ ìš”ì²­ì´ ì—†ìŠµë‹ˆë‹¤. ì¹œêµ¬ë¥¼ ì¶”ê°€í•˜ë ¤ë©´, {startSpan}ì£¼ë³€ í”Œë ˆì´ì–´ ì°¾ê¸°{endSpan}ë¥¼ ì‚´íŽ´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "ëŒ€ê¸° ì¤‘ì¸ ì¹œêµ¬ ìš”ì²­ì´ ì—†ìŠµë‹ˆë‹¤. ì¹œêµ¬ë¥¼ ì¶”ê°€í•˜ë ¤ë©´, {startSpan}ì£¼ë³€ í”Œë ˆì´ì–´ ì°¾ê¸°{endSpan}ë¥¼ ì‚´íŽ´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ì˜¤í”„ë¼ì¸";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ì˜¨ë¼ì¸";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "ìš”ì²­";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "ì¹œêµ¬ ê²€ìƒ‰";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "íŒ”ë¡œìš° ì·¨ì†Œë¨";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "í—ˆìš©ë˜ì§€ ì•Šì€ ìž‘ì—…";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "ì´ë¯¸ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ë§¤ê°œë³€ìˆ˜.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ì¹œêµ¬ ìš”ì²­ì„ ë” ë°›ìœ¼ë ¤ë©´ ë¨¼ì € ë‹¤ë¥¸ ë¶„ê³¼ ì¹œêµ¬ë¥¼ ëŠìœ¼ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "ê°™ì€ ìž‘ì—…ì„ ë„ˆë¬´ ìžì£¼ ë°˜ë³µí•˜ì…¨ë„¤ìš”. ìž ì‹œ ê¸°ë‹¤ë ¸ë‹¤ê°€ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "íšŒì›ë‹˜ì„ íŒ”ë¡œìš°í•˜ëŠ” ì‚¬ëžŒë“¤ì´ì—ìš”.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "íšŒì›ë‹˜ì´ íŒ”ë¡œìš°í•˜ëŠ” ì‚¬ëžŒë“¤ì´ì—ìš”.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "ëª‡ ë¶„ í›„ ë‹¤ì‹œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "ìš”ì²­ ì²˜ë¦¬ ë¶ˆê°€. ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "ì¹œêµ¬ ìš”ì²­ì„ ë” ë°›ê³  ì‹¶ìœ¼ì‹œë©´ ë¨¼ì € ë‹¤ë¥¸ ë¶„ê³¼ ì¹œêµ¬ ëŠê¸°ë¥¼ í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "ìš”ì²­ ì²˜ë¦¬ ë¶ˆê°€. í•´ë‹¹ ì‚¬ìš©ìžê°€ ë“±ë¡í•œ ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í•˜ë ¤ë©´ ë¨¼ì € ìƒëŒ€ë°©ì´ ì¹œêµ¬ë¥¼ ì‚­ì œí•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "ì¹œêµ¬ ìš”ì²­ì´ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Roblox ì‚¬ìš©ìž ë‘ ëª…ì´ ì„œë¡œ ì¹œêµ¬ ë§ºê¸°ì— ë™ì˜í•´ì•¼ ì¹œêµ¬ ê´€ê³„ê°€ ì„±ë¦½ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "íšŒì›ë‹˜ì€ ë³¸ ì¹œêµ¬ ìš”ì²­ì˜ ìˆ˜ì‹ ìžê°€ ì•„ë‹™ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ë¥¼ ì´ˆê³¼í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Roblox ì‚¬ìš©ìž ë‘ ëª…ì´ ì„œë¡œ ì¹œêµ¬ ë§ºê¸°ì— ë™ì˜í•´ì•¼ ì¹œêµ¬ ê´€ê³„ê°€ ì„±ë¦½ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "ì¹œêµ¬ì™€ í•¨ê»˜í•  ë•Œ ë”ìš± ì¦ê±°ìš´ Roblox!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "ìžê¸° ìžì‹ ì„ íŒ”ë¡œìš°í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "ìžê¸° ìžì‹ ê³¼ëŠ” ì¹œêµ¬ë¥¼ ë§ºì„ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "ì¹œêµ¬ ë° íŒ”ë¡œì›Œ ì‹œìŠ¤í…œì„ ì´ìš©í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN ì‚¬ìš©ì´ ì¤‘ì§€ë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "ì°¨ë‹¨ëœ ì‚¬ìš©ìžìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "ë³´ì•ˆ ë¬¸ìž ìž…ë ¥ì„ í†µê³¼í•´ì•¼ í•´ìš”.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "ì‚¬ìš©ìžë“¤ì´ ê°™ì€ ê²Œìž„ì— ì°¸ì—¬í•´ì•¼ í•´ìš”.";
	}
}


}
