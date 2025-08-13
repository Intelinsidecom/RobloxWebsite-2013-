namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_ko_kr : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "만들어 보기";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "아바타 꾸미기";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Roblox 포럼에서 도움 얻기";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "친구 사귀기";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "게임 플레이";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "지금 바로 베스트 프렌드를 사귀어보세요.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "베스트 프렌드에 관한 새소식이 없네요... 베스트 프렌드 소식이 궁금하세요?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "여러분과 같은 플레이어들이 Roblox의 게임 대부분을 만든답니다. 재미난 게임 몇 가지를 구경해보세요.";

	public FeedResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "만들어 보기";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "아바타 꾸미기";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Roblox 포럼에서 도움 얻기";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "친구 사귀기";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "게임 플레이";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Roblox에는 재미난 멀티플레이어 건설 게임이 가득하죠. 직접 게임을 만들고 싶나요? {linkStart}개발 페이지{linkEnd}에서 Roblox의 게임 개발 환경인 Roblox Studio를 살펴보세요.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Roblox에는 재미난 멀티플레이어 건설 게임이 가득하죠. 직접 게임을 만들고 싶나요? {linkStart}개발 페이지{linkEnd}에서 Roblox의 게임 개발 환경인 Roblox Studio를 살펴보세요.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"{avatarLinkStart}아바타{avatarLinkEnd} 페이지를 방문하여 아바타를 마음껏 꾸며보세요. 새 복장은 {catalogLinkStart}카탈로그{catalogLinkEnd} 페이지에서 구입하실 수 있어요.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "{avatarLinkStart}아바타{avatarLinkEnd} 페이지를 방문하여 아바타를 마음껏 꾸며보세요. 새 복장은 {catalogLinkStart}카탈로그{catalogLinkEnd} 페이지에서 구입하실 수 있어요.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"{linkStart}카탈로그{linkEnd}에서 새 복장을 구매하여 아바타를 마음껏 꾸며보세요.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "{linkStart}카탈로그{linkEnd}에서 새 복장을 구매하여 아바타를 마음껏 꾸며보세요.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"Roblox에 관해 궁금한 점이 너무 많다구요? {linkStart}여기{linkEnd}에서 다른 사람들의 이야기를 들어보세요.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "Roblox에 관해 궁금한 점이 너무 많다구요? {linkStart}여기{linkEnd}에서 다른 사람들의 이야기를 들어보세요.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"게임에서 만난 다른 플레이어들에게 친구 요청을 보내보세요. 혹시 기회를 놓쳤다면 언제든 사용자 프로필을 {linkStart}검색{linkEnd}하여 친구 요청을 보낼 수 있습니다.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "게임에서 만난 다른 플레이어들에게 친구 요청을 보내보세요. 혹시 기회를 놓쳤다면 언제든 사용자 프로필을 {linkStart}검색{linkEnd}하여 친구 요청을 보낼 수 있습니다.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "지금 바로 베스트 프렌드를 사귀어보세요.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "베스트 프렌드에 관한 새소식이 없네요... 베스트 프렌드 소식이 궁금하세요?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "여러분과 같은 플레이어들이 Roblox의 게임 대부분을 만든답니다. 재미난 게임 몇 가지를 구경해보세요.";
	}
}
