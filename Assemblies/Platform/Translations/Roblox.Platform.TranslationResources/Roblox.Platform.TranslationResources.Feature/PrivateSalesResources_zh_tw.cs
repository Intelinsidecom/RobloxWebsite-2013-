namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_zh_tw : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "è³¼è²·";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "åƒ¹æ ¼è¡¨";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "è½‰è³£è€…";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "å¹³å‡åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "ç„¡è³‡æ–™è™•ç†ã€‚";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "åŽŸå§‹åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "å”®å‡ºæ•¸é‡";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "è¿‘æœŸå¹³å‡åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "ç„¡æ³•è¼‰å…¥åƒ¹æ ¼è¡¨èˆ‡è½‰è³£è€…ï¼Œè«‹å†è©¦ä¸€æ¬¡ã€‚";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "éŸ³é‡";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "å°ä¸èµ·ï¼Œç›®å‰æ²’æœ‰äººè½‰è³£æ­¤é“å…·ã€‚";

	public PrivateSalesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è³¼è²·";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "åƒ¹æ ¼è¡¨";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "è½‰è³£è€…";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "å¹³å‡åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "ç„¡è³‡æ–™è™•ç†ã€‚";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "åŽŸå§‹åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "å”®å‡ºæ•¸é‡";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "è¿‘æœŸå¹³å‡åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "ç„¡æ³•è¼‰å…¥åƒ¹æ ¼è¡¨èˆ‡è½‰è³£è€…ï¼Œè«‹å†è©¦ä¸€æ¬¡ã€‚";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "éŸ³é‡";
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
		return "å°ä¸èµ·ï¼Œç›®å‰æ²’æœ‰äººè½‰è³£æ­¤é“å…·ã€‚";
	}
}


}
