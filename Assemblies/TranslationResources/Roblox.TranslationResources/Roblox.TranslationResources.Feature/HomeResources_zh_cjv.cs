namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_zh_cjv : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "返回顶部";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "了解更多";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "查看全部";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "查看更多";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "分享";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "最近怎么样？";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "博客消息";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "好友动态";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "好友";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "我的最爱";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "我的推送";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "最近玩过";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "在找“我的推送”？现已改为在侧边栏显示。";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "公告";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "创作游戏，赚取金钱";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "正在分享...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "无法更新状态。";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "更新不能为空白。请重试。";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "请登录你的帐户。";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "系统出现问题，请稍后重试并联系技术支持。";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "更新次数过多。请稍后重试。";

	public HomeResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "返回顶部";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "了解更多";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "查看全部";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "分享";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "最近怎么样？";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "博客消息";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "好友动态";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"好友（{friendCount} 名）";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "好友（{friendCount} 名）";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "好友";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "我的最爱";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "我的推送";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "最近玩过";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "在找“我的推送”？现已改为在侧边栏显示。";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "公告";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "创作游戏，赚取金钱";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"你好，{username}！";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "你好，{username}！";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "正在分享...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "无法更新状态。";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "更新不能为空白。请重试。";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "请登录你的帐户。";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "系统出现问题，请稍后重试并联系技术支持。";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "更新次数过多。请稍后重试。";
	}
}
