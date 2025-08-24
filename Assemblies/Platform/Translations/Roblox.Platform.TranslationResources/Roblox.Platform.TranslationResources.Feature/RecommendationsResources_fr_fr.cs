namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RecommendationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RecommendationsResources_fr_fr : RecommendationsResources_en_us, IRecommendationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item in exchange for in-game money.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Acheter";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy an item for free.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "Obtenir";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// Button used to see all items
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Afficher tout";

	/// <summary>
	/// Key: "Heading.RecommendationsTitle"
	/// heading for inventory page recommendations section.
	/// English String: "Recommendations"
	/// </summary>
	public override string HeadingRecommendationsTitle => "Recommandations";

	/// <summary>
	/// Key: "Heading.RecommendedItems"
	/// heading for Item page recommendations section.
	/// English String: "Recommended items"
	/// </summary>
	public override string HeadingRecommendedItems => "Objets recommandés";

	/// <summary>
	/// Key: "Heading.RecommendedTitle"
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommendedTitle => "Recommandés";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratuit";

	/// <summary>
	/// Key: "Label.NoReSellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoReSellers => "Aucun revendeur";

	/// <summary>
	/// Key: "Label.OffSale"
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "Hors d'offre";

	public RecommendationsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Acheter";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "Obtenir";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Afficher tout";
	}

	protected override string _GetTemplateForHeadingRecommendationsTitle()
	{
		return "Recommandations";
	}

	/// <summary>
	/// Key: "Heading.Recommended"
	/// English String: "Recommended {recommendedItem}"
	/// </summary>
	public override string HeadingRecommended(string recommendedItem)
	{
		return $"Recommandation : {recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "Recommandation : {recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommendedItems()
	{
		return "Objets recommandés";
	}

	protected override string _GetTemplateForHeadingRecommendedTitle()
	{
		return "Recommandés";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// creator label which shows like "By Alex"
	/// English String: "{styleBegin}By{styleEnd}{creator}"
	/// </summary>
	public override string LabelByCreator(string styleBegin, string styleEnd, string creator)
	{
		return $"{styleBegin}Par{styleEnd}{creator}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{styleBegin}Par{styleEnd}{creator}";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"Par {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "Par {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Gratuit";
	}

	protected override string _GetTemplateForLabelNoReSellers()
	{
		return "Aucun revendeur";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "Hors d'offre";
	}
}
