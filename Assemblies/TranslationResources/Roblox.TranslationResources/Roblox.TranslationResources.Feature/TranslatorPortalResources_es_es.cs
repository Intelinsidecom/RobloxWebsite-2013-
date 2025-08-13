namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_es_es : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "Informes";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "Traducir";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "Descargar informe de contribuciones del traductor";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "Portal del traductor";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "Creador";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nombre del juego";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "Juegos";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "Ordenar por";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "En orden alfabético";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "Favoritos";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "Nombre del juego";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "Avance";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "Avance (de poco a mucho)";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "Avance (de mucho a poco)";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Buscar";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Ordenar por";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "Traductor";

	public TranslatorPortalResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "Informes";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "Traducir";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "Descargar informe de contribuciones del traductor";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "Portal del traductor";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "Creador";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"De {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "De {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nombre del juego";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "Juegos";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"Grupo: {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "Grupo: {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{role} de {groupName}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{role} de {groupName}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $" El {languageName} no está disponible para este juego";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return " El {languageName} no está disponible para este juego";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "Ordenar por";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "En orden alfabético";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "Nombre del juego";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "Avance";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "Avance (de poco a mucho)";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "Avance (de mucho a poco)";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Buscar";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Ordenar por";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"Avance en la traducción ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "Avance en la traducción ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Traductor";
	}
}
