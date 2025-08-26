namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_zh_cn : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "è´­ä¹°";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "ä»·æ ¼å›¾è¡¨";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "è½¬å”®è€…";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "å¹³å‡ä»·æ ¼";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "æ²¡æœ‰å¯åˆ—å…¥å›¾è¡¨çš„åŽ†å²æ•°æ®ã€‚";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "åŽŸå§‹ä»·æ ¼";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "å”®å‡ºæ•°é‡";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "æœ€è¿‘å¹³å‡ä»·æ ¼";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "æ— æ³•åŠ è½½ä»·æ ¼è¡¨åŠè½¬å”®è€…ä¿¡æ¯ï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "æ•°é‡";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "æŠ±æ­‰ï¼ŒçŽ°åœ¨æ— äººè½¬å”®æ­¤ç‰©å“ã€‚";

	public PrivateSalesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è´­ä¹°";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "ä»·æ ¼å›¾è¡¨";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "è½¬å”®è€…";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "å¹³å‡ä»·æ ¼";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "æ²¡æœ‰å¯åˆ—å…¥å›¾è¡¨çš„åŽ†å²æ•°æ®ã€‚";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "åŽŸå§‹ä»·æ ¼";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "å”®å‡ºæ•°é‡";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "æœ€è¿‘å¹³å‡ä»·æ ¼";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "æ— æ³•åŠ è½½ä»·æ ¼è¡¨åŠè½¬å”®è€…ä¿¡æ¯ï¼Œè¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "æ•°é‡";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} å¤©";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} å¤©";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "æŠ±æ­‰ï¼ŒçŽ°åœ¨æ— äººè½¬å”®æ­¤ç‰©å“ã€‚";
	}
}


}
