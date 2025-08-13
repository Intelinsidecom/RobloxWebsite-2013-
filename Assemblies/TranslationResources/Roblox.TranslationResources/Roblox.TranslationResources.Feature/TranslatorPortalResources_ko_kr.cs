namespace Roblox.TranslationResources.Feature;

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
	public override string ActionReports => "신고";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "번역하기";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "번역 기여도 보고서 다운로드";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "번역자 포털";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "개발자";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "게임 이름";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "게임";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "정렬 기준";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "알파벳 순";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "즐겨찾기";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "게임 이름";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "진행";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "낮은 진행률 순";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "높은 진행률 순";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "검색";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "정렬 기준";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "번역자";

	public TranslatorPortalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "신고";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "번역하기";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "번역 기여도 보고서 다운로드";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "번역자 포털";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "개발자";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"제작: {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "제작: {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "게임 이름";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "게임";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"그룹: {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "그룹: {groupName}";
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
		return $"이 게임은 {languageName}를 지원하지 않아요";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "이 게임은 {languageName}를 지원하지 않아요";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "정렬 기준";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "알파벳 순";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "게임 이름";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "진행";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "낮은 진행률 순";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "높은 진행률 순";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "검색";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "정렬 기준";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"번역 진행 상황 ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "번역 진행 상황 ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "번역자";
	}
}
