namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_zh_cn : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "购买通行证";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "立即购买";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "配置";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "继续";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "自定义";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "立即获取";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "以后再说";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "好";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "立即租用";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "购买物品";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "发生错误";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "获取道具";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "资金不足";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "道具价格已更改";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "购买完成";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "租用道具";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "同意并付款";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "免费";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "暂时无法购买。请稍后重试。";

	public PurchaseDialogResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "购买通行证";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "立即购买";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "配置";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "继续";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "自定义";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "立即获取";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "以后再说";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "立即租用";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "购买物品";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "发生错误";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "获取道具";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "资金不足";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "道具价格已更改";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "购买完成";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "租用道具";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "同意并付款";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "免费";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"你在此次交易后的余额将为 {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "你在此次交易后的余额将为 {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"你还需要 {robux} 才能购买此道具。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "你还需要 {robux} 才能购买此道具。";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"在你购物时，此道具的价格已从 {robuxBefore} 更改为 {robuxAfter}。";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "在你购物时，此道具的价格已从 {robuxBefore} 更改为 {robuxAfter}。";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"你是否要以 {robux} 的价格向“{seller}”购买{assetType}“{assetName}”？";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "你是否要以 {robux} 的价格向“{seller}”购买{assetType}“{assetName}”？";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"你是否要以 {robux} 的价格向“{seller}”购买{assetType}“{assetName}”的使用权？";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "你是否要以 {robux} 的价格向“{seller}”购买{assetType}“{assetName}”的使用权？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"你是否要{freeTextStart}免费{freeTextEnd}向 {seller} 获取{assetType}“{assetName}”？";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "你是否要{freeTextStart}免费{freeTextEnd}向 {seller} 获取{assetType}“{assetName}”？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"你是否要{freeTextStart}免费{freeTextEnd}向 {seller} 获取{assetType}“{assetName}”的通行证？";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "你是否要{freeTextStart}免费{freeTextEnd}向 {seller} 获取{assetType}“{assetName}”的通行证？";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"你是否要以 {robux} 的价格向“{seller}”租用{assetType}“{assetName}”？";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "你是否要以 {robux} 的价格向“{seller}”租用{assetType}“{assetName}”？";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"你是否要以 {robux} 的价格向“{seller}“租用{assetType}“{assetName}”的使用权？";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "你是否要以 {robux} 的价格向“{seller}“租用{assetType}“{assetName}”的使用权？";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "暂时无法购买。请稍后重试。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 获取 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "你已成功以 {robux} 的价格向 {seller} 获取 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 获取 {assetName} {assetType} 的使用权。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "你已成功以 {robux} 的价格向 {seller} 获取 {assetName} {assetType} 的使用权。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 购买 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "你已成功以 {robux} 的价格向 {seller} 购买 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 购买 {assetName} {assetType} 的使用权。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "你已成功以 {robux} 的价格向 {seller} 购买 {assetName} {assetType} 的使用权。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 续订 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "你已成功以 {robux} 的价格向 {seller} 续订 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 续订 {assetName} {assetType} 的使用权。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "你已成功以 {robux} 的价格向 {seller} 续订 {assetName} {assetType} 的使用权。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 租用 {assetName} {assetType}。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "你已成功以 {robux} 的价格向 {seller} 租用 {assetName} {assetType}。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"你已成功以 {robux} 的价格向 {seller} 租用 {assetName} {assetType} 的使用权。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "你已成功以 {robux} 的价格向 {seller} 租用 {assetName} {assetType} 的使用权。";
	}
}
