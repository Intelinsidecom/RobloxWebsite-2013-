namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_pt_br : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Comprar acesso";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "Comprar agora";

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
	public override string ActionGetNow => "Obter agora";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "Agora não";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "Alugar agora";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Comprar item";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "Ocorreu um erro";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "Obter item";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "Fundos insuficientes";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "Preço do item alterado";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "Compra concluída";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "Alugar item";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "Concordar e pagar";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Grátis";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "Compra não disponível temporariamente. Tente novamente mais tarde.";

	public PurchaseDialogResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Comprar acesso";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Comprar agora";
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
		return "Obter agora";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "Agora não";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "Alugar agora";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Comprar item";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "Ocorreu um erro";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "Obter item";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "Fundos insuficientes";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "Preço do item alterado";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "Compra concluída";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "Alugar item";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "Concordar e pagar";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Grátis";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"Seu saldo depois desta transação será de {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "Seu saldo depois desta transação será de {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"Você precisa de mais {robux} para comprar este item.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Você precisa de mais {robux} para comprar este item.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"Enquanto você estava comprando, o preço deste item mudou de {robuxBefore} para {robuxAfter}.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "Enquanto você estava comprando, o preço deste item mudou de {robuxBefore} para {robuxAfter}.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"Deseja comprar {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "Deseja comprar {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Gostaria de comprar o acesso a {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "Gostaria de comprar o acesso a {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Deseja adquirir {assetType}: “{assetName}“ de {seller} {freeTextStart}grátis{freeTextEnd}?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "Deseja adquirir {assetType}: “{assetName}“ de {seller} {freeTextStart}grátis{freeTextEnd}?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"Gostaria de adquirir o acesso a {assetType}: “{assetName}“ de {seller} {freeTextStart}grátis{freeTextEnd}?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "Gostaria de adquirir o acesso a {assetType}: “{assetName}“ de {seller} {freeTextStart}grátis{freeTextEnd}?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"Deseja alugar {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "Deseja alugar {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"Gostaria de alugar o acesso a {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "Gostaria de alugar o acesso a {assetType}: “{assetName}“ de {seller} por {robux}?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "Compra não disponível temporariamente. Tente novamente mais tarde.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"Você adquiriu {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "Você adquiriu {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Você adquiriu o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "Você adquiriu o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"Você comprou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "Você comprou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Você comprou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "Você comprou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"Você renovou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "Você renovou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Você renovou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "Você renovou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"Você alugou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "Você alugou {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"Você alugou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "Você alugou o acesso a {assetName} ({assetType}) de {seller} por {robux} com sucesso.";
	}
}
