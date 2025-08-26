namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RecommendationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RecommendationsResources_zh_cjv : RecommendationsResources_en_us, IRecommendationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item in exchange for in-game money.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "è´­ä¹°";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy an item for free.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "èŽ·å–";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// Button used to see all items
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Heading.RecommendationsTitle"
	/// heading for inventory page recommendations section.
	/// English String: "Recommendations"
	/// </summary>
	public override string HeadingRecommendationsTitle => "æŽ¨è";

	/// <summary>
	/// Key: "Heading.RecommendedItems"
	/// heading for Item page recommendations section.
	/// English String: "Recommended items"
	/// </summary>
	public override string HeadingRecommendedItems => "æŽ¨èé“å…·";

	/// <summary>
	/// Key: "Heading.RecommendedTitle"
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommendedTitle => "æŽ¨è";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "å…è´¹";

	/// <summary>
	/// Key: "Label.NoReSellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoReSellers => "æ— äººè½¬å”®";

	/// <summary>
	/// Key: "Label.OffSale"
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "ä¸‹æž¶";

	public RecommendationsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è´­ä¹°";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "èŽ·å–";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForHeadingRecommendationsTitle()
	{
		return "æŽ¨è";
	}

	/// <summary>
	/// Key: "Heading.Recommended"
	/// English String: "Recommended {recommendedItem}"
	/// </summary>
	public override string HeadingRecommended(string recommendedItem)
	{
		return $"æŽ¨è{recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "æŽ¨è{recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommendedItems()
	{
		return "æŽ¨èé“å…·";
	}

	protected override string _GetTemplateForHeadingRecommendedTitle()
	{
		return "æŽ¨è";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// creator label which shows like "By Alex"
	/// English String: "{styleBegin}By{styleEnd}{creator}"
	/// </summary>
	public override string LabelByCreator(string styleBegin, string styleEnd, string creator)
	{
		return $"{styleBegin}åˆ›ä½œè€…ï¼š{styleEnd}{creator}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{styleBegin}åˆ›ä½œè€…ï¼š{styleEnd}{creator}";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"åˆ›ä½œè€…ï¼š{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "åˆ›ä½œè€…ï¼š{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "å…è´¹";
	}

	protected override string _GetTemplateForLabelNoReSellers()
	{
		return "æ— äººè½¬å”®";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "ä¸‹æž¶";
	}
}


}
