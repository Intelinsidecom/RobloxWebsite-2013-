using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PrivateSalesResources_en_us : TranslationResourcesBase, IPrivateSalesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionBuy => "Buy";

	/// <summary>
	/// Key: "Heading.PriceChart"
	/// English String: "Price Chart"
	/// </summary>
	public virtual string HeadingPriceChart => "Price Chart";

	/// <summary>
	/// Key: "Heading.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public virtual string HeadingResellers => "Resellers";

	/// <summary>
	/// Key: "Label.AveragePrice"
	/// English String: "Average Price"
	/// </summary>
	public virtual string LabelAveragePrice => "Average Price";

	/// <summary>
	/// Key: "Label.NoHistoricalData"
	/// English String: "No historical data to chart."
	/// </summary>
	public virtual string LabelNoHistoricalData => "No historical data to chart.";

	/// <summary>
	/// Key: "Label.OriginalPrice"
	/// English String: "Original Price"
	/// </summary>
	public virtual string LabelOriginalPrice => "Original Price";

	/// <summary>
	/// Key: "Label.QuantitySold"
	/// English String: "Quantity Sold"
	/// </summary>
	public virtual string LabelQuantitySold => "Quantity Sold";

	/// <summary>
	/// Key: "Label.RecentAveragePrice"
	/// English String: "Recent Average Price"
	/// </summary>
	public virtual string LabelRecentAveragePrice => "Recent Average Price";

	/// <summary>
	/// Key: "Label.ResaleDataLoadFailure"
	/// Price chart and resellers fail to load on the page.
	/// English String: "Failed to load price chart and resellers. Try again"
	/// </summary>
	public virtual string LabelResaleDataLoadFailure => "Failed to load price chart and resellers. Try again";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string LabelSeeMore => "See More";

	/// <summary>
	/// Key: "Label.Volume"
	/// English String: "Volume"
	/// </summary>
	public virtual string LabelVolume => "Volume";

	/// <summary>
	/// Key: "Message.NoOneSelling"
	/// English String: "Sorry, no one is reselling this item at the moment."
	/// </summary>
	public virtual string MessageNoOneSelling => "Sorry, no one is reselling this item at the moment.";

	public PrivateSalesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Buy",
				_GetTemplateForActionBuy()
			},
			{
				"Heading.PriceChart",
				_GetTemplateForHeadingPriceChart()
			},
			{
				"Heading.Resellers",
				_GetTemplateForHeadingResellers()
			},
			{
				"Label.AveragePrice",
				_GetTemplateForLabelAveragePrice()
			},
			{
				"Label.NoHistoricalData",
				_GetTemplateForLabelNoHistoricalData()
			},
			{
				"Label.OriginalPrice",
				_GetTemplateForLabelOriginalPrice()
			},
			{
				"Label.QuantitySold",
				_GetTemplateForLabelQuantitySold()
			},
			{
				"Label.RecentAveragePrice",
				_GetTemplateForLabelRecentAveragePrice()
			},
			{
				"Label.ResaleDataLoadFailure",
				_GetTemplateForLabelResaleDataLoadFailure()
			},
			{
				"Label.SeeMore",
				_GetTemplateForLabelSeeMore()
			},
			{
				"Label.Volume",
				_GetTemplateForLabelVolume()
			},
			{
				"Label.XDays",
				_GetTemplateForLabelXDays()
			},
			{
				"Message.NoOneSelling",
				_GetTemplateForMessageNoOneSelling()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PrivateSales";
	}

	protected virtual string _GetTemplateForActionBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForHeadingPriceChart()
	{
		return "Price Chart";
	}

	protected virtual string _GetTemplateForHeadingResellers()
	{
		return "Resellers";
	}

	protected virtual string _GetTemplateForLabelAveragePrice()
	{
		return "Average Price";
	}

	protected virtual string _GetTemplateForLabelNoHistoricalData()
	{
		return "No historical data to chart.";
	}

	protected virtual string _GetTemplateForLabelOriginalPrice()
	{
		return "Original Price";
	}

	protected virtual string _GetTemplateForLabelQuantitySold()
	{
		return "Quantity Sold";
	}

	protected virtual string _GetTemplateForLabelRecentAveragePrice()
	{
		return "Recent Average Price";
	}

	protected virtual string _GetTemplateForLabelResaleDataLoadFailure()
	{
		return "Failed to load price chart and resellers. Try again";
	}

	protected virtual string _GetTemplateForLabelSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForLabelVolume()
	{
		return "Volume";
	}

	/// <summary>
	/// Key: "Label.XDays"
	/// English String: "{numberOfDays} Days"
	/// </summary>
	public virtual string LabelXDays(string numberOfDays)
	{
		return $"{numberOfDays} Days";
	}

	protected virtual string _GetTemplateForLabelXDays()
	{
		return "{numberOfDays} Days";
	}

	protected virtual string _GetTemplateForMessageNoOneSelling()
	{
		return "Sorry, no one is reselling this item at the moment.";
	}
}
