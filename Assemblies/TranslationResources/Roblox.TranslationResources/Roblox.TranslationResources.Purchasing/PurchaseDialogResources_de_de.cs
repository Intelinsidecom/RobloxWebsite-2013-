namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_de_de : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Zugang kaufen";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "Jetzt kaufen";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "Konfigurieren";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Fortsetzen";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "Anpassen";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "Jetzt holen";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "Nicht jetzt";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Okay";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "Jetzt mieten";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Artikel kaufen";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "Fehler aufgetreten";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "Artikel holen";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "Nicht genügend Guthaben";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "Preis des Artikels hat sich geändert";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "Kauf abgeschlossen";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "Artikel mieten";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "Akzeptieren und bezahlen";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratis";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "Käufe sind derzeit nicht verfügbar. Bitte versuche es später erneut.";

	public PurchaseDialogResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Zugang kaufen";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Jetzt kaufen";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux kaufen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "Konfigurieren";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Fortsetzen";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "Anpassen";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "Jetzt holen";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "Nicht jetzt";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "Jetzt mieten";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Artikel kaufen";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "Fehler aufgetreten";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "Artikel holen";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "Nicht genügend Guthaben";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "Preis des Artikels hat sich geändert";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "Kauf abgeschlossen";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "Artikel mieten";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "Akzeptieren und bezahlen";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Gratis";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"Nach dieser Transaktion wird dein Guthaben {robuxBalance} betragen.";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "Nach dieser Transaktion wird dein Guthaben {robuxBalance} betragen.";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"Du benötigst noch {robux}, um diesen Artikel zu kaufen.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Du benötigst noch {robux}, um diesen Artikel zu kaufen.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"Während du dich umgesehen hast, hat sich der Preis dieses Artikels von {robuxBefore} zu {robuxAfter} geändert.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "Während du dich umgesehen hast, hat sich der Preis dieses Artikels von {robuxBefore} zu {robuxAfter} geändert.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"Möchtest du „{assetType}: {assetName}“ von {seller} für {robux} kaufen?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "Möchtest du „{assetType}: {assetName}“ von {seller} für {robux} kaufen?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} kaufen?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} kaufen?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Möchtest du „{assetType}: {assetName}“ von {seller} {freeTextStart}gratis{freeTextEnd} erhalten?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "Möchtest du „{assetType}: {assetName}“ von {seller} {freeTextStart}gratis{freeTextEnd} erhalten?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} {freeTextStart}gratis{freeTextEnd} erhalten?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} {freeTextStart}gratis{freeTextEnd} erhalten?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"Möchtest du „{assetType}: {assetName}“ von {seller} für {robux} mieten?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "Möchtest du „{assetType}: {assetName}“ von {seller} für {robux} mieten?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} mieten?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "Möchtest du Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} mieten?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "Käufe sind derzeit nicht verfügbar. Bitte versuche es später erneut.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast „{assetType}: {assetName}“ von {seller} für {robux} erhalten.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "Du hast „{assetType}: {assetName}“ von {seller} für {robux} erhalten.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} erhalten.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} erhalten.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast „{assetType}: {assetName}“ von {seller} für {robux} gekauft.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "Du hast „{assetType}: {assetName}“ von {seller} für {robux} gekauft.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} gekauft.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} gekauft.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast „{assetType}: {assetName}“ von {seller} für {robux} verlängert.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "Du hast „{assetType}: {assetName}“ von {seller} für {robux} verlängert.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast den Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} verlängert.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "Du hast den Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} verlängert.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast „{assetType}: {assetName}“ von {seller} für {robux} gemietet.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "Du hast „{assetType}: {assetName}“ von {seller} für {robux} gemietet.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} gemietet.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "Du hast Zugriff auf „{assetType}: {assetName}“ von {seller} für {robux} gemietet.";
	}
}
