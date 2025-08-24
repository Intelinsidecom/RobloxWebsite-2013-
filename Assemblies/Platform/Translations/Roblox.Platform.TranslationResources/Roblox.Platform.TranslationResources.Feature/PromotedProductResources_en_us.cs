using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PromotedProductResources_en_us : TranslationResourcesBase, IPromotedProductResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public virtual string HeadingGearForThisGame => "Gear for this game";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public virtual string LabelAddGear => "Add Gear";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public virtual string LabelBuy => "Buy";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public virtual string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public virtual string LabelErrorOccurred => "An error occurred, please try again.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public virtual string LabelNotForSale => "This item is not for sale.";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public virtual string LabelNotForSaleShort => "Not for sale";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public virtual string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public virtual string LabelOwned => "Owned";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public virtual string LabelRent => "Rent";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public virtual string LabelResourceRent => "Rent";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public virtual string LabelSorry => "Sorry, we couldn't remove the item from your game. Please try again.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public virtual string LabelSuccess => "Success!";

	public PromotedProductResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Heading.GearForThisGame",
				_GetTemplateForHeadingGearForThisGame()
			},
			{
				"Label.AddGear",
				_GetTemplateForLabelAddGear()
			},
			{
				"Label.Buy",
				_GetTemplateForLabelBuy()
			},
			{
				"Label.Error",
				_GetTemplateForLabelError()
			},
			{
				"Label.ErrorOccurred",
				_GetTemplateForLabelErrorOccurred()
			},
			{
				"Label.ItemAddedToGame",
				_GetTemplateForLabelItemAddedToGame()
			},
			{
				"Label.ItemRemovedFromGame",
				_GetTemplateForLabelItemRemovedFromGame()
			},
			{
				"Label.NotForSale",
				_GetTemplateForLabelNotForSale()
			},
			{
				"Label.NotForSaleShort",
				_GetTemplateForLabelNotForSaleShort()
			},
			{
				"Label.Ok",
				_GetTemplateForLabelOk()
			},
			{
				"Label.Owned",
				_GetTemplateForLabelOwned()
			},
			{
				"Label.Rent",
				_GetTemplateForLabelRent()
			},
			{
				"Label.ResourceRent",
				_GetTemplateForLabelResourceRent()
			},
			{
				"Label.Sorry",
				_GetTemplateForLabelSorry()
			},
			{
				"Label.Success",
				_GetTemplateForLabelSuccess()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PromotedProduct";
	}

	protected virtual string _GetTemplateForHeadingGearForThisGame()
	{
		return "Gear for this game";
	}

	protected virtual string _GetTemplateForLabelAddGear()
	{
		return "Add Gear";
	}

	protected virtual string _GetTemplateForLabelBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForLabelErrorOccurred()
	{
		return "An error occurred, please try again.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public virtual string LabelItemAddedToGame(string item)
	{
		return $"You have added {item} to your game.";
	}

	protected virtual string _GetTemplateForLabelItemAddedToGame()
	{
		return "You have added {item} to your game.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public virtual string LabelItemRemovedFromGame(string item)
	{
		return $"You have removed {item} from your game.";
	}

	protected virtual string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "You have removed {item} from your game.";
	}

	protected virtual string _GetTemplateForLabelNotForSale()
	{
		return "This item is not for sale.";
	}

	protected virtual string _GetTemplateForLabelNotForSaleShort()
	{
		return "Not for sale";
	}

	protected virtual string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelOwned()
	{
		return "Owned";
	}

	protected virtual string _GetTemplateForLabelRent()
	{
		return "Rent";
	}

	protected virtual string _GetTemplateForLabelResourceRent()
	{
		return "Rent";
	}

	protected virtual string _GetTemplateForLabelSorry()
	{
		return "Sorry, we couldn't remove the item from your game. Please try again.";
	}

	protected virtual string _GetTemplateForLabelSuccess()
	{
		return "Success!";
	}
}
