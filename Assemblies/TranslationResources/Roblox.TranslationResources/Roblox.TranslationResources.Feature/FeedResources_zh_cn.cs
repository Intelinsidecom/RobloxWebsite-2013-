namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_zh_cn : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "发挥创造力";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "自定义你的虚拟形象";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "前往 Roblox 论坛寻求帮助";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "结交好友";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "玩游戏";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "立即认识新朋友。";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "没有你好友的消息... 想知道他们在做什么吗？";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "几乎所有的 Roblox 游戏都是由和你一样的玩家创作的。这里是我们最爱的几个游戏：";

	public FeedResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "发挥创造力";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "自定义你的虚拟形象";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "前往 Roblox 论坛寻求帮助";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "结交好友";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "玩游戏";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"你会在 Roblox 中发现许多深受大家欢迎的多人建造游戏。专业的创建者可以前往{linkStart}创建页面{linkEnd}，了解我们的游戏开发环境 Roblox Studio。";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "你会在 Roblox 中发现许多深受大家欢迎的多人建造游戏。专业的创建者可以前往{linkStart}创建页面{linkEnd}，了解我们的游戏开发环境 Roblox Studio。";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"访问{avatarLinkStart}虚拟形象页面{avatarLinkEnd}，自定义你的虚拟形象。在{catalogLinkStart}商店{catalogLinkEnd}中获得新服装。";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "访问{avatarLinkStart}虚拟形象页面{avatarLinkEnd}，自定义你的虚拟形象。在{catalogLinkStart}商店{catalogLinkEnd}中获得新服装。";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"在{linkStart}商店{linkEnd}中获取新服装，自定义你的虚拟形象。";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "在{linkStart}商店{linkEnd}中获取新服装，自定义你的虚拟形象。";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"无论你要找什么，只要与 Roblox 相关，就有人在{linkStart}此处{linkEnd}讨论。";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "无论你要找什么，只要与 Roblox 相关，就有人在{linkStart}此处{linkEnd}讨论。";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"在游戏中认识其他玩家，并向他们发出好友邀请。如果你错过了机会，不用担心，你可以随时通过{linkStart}搜索{linkEnd}该玩家的个人资料，再向他们发出好友邀请。";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "在游戏中认识其他玩家，并向他们发出好友邀请。如果你错过了机会，不用担心，你可以随时通过{linkStart}搜索{linkEnd}该玩家的个人资料，再向他们发出好友邀请。";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "立即认识新朋友。";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "没有你好友的消息... 想知道他们在做什么吗？";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "几乎所有的 Roblox 游戏都是由和你一样的玩家创作的。这里是我们最爱的几个游戏：";
	}
}
