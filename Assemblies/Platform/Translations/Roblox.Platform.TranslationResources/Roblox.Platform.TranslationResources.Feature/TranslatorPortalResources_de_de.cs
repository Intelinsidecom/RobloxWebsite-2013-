namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_de_de : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "Berichte";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "Übersetzen";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "Übersetzer-Beitragsbericht herunterladen";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "Übersetzungsportal";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "Ersteller";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Spielname";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "Spiele";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "Ordnen nach";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "Alphabetisch";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "Favoriten";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "Spielname";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "Fortschritt";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "Fortschritt (niedrig bis hoch)";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "Fortschritt (Hoch bis niedrig)";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Suchen";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Sortieren nach";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "Übersetzer";

	public TranslatorPortalResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "Berichte";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "Übersetzen";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "Übersetzer-Beitragsbericht herunterladen";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "Übersetzungsportal";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "Ersteller";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"Von {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "Von {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Spielname";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "Spiele";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"Gruppe: {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "Gruppe: {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{role}\u00a0von {groupName}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{role}\u00a0von {groupName}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"{languageName} wird von diesem Spiel nicht unterstützt";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "{languageName} wird von diesem Spiel nicht unterstützt";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "Ordnen nach";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "Alphabetisch";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "Favoriten";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "Spielname";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "Fortschritt";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "Fortschritt (niedrig bis hoch)";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "Fortschritt (Hoch bis niedrig)";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Suchen";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Sortieren nach";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"Übersetzungsfortschritt ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "Übersetzungsfortschritt ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Übersetzer";
	}
}
