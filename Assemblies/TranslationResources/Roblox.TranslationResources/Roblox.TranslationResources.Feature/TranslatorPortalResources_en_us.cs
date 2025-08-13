using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class TranslatorPortalResources_en_us : TranslationResourcesBase, ITranslatorPortalResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Reports"
	/// English String: "Reports"
	/// </summary>
	public virtual string ActionReports => "Reports";

	/// <summary>
	/// Key: "Action.Translate"
	/// button text
	/// English String: "Translate"
	/// </summary>
	public virtual string ActionTranslate => "Translate";

	/// <summary>
	/// Key: "Heading.DownloadTranslationContributionReport"
	/// modal window heading
	/// English String: "Download Translation Contribution Report"
	/// </summary>
	public virtual string HeadingDownloadTranslationContributionReport => "Download Translation Contribution Report";

	/// <summary>
	/// Key: "Heading.TranslatorPortal"
	/// English String: "Translator Portal"
	/// </summary>
	public virtual string HeadingTranslatorPortal => "Translator Portal";

	/// <summary>
	/// Key: "Label.Creator"
	/// English String: "Creator"
	/// </summary>
	public virtual string LabelCreator => "Creator";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public virtual string LabelGameName => "Game Name";

	/// <summary>
	/// Key: "Label.Games"
	/// English String: "Games"
	/// </summary>
	public virtual string LabelGames => "Games";

	/// <summary>
	/// Key: "Label.OrderBy"
	/// English String: "Order By"
	/// </summary>
	public virtual string LabelOrderBy => "Order By";

	/// <summary>
	/// Key: "Label.OrderByAlphabetical"
	/// English String: "Alphabetical"
	/// </summary>
	public virtual string LabelOrderByAlphabetical => "Alphabetical";

	/// <summary>
	/// Key: "Label.OrderByFavorites"
	/// English String: "Favorites"
	/// </summary>
	public virtual string LabelOrderByFavorites => "Favorites";

	/// <summary>
	/// Key: "Label.OrderByGameName"
	/// English String: "Game Name"
	/// </summary>
	public virtual string LabelOrderByGameName => "Game Name";

	/// <summary>
	/// Key: "Label.OrderByProgress"
	/// English String: "Progress"
	/// </summary>
	public virtual string LabelOrderByProgress => "Progress";

	/// <summary>
	/// Key: "Label.OrderByProgressAsc"
	/// translation percent progress of a game
	/// English String: "Progress (Low to High)"
	/// </summary>
	public virtual string LabelOrderByProgressAsc => "Progress (Low to High)";

	/// <summary>
	/// Key: "Label.OrderByProgressDesc"
	/// translation percent progress of a game
	/// English String: "Progress (High to Low)"
	/// </summary>
	public virtual string LabelOrderByProgressDesc => "Progress (High to Low)";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public virtual string LabelSearch => "Search";

	/// <summary>
	/// Key: "Label.SortBy"
	/// English String: "Sort By"
	/// </summary>
	public virtual string LabelSortBy => "Sort By";

	/// <summary>
	/// Key: "Label.Translator"
	/// English String: "Translator"
	/// </summary>
	public virtual string LabelTranslator => "Translator";

	public TranslatorPortalResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Reports",
				_GetTemplateForActionReports()
			},
			{
				"Action.Translate",
				_GetTemplateForActionTranslate()
			},
			{
				"Heading.DownloadTranslationContributionReport",
				_GetTemplateForHeadingDownloadTranslationContributionReport()
			},
			{
				"Heading.TranslatorPortal",
				_GetTemplateForHeadingTranslatorPortal()
			},
			{
				"Label.Creator",
				_GetTemplateForLabelCreator()
			},
			{
				"Label.GameCreator",
				_GetTemplateForLabelGameCreator()
			},
			{
				"Label.GameName",
				_GetTemplateForLabelGameName()
			},
			{
				"Label.Games",
				_GetTemplateForLabelGames()
			},
			{
				"Label.GroupName",
				_GetTemplateForLabelGroupName()
			},
			{
				"Label.GroupRole",
				_GetTemplateForLabelGroupRole()
			},
			{
				"Label.LanguageNotSupportedByGame",
				_GetTemplateForLabelLanguageNotSupportedByGame()
			},
			{
				"Label.OrderBy",
				_GetTemplateForLabelOrderBy()
			},
			{
				"Label.OrderByAlphabetical",
				_GetTemplateForLabelOrderByAlphabetical()
			},
			{
				"Label.OrderByFavorites",
				_GetTemplateForLabelOrderByFavorites()
			},
			{
				"Label.OrderByGameName",
				_GetTemplateForLabelOrderByGameName()
			},
			{
				"Label.OrderByProgress",
				_GetTemplateForLabelOrderByProgress()
			},
			{
				"Label.OrderByProgressAsc",
				_GetTemplateForLabelOrderByProgressAsc()
			},
			{
				"Label.OrderByProgressDesc",
				_GetTemplateForLabelOrderByProgressDesc()
			},
			{
				"Label.Search",
				_GetTemplateForLabelSearch()
			},
			{
				"Label.SortBy",
				_GetTemplateForLabelSortBy()
			},
			{
				"Label.TranslationProgress",
				_GetTemplateForLabelTranslationProgress()
			},
			{
				"Label.Translator",
				_GetTemplateForLabelTranslator()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.TranslatorPortal";
	}

	protected virtual string _GetTemplateForActionReports()
	{
		return "Reports";
	}

	protected virtual string _GetTemplateForActionTranslate()
	{
		return "Translate";
	}

	protected virtual string _GetTemplateForHeadingDownloadTranslationContributionReport()
	{
		return "Download Translation Contribution Report";
	}

	protected virtual string _GetTemplateForHeadingTranslatorPortal()
	{
		return "Translator Portal";
	}

	protected virtual string _GetTemplateForLabelCreator()
	{
		return "Creator";
	}

	/// <summary>
	/// Key: "Label.GameCreator"
	/// English String: "By {linkStart}{creatorName}{linkEnd}"
	/// </summary>
	public virtual string LabelGameCreator(string linkStart, string creatorName, string linkEnd)
	{
		return $"By {linkStart}{creatorName}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelGameCreator()
	{
		return "By {linkStart}{creatorName}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelGameName()
	{
		return "Game Name";
	}

	protected virtual string _GetTemplateForLabelGames()
	{
		return "Games";
	}

	/// <summary>
	/// Key: "Label.GroupName"
	/// Will be used in a dropdown of list of groups
	/// English String: "Group: {groupName}"
	/// </summary>
	public virtual string LabelGroupName(string groupName)
	{
		return $"Group: {groupName}";
	}

	protected virtual string _GetTemplateForLabelGroupName()
	{
		return "Group: {groupName}";
	}

	/// <summary>
	/// Key: "Label.GroupRole"
	/// English String: "{role} of {groupName}"
	/// </summary>
	public virtual string LabelGroupRole(string role, string groupName)
	{
		return $"{role} of {groupName}";
	}

	protected virtual string _GetTemplateForLabelGroupRole()
	{
		return "{role} of {groupName}";
	}

	/// <summary>
	/// Key: "Label.LanguageNotSupportedByGame"
	/// English String: "{languageName} is not supported by this game"
	/// </summary>
	public virtual string LabelLanguageNotSupportedByGame(string languageName)
	{
		return $"{languageName} is not supported by this game";
	}

	protected virtual string _GetTemplateForLabelLanguageNotSupportedByGame()
	{
		return "{languageName} is not supported by this game";
	}

	protected virtual string _GetTemplateForLabelOrderBy()
	{
		return "Order By";
	}

	protected virtual string _GetTemplateForLabelOrderByAlphabetical()
	{
		return "Alphabetical";
	}

	protected virtual string _GetTemplateForLabelOrderByFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForLabelOrderByGameName()
	{
		return "Game Name";
	}

	protected virtual string _GetTemplateForLabelOrderByProgress()
	{
		return "Progress";
	}

	protected virtual string _GetTemplateForLabelOrderByProgressAsc()
	{
		return "Progress (Low to High)";
	}

	protected virtual string _GetTemplateForLabelOrderByProgressDesc()
	{
		return "Progress (High to Low)";
	}

	protected virtual string _GetTemplateForLabelSearch()
	{
		return "Search";
	}

	protected virtual string _GetTemplateForLabelSortBy()
	{
		return "Sort By";
	}

	/// <summary>
	/// Key: "Label.TranslationProgress"
	/// English String: "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})"
	/// </summary>
	public virtual string LabelTranslationProgress(string translatedEntriesCount, string totalEntriesCount)
	{
		return $"Translation Progress ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected virtual string _GetTemplateForLabelTranslationProgress()
	{
		return "Translation Progress ({translatedEntriesCount}/{totalEntriesCount})";
	}

	protected virtual string _GetTemplateForLabelTranslator()
	{
		return "Translator";
	}
}
