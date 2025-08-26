namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_ja_jp : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "ãƒˆãƒƒãƒ—ã«æˆ»ã‚‹";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "ã‚‚ã£ã¨è©³ã—ã";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ã™ã¹ã¦è¦‹ã‚‹";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "ã‚·ã‚§ã‚¢";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "ä½•ã‚’ã—ã¦ã„ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "ãƒ–ãƒ­ã‚°ãƒ‹ãƒ¥ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "å‹é”ã®ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "å‹é”";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "ã‚ãªãŸã®ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "ãƒžã‚¤ãƒ•ã‚£ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "æœ€è¿‘ãƒ—ãƒ¬ã‚¤ã—ãŸã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "ãƒžã‚¤ãƒ•ã‚£ãƒ¼ãƒ‰ã‚’ãŠæŽ¢ã—ã§ã™ã‹ï¼Ÿã‚µã‚¤ãƒ‰ãƒ¡ãƒ‹ãƒ¥ãƒ¼ã«è¡¨ç¤ºã•ã‚Œã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "å‘ŠçŸ¥";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ãŠé‡‘ã‚’ç¨¼ã”ã†";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "ã‚·ã‚§ã‚¢ã—ã¦ã„ã¾ã™...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "çŠ¶æ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "ã‚·ã‚¹ãƒ†ãƒ ã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚å•é¡ŒãŒå†ç™ºã™ã‚‹å ´åˆã¯ã€ã‚µãƒãƒ¼ãƒˆã¾ã§ã”é€£çµ¡ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public HomeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "ãƒˆãƒƒãƒ—ã«æˆ»ã‚‹";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "ã‚‚ã£ã¨è©³ã—ã";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ã™ã¹ã¦è¦‹ã‚‹";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "ã‚·ã‚§ã‚¢";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "ä½•ã‚’ã—ã¦ã„ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "ãƒ–ãƒ­ã‚°ãƒ‹ãƒ¥ãƒ¼ã‚¹";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "å‹é”ã®ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"å‹é”ï¼ˆ{friendCount} äººï¼‰";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å‹é”ï¼ˆ{friendCount} äººï¼‰";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "å‹é”";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "ã‚ãªãŸã®ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "ãƒžã‚¤ãƒ•ã‚£ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "æœ€è¿‘ãƒ—ãƒ¬ã‚¤ã—ãŸã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "ãƒžã‚¤ãƒ•ã‚£ãƒ¼ãƒ‰ã‚’ãŠæŽ¢ã—ã§ã™ã‹ï¼Ÿã‚µã‚¤ãƒ‰ãƒ¡ãƒ‹ãƒ¥ãƒ¼ã«è¡¨ç¤ºã•ã‚Œã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "å‘ŠçŸ¥";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ãŠé‡‘ã‚’ç¨¼ã”ã†";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"ã“ã‚“ã«ã¡ã¯ã€{username}ã•ã‚“ï¼";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "ã“ã‚“ã«ã¡ã¯ã€{username}ã•ã‚“ï¼";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "ã‚·ã‚§ã‚¢ã—ã¦ã„ã¾ã™...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "çŠ¶æ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "ã‚·ã‚¹ãƒ†ãƒ ã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚å•é¡ŒãŒå†ç™ºã™ã‚‹å ´åˆã¯ã€ã‚µãƒãƒ¼ãƒˆã¾ã§ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
