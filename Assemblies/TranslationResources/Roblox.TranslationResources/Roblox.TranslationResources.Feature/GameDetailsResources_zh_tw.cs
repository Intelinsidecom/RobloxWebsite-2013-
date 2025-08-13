namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_zh_tw : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "在聊天室分享";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "說明";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "推薦的遊戲";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "介紹";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "允許複製";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "允許的裝備";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "創作者";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "複製";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "創作時間";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "實驗模式";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "設為最愛人數";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "此遊戲禁止複製。";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "沒有可用的虛擬道具或強化。";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "此遊戲限 Builders Club 會員遊玩";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "類別";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "排行榜";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "玩家上限";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "目前沒有正在執行的遊戲。";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "此遊戲的原始碼可複製。";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "正在玩";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "私人原始碼";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "此遊戲的原始碼設為私人";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "若勾選此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "開放原始碼";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "此遊戲的原始碼設為開放";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "伺服器";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "商店";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "更新時間";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "造訪次數";

	public GameDetailsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "在聊天室分享";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"若勾選此選項，{boldTagStart}您將授權其他 Roblox 使用者授以不同方式使用{boldTagEnd}您現在分享的內容。{boldTagStart2}若您不想進行授權，請勿勾選此方塊{boldTagEnd2}。若需更多資訊，請參考 Roblox {linkStart}使用條款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "若勾選此選項，{boldTagStart}您將授權其他 Roblox 使用者授以不同方式使用{boldTagEnd}您現在分享的內容。{boldTagStart2}若您不想進行授權，請勿勾選此方塊{boldTagEnd2}。若需更多資訊，請參考 Roblox {linkStart}使用條款{linkEnd}。";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "說明";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "推薦的遊戲";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "介紹";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "允許複製";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "允許的裝備";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "創作者";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// English String: "{byText} {creatorLink}"
	/// </summary>
	public override string LabelByCreator(string byText, string creatorLink)
	{
		return $"{byText}：{creatorLink}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{byText}：{creatorLink}";
	}

	protected override string _GetTemplateForLabelCopyingTitle()
	{
		return "複製";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "創作時間";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "實驗模式";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}此遊戲可能無法正確執行。{aTagEnd}開發人員需要更新遊戲。";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}此遊戲可能無法正確執行。{aTagEnd}開發人員需要更新遊戲。";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "設為最愛人數";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "此遊戲禁止複製。";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "沒有可用的虛擬道具或強化。";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "此遊戲限 Builders Club 會員遊玩";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "類別";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "排行榜";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "玩家上限";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "目前沒有正在執行的遊戲。";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "此遊戲的原始碼可複製。";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "正在玩";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "私人原始碼";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "此遊戲的原始碼設為私人";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "若勾選此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "開放原始碼";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "此遊戲的原始碼設為開放";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "伺服器";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "商店";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "更新時間";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "造訪次數";
	}
}
