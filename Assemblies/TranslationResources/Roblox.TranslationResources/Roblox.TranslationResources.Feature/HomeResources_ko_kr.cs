namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBackToTop => "맨 위로 돌아가기";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "더 알아보기";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "전체 보기";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "더 보기";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "공유";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "무엇을 하고 싶나요?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "블로그 새소식";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "개발자 환전";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "친구 활동";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "친구";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "내 즐겨찾기";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "내 피드";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "최근 플레이한 게임";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "내 피드를 찾으시나요? 사이드 메뉴에서 확인하세요.";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "공지";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "게임 개발을 통해 수익 창출까지";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "공유 중...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "상태 업데이트 실패.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "업데이트란에 입력을 하셔야 합니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "회원님의 계정으로 로그인하세요.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "시스템 오류. 나중에 다시 시도하세요. 문제가 계속되면 고객지원으로 문의하세요.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "업데이트 가능 횟수 초과. 나중에 다시 시도하세요.";

	public HomeResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "맨 위로 돌아가기";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "더 알아보기";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "공유";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "무엇을 하고 싶나요?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "블로그 새소식";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "개발자 환전";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "친구 활동";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"친구 ({friendCount}명)";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "친구 ({friendCount}명)";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "친구";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "내 즐겨찾기";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "내 피드";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "최근 플레이한 게임";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "내 피드를 찾으시나요? 사이드 메뉴에서 확인하세요.";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "공지";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "게임 개발을 통해 수익 창출까지";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"{username} 님, 안녕하세요!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "{username} 님, 안녕하세요!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "공유 중...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "상태 업데이트 실패.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "업데이트란에 입력을 하셔야 합니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "회원님의 계정으로 로그인하세요.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "시스템 오류. 나중에 다시 시도하세요. 문제가 계속되면 고객지원으로 문의하세요.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "업데이트 가능 횟수 초과. 나중에 다시 시도하세요.";
	}
}
