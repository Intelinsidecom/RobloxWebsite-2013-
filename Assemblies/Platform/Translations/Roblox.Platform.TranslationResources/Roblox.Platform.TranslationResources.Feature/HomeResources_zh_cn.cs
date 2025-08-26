namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_zh_cn : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "è¿”å›žé¡¶éƒ¨";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "äº†è§£æ›´å¤š";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "åˆ†äº«";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "æœ€è¿‘æ€Žä¹ˆæ ·ï¼Ÿ";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "åšå®¢æ¶ˆæ¯";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "å¥½å‹åŠ¨æ€";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "å¥½å‹";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "æˆ‘çš„æœ€çˆ±";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "æˆ‘çš„æŽ¨é€";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "æœ€è¿‘çŽ©è¿‡";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "åœ¨æ‰¾â€œæˆ‘çš„æŽ¨é€â€ï¼ŸçŽ°å·²æ”¹ä¸ºåœ¨ä¾§è¾¹æ æ˜¾ç¤ºã€‚";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "å…¬å‘Š";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "åˆ›ä½œæ¸¸æˆï¼Œèµšå–é‡‘é’±";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "æ­£åœ¨åˆ†äº«...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "æ— æ³•æ›´æ–°çŠ¶æ€ã€‚";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "æ›´æ–°ä¸èƒ½ä¸ºç©ºç™½ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "è¯·ç™»å½•ä½ çš„å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "ç³»ç»Ÿå‡ºçŽ°é—®é¢˜ï¼Œè¯·ç¨åŽé‡è¯•å¹¶è”ç³»æŠ€æœ¯æ”¯æŒã€‚";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "æ›´æ–°æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public HomeResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "è¿”å›žé¡¶éƒ¨";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "åˆ†äº«";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "æœ€è¿‘æ€Žä¹ˆæ ·ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "åšå®¢æ¶ˆæ¯";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "å¥½å‹åŠ¨æ€";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"å¥½å‹ï¼ˆ{friendCount} åï¼‰";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å¥½å‹ï¼ˆ{friendCount} åï¼‰";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "å¥½å‹";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "æˆ‘çš„æœ€çˆ±";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "æˆ‘çš„æŽ¨é€";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "æœ€è¿‘çŽ©è¿‡";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "åœ¨æ‰¾â€œæˆ‘çš„æŽ¨é€â€ï¼ŸçŽ°å·²æ”¹ä¸ºåœ¨ä¾§è¾¹æ æ˜¾ç¤ºã€‚";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "å…¬å‘Š";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "åˆ›ä½œæ¸¸æˆï¼Œèµšå–é‡‘é’±";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"ä½ å¥½ï¼Œ{username}ï¼";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "ä½ å¥½ï¼Œ{username}ï¼";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "æ­£åœ¨åˆ†äº«...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "æ— æ³•æ›´æ–°çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "æ›´æ–°ä¸èƒ½ä¸ºç©ºç™½ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "è¯·ç™»å½•ä½ çš„å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "ç³»ç»Ÿå‡ºçŽ°é—®é¢˜ï¼Œè¯·ç¨åŽé‡è¯•å¹¶è”ç³»æŠ€æœ¯æ”¯æŒã€‚";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "æ›´æ–°æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}
}


}
