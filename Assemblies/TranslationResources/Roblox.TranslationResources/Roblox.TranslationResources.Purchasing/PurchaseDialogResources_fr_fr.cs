namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_fr_fr : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Acheter accès";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "Acheter maintenant";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "Configurer";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Continuer";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "Personnaliser";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "Obtenir maintenant";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "Pas maintenant";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "Louer maintenant";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Acheter objet";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "Une erreur est survenue";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "Obtenir objet";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "Fonds insuffisants";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "Prix de l'objet modifié";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "Achat effectué";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "Louer objet";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "Accepter et payer";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratuit";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "Les achats sont temporairement indisponibles. Veuillez réessayer plus tard.";

	public PurchaseDialogResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Acheter accès";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Acheter maintenant";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "Configurer";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Continuer";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "Personnaliser";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "Obtenir maintenant";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "Pas maintenant";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "Louer maintenant";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Acheter objet";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "Une erreur est survenue";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "Obtenir objet";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "Fonds insuffisants";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "Prix de l'objet modifié";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "Achat effectué";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "Louer objet";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "Accepter et payer";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Gratuit";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"Ton solde après cette transaction sera de {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "Ton solde après cette transaction sera de {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"Il vous manque {robux} pour acheter cet objet.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Il vous manque {robux} pour acheter cet objet.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"Pendant que vous parcouriez la boutique, le prix de cet objet est passé de {robuxBefore} à {robuxAfter}.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "Pendant que vous parcouriez la boutique, le prix de cet objet est passé de {robuxBefore} à {robuxAfter}.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"Souhaitez-vous acheter l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "Souhaitez-vous acheter l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Souhaitez-vous acheter l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "Souhaitez-vous acheter l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Souhaitez-vous obtenir l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} {freeTextStart}gratuitement{freeTextEnd}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "Souhaitez-vous obtenir l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} {freeTextStart}gratuitement{freeTextEnd}\u00a0?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Souhaitez-vous obtenir l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} {freeTextStart}gratuitement{freeTextEnd}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "Souhaitez-vous obtenir l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} {freeTextStart}gratuitement{freeTextEnd}\u00a0?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"Souhaitez-vous louer l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "Souhaitez-vous louer l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Souhaitez-vous louer l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "Souhaitez-vous louer l'accès à l'élément «\u00a0{assetName}\u00a0» de type {assetType} de {seller} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "Les achats sont temporairement indisponibles. Veuillez réessayer plus tard.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez obtenu l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "Vous avez obtenu l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez obtenu l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "Vous avez obtenu l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez acheté l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "Vous avez acheté l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez acheté l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "Vous avez acheté l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez renouvelé l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "Vous avez renouvelé l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez renouvelé l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "Vous avez renouvelé l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez loué l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "Vous avez loué l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Vous avez loué l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "Vous avez loué l'accès à l'élément {assetName} de type {assetType} de {seller} pour {robux}.";
	}
}
