namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_zh_cjv : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "åˆ†äº«è‡³èŠå¤©çª—å£";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "æè¿°";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "æŽ¨èæ¸¸æˆ";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "å…³äºŽ";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "å…è®¸å¤åˆ¶";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "å…è®¸è£…å¤‡";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "ä½œè€…";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "æ­£åœ¨å¤åˆ¶";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "åˆ›å»ºæ—¶é—´";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "å®žéªŒæ¨¡å¼";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "è®¾ä¸ºæœ€çˆ±äººæ•°";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "æ­¤æ¸¸æˆç¦æ­¢å¤åˆ¶ã€‚";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "æ— å¯ç”¨çš„è™šæ‹Ÿç‰©å“åŠå‡çº§é“å…·ã€‚";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "æ­¤æ¸¸æˆä»…é™ Builders Club ä¼šå‘˜";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "ä¸»é¢˜";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "æŽ’è¡Œæ¦œ";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "çŽ©å®¶äººæ•°ä¸Šé™";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "ç›®å‰æ²¡æœ‰è¿è¡Œä¸­çš„æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "æ­¤æ¸¸æˆçš„æºä»£ç å¯å¤åˆ¶ã€‚";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "æ­£åœ¨æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "ç§äººæºä»£ç ";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "æ­¤æ¸¸æˆçš„æºä»£ç ä¸ºç§äºº";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "å¦‚æžœé€‰ä¸­æ­¤å¤é€‰æ¡†ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ·ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "å…¬å…±æºä»£ç ";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "æ­¤æ¸¸æˆçš„æºä»£ç ä¸ºå…¬å¼€";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "å•†åº—";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "æ›´æ–°æ—¶é—´";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "è®¿é—®æ¬¡æ•°";

	public GameDetailsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "åˆ†äº«è‡³èŠå¤©çª—å£";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"å¦‚æžœé€‰ä¸­æ­¤å¤é€‰æ¡†ï¼Œ{boldTagStart}å³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· {boldTagEnd}ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚{boldTagStart2}å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚{boldTagEnd2}å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox {linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "å¦‚æžœé€‰ä¸­æ­¤å¤é€‰æ¡†ï¼Œ{boldTagStart}å³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· {boldTagEnd}ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚{boldTagStart2}å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚{boldTagEnd2}å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox {linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "æè¿°";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "æŽ¨èæ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "å…³äºŽ";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "å…è®¸å¤åˆ¶";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "å…è®¸è£…å¤‡";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "ä½œè€…";
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
		return "æ­£åœ¨å¤åˆ¶";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "åˆ›å»ºæ—¶é—´";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "å®žéªŒæ¨¡å¼";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}æ­¤æ¸¸æˆå¯èƒ½æ— æ³•æŒ‰é¢„æœŸè¿è¡Œã€‚{aTagEnd}å¼€å‘è€…éœ€è¦æ›´æ–°æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}æ­¤æ¸¸æˆå¯èƒ½æ— æ³•æŒ‰é¢„æœŸè¿è¡Œã€‚{aTagEnd}å¼€å‘è€…éœ€è¦æ›´æ–°æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "è®¾ä¸ºæœ€çˆ±äººæ•°";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "æ­¤æ¸¸æˆç¦æ­¢å¤åˆ¶ã€‚";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "æ— å¯ç”¨çš„è™šæ‹Ÿç‰©å“åŠå‡çº§é“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "æ­¤æ¸¸æˆä»…é™ Builders Club ä¼šå‘˜";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "ä¸»é¢˜";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "æŽ’è¡Œæ¦œ";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "çŽ©å®¶äººæ•°ä¸Šé™";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "ç›®å‰æ²¡æœ‰è¿è¡Œä¸­çš„æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "æ­¤æ¸¸æˆçš„æºä»£ç å¯å¤åˆ¶ã€‚";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "æ­£åœ¨æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "ç§äººæºä»£ç ";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "æ­¤æ¸¸æˆçš„æºä»£ç ä¸ºç§äºº";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "å¦‚æžœé€‰ä¸­æ­¤å¤é€‰æ¡†ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ·ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "å…¬å…±æºä»£ç ";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "æ­¤æ¸¸æˆçš„æºä»£ç ä¸ºå…¬å¼€";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "å•†åº—";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "æ›´æ–°æ—¶é—´";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "è®¿é—®æ¬¡æ•°";
	}
}


}
