namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_zh_cn : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "分享至聊天窗口";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "描述";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "推荐游戏";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "关于";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "允许复制";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "允许装备";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "作者";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "正在复制";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "创建时间";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "实验模式";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "设为最爱人数";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "此游戏禁止复制。";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "无可用的虚拟物品及升级道具。";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "此游戏仅限 Builders Club 会员";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "主题";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "排行榜";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "玩家人数上限";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "目前没有运行中的游戏。";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "此游戏的源代码可复制。";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "正在游戏";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "私人源代码";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "此游戏的源代码为私人";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "如果选中此复选框，即表示你同意授权其他 Roblox 用户（以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "公共源代码";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "此游戏的源代码为公开";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "服务器";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "商店";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "更新时间";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "访问次数";

	public GameDetailsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "分享至聊天窗口";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"如果选中此复选框，{boldTagStart}即表示你同意授权其他 Roblox 用户 {boldTagEnd}（以各种方式）使用你现在分享的内容。{boldTagStart2}如果你不想进行此项授权，请勿选中此框。{boldTagEnd2}如需更多关于分享内容的信息，请参阅 Roblox {linkStart}使用条款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "如果选中此复选框，{boldTagStart}即表示你同意授权其他 Roblox 用户 {boldTagEnd}（以各种方式）使用你现在分享的内容。{boldTagStart2}如果你不想进行此项授权，请勿选中此框。{boldTagEnd2}如需更多关于分享内容的信息，请参阅 Roblox {linkStart}使用条款{linkEnd}。";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "描述";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "推荐游戏";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "关于";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "允许复制";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "允许装备";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "作者";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// English String: "{byText} {creatorLink}"
	/// </summary>
	public override string LabelByCreator(string byText, string creatorLink)
	{
		return $"{byText} {creatorLink}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{byText} {creatorLink}";
	}

	protected override string _GetTemplateForLabelCopyingTitle()
	{
		return "正在复制";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "创建时间";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "实验模式";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}此游戏可能无法按预期运行。{aTagEnd}开发者需要更新游戏。";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}此游戏可能无法按预期运行。{aTagEnd}开发者需要更新游戏。";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "设为最爱人数";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "此游戏禁止复制。";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "无可用的虚拟物品及升级道具。";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "此游戏仅限 Builders Club 会员";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "主题";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "排行榜";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "玩家人数上限";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "目前没有运行中的游戏。";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "此游戏的源代码可复制。";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "正在游戏";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "私人源代码";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "此游戏的源代码为私人";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "如果选中此复选框，即表示你同意授权其他 Roblox 用户（以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "公共源代码";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "此游戏的源代码为公开";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "服务器";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "商店";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "更新时间";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "访问次数";
	}
}
