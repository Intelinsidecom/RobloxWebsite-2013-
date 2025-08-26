namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_ja_jp : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "è²·ã†";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "ä¾¡æ ¼è¡¨";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "å†è²©è€…";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "å¹³å‡ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "è¡¨ç¤ºã™ã‚‹å±¥æ­´ãƒ‡ãƒ¼ã‚¿ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "å…ƒã®ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "å£²ã‚ŒãŸæ•°";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "æœ€è¿‘ã®å¹³å‡ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "ä¾¡æ ¼è¡¨ã¨å†è²©è€…ã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "é‡";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ç¾åœ¨ã€èª°ã‚‚ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’å†è²©å£²ã—ã¦ã„ã¾ã›ã‚“ã€‚";

	public PrivateSalesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è²·ã†";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "ä¾¡æ ¼è¡¨";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "å†è²©è€…";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "å¹³å‡ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "è¡¨ç¤ºã™ã‚‹å±¥æ­´ãƒ‡ãƒ¼ã‚¿ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "å…ƒã®ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "å£²ã‚ŒãŸæ•°";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "æœ€è¿‘ã®å¹³å‡ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "ä¾¡æ ¼è¡¨ã¨å†è²©è€…ã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "é‡";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays}æ—¥";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays}æ—¥";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ç¾åœ¨ã€èª°ã‚‚ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’å†è²©å£²ã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}
}


}
