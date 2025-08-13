namespace Roblox.TranslationResources.Feature;

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
	public override string ActionReports => "報告";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public override string ActionTranslate => "翻訳する";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public override string HeadingDownloadTranslationContributionReport => "翻訳者の貢献レポートをダウンロード";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public override string HeadingTranslatorPortal => "翻訳者ポータル";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelCreator => "クリエーター";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ゲーム名";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public override string LabelGames => "ゲーム";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public override string LabelOrderBy => "並び替え：";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelOrderByAlphabetical => "アルファベット順";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelOrderByFavorites => "お気に入り";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelOrderByGameName => "ゲーム名";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public override string LabelOrderByProgress => "進行状況";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public override string LabelOrderByProgressAsc => "進行度（低い順）";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public override string LabelOrderByProgressDesc => "進行度（高い順）";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "検索";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "並べ替え";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public override string LabelTranslator => "翻訳者";

	public TranslatorPortalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionReports()
	{
		return "報告";
	}

	protected override string _GetTemplateForActionTranslate()
	{
		return "翻訳する";
	}

	protected override string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "翻訳者の貢献レポートをダウンロード";
	}

	protected override string _GetTemplateForHeadingTranslatorPortal()
	{
		return "翻訳者ポータル";
	}

	protected override string _GetTemplateForLabelCreator()
	{
		return "クリエーター";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public override string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"作： {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameCreator()
	{
		return "作： {linkStart}{creatorName}{linkEnd}";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ゲーム名";
	}

	protected override string _GetTemplateForLabelGames()
	{
		return "ゲーム";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public override string LabelGroupName(string groupName)
	{
		return $"グループ： {groupName}";
	}

	protected override string _GetTemplateForLabelGroupName()
	{
		return "グループ： {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public override string LabelGroupRole(string role, string groupName)
	{
		return $"{groupName} の {role}";
	}

	protected override string _GetTemplateForLabelGroupRole()
	{
		return "{groupName} の {role}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public override string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"このゲームは {languageName} に対応していません";
	}

	protected override string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "このゲームは {languageName} に対応していません";
	}

	protected override string _GetTemplateForLabelOrderBy()
	{
		return "並び替え：";
	}

	protected override string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "アルファベット順";
	}

	protected override string _GetTemplateForLabelOrderByFavorites()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForLabelOrderByGameName()
	{
		return "ゲーム名";
	}

	protected override string _GetTemplateForLabelOrderByProgress()
	{
		return "進行状況";
	}

	protected override string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "進行度（低い順）";
	}

	protected override string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "進行度（高い順）";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "検索";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "並べ替え";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public override string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"翻訳の進行状況 ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslationProgress()
	{
		return "翻訳の進行状況 ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "翻訳者";
	}
}
