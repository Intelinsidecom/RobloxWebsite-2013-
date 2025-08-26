namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_zh_tw : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "å›žåˆ°é ‚ç«¯";

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
	public override string ActionWhatAreYouUpto => "æ‚¨æƒ³åšä»€éº¼ï¼Ÿ";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "éƒ¨è½æ ¼æ¶ˆæ¯";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "å¥½å‹å‹•æ…‹";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "å¥½å‹";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "æˆ‘çš„æœ€æ„›";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "æˆ‘çš„é¥‹é€";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "æœ€è¿‘çŽ©éŽ";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "åœ¨æ‰¾æˆ‘çš„é¥‹é€ï¼Ÿè«‹å‰å¾€å´é¸å–®";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "å…¬å‘Š";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "å‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "æ­£åœ¨åˆ†äº«â€¦";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "å‹•æ…‹æ›´æ–°å¤±æ•—ã€‚";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "æ›´æ–°ä¸å¯ç©ºç™½ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "è«‹ç™»å…¥æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "ç³»çµ±å‡ºç¾å•é¡Œã€‚è«‹ç¨å¾Œå†è©¦ï¼Œä¸¦è¯çµ¡å®¢æœäººå“¡ã€‚";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "æ›´æ–°æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public HomeResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "å›žåˆ°é ‚ç«¯";
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
		return "æ‚¨æƒ³åšä»€éº¼ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "éƒ¨è½æ ¼æ¶ˆæ¯";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "å¥½å‹å‹•æ…‹";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"å¥½å‹ï¼ˆ{friendCount}ï¼‰";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å¥½å‹ï¼ˆ{friendCount}ï¼‰";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "å¥½å‹";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "æˆ‘çš„æœ€æ„›";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "æˆ‘çš„é¥‹é€";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "æœ€è¿‘çŽ©éŽ";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "åœ¨æ‰¾æˆ‘çš„é¥‹é€ï¼Ÿè«‹å‰å¾€å´é¸å–®";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "å…¬å‘Š";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "å‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"{username}ï¼Œæ‚¨å¥½ï¼";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "{username}ï¼Œæ‚¨å¥½ï¼";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "æ­£åœ¨åˆ†äº«â€¦";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "å‹•æ…‹æ›´æ–°å¤±æ•—ã€‚";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "æ›´æ–°ä¸å¯ç©ºç™½ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "è«‹ç™»å…¥æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "ç³»çµ±å‡ºç¾å•é¡Œã€‚è«‹ç¨å¾Œå†è©¦ï¼Œä¸¦è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "æ›´æ–°æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
