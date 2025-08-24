using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class RecommendationsResources_en_us : TranslationResourcesBase, IRecommendationsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item in exchange for in-game money.
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionBuy => "Buy";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy an item for free.
	/// English String: "Get"
	/// </summary>
	public virtual string ActionGet => "Get";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// Button used to see all items
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "Heading.RecommendationsTitle"
	/// heading for inventory page recommendations section.
	/// English String: "Recommendations"
	/// </summary>
	public virtual string HeadingRecommendationsTitle => "Recommendations";

	/// <summary>
	/// Key: "Heading.RecommendedItems"
	/// heading for Item page recommendations section.
	/// English String: "Recommended items"
	/// </summary>
	public virtual string HeadingRecommendedItems => "Recommended items";

	/// <summary>
	/// Key: "Heading.RecommendedTitle"
	/// English String: "Recommended"
	/// </summary>
	public virtual string HeadingRecommendedTitle => "Recommended";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public virtual string LabelFree => "Free";

	/// <summary>
	/// Key: "Label.NoReSellers"
	/// English String: "No Resellers"
	/// </summary>
	public virtual string LabelNoReSellers => "No Resellers";

	/// <summary>
	/// Key: "Label.OffSale"
	/// English String: "Off sale"
	/// </summary>
	public virtual string LabelOffSale => "Off sale";

	public RecommendationsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Buy",
				_GetTemplateForActionBuy()
			},
			{
				"Action.Get",
				_GetTemplateForActionGet()
			},
			{
				"Action.SeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"Heading.RecommendationsTitle",
				_GetTemplateForHeadingRecommendationsTitle()
			},
			{
				"Heading.Recommended",
				_GetTemplateForHeadingRecommended()
			},
			{
				"Heading.RecommendedItems",
				_GetTemplateForHeadingRecommendedItems()
			},
			{
				"Heading.RecommendedTitle",
				_GetTemplateForHeadingRecommendedTitle()
			},
			{
				"Label.ByCreator",
				_GetTemplateForLabelByCreator()
			},
			{
				"Label.ByCreatorLink",
				_GetTemplateForLabelByCreatorLink()
			},
			{
				"Label.Free",
				_GetTemplateForLabelFree()
			},
			{
				"Label.NoReSellers",
				_GetTemplateForLabelNoReSellers()
			},
			{
				"Label.OffSale",
				_GetTemplateForLabelOffSale()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Recommendations";
	}

	protected virtual string _GetTemplateForActionBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForActionGet()
	{
		return "Get";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForHeadingRecommendationsTitle()
	{
		return "Recommendations";
	}

	/// <summary>
	/// Key: "Heading.Recommended"
	/// English String: "Recommended {recommendedItem}"
	/// </summary>
	public virtual string HeadingRecommended(string recommendedItem)
	{
		return $"Recommended {recommendedItem}";
	}

	protected virtual string _GetTemplateForHeadingRecommended()
	{
		return "Recommended {recommendedItem}";
	}

	protected virtual string _GetTemplateForHeadingRecommendedItems()
	{
		return "Recommended items";
	}

	protected virtual string _GetTemplateForHeadingRecommendedTitle()
	{
		return "Recommended";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// creator label which shows like "By Alex"
	/// English String: "{styleBegin}By{styleEnd}{creator}"
	/// </summary>
	public virtual string LabelByCreator(string styleBegin, string styleEnd, string creator)
	{
		return $"{styleBegin}By{styleEnd}{creator}";
	}

	protected virtual string _GetTemplateForLabelByCreator()
	{
		return "{styleBegin}By{styleEnd}{creator}";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public virtual string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"By {linkStart}{creator}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelByCreatorLink()
	{
		return "By {linkStart}{creator}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelFree()
	{
		return "Free";
	}

	protected virtual string _GetTemplateForLabelNoReSellers()
	{
		return "No Resellers";
	}

	protected virtual string _GetTemplateForLabelOffSale()
	{
		return "Off sale";
	}
}
