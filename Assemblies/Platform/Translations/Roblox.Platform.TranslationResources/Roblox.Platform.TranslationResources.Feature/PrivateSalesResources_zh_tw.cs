namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "購買";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "價格表";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "轉賣者";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "平均價格";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "無資料處理。";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "原始價格";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "售出數量";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "近期平均價格";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "無法載入價格表與轉賣者，請再試一次。";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "音量";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "對不起，目前沒有人轉賣此道具。";

	public PrivateSalesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "購買";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "價格表";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "轉賣者";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "平均價格";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "無資料處理。";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "原始價格";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "售出數量";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "近期平均價格";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "無法載入價格表與轉賣者，請再試一次。";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "音量";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} 天";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} 天";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "對不起，目前沒有人轉賣此道具。";
	}
}
