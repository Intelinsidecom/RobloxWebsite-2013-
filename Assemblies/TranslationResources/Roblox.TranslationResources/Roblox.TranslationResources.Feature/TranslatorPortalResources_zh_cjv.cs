namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslatorPortalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslatorPortalResources_zh_cjv : TranslatorPortalResources_en_us, ITranslatorPortalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public override string ActionReports => "报告";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "翻译";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "下载译者贡献报告";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "译者平台";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "创作者";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "游戏名称";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "游戏";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "排序方式：";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "按英文字母顺序";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "最爱";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "游戏名称";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "进度";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "进度（从低到高）";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "进度（从高到低）";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "搜索";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "排序依据";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "译者";

	public TranslatorPortalResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "报告";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "翻译";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "下载译者贡献报告";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "译者平台";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "创作者";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"创作者：{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "创作者：{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "游戏名称";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "游戏";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"群组：{groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "群组：{groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{groupName} 的 {role}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{groupName} 的 {role}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"此游戏不支持“{languageName}”";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "此游戏不支持“{languageName}”";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "排序方式：";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "按英文字母顺序";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "最爱";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "游戏名称";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "进度";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "进度（从低到高）";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "进度（从高到低）";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "搜索";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "排序依据";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"翻译进度（{translatedEntriesCount}/{totalEntriesCount}）";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "翻译进度（{translatedEntriesCount}/{totalEntriesCount}）";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "译者";
	}
}
