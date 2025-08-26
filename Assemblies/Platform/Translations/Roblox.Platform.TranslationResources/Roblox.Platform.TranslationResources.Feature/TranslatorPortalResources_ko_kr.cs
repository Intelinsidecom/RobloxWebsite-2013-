namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_ko_kr : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "ì‹ ê³ ";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "ë²ˆì—­í•˜ê¸°";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "ë²ˆì—­ ê¸°ì—¬ë„ ë³´ê³ ì„œ ë‹¤ìš´ë¡œë“œ";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "ë²ˆì—­ìž í¬í„¸";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "ê°œë°œìž";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ê²Œìž„ ì´ë¦„";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "ê²Œìž„";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "ì •ë ¬ ê¸°ì¤€";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "ì•ŒíŒŒë²³ ìˆœ";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "ê²Œìž„ ì´ë¦„";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "ì§„í–‰";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "ë‚®ì€ ì§„í–‰ë¥  ìˆœ";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "ë†’ì€ ì§„í–‰ë¥  ìˆœ";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "ê²€ìƒ‰";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "ì •ë ¬ ê¸°ì¤€";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "ë²ˆì—­ìž";

	public TranslatorPortalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "ì‹ ê³ ";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "ë²ˆì—­í•˜ê¸°";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "ë²ˆì—­ ê¸°ì—¬ë„ ë³´ê³ ì„œ ë‹¤ìš´ë¡œë“œ";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "ë²ˆì—­ìž í¬í„¸";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "ê°œë°œìž";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"ì œìž‘: {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "ì œìž‘: {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ê²Œìž„ ì´ë¦„";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "ê²Œìž„";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"ê·¸ë£¹: {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "ê·¸ë£¹: {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{role} / {groupName}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{role} / {groupName}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"ì´ ê²Œìž„ì€ {languageName}ë¥¼ ì§€ì›í•˜ì§€ ì•Šì•„ìš”";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "ì´ ê²Œìž„ì€ {languageName}ë¥¼ ì§€ì›í•˜ì§€ ì•Šì•„ìš”";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "ì •ë ¬ ê¸°ì¤€";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "ì•ŒíŒŒë²³ ìˆœ";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "ê²Œìž„ ì´ë¦„";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "ì§„í–‰";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "ë‚®ì€ ì§„í–‰ë¥  ìˆœ";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "ë†’ì€ ì§„í–‰ë¥  ìˆœ";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "ê²€ìƒ‰";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "ì •ë ¬ ê¸°ì¤€";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"ë²ˆì—­ ì§„í–‰ ìƒí™© ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "ë²ˆì—­ ì§„í–‰ ìƒí™© ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "ë²ˆì—­ìž";
	}
}


}
