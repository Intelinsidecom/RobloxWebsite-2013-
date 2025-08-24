namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedsResources_ja_jp : FeedsResources_en_us, IFeedsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.BuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "自分で作ってみよう";

	/// <summary>
	/// Key: "Heading.CustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "アバターをカスタマイズ";

	/// <summary>
	/// Key: "Heading.ForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Robloxヘルプフォーラム";

	/// <summary>
	/// Key: "Heading.MakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "友達を作ろう";

	/// <summary>
	/// Key: "Heading.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "ゲームをプレイ";

	/// <summary>
	/// Key: "Label.NoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "今すぐ親友を作ろう。";

	/// <summary>
	/// Key: "Label.NoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "親友に関する最新情報はありません... 親友の状況を確認しますか？";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Robloxのほとんどのゲームは、あなたのようなプレイヤーが制作したものです。人気ゲームの一部をご紹介します:";

	public FeedsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "自分で作ってみよう";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "アバターをカスタマイズ";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Robloxヘルプフォーラム";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "友達を作ろう";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "ゲームをプレイ";
	}

	/// <summary>
	/// Key: "Label.BuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"ビルダーはマルチプレイヤー用の建築ゲームをプレイするのが大好きです。プロのビルダーがRoblox Studioや、あなたの{linkStart}開発ページ{linkEnd}のゲーム開発環境に興味を持ってくれるかもしれません。";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "ビルダーはマルチプレイヤー用の建築ゲームをプレイするのが大好きです。プロのビルダーがRoblox Studioや、あなたの{linkStart}開発ページ{linkEnd}のゲーム開発環境に興味を持ってくれるかもしれません。";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"{avatarLinkStart}アバターエディタ{avatarLinkEnd}にアクセスしてキャラクターをカスタマイズしよう。コスチュームは{catalogLinkStart}カタログ{catalogLinkEnd}で購入できます。";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "{avatarLinkStart}アバターエディタ{avatarLinkEnd}にアクセスしてキャラクターをカスタマイズしよう。コスチュームは{catalogLinkStart}カタログ{catalogLinkEnd}で購入できます。";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"{linkStart}カタログ{linkEnd} でコスチュームをゲットしてアバターをカスタマイズしよう。";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "{linkStart}カタログ{linkEnd} でコスチュームをゲットしてアバターをカスタマイズしよう。";
	}

	/// <summary>
	/// Key: "Label.ForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"どんなものを探す場合でも、Robloxに関連したものであれば、{linkStart}こちら{linkEnd}で話題に上ることがあります。";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "どんなものを探す場合でも、Robloxに関連したものであれば、{linkStart}こちら{linkEnd}で話題に上ることがあります。";
	}

	/// <summary>
	/// Key: "Label.MakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"ゲーム内で他のプレイヤーと知り合いになって友達リクエストを送ろう。タイミングを逃した場合でも、ユーザープロフィールで{linkStart}検索{linkEnd}して、いつでもまたリクエストできます。";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "ゲーム内で他のプレイヤーと知り合いになって友達リクエストを送ろう。タイミングを逃した場合でも、ユーザープロフィールで{linkStart}検索{linkEnd}して、いつでもまたリクエストできます。";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "今すぐ親友を作ろう。";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "親友に関する最新情報はありません... 親友の状況を確認しますか？";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Robloxのほとんどのゲームは、あなたのようなプレイヤーが制作したものです。人気ゲームの一部をご紹介します:";
	}
}
