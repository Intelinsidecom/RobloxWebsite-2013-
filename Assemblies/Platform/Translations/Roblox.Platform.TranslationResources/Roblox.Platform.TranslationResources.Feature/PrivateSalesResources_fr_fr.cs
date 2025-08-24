namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateSalesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateSalesResources_fr_fr : PrivateSalesResources_en_us, IPrivateSalesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Acheter";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public override string HeadingPriceChart => "Tableau des prix";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string HeadingResellers => "Revendeurs";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public override string LabelAveragePrice => "Prix moyen";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public override string LabelNoHistoricalData => "Aucune donnée historique à suivre.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public override string LabelOriginalPrice => "Prix d'origine";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public override string LabelQuantitySold => "Quantité vendue";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public override string LabelRecentAveragePrice => "Prix moyen récent";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public override string LabelResaleDataLoadFailure => "Erreur lors du chargement de la carte des prix et revendeurs. Réessaie";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public override string LabelVolume => "Quantité";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public override string MessageNoOneSelling => "Désolé, cet objet n'a aucun revendeur pour le moment.";

	public PrivateSalesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Acheter";
	}

	protected override string _GetTemplateForHeadingPriceChart()
	{
		return "Tableau des prix";
	}

	protected override string _GetTemplateForHeadingResellers()
	{
		return "Revendeurs";
	}

	protected override string _GetTemplateForLabelAveragePrice()
	{
		return "Prix moyen";
	}

	protected override string _GetTemplateForLabelNoHistoricalData()
	{
		return "Aucune donnée historique à suivre.";
	}

	protected override string _GetTemplateForLabelOriginalPrice()
	{
		return "Prix d'origine";
	}

	protected override string _GetTemplateForLabelQuantitySold()
	{
		return "Quantité vendue";
	}

	protected override string _GetTemplateForLabelRecentAveragePrice()
	{
		return "Prix moyen récent";
	}

	protected override string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "Erreur lors du chargement de la carte des prix et revendeurs. Réessaie";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForLabelVolume()
	{
		return "Quantité";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public override string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays}\u00a0jours";
	}

	protected override string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays}\u00a0jours";
	}

	protected override string _GetTemplateForMessageNoOneSelling()
	{
		return "Désolé, cet objet n'a aucun revendeur pour le moment.";
	}
}
