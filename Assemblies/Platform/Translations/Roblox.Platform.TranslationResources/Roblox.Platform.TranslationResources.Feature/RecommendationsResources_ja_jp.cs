namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RecommendationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RecommendationsResources_ja_jp : RecommendationsResources_en_us, IRecommendationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item in exchange for in-game money.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "è²·ã†";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy an item for free.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "ã‚²ãƒƒãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// Button used to see all items
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ã™ã¹ã¦è¦‹ã‚‹";

	/// <summary>
	/// Key: "Heading.RecommendationsTitle"
	/// heading for inventory page recommendations section.
	/// English String: "Recommendations"
	/// </summary>
	public override string HeadingRecommendationsTitle => "ãŠã™ã™ã‚";

	/// <summary>
	/// Key: "Heading.RecommendedItems"
	/// heading for Item page recommendations section.
	/// English String: "Recommended items"
	/// </summary>
	public override string HeadingRecommendedItems => "ãŠã™ã™ã‚ã‚¢ã‚¤ãƒ†ãƒ ";

	/// <summary>
	/// Key: "Heading.RecommendedTitle"
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommendedTitle => "ãŠã™ã™ã‚";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ç„¡æ–™";

	/// <summary>
	/// Key: "Label.NoReSellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoReSellers => "å†è²©è€…ãªã—";

	/// <summary>
	/// Key: "Label.OffSale"
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "éžå£²å“";

	public RecommendationsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è²·ã†";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "ã‚²ãƒƒãƒˆã™ã‚‹";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ã™ã¹ã¦è¦‹ã‚‹";
	}

	protected override string _GetTemplateForHeadingRecommendationsTitle()
	{
		return "ãŠã™ã™ã‚";
	}

	/// <summary>
	/// Key: "Heading.Recommended"
	/// English String: "Recommended {recommendedItem}"
	/// </summary>
	public override string HeadingRecommended(string recommendedItem)
	{
		return $"ãŠã™ã™ã‚{recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "ãŠã™ã™ã‚{recommendedItem}";
	}

	protected override string _GetTemplateForHeadingRecommendedItems()
	{
		return "ãŠã™ã™ã‚ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForHeadingRecommendedTitle()
	{
		return "ãŠã™ã™ã‚";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// creator label which shows like "By Alex"
	/// English String: "{styleBegin}By{styleEnd}{creator}"
	/// </summary>
	public override string LabelByCreator(string styleBegin, string styleEnd, string creator)
	{
		return $"{styleBegin}ä½œæˆè€…{styleEnd}{creator}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{styleBegin}ä½œæˆè€…{styleEnd}{creator}";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"ä½œï¼š {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "ä½œï¼š {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ç„¡æ–™";
	}

	protected override string _GetTemplateForLabelNoReSellers()
	{
		return "å†è²©è€…ãªã—";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "éžå£²å“";
	}
}


}
