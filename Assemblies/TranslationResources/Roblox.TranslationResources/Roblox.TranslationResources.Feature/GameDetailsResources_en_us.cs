using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameDetailsResources_en_us : TranslationResourcesBase, IGameDetailsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public virtual string ActionShareGameToChat => "Share to chat";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public virtual string HeadingDescription => "Description";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public virtual string HeadingRecommendedGames => "Recommended Games";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public virtual string LabelAbout => "About";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public virtual string LabelAllowCopyingCheckbox => "Allow Copying";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public virtual string LabelAllowedGear => "Allowed Gear";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public virtual string LabelBy => "By";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public virtual string LabelCopyingTitle => "Copying";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public virtual string LabelCreated => "Created";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public virtual string LabelExperimentalMode => "Experimental Mode";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public virtual string LabelFavorites => "Favorites";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public virtual string LabelGameCopyLocked => "This game is copylocked";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public virtual string LabelGameDoesNotSell => "No virtual items or power-ups available.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public virtual string LabelGameRequiresBuildersClub => "This Game requires Builders Club";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public virtual string LabelGenre => "Genre";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public virtual string LabelLeaderboards => "Leaderboards";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public virtual string LabelMaxPlayers => "Max Players";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public virtual string LabelNoRunningGames => "There are currently no running games.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public virtual string LabelPlaceCopyingAllowed => "This game's source can be copied.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public virtual string LabelPlaying => "Playing";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public virtual string LabelPrivateSource => "Private Source";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public virtual string LabelPrivateSourceDescription => "This game's source is private";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public virtual string LabelPublicPrivateSourceCheckBox => "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public virtual string LabelPublicSource => "Public Source";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public virtual string LabelPublicSourceDescription => "This game's source is public";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string LabelReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public virtual string LabelServers => "Servers";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public virtual string LabelStore => "Store";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public virtual string LabelUpdated => "Updated";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public virtual string LabelVisits => "Visits";

	public GameDetailsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ShareGameToChat",
				_GetTemplateForActionShareGameToChat()
			},
			{
				"Description.AllowCopyingDisclaimer",
				_GetTemplateForDescriptionAllowCopyingDisclaimer()
			},
			{
				"Heading.Description",
				_GetTemplateForHeadingDescription()
			},
			{
				"Heading.RecommendedGames",
				_GetTemplateForHeadingRecommendedGames()
			},
			{
				"Label.About",
				_GetTemplateForLabelAbout()
			},
			{
				"Label.AllowCopyingCheckbox",
				_GetTemplateForLabelAllowCopyingCheckbox()
			},
			{
				"Label.AllowedGear",
				_GetTemplateForLabelAllowedGear()
			},
			{
				"Label.By",
				_GetTemplateForLabelBy()
			},
			{
				"Label.ByCreator",
				_GetTemplateForLabelByCreator()
			},
			{
				"Label.CopyingTitle",
				_GetTemplateForLabelCopyingTitle()
			},
			{
				"Label.Created",
				_GetTemplateForLabelCreated()
			},
			{
				"Label.ExperimentalMode",
				_GetTemplateForLabelExperimentalMode()
			},
			{
				"Label.ExperimentalWarning",
				_GetTemplateForLabelExperimentalWarning()
			},
			{
				"Label.Favorites",
				_GetTemplateForLabelFavorites()
			},
			{
				"Label.GameCopyLocked",
				_GetTemplateForLabelGameCopyLocked()
			},
			{
				"Label.GameDoesNotSell",
				_GetTemplateForLabelGameDoesNotSell()
			},
			{
				"Label.GameRequiresBuildersClub",
				_GetTemplateForLabelGameRequiresBuildersClub()
			},
			{
				"Label.Genre",
				_GetTemplateForLabelGenre()
			},
			{
				"Label.Leaderboards",
				_GetTemplateForLabelLeaderboards()
			},
			{
				"Label.MaxPlayers",
				_GetTemplateForLabelMaxPlayers()
			},
			{
				"Label.NoRunningGames",
				_GetTemplateForLabelNoRunningGames()
			},
			{
				"Label.PlaceCopyingAllowed",
				_GetTemplateForLabelPlaceCopyingAllowed()
			},
			{
				"Label.Playing",
				_GetTemplateForLabelPlaying()
			},
			{
				"Label.PrivateSource",
				_GetTemplateForLabelPrivateSource()
			},
			{
				"Label.PrivateSourceDescription",
				_GetTemplateForLabelPrivateSourceDescription()
			},
			{
				"Label.PublicPrivateSourceCheckBox",
				_GetTemplateForLabelPublicPrivateSourceCheckBox()
			},
			{
				"Label.PublicSource",
				_GetTemplateForLabelPublicSource()
			},
			{
				"Label.PublicSourceDescription",
				_GetTemplateForLabelPublicSourceDescription()
			},
			{
				"Label.ReportAbuse",
				_GetTemplateForLabelReportAbuse()
			},
			{
				"Label.Servers",
				_GetTemplateForLabelServers()
			},
			{
				"Label.Store",
				_GetTemplateForLabelStore()
			},
			{
				"Label.Updated",
				_GetTemplateForLabelUpdated()
			},
			{
				"Label.Visits",
				_GetTemplateForLabelVisits()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameDetails";
	}

	protected virtual string _GetTemplateForActionShareGameToChat()
	{
		return "Share to chat";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public virtual string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}.";
	}

	protected virtual string _GetTemplateForHeadingDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForHeadingRecommendedGames()
	{
		return "Recommended Games";
	}

	protected virtual string _GetTemplateForLabelAbout()
	{
		return "About";
	}

	protected virtual string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "Allow Copying";
	}

	protected virtual string _GetTemplateForLabelAllowedGear()
	{
		return "Allowed Gear";
	}

	protected virtual string _GetTemplateForLabelBy()
	{
		return "By";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// English String: "{byText} {creatorLink}"
	/// </summary>
	public virtual string LabelByCreator(string byText, string creatorLink)
	{
		return $"{byText} {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelByCreator()
	{
		return "{byText} {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelCopyingTitle()
	{
		return "Copying";
	}

	protected virtual string _GetTemplateForLabelCreated()
	{
		return "Created";
	}

	protected virtual string _GetTemplateForLabelExperimentalMode()
	{
		return "Experimental Mode";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public virtual string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game.";
	}

	protected virtual string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game.";
	}

	protected virtual string _GetTemplateForLabelFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForLabelGameCopyLocked()
	{
		return "This game is copylocked";
	}

	protected virtual string _GetTemplateForLabelGameDoesNotSell()
	{
		return "No virtual items or power-ups available.";
	}

	protected virtual string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "This Game requires Builders Club";
	}

	protected virtual string _GetTemplateForLabelGenre()
	{
		return "Genre";
	}

	protected virtual string _GetTemplateForLabelLeaderboards()
	{
		return "Leaderboards";
	}

	protected virtual string _GetTemplateForLabelMaxPlayers()
	{
		return "Max Players";
	}

	protected virtual string _GetTemplateForLabelNoRunningGames()
	{
		return "There are currently no running games.";
	}

	protected virtual string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "This game's source can be copied.";
	}

	protected virtual string _GetTemplateForLabelPlaying()
	{
		return "Playing";
	}

	protected virtual string _GetTemplateForLabelPrivateSource()
	{
		return "Private Source";
	}

	protected virtual string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "This game's source is private";
	}

	protected virtual string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box.";
	}

	protected virtual string _GetTemplateForLabelPublicSource()
	{
		return "Public Source";
	}

	protected virtual string _GetTemplateForLabelPublicSourceDescription()
	{
		return "This game's source is public";
	}

	protected virtual string _GetTemplateForLabelReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForLabelServers()
	{
		return "Servers";
	}

	protected virtual string _GetTemplateForLabelStore()
	{
		return "Store";
	}

	protected virtual string _GetTemplateForLabelUpdated()
	{
		return "Updated";
	}

	protected virtual string _GetTemplateForLabelVisits()
	{
		return "Visits";
	}
}
