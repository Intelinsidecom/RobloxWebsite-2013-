namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "買う";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "価格表";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "再販者";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "平均価格";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "表示する履歴データがありません。";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "元の価格";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "売れた数";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "最近の平均価格";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "価格表と再販者を読み込めませんでした。もう一度お試しください";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "もっと見る";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "量";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "申し訳ありませんが、現在、誰もこのアイテムを再販売していません。";

	public PrivateSalesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "買う";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "価格表";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "再販者";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "平均価格";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "表示する履歴データがありません。";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "元の価格";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "売れた数";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "最近の平均価格";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "価格表と再販者を読み込めませんでした。もう一度お試しください";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "量";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays}日";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays}日";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "申し訳ありませんが、現在、誰もこのアイテムを再販売していません。";
	}
}
