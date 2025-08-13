using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PlacesListResources_en_us : TranslationResourcesBase, IPlacesListResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public virtual string ActionJoinGame => "Join";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public virtual string ActionViewDetails => "View Details";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public virtual string LabelContextMenuTitle => "Game";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public virtual string LabelPlacesListName => "Games";

	public PlacesListResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.JoinGame",
				_GetTemplateForActionJoinGame()
			},
			{
				"Action.SeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"Action.ViewDetails",
				_GetTemplateForActionViewDetails()
			},
			{
				"Label.ContextMenuTitle",
				_GetTemplateForLabelContextMenuTitle()
			},
			{
				"Label.CreatorBy",
				_GetTemplateForLabelCreatorBy()
			},
			{
				"Label.PlacesListName",
				_GetTemplateForLabelPlacesListName()
			},
			{
				"Label.PlayingPhrase",
				_GetTemplateForLabelPlayingPhrase()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PlacesList";
	}

	protected virtual string _GetTemplateForActionJoinGame()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForActionViewDetails()
	{
		return "View Details";
	}

	protected virtual string _GetTemplateForLabelContextMenuTitle()
	{
		return "Game";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public virtual string LabelCreatorBy(string creatorLink)
	{
		return $"By {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelCreatorBy()
	{
		return "By {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelPlacesListName()
	{
		return "Games";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public virtual string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} Playing";
	}

	protected virtual string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} Playing";
	}
}
