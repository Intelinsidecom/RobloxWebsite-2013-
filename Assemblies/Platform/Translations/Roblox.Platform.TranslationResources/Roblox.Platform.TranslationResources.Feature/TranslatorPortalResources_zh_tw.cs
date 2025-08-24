namespace Roblox.TranslationResources.Feature;

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
	public override string ActionReports => "報告";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "翻譯";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "下載翻譯貢獻報告";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "譯者平台";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "創作者";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "遊戲名稱";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "遊戲";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "排序方式：";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "依字母排序";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "嘴愛";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "遊戲名稱";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "進度";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "進度（由低到高）";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "進度（由高到低）";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "搜尋";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "排序方式";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "譯者";

	public TranslatorPortalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "報告";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "翻譯";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "下載翻譯貢獻報告";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "譯者平台";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "創作者";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"創作者：{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "創作者：{linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "遊戲名稱";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "遊戲";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"群組：{groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "群組：{groupName}";
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
		return $"此遊戲不支援{languageName}";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "此遊戲不支援{languageName}";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "排序方式：";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "依字母排序";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "嘴愛";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "遊戲名稱";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "進度";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "進度（由低到高）";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "進度（由高到低）";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "搜尋";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "排序方式";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"翻譯進度（{translatedEntriesCount}/{totalEntriesCount}）";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "翻譯進度（{translatedEntriesCount}/{totalEntriesCount}）";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "譯者";
	}
}
