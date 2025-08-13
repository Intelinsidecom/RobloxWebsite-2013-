using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Purchasing;

internal class PurchaseDialogResources_en_us : TranslationResourcesBase, IPurchaseDialogResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public virtual string ActionBuyAccess => "Buy Access";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public virtual string ActionBuyNow => "Buy Now";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string ActionBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public virtual string ActionConfigure => "Configure";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public virtual string ActionContinue => "Continue";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public virtual string ActionCustomize => "Customize";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public virtual string ActionGetNow => "Get Now";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public virtual string ActionNotNow => "Not Now";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public virtual string ActionRentNow => "Rent Now";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public virtual string HeadingBuyItem => "Buy Item";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public virtual string HeadingErrorOccured => "Error Occured";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public virtual string HeadingGetItem => "Get Item";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public virtual string HeadingInsufficientFunds => "Insufficient Funds";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public virtual string HeadingPriceChanged => "Item Price Has Changed";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public virtual string HeadingPurchaseComplete => "Purchase Complete";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public virtual string HeadingRentItem => "Rent Item";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public virtual string LabelAgreeAndPay => "Agree and Pay";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public virtual string LabelFree => "Free";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public virtual string MessagePurchasingUnavailable => "Purchasing is temporarily unavailable. Please try again later.";

	public PurchaseDialogResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BuyAccess",
				_GetTemplateForActionBuyAccess()
			},
			{
				"Action.BuyNow",
				_GetTemplateForActionBuyNow()
			},
			{
				"Action.BuyRobux",
				_GetTemplateForActionBuyRobux()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Configure",
				_GetTemplateForActionConfigure()
			},
			{
				"Action.Continue",
				_GetTemplateForActionContinue()
			},
			{
				"Action.Customize",
				_GetTemplateForActionCustomize()
			},
			{
				"Action.GetNow",
				_GetTemplateForActionGetNow()
			},
			{
				"Action.NotNow",
				_GetTemplateForActionNotNow()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.RentNow",
				_GetTemplateForActionRentNow()
			},
			{
				"Heading.BuyItem",
				_GetTemplateForHeadingBuyItem()
			},
			{
				"Heading.ErrorOccured",
				_GetTemplateForHeadingErrorOccured()
			},
			{
				"Heading.GetItem",
				_GetTemplateForHeadingGetItem()
			},
			{
				"Heading.InsufficientFunds",
				_GetTemplateForHeadingInsufficientFunds()
			},
			{
				"Heading.PriceChanged",
				_GetTemplateForHeadingPriceChanged()
			},
			{
				"Heading.PurchaseComplete",
				_GetTemplateForHeadingPurchaseComplete()
			},
			{
				"Heading.RentItem",
				_GetTemplateForHeadingRentItem()
			},
			{
				"Label.AgreeAndPay",
				_GetTemplateForLabelAgreeAndPay()
			},
			{
				"Label.Free",
				_GetTemplateForLabelFree()
			},
			{
				"Message.BalanceAfter",
				_GetTemplateForMessageBalanceAfter()
			},
			{
				"Message.InsufficientFunds",
				_GetTemplateForMessageInsufficientFunds()
			},
			{
				"Message.PriceChanged",
				_GetTemplateForMessagePriceChanged()
			},
			{
				"Message.PromptBuy",
				_GetTemplateForMessagePromptBuy()
			},
			{
				"Message.PromptBuyAccess",
				_GetTemplateForMessagePromptBuyAccess()
			},
			{
				"Message.PromptGetFree",
				_GetTemplateForMessagePromptGetFree()
			},
			{
				"Message.PromptGetFreeAccess",
				_GetTemplateForMessagePromptGetFreeAccess()
			},
			{
				"Message.PromptRent",
				_GetTemplateForMessagePromptRent()
			},
			{
				"Message.PromptRentAccess",
				_GetTemplateForMessagePromptRentAccess()
			},
			{
				"Message.PurchasingUnavailable",
				_GetTemplateForMessagePurchasingUnavailable()
			},
			{
				"Message.SuccessfullyAcquired",
				_GetTemplateForMessageSuccessfullyAcquired()
			},
			{
				"Message.SuccessfullyAcquiredAccess",
				_GetTemplateForMessageSuccessfullyAcquiredAccess()
			},
			{
				"Message.SuccessfullyBought",
				_GetTemplateForMessageSuccessfullyBought()
			},
			{
				"Message.SuccessfullyBoughtAccess",
				_GetTemplateForMessageSuccessfullyBoughtAccess()
			},
			{
				"Message.SuccessfullyRenewed",
				_GetTemplateForMessageSuccessfullyRenewed()
			},
			{
				"Message.SuccessfullyRenewedAccess",
				_GetTemplateForMessageSuccessfullyRenewedAccess()
			},
			{
				"Message.SuccessfullyRented",
				_GetTemplateForMessageSuccessfullyRented()
			},
			{
				"Message.SuccessfullyRentedAccess",
				_GetTemplateForMessageSuccessfullyRentedAccess()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Purchasing.PurchaseDialog";
	}

	protected virtual string _GetTemplateForActionBuyAccess()
	{
		return "Buy Access";
	}

	protected virtual string _GetTemplateForActionBuyNow()
	{
		return "Buy Now";
	}

	protected virtual string _GetTemplateForActionBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionConfigure()
	{
		return "Configure";
	}

	protected virtual string _GetTemplateForActionContinue()
	{
		return "Continue";
	}

	protected virtual string _GetTemplateForActionCustomize()
	{
		return "Customize";
	}

	protected virtual string _GetTemplateForActionGetNow()
	{
		return "Get Now";
	}

	protected virtual string _GetTemplateForActionNotNow()
	{
		return "Not Now";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionRentNow()
	{
		return "Rent Now";
	}

	protected virtual string _GetTemplateForHeadingBuyItem()
	{
		return "Buy Item";
	}

	protected virtual string _GetTemplateForHeadingErrorOccured()
	{
		return "Error Occured";
	}

	protected virtual string _GetTemplateForHeadingGetItem()
	{
		return "Get Item";
	}

	protected virtual string _GetTemplateForHeadingInsufficientFunds()
	{
		return "Insufficient Funds";
	}

	protected virtual string _GetTemplateForHeadingPriceChanged()
	{
		return "Item Price Has Changed";
	}

	protected virtual string _GetTemplateForHeadingPurchaseComplete()
	{
		return "Purchase Complete";
	}

	protected virtual string _GetTemplateForHeadingRentItem()
	{
		return "Rent Item";
	}

	protected virtual string _GetTemplateForLabelAgreeAndPay()
	{
		return "Agree and Pay";
	}

	protected virtual string _GetTemplateForLabelFree()
	{
		return "Free";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public virtual string MessageBalanceAfter(string robuxBalance)
	{
		return $"Your balance after this transaction will be {robuxBalance}";
	}

	protected virtual string _GetTemplateForMessageBalanceAfter()
	{
		return "Your balance after this transaction will be {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public virtual string MessageInsufficientFunds(string robux)
	{
		return $"You need {robux} more to purchase this item.";
	}

	protected virtual string _GetTemplateForMessageInsufficientFunds()
	{
		return "You need {robux} more to purchase this item.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public virtual string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}.";
	}

	protected virtual string _GetTemplateForMessagePriceChanged()
	{
		return "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public virtual string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	protected virtual string _GetTemplateForMessagePromptBuy()
	{
		return "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public virtual string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	protected virtual string _GetTemplateForMessagePromptBuyAccess()
	{
		return "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public virtual string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?";
	}

	protected virtual string _GetTemplateForMessagePromptGetFree()
	{
		return "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public virtual string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?";
	}

	protected virtual string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public virtual string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	protected virtual string _GetTemplateForMessagePromptRent()
	{
		return "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public virtual string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	protected virtual string _GetTemplateForMessagePromptRentAccess()
	{
		return "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?";
	}

	protected virtual string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "Purchasing is temporarily unavailable. Please try again later.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully acquired the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully bought the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyBought()
	{
		return "You have successfully bought the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully renewed the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully rented the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyRented()
	{
		return "You have successfully rented the {assetName} {assetType} from {seller} for {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public virtual string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}.";
	}

	protected virtual string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}.";
	}
}
