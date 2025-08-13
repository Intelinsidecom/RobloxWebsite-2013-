namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_de_de : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Kaufen";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "Preistabelle";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "Wiederverkäufer";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "Durchschnittspreis";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "Keine Verlaufsdaten erfasst.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "Originalpreis";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "Verkaufte Menge";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "Aktueller Durchschnittspreis";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "Fehler beim Laden der Preistabelle und der Wiederverkäufer. Versuch es erneut";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "Lautstärke";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "Dieser Artikel wird gerade leider von niemandem weiterverkauft.";

	public PrivateSalesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "Preistabelle";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "Wiederverkäufer";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "Durchschnittspreis";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "Keine Verlaufsdaten erfasst.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "Originalpreis";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "Verkaufte Menge";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "Aktueller Durchschnittspreis";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "Fehler beim Laden der Preistabelle und der Wiederverkäufer. Versuch es erneut";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "Lautstärke";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} Tage";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} Tage";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "Dieser Artikel wird gerade leider von niemandem weiterverkauft.";
	}
}
