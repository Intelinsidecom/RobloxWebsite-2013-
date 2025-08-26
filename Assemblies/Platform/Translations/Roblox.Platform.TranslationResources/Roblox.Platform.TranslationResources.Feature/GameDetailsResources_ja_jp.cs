namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_ja_jp : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "ã‚·ã‚§ã‚¢ã—ã¦ãƒãƒ£ãƒƒãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "è©³ç´°";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "ãŠã™ã™ã‚ã®ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "æƒ…å ±";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "ã‚³ãƒ”ãƒ¼ã‚’è¨±å¯";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "è¨±å¯ã•ã‚ŒãŸã‚®ã‚¢";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "ä½œï¼š";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "ã‚³ãƒ”ãƒ¼ä¸­";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "ä½œæˆæ—¥";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "è©¦é¨“ãƒ¢ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "ã“ã®ã‚²ãƒ¼ãƒ ã¯ã‚³ãƒ”ãƒ¼ã‚¬ãƒ¼ãƒ‰ä»•æ§˜ã§ã™";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "ãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã‚„ãƒ‘ãƒ¯ãƒ¼ã‚¢ãƒƒãƒ—ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "ã“ã®ã‚²ãƒ¼ãƒ ã«ã¯Builders ClubãŒå¿…é ˆã§ã™";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "ã‚¸ãƒ£ãƒ³ãƒ«";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "ãƒªãƒ¼ãƒ€ãƒ¼ãƒœãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "æœ€å¤§ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼æ•°";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "å®Ÿè¡Œä¸­ã®ã‚²ãƒ¼ãƒ ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯ã‚³ãƒ”ãƒ¼ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "ãƒ—ãƒ¬ã‚¤ä¸­";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "éžå…¬é–‹ã‚½ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯éžå…¬é–‹ã§ã™";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "ã“ã®ãƒã‚§ãƒƒã‚¯ãƒœãƒƒã‚¯ã‚¹ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ãŸã¾ã¾ã«ã—ã¦ãŠãã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€åˆ©ç”¨è¦ç´„ã«åŸºã¥ãã€ç¾åœ¨ä½œæˆä¸­ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "å…¬é–‹ã‚½ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯å…¬é–‹ã•ã‚Œã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "ã‚¹ãƒˆã‚¢";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "è¨ªå•æ•°";

	public GameDetailsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "ã‚·ã‚§ã‚¢ã—ã¦ãƒãƒ£ãƒƒãƒˆã™ã‚‹";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"ã“ã®ãƒœãƒƒã‚¯ã‚¹ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã‚‹ã“ã¨ã§ã€{boldTagStart}ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„{boldTagEnd}ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚{boldTagStart2}æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚{boldTagEnd2}ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã®{linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "ã“ã®ãƒœãƒƒã‚¯ã‚¹ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã‚‹ã“ã¨ã§ã€{boldTagStart}ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„{boldTagEnd}ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚{boldTagStart2}æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚{boldTagEnd2}ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã®{linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "è©³ç´°";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "ãŠã™ã™ã‚ã®ã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "æƒ…å ±";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "ã‚³ãƒ”ãƒ¼ã‚’è¨±å¯";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "è¨±å¯ã•ã‚ŒãŸã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "ä½œï¼š";
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
		return "ã‚³ãƒ”ãƒ¼ä¸­";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "ä½œæˆæ—¥";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "è©¦é¨“ãƒ¢ãƒ¼ãƒ‰";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ã‚²ãƒ¼ãƒ ãŒæ­£ã—ãæ©Ÿèƒ½ã—ãªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚{aTagEnd}é–‹ç™ºè€…ã®ã‚²ãƒ¼ãƒ ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ã‚²ãƒ¼ãƒ ãŒæ­£ã—ãæ©Ÿèƒ½ã—ãªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚{aTagEnd}é–‹ç™ºè€…ã®ã‚²ãƒ¼ãƒ ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ã‚³ãƒ”ãƒ¼ã‚¬ãƒ¼ãƒ‰ä»•æ§˜ã§ã™";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "ãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã‚„ãƒ‘ãƒ¯ãƒ¼ã‚¢ãƒƒãƒ—ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã«ã¯Builders ClubãŒå¿…é ˆã§ã™";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "ã‚¸ãƒ£ãƒ³ãƒ«";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "ãƒªãƒ¼ãƒ€ãƒ¼ãƒœãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "æœ€å¤§ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼æ•°";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "å®Ÿè¡Œä¸­ã®ã‚²ãƒ¼ãƒ ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯ã‚³ãƒ”ãƒ¼ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "ãƒ—ãƒ¬ã‚¤ä¸­";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "éžå…¬é–‹ã‚½ãƒ¼ã‚¹";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯éžå…¬é–‹ã§ã™";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "ã“ã®ãƒã‚§ãƒƒã‚¯ãƒœãƒƒã‚¯ã‚¹ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ãŸã¾ã¾ã«ã—ã¦ãŠãã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€åˆ©ç”¨è¦ç´„ã«åŸºã¥ãã€ç¾åœ¨ä½œæˆä¸­ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "å…¬é–‹ã‚½ãƒ¼ã‚¹";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã¯å…¬é–‹ã•ã‚Œã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "ã‚¹ãƒˆã‚¢";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "è¨ªå•æ•°";
	}
}


}
