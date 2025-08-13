namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedsResources_zh_tw : FeedsResources_en_us, IFeedsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.BuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "開始創作";

	/// <summary>
	/// Key: "Heading.CustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "自訂您的虛擬人偶";

	/// <summary>
	/// Key: "Heading.ForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "瀏覽 Roblox 論壇取得協助";

	/// <summary>
	/// Key: "Heading.MakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "結交好友";

	/// <summary>
	/// Key: "Heading.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "玩遊戲";

	/// <summary>
	/// Key: "Label.NoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "現在開始結交好友。";

	/// <summary>
	/// Key: "Label.NoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "沒有您的好友的消息…想知道您的好友在做什麼嗎？";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Roblox 遊戲幾乎都是由像您一樣的玩家創作。以下是幾個我們最愛的遊戲：";

	public FeedsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "開始創作";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "自訂您的虛擬人偶";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "瀏覽 Roblox 論壇取得協助";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "結交好友";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "玩遊戲";
	}

	/// <summary>
	/// Key: "Label.BuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"建築家都喜歡玩我們的多人建造遊戲。專業建築家可以前往{linkStart}開發頁面{linkEnd}看看我們的遊戲開發環境 Roblox Studio。";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "建築家都喜歡玩我們的多人建造遊戲。專業建築家可以前往{linkStart}開發頁面{linkEnd}看看我們的遊戲開發環境 Roblox Studio。";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"前往{avatarLinkStart}虛擬人偶編輯器{avatarLinkEnd}自訂您的角色，或前往{catalogLinkStart}型錄{catalogLinkEnd}購買服裝。";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "前往{avatarLinkStart}虛擬人偶編輯器{avatarLinkEnd}自訂您的角色，或前往{catalogLinkStart}型錄{catalogLinkEnd}購買服裝。";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"從{linkStart}型錄{linkEnd}取得新服裝，自訂您的虛擬人偶";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "從{linkStart}型錄{linkEnd}取得新服裝，自訂您的虛擬人偶";
	}

	/// <summary>
	/// Key: "Label.ForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"不管您在找什麼，只要和 Roblox 有關，就有人在{linkStart}這裡{linkEnd}討論。";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "不管您在找什麼，只要和 Roblox 有關，就有人在{linkStart}這裡{linkEnd}討論。";
	}

	/// <summary>
	/// Key: "Label.MakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"在遊戲中與其他玩家相會，並向對方傳送好友邀請。若您已離開遊戲，您可以{linkStart}搜尋{linkEnd}該玩家的個人檔案，再傳送邀請。";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "在遊戲中與其他玩家相會，並向對方傳送好友邀請。若您已離開遊戲，您可以{linkStart}搜尋{linkEnd}該玩家的個人檔案，再傳送邀請。";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "現在開始結交好友。";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "沒有您的好友的消息…想知道您的好友在做什麼嗎？";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Roblox 遊戲幾乎都是由像您一樣的玩家創作。以下是幾個我們最愛的遊戲：";
	}
}
