namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_es_es : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Comprar acceso";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "Comprar ahora";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "Configurar";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Continuar";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "Personalizar";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "Obtener ahora";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "Ahora no";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Aceptar";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "Alquilar ahora";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Comprar objeto";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "Se ha producido un error";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "Obtener objeto";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "Fondos insuficientes";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "El precio del objeto ha cambiado";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "Compra finalizada";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "Alquilar objeto";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "Aceptar y pagar";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratis";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "Las compras no están disponibles temporalmente. Inténtalo de nuevo más tarde.";

	public PurchaseDialogResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Comprar acceso";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Comprar ahora";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "Configurar";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Continuar";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "Personalizar";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "Obtener ahora";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "Ahora no";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "Alquilar ahora";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Comprar objeto";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "Se ha producido un error";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "Obtener objeto";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "Fondos insuficientes";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "El precio del objeto ha cambiado";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "Compra finalizada";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "Alquilar objeto";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "Aceptar y pagar";
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
		return $"Tu saldo después de esta transacción será de {robuxBalance}.";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "Tu saldo después de esta transacción será de {robuxBalance}.";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"Necesitas {robux} más para comprar este objeto.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Necesitas {robux} más para comprar este objeto.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"Mientras comprabas, este objeto ha pasado de costar {robuxBefore} a {robuxAfter}.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "Mientras comprabas, este objeto ha pasado de costar {robuxBefore} a {robuxAfter}.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"¿Quieres comprarle el recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "¿Quieres comprarle el recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"¿Quieres comprarle el acceso al recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "¿Quieres comprarle el acceso al recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"¿Quieres obtener el recurso {freeTextStart}gratis{freeTextEnd} {assetType} \"{assetName}\" de {seller}?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "¿Quieres obtener el recurso {freeTextStart}gratis{freeTextEnd} {assetType} \"{assetName}\" de {seller}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"¿Quieres obtener el acceso {freeTextStart}gratis{freeTextEnd} al recurso {assetType} \"{assetName}\" de {seller}?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "¿Quieres obtener el acceso {freeTextStart}gratis{freeTextEnd} al recurso {assetType} \"{assetName}\" de {seller}?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"¿Quieres alquilarle el recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "¿Quieres alquilarle el recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"¿Quieres alquilarle el acceso al recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "¿Quieres alquilarle el acceso al recurso {assetType} \"{assetName}\" a {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "Las compras no están disponibles temporalmente. Inténtalo de nuevo más tarde.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"Has adquirido el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "Has adquirido el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Has adquirido el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "Has adquirido el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"Le has comprado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "Le has comprado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Le has comprado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "Le has comprado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"Has renovado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "Has renovado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Has renovado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "Has renovado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"Le has alquilado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "Le has alquilado el recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Le has alquilado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "Le has alquilado el acceso al recurso {assetType}: {assetName} a {seller} por {robux}.";
	}
}
