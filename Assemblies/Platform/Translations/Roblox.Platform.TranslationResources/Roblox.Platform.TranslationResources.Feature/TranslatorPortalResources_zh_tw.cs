namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_zh_tw : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
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
	public override string ActionTranslate => "ç¿»è­¯";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "ä¸‹è¼‰ç¿»è­¯è²¢ç»å ±å‘Š";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "è­¯è€…å¹³å°";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "å‰µä½œè€…";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "éŠæˆ²";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "æŽ’åºæ–¹å¼ï¼š";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "ä¾å­—æ¯æŽ’åº";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "å˜´æ„›";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "é€²åº¦";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "é€²åº¦ï¼ˆç”±ä½Žåˆ°é«˜ï¼‰";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "é€²åº¦ï¼ˆç”±é«˜åˆ°ä½Žï¼‰";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "æœå°‹";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "æŽ’åºæ–¹å¼";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "è­¯è€…";

	public TranslatorPortalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "å ±å‘Š";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "ç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "ä¸‹è¼‰ç¿»è­¯è²¢ç»å ±å‘Š";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "è­¯è€…å¹³å°";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "å‰µä½œè€…";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"å‰µä½œè€…ï¼š{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "å‰µä½œè€…ï¼š{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "éŠæˆ²";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"ç¾¤çµ„ï¼š{groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "ç¾¤çµ„ï¼š{groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{groupName} çš„ {role}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{groupName} çš„ {role}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"æ­¤éŠæˆ²ä¸æ”¯æ´{languageName}";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "æ­¤éŠæˆ²ä¸æ”¯æ´{languageName}";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "æŽ’åºæ–¹å¼ï¼š";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "ä¾å­—æ¯æŽ’åº";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "å˜´æ„›";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "é€²åº¦";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "é€²åº¦ï¼ˆç”±ä½Žåˆ°é«˜ï¼‰";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "é€²åº¦ï¼ˆç”±é«˜åˆ°ä½Žï¼‰";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "æœå°‹";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "æŽ’åºæ–¹å¼";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"ç¿»è­¯é€²åº¦ï¼ˆ{translatedEntriesCount}/{totalEntriesCount}ï¼‰";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "ç¿»è­¯é€²åº¦ï¼ˆ{translatedEntriesCount}/{totalEntriesCount}ï¼‰";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "è­¯è€…";
	}
}


}
