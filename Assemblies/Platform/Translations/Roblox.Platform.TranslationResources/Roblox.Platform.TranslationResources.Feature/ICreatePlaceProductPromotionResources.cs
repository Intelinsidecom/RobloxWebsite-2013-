namespace Roblox.TranslationResources.Feature;

public interface ICreatePlaceProductPromotionResources : ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	string LabelAddToGame { get; }

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	string LabelCancel { get; }

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	string LabelError { get; }

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	string LabelErrorOccured { get; }

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	string LabelNotForSale { get; }

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	string LabelOk { get; }

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	string LabelPromoteOnYourGame { get; }

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	string LabelRent { get; }

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	string LabelSelectGroup { get; }

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	string LabelSelectNone { get; }

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	string LabelSelectYourGame { get; }

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	string LabelSelectYourGameSemicolon { get; }

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	string LabelSorryWeCouldnt { get; }

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	string LabelSuccess { get; }

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	string MessageWhatIsAddingGear(string affiliateSaleTotal);
}
