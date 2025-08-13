using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CreatePlaceProductPromotionResources_en_us : TranslationResourcesBase, ICreatePlaceProductPromotionResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public virtual string LabelAddToGame => "Add to Game";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public virtual string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public virtual string LabelErrorOccured => "An error occurred, please try again.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public virtual string LabelNotForSale => "This item is not for sale.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public virtual string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public virtual string LabelPromoteOnYourGame => "Promote on your Game";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public virtual string LabelRent => "Rent";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public virtual string LabelSelectGroup => "Select Group";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public virtual string LabelSelectNone => "None";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public virtual string LabelSelectYourGame => "Select Your Game";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public virtual string LabelSelectYourGameSemicolon => "Select Your Game:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public virtual string LabelSorryWeCouldnt => "Sorry, we couldn't remove the item from your game. Please try again.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public virtual string LabelSuccess => "Success!";

	public CreatePlaceProductPromotionResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.AddToGame",
				_GetTemplateForLabelAddToGame()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.Error",
				_GetTemplateForLabelError()
			},
			{
				"Label.ErrorOccured",
				_GetTemplateForLabelErrorOccured()
			},
			{
				"Label.NotForSale",
				_GetTemplateForLabelNotForSale()
			},
			{
				"Label.Ok",
				_GetTemplateForLabelOk()
			},
			{
				"Label.PromoteOnYourGame",
				_GetTemplateForLabelPromoteOnYourGame()
			},
			{
				"Label.Rent",
				_GetTemplateForLabelRent()
			},
			{
				"Label.SelectGroup",
				_GetTemplateForLabelSelectGroup()
			},
			{
				"Label.SelectNone",
				_GetTemplateForLabelSelectNone()
			},
			{
				"Label.SelectYourGame",
				_GetTemplateForLabelSelectYourGame()
			},
			{
				"Label.SelectYourGameSemicolon",
				_GetTemplateForLabelSelectYourGameSemicolon()
			},
			{
				"Label.SorryWeCouldnt",
				_GetTemplateForLabelSorryWeCouldnt()
			},
			{
				"Label.Success",
				_GetTemplateForLabelSuccess()
			},
			{
				"Message.WhatIsAddingGear",
				_GetTemplateForMessageWhatIsAddingGear()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.CreatePlaceProductPromotion";
	}

	protected virtual string _GetTemplateForLabelAddToGame()
	{
		return "Add to Game";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForLabelErrorOccured()
	{
		return "An error occurred, please try again.";
	}

	protected virtual string _GetTemplateForLabelNotForSale()
	{
		return "This item is not for sale.";
	}

	protected virtual string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "Promote on your Game";
	}

	protected virtual string _GetTemplateForLabelRent()
	{
		return "Rent";
	}

	protected virtual string _GetTemplateForLabelSelectGroup()
	{
		return "Select Group";
	}

	protected virtual string _GetTemplateForLabelSelectNone()
	{
		return "None";
	}

	protected virtual string _GetTemplateForLabelSelectYourGame()
	{
		return "Select Your Game";
	}

	protected virtual string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "Select Your Game:";
	}

	protected virtual string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "Sorry, we couldn't remove the item from your game. Please try again.";
	}

	protected virtual string _GetTemplateForLabelSuccess()
	{
		return "Success!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public virtual string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!";
	}

	protected virtual string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!";
	}
}
