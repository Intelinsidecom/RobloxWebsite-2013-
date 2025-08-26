namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_ko_kr : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "ê°€ê²©í‘œ";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "ìž¬íŒë§¤ìž";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "í‰ê· ê°€";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "ë°ì´í„°ê°€ ì—†ì–´ í‘œë¥¼ ë§Œë“¤ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "ê¸°ë³¸ê°€";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "íŒë§¤ëŸ‰";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "ìµœê·¼ í‰ê· ê°€";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "ìž¬íŒë§¤ìž ë° ê°€ê²© ì°¨íŠ¸ë¥¼ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "ë³¼ë¥¨";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "ì£„ì†¡í•©ë‹ˆë‹¤. í˜„ìž¬ ë³¸ ì•„ì´í…œì„ ìž¬íŒë§¤í•˜ëŠ” ì‚¬ëžŒì´ ì—†ì–´ìš”.";

	public PrivateSalesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "ê°€ê²©í‘œ";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "ìž¬íŒë§¤ìž";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "í‰ê· ê°€";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "ë°ì´í„°ê°€ ì—†ì–´ í‘œë¥¼ ë§Œë“¤ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "ê¸°ë³¸ê°€";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "íŒë§¤ëŸ‰";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "ìµœê·¼ í‰ê· ê°€";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "ìž¬íŒë§¤ìž ë° ê°€ê²© ì°¨íŠ¸ë¥¼ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "ë³¼ë¥¨";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays}ì¼";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays}ì¼";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. í˜„ìž¬ ë³¸ ì•„ì´í…œì„ ìž¬íŒë§¤í•˜ëŠ” ì‚¬ëžŒì´ ì—†ì–´ìš”.";
	}
}


}
