namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionShareGameToChat => "åœ¨èŠå¤©å®¤åˆ†äº«";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "èªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "æŽ¨è–¦çš„éŠæˆ²";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ä»‹ç´¹";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "å…è¨±è¤‡è£½";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "å…è¨±çš„è£å‚™";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "å‰µä½œè€…";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "è¤‡è£½";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "å‰µä½œæ™‚é–“";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "å¯¦é©—æ¨¡å¼";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "è¨­ç‚ºæœ€æ„›äººæ•¸";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "æ­¤éŠæˆ²ç¦æ­¢è¤‡è£½ã€‚";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "æ²’æœ‰å¯ç”¨çš„è™›æ“¬é“å…·æˆ–å¼·åŒ–ã€‚";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "æ­¤éŠæˆ²é™ Builders Club æœƒå“¡éŠçŽ©";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "é¡žåˆ¥";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "æŽ’è¡Œæ¦œ";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "çŽ©å®¶ä¸Šé™";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "ç›®å‰æ²’æœ‰æ­£åœ¨åŸ·è¡Œçš„éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼å¯è¤‡è£½ã€‚";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "æ­£åœ¨çŽ©";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "ç§äººåŽŸå§‹ç¢¼";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼è¨­ç‚ºç§äºº";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "è‹¥å‹¾é¸æ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "é–‹æ”¾åŽŸå§‹ç¢¼";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼è¨­ç‚ºé–‹æ”¾";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "å•†åº—";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "æ›´æ–°æ™‚é–“";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "é€ è¨ªæ¬¡æ•¸";

	public GameDetailsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "åœ¨èŠå¤©å®¤åˆ†äº«";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"è‹¥å‹¾é¸æ­¤é¸é …ï¼Œ{boldTagStart}æ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨{boldTagEnd}æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚{boldTagStart2}è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Š{boldTagEnd2}ã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox {linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "è‹¥å‹¾é¸æ­¤é¸é …ï¼Œ{boldTagStart}æ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨{boldTagEnd}æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚{boldTagStart2}è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Š{boldTagEnd2}ã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox {linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "èªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "æŽ¨è–¦çš„éŠæˆ²";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ä»‹ç´¹";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "å…è¨±è¤‡è£½";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "å…è¨±çš„è£å‚™";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "å‰µä½œè€…";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// English String: "{byText} {creatorLink}"
	/// </summary>
	public override string LabelByCreator(string byText, string creatorLink)
	{
		return $"{byText}ï¼š{creatorLink}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{byText}ï¼š{creatorLink}";
	}

	protected override string _GetTemplateForLabelCopyingTitle()
	{
		return "è¤‡è£½";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "å‰µä½œæ™‚é–“";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "å¯¦é©—æ¨¡å¼";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}æ­¤éŠæˆ²å¯èƒ½ç„¡æ³•æ­£ç¢ºåŸ·è¡Œã€‚{aTagEnd}é–‹ç™¼äººå“¡éœ€è¦æ›´æ–°éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}æ­¤éŠæˆ²å¯èƒ½ç„¡æ³•æ­£ç¢ºåŸ·è¡Œã€‚{aTagEnd}é–‹ç™¼äººå“¡éœ€è¦æ›´æ–°éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "è¨­ç‚ºæœ€æ„›äººæ•¸";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "æ­¤éŠæˆ²ç¦æ­¢è¤‡è£½ã€‚";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "æ²’æœ‰å¯ç”¨çš„è™›æ“¬é“å…·æˆ–å¼·åŒ–ã€‚";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "æ­¤éŠæˆ²é™ Builders Club æœƒå“¡éŠçŽ©";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "æŽ’è¡Œæ¦œ";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "çŽ©å®¶ä¸Šé™";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "ç›®å‰æ²’æœ‰æ­£åœ¨åŸ·è¡Œçš„éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼å¯è¤‡è£½ã€‚";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "æ­£åœ¨çŽ©";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "ç§äººåŽŸå§‹ç¢¼";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼è¨­ç‚ºç§äºº";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "è‹¥å‹¾é¸æ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "é–‹æ”¾åŽŸå§‹ç¢¼";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "æ­¤éŠæˆ²çš„åŽŸå§‹ç¢¼è¨­ç‚ºé–‹æ”¾";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "å•†åº—";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "æ›´æ–°æ™‚é–“";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "é€ è¨ªæ¬¡æ•¸";
	}
}


}
