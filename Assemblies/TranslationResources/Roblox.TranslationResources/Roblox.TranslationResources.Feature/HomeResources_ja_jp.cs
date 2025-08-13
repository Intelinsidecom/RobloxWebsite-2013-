namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBackToTop => "トップに戻る";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "もっと詳しく";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "すべて見る";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "もっと見る";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "シェア";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "何をしていますか？";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "ブログニュース";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "友達のアクティビティ";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "友達";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "あなたのお気に入り";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "マイフィード";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "最近プレイしたゲーム";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "マイフィードをお探しですか？サイドメニューに表示されています";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "告知";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "ゲームを制作してお金を稼ごう";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "シェアしています...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "状況をアップデートできませんでした。";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "アップデートは空白にできません。もう一度お試しください";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "アカウントにログインしてください。";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "システムに問題があります。後でもう一度お試しください。問題が再発する場合は、サポートまでご連絡ください。";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "アップデートが多すぎます。後でもう一度お試しください。";

	public HomeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "トップに戻る";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "もっと詳しく";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "すべて見る";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "シェア";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "何をしていますか？";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "ブログニュース";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "友達のアクティビティ";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"友達（{friendCount} 人）";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "友達（{friendCount} 人）";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "友達";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "あなたのお気に入り";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "マイフィード";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "最近プレイしたゲーム";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "マイフィードをお探しですか？サイドメニューに表示されています";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "告知";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "ゲームを制作してお金を稼ごう";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"こんにちは、{username}さん！";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "こんにちは、{username}さん！";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "シェアしています...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "状況をアップデートできませんでした。";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "アップデートは空白にできません。もう一度お試しください";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "アカウントにログインしてください。";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "システムに問題があります。後でもう一度お試しください。問題が再発する場合は、サポートまでご連絡ください。";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "アップデートが多すぎます。後でもう一度お試しください。";
	}
}
