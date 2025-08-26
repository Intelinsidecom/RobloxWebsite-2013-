namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RecommendationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RecommendationsResources_ko_kr : RecommendationsResources_en_us, IRecommendationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item in exchange for in-game money.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy an item for free.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "íšë“";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// Button used to see all items
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "Heading.RecommendationsTitle"
	/// heading for inventory page recommendations section.
	/// English String: "Recommendations"
	/// </summary>
	public override string HeadingRecommendationsTitle => "ì¶”ì²œ";

	/// <summary>
	/// Key: "Heading.RecommendedItems"
	/// heading for Item page recommendations section.
	/// English String: "Recommended items"
	/// </summary>
	public override string HeadingRecommendedItems => "ì¶”ì²œ ì•„ì´í…œ";

	/// <summary>
	/// Key: "Heading.RecommendedTitle"
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommendedTitle => "ì¶”ì²œ";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ë¬´ë£Œ";

	/// <summary>
	/// Key: "Label.NoReSellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoReSellers => "ìž¬íŒë§¤ìž ì—†ìŒ";

	/// <summary>
	/// Key: "Label.OffSale"
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "íŒë§¤ ì¤‘ë‹¨";

	public RecommendationsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "íšë“";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingRecommendationsTitle()
	{
		return "ì¶”ì²œ";
	}

	/// <summary>
	/// Key: "Heading.Recommended"
	/// English String: "Recommended {recommendedItem}"
	/// </summary>
	public override string HeadingRecommended(string recommendedItem)
	{
		return $"ì¶”ì²œ {recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "ì¶”ì²œ {recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommendedItems()
	{
		return "ì¶”ì²œ ì•„ì´í…œ";
	}

	protected override string _GetTemplateForHeadingRecommendedTitle()
	{
		return "ì¶”ì²œ";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// creator label which shows like "By Alex"
	/// English String: "{styleBegin}By{styleEnd}{creator}"
	/// </summary>
	public override string LabelByCreator(string styleBegin, string styleEnd, string creator)
	{
		return $"{styleBegin}ê°œë°œ:{styleEnd} {creator}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{styleBegin}ê°œë°œ:{styleEnd} {creator}";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"ì œìž‘: {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "ì œìž‘: {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ë¬´ë£Œ";
	}

	protected override string _GetTemplateForLabelNoReSellers()
	{
		return "ìž¬íŒë§¤ìž ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "íŒë§¤ ì¤‘ë‹¨";
	}
}


}
