namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_ko_kr : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "ë§¨ ìœ„ë¡œ ëŒì•„ê°€ê¸°";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "ë” ì•Œì•„ë³´ê¸°";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "ê³µìœ ";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "ë¬´ì—‡ì„ í•˜ê³  ì‹¶ë‚˜ìš”?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "ë¸”ë¡œê·¸ ìƒˆì†Œì‹";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "ê°œë°œìž í™˜ì „";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "ì¹œêµ¬ í™œë™";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "ì¹œêµ¬";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "ë‚´ ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "ë‚´ í”¼ë“œ";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "ìµœê·¼ í”Œë ˆì´í•œ ê²Œìž„";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "ë‚´ í”¼ë“œë¥¼ ì°¾ìœ¼ì‹œë‚˜ìš”? ì‚¬ì´ë“œ ë©”ë‰´ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "ê³µì§€";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "ê³µìœ  ì¤‘...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "ìƒíƒœ ì—…ë°ì´íŠ¸ ì‹¤íŒ¨.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "ì—…ë°ì´íŠ¸ëž€ì— ìž…ë ¥ì„ í•˜ì…”ì•¼ í•©ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "ì—…ë°ì´íŠ¸ ê°€ëŠ¥ íšŸìˆ˜ ì´ˆê³¼. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public HomeResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "ë§¨ ìœ„ë¡œ ëŒì•„ê°€ê¸°";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "ë” ì•Œì•„ë³´ê¸°";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "ê³µìœ ";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "ë¬´ì—‡ì„ í•˜ê³  ì‹¶ë‚˜ìš”?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "ë¸”ë¡œê·¸ ìƒˆì†Œì‹";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "ê°œë°œìž í™˜ì „";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "ì¹œêµ¬ í™œë™";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"ì¹œêµ¬ ({friendCount}ëª…)";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "ì¹œêµ¬ ({friendCount}ëª…)";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "ì¹œêµ¬";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "ë‚´ ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "ë‚´ í”¼ë“œ";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "ìµœê·¼ í”Œë ˆì´í•œ ê²Œìž„";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "ë‚´ í”¼ë“œë¥¼ ì°¾ìœ¼ì‹œë‚˜ìš”? ì‚¬ì´ë“œ ë©”ë‰´ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "ê³µì§€";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"{username} ë‹˜, ì•ˆë…•í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "{username} ë‹˜, ì•ˆë…•í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "ê³µìœ  ì¤‘...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "ìƒíƒœ ì—…ë°ì´íŠ¸ ì‹¤íŒ¨.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "ì—…ë°ì´íŠ¸ëž€ì— ìž…ë ¥ì„ í•˜ì…”ì•¼ í•©ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "ì—…ë°ì´íŠ¸ ê°€ëŠ¥ íšŸìˆ˜ ì´ˆê³¼. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
