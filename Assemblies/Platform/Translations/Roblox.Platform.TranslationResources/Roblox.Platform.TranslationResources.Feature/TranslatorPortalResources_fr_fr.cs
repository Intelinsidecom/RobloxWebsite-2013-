namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_fr_fr : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "Rapports";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "Traduire";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "Télécharger Compte rendu de traduction";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "Portail de traducteur";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "Créateur";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nom du jeu";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "Jeux";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "Ordre : ";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "Alphabétique";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "Favoris";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "Nom du jeu";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "Évolution";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "Progression (croissante)";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "Progression (décroissante)";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Rechercher";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Trier par";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "Traducteur";

	public TranslatorPortalResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "Rapports";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "Traduire";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "Télécharger Compte rendu de traduction";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "Portail de traducteur";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "Créateur";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"Par {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "Par {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nom du jeu";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "Jeux";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"Groupe\u00a0: {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "Groupe\u00a0: {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{role} sur {groupName}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{role} sur {groupName}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"Ce jeu n'a pas été traduit en : {languageName}";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "Ce jeu n'a pas été traduit en : {languageName}";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "Ordre : ";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "Alphabétique";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "Favoris";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "Nom du jeu";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "Évolution";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "Progression (croissante)";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "Progression (décroissante)";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Rechercher";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Trier par";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"Progression de la traduction ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "Progression de la traduction ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Traducteur";
	}
}
