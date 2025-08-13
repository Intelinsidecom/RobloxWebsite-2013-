namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_pt_br : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Comprar";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "Tabela de preços";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "Revendedores";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "Preço médio";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "Nenhum dado histórico para registrar.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "Preço original";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "Quantidade vendida";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "Preço médio recente";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "Não foi possível carregar a tabela de preços e os revendedores. Tente novamente.";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver mais";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "Volume";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "Infelizmente, ninguém está revendendo este item no momento.";

	public PrivateSalesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "Tabela de preços";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "Revendedores";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "Preço médio";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "Nenhum dado histórico para registrar.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "Preço original";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "Quantidade vendida";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "Preço médio recente";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "Não foi possível carregar a tabela de preços e os revendedores. Tente novamente.";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver mais";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "Volume";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} dias";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} dias";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "Infelizmente, ninguém está revendendo este item no momento.";
	}
}
