namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_es_es : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
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
	public override string HeadingPriceChart => "Lista de precios";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "Revendedores";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "Precio medio";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "No hay datos históricos para mostrar.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "Precio original";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "Cantidad vendida";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "Precio medio reciente";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "Error al cargar la gráfica de precios y revendedores. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver más";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "Volumen";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "En estos momentos nadie está revendiendo este objeto.";

	public PrivateSalesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "Lista de precios";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "Revendedores";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "Precio medio";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "No hay datos históricos para mostrar.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "Precio original";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "Cantidad vendida";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "Precio medio reciente";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "Error al cargar la gráfica de precios y revendedores. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "Volumen";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} días";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} días";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "En estos momentos nadie está revendiendo este objeto.";
	}
}
