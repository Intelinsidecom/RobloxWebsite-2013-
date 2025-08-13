namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_zh_cjv : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "购买";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "价格图表";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "转售者";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "平均价格";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "没有可列入图表的历史数据。";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "原始价格";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "售出数量";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "最近平均价格";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "无法加载价格表及转售者信息，请重试。";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "数量";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "抱歉，现在无人转售此物品。";

	public PrivateSalesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "购买";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "价格图表";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "转售者";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "平均价格";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "没有可列入图表的历史数据。";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "原始价格";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "售出数量";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "最近平均价格";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "无法加载价格表及转售者信息，请重试。";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "数量";
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
		return "抱歉，现在无人转售此物品。";
	}
}
