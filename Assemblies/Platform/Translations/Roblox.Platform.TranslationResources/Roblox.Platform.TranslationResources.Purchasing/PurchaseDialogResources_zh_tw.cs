namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_zh_tw : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "購買通行權";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "現在購買";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "設定";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "繼續";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "自訂";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "現在取得";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "下次再說";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "確定";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "現在租用";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "購買道具";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "發生錯誤";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "取得道具";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "資金不足";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "道具價格已變更";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "購買完成";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "租用道具";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "同意並付款";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "免費";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "暫時無法購買，請稍後再試。";

	public PurchaseDialogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "購買通行權";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "現在購買";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "設定";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "繼續";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "自訂";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "現在取得";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "下次再說";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "現在租用";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "購買道具";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "取得道具";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "資金不足";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "道具價格已變更";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "購買完成";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "租用道具";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "同意並付款";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "免費";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"您在此交易後的餘額將為 {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "您在此交易後的餘額將為 {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"您還需要 {robux} 才能購買此道具。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "您還需要 {robux} 才能購買此道具。";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"在您購物時，此道具價格已從 {robuxBefore} 變更為 {robuxAfter}。";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "在您購物時，此道具價格已從 {robuxBefore} 變更為 {robuxAfter}。";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"您要向 {seller} 以 {robux} 購買{assetType}「{assetName}」嗎？";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "您要向 {seller} 以 {robux} 購買{assetType}「{assetName}」嗎？";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"您要向 {seller} 以 {robux} 購買{assetType}「{assetName}」的使用權嗎？";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "您要向 {seller} 以 {robux} 購買{assetType}「{assetName}」的使用權嗎？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"您要向 {seller} {freeTextStart}免費{freeTextEnd}取得{assetType}「{assetName}」嗎？";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "您要向 {seller} {freeTextStart}免費{freeTextEnd}取得{assetType}「{assetName}」嗎？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"您要向 {seller} {freeTextStart}免費{freeTextEnd}取得{assetType}「{assetName}」的使用權嗎？";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "您要向 {seller} {freeTextStart}免費{freeTextEnd}取得{assetType}「{assetName}」的使用權嗎？";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"您要向 {seller} 以 {robux} 租用{assetType}「{assetName}」嗎？";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "您要向 {seller} 以 {robux} 租用{assetType}「{assetName}」嗎？";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"您要向 {seller} 以 {robux} 租用{assetType}「{assetName}」的使用權嗎？";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "您要向 {seller} 以 {robux} 租用{assetType}「{assetName}」的使用權嗎？";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "暫時無法購買，請稍後再試。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功從 {seller} 以 {robux} 取得 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "您已成功從 {seller} 以 {robux} 取得 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功向 {seller} 以 {robux} 取得對 {assetName} {assetType}的使用權。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "您已成功向 {seller} 以 {robux} 取得對 {assetName} {assetType}的使用權。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功從 {seller} 以 {robux} 購買 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "您已成功從 {seller} 以 {robux} 購買 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功向 {seller} 以 {robux} 購買 {assetName} {assetType}的使用權。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "您已成功向 {seller} 以 {robux} 購買 {assetName} {assetType}的使用權。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功自 {seller} 以 {robux} 續訂 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "您已成功自 {seller} 以 {robux} 續訂 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功向 {seller} 以 {robux} 續訂 {assetName} {assetType}的使用權。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "您已成功向 {seller} 以 {robux} 續訂 {assetName} {assetType}的使用權。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功自 {seller} 以 {robux} 租用 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "您已成功自 {seller} 以 {robux} 租用 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"您已成功向 {seller} 以 {robux} 租用 {assetName} {assetType}的使用權。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "您已成功向 {seller} 以 {robux} 租用 {assetName} {assetType}的使用權。";
	}
}
