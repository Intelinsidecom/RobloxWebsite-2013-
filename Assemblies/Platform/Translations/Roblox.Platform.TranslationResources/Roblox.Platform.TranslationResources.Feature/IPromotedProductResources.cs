namespace Roblox.TranslationResources.Feature;

public interface IPromotedProductResources : ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	string HeadingGearForThisGame { get; }

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	string LabelAddGear { get; }

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	string LabelBuy { get; }

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	string LabelError { get; }

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	string LabelErrorOccurred { get; }

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	string LabelNotForSale { get; }

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	string LabelNotForSaleShort { get; }

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	string LabelOk { get; }

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	string LabelOwned { get; }

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	string LabelRent { get; }

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	string LabelResourceRent { get; }

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	string LabelSorry { get; }

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	string LabelSuccess { get; }

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	string LabelItemAddedToGame(string item);

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	string LabelItemRemovedFromGame(string item);
}
