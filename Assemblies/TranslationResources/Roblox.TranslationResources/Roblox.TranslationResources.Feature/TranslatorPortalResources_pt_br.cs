namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_pt_br : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "Denúncias";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "Traduzir";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "Baixe o relatório de contribuição de tradução";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "Portal do Tradutor";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "Criador";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nome do jogo";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "Jogos";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "Classificar por";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "Ordem alfabética";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "Favoritos";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "Nome do jogo";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "Andamento";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "Progresso (menor ao maior)";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "Progresso (maior ao menor)";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Pesquisar";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Ordenar por";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "Tradutor";

	public TranslatorPortalResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "Denúncias";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "Traduzir";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "Baixe o relatório de contribuição de tradução";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "Portal do Tradutor";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "Criador";
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
		return "Nome do jogo";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "Jogos";
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
		return $"Não há suporte para {languageName} neste jogo";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "Não há suporte para {languageName} neste jogo";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "Classificar por";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "Ordem alfabética";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "Nome do jogo";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "Andamento";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "Progresso (menor ao maior)";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "Progresso (maior ao menor)";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Pesquisar";
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
		return $"Progresso da tradução ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "Progresso da tradução ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Tradutor";
	}
}
