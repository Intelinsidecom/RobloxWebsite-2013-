namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_ja_jp : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "å ±å‘Š";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "ç¿»è¨³ã™ã‚‹";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "ç¿»è¨³è€…ã®è²¢çŒ®ãƒ¬ãƒãƒ¼ãƒˆã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "ç¿»è¨³è€…ãƒãƒ¼ã‚¿ãƒ«";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ã‚²ãƒ¼ãƒ å";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "ä¸¦ã³æ›¿ãˆï¼š";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "ã‚¢ãƒ«ãƒ•ã‚¡ãƒ™ãƒƒãƒˆé †";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "ã‚²ãƒ¼ãƒ å";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "é€²è¡ŒçŠ¶æ³";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "é€²è¡Œåº¦ï¼ˆä½Žã„é †ï¼‰";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "é€²è¡Œåº¦ï¼ˆé«˜ã„é †ï¼‰";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "æ¤œç´¢";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "ä¸¦ã¹æ›¿ãˆ";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "ç¿»è¨³è€…";

	public TranslatorPortalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "å ±å‘Š";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "ç¿»è¨³ã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "ç¿»è¨³è€…ã®è²¢çŒ®ãƒ¬ãƒãƒ¼ãƒˆã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "ç¿»è¨³è€…ãƒãƒ¼ã‚¿ãƒ«";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"ä½œï¼š {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "ä½œï¼š {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ã‚²ãƒ¼ãƒ å";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "ã‚²ãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"ã‚°ãƒ«ãƒ¼ãƒ—ï¼š {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ï¼š {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{groupName} ã® {role}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{groupName} ã® {role}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ {languageName} ã«å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ {languageName} ã«å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "ä¸¦ã³æ›¿ãˆï¼š";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "ã‚¢ãƒ«ãƒ•ã‚¡ãƒ™ãƒƒãƒˆé †";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "ã‚²ãƒ¼ãƒ å";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "é€²è¡ŒçŠ¶æ³";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "é€²è¡Œåº¦ï¼ˆä½Žã„é †ï¼‰";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "é€²è¡Œåº¦ï¼ˆé«˜ã„é †ï¼‰";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "æ¤œç´¢";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "ä¸¦ã¹æ›¿ãˆ";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"ç¿»è¨³ã®é€²è¡ŒçŠ¶æ³ ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "ç¿»è¨³ã®é€²è¡ŒçŠ¶æ³ ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "ç¿»è¨³è€…";
	}
}


}
