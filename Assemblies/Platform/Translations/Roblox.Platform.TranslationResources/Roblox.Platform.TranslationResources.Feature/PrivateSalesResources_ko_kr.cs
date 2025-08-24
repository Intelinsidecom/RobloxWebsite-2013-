namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "구매";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "가격표";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "재판매자";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "평균가";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "데이터가 없어 표를 만들 수 없어요.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "기본가";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "판매량";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "최근 평균가";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "재판매자 및 가격 차트를 불러오지 못했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "더 보기";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "볼륨";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "죄송합니다. 현재 본 아이템을 재판매하는 사람이 없어요.";

	public PrivateSalesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "구매";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "가격표";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "재판매자";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "평균가";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "데이터가 없어 표를 만들 수 없어요.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "기본가";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "판매량";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "최근 평균가";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "재판매자 및 가격 차트를 불러오지 못했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "볼륨";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays}일";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays}일";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "죄송합니다. 현재 본 아이템을 재판매하는 사람이 없어요.";
	}
}
