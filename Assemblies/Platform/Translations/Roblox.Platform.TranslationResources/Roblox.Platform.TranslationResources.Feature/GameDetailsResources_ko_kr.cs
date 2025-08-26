namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_ko_kr : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "ê³µìœ  ë° ì±„íŒ…";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "ì„¤ëª…";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "ì¶”ì²œ ê²Œìž„";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ì†Œê°œ";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "ë³µì‚¬ í—ˆìš©";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "í—ˆìš©ëœ ìž¥ë¹„";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "ê°œë°œ:";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "ë³µì‚¬ ì¤‘";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "ê°œë°œ ì™„ë£Œ";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "ì‹¤í—˜ ëª¨ë“œ";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "ë³µì œ ë°©ì§€ëœ ê²Œìž„ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "ì´ìš© ê°€ëŠ¥í•œ ê°€ìƒ ì•„ì´í…œì´ë‚˜ íŒŒì›Œì—…ì´ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "ë³¸ ê²Œìž„ì€ Builders Clubì´ í•„ìš”í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "ìž¥ë¥´";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "ë¦¬ë”ë³´ë“œ";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "ìµœëŒ€ ì¸ì›";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "í˜„ìž¬ ì‹¤í–‰ ì¤‘ì¸ ê²Œìž„ì´ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "ë³¸ ê²Œìž„ì˜ ì†ŒìŠ¤ëŠ” ë³µì‚¬í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "í”Œë ˆì´ ì¤‘";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "ë¹„ê³µê°œ ì†ŒìŠ¤";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "ì†ŒìŠ¤ê°€ ë¹„ê³µê°œì¸ ê²Œìž„ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ ì•½ê´€ì— ë”°ë¼ íšŒì›ë‹˜ì˜ ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒ í•´ì œí•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "ê³µê°œ ì†ŒìŠ¤";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "ì†ŒìŠ¤ê°€ ê³µê°œì¸ ê²Œìž„ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ì„œë²„";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "ìƒì ";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "ë°©ë¬¸";

	public GameDetailsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "ê³µìœ  ë° ì±„íŒ…";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ {boldTagStart}Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤{boldTagEnd}. {boldTagStart2}ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”{boldTagEnd2}. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox {linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ {boldTagStart}Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤{boldTagEnd}. {boldTagStart2}ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”{boldTagEnd2}. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox {linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "ì„¤ëª…";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "ì¶”ì²œ ê²Œìž„";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ì†Œê°œ";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "ë³µì‚¬ í—ˆìš©";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "í—ˆìš©ëœ ìž¥ë¹„";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "ê°œë°œ:";
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
		return "ë³µì‚¬ ì¤‘";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "ê°œë°œ ì™„ë£Œ";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "ì‹¤í—˜ ëª¨ë“œ";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ê²Œìž„ì´ ì œëŒ€ë¡œ ìž‘ë™í•˜ì§€ ì•Šì„ ìˆ˜ë„ ìžˆì–´ìš”.{aTagEnd} ê°œë°œìžê°€ ê²Œìž„ì„ ì—…ë°ì´íŠ¸í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ê²Œìž„ì´ ì œëŒ€ë¡œ ìž‘ë™í•˜ì§€ ì•Šì„ ìˆ˜ë„ ìžˆì–´ìš”.{aTagEnd} ê°œë°œìžê°€ ê²Œìž„ì„ ì—…ë°ì´íŠ¸í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "ë³µì œ ë°©ì§€ëœ ê²Œìž„ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "ì´ìš© ê°€ëŠ¥í•œ ê°€ìƒ ì•„ì´í…œì´ë‚˜ íŒŒì›Œì—…ì´ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "ë³¸ ê²Œìž„ì€ Builders Clubì´ í•„ìš”í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "ìž¥ë¥´";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "ë¦¬ë”ë³´ë“œ";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "ìµœëŒ€ ì¸ì›";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "í˜„ìž¬ ì‹¤í–‰ ì¤‘ì¸ ê²Œìž„ì´ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "ë³¸ ê²Œìž„ì˜ ì†ŒìŠ¤ëŠ” ë³µì‚¬í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "í”Œë ˆì´ ì¤‘";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "ë¹„ê³µê°œ ì†ŒìŠ¤";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "ì†ŒìŠ¤ê°€ ë¹„ê³µê°œì¸ ê²Œìž„ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ ì•½ê´€ì— ë”°ë¼ íšŒì›ë‹˜ì˜ ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒ í•´ì œí•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "ê³µê°œ ì†ŒìŠ¤";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "ì†ŒìŠ¤ê°€ ê³µê°œì¸ ê²Œìž„ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ì„œë²„";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "ìƒì ";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "ë°©ë¬¸";
	}
}


}
