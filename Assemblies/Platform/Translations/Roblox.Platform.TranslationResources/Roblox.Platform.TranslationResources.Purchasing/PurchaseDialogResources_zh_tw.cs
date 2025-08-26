namespace Roblox.Platform.TranslationResources.Purchasing {
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
	public override string ActionBuyAccess => "è³¼è²·é€šè¡Œæ¬Š";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "ç¾åœ¨è³¼è²·";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "è¨­å®š";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ç¹¼çºŒ";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "è‡ªè¨‚";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "ç¾åœ¨å–å¾—";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "ä¸‹æ¬¡å†èªª";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "ç¾åœ¨ç§Ÿç”¨";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "è³¼è²·é“å…·";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "å–å¾—é“å…·";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "è³‡é‡‘ä¸è¶³";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "é“å…·åƒ¹æ ¼å·²è®Šæ›´";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "è³¼è²·å®Œæˆ";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "ç§Ÿç”¨é“å…·";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "åŒæ„ä¸¦ä»˜æ¬¾";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "å…è²»";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "æš«æ™‚ç„¡æ³•è³¼è²·ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public PurchaseDialogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "è³¼è²·é€šè¡Œæ¬Š";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ç¾åœ¨è³¼è²·";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç¹¼çºŒ";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "è‡ªè¨‚";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "ç¾åœ¨å–å¾—";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "ä¸‹æ¬¡å†èªª";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "ç¾åœ¨ç§Ÿç”¨";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "è³¼è²·é“å…·";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "å–å¾—é“å…·";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "è³‡é‡‘ä¸è¶³";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "é“å…·åƒ¹æ ¼å·²è®Šæ›´";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "è³¼è²·å®Œæˆ";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "ç§Ÿç”¨é“å…·";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "åŒæ„ä¸¦ä»˜æ¬¾";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "å…è²»";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"æ‚¨åœ¨æ­¤äº¤æ˜“å¾Œçš„é¤˜é¡å°‡ç‚º {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "æ‚¨åœ¨æ­¤äº¤æ˜“å¾Œçš„é¤˜é¡å°‡ç‚º {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"æ‚¨é‚„éœ€è¦ {robux} æ‰èƒ½è³¼è²·æ­¤é“å…·ã€‚";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "æ‚¨é‚„éœ€è¦ {robux} æ‰èƒ½è³¼è²·æ­¤é“å…·ã€‚";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"åœ¨æ‚¨è³¼ç‰©æ™‚ï¼Œæ­¤é“å…·åƒ¹æ ¼å·²å¾ž {robuxBefore} è®Šæ›´ç‚º {robuxAfter}ã€‚";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "åœ¨æ‚¨è³¼ç‰©æ™‚ï¼Œæ­¤é“å…·åƒ¹æ ¼å·²å¾ž {robuxBefore} è®Šæ›´ç‚º {robuxAfter}ã€‚";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"æ‚¨è¦å‘ {seller} ä»¥ {robux} è³¼è²·{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "æ‚¨è¦å‘ {seller} ä»¥ {robux} è³¼è²·{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"æ‚¨è¦å‘ {seller} ä»¥ {robux} è³¼è²·{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "æ‚¨è¦å‘ {seller} ä»¥ {robux} è³¼è²·{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"æ‚¨è¦å‘ {seller} {freeTextStart}å…è²»{freeTextEnd}å–å¾—{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "æ‚¨è¦å‘ {seller} {freeTextStart}å…è²»{freeTextEnd}å–å¾—{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"æ‚¨è¦å‘ {seller} {freeTextStart}å…è²»{freeTextEnd}å–å¾—{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "æ‚¨è¦å‘ {seller} {freeTextStart}å…è²»{freeTextEnd}å–å¾—{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"æ‚¨è¦å‘ {seller} ä»¥ {robux} ç§Ÿç”¨{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "æ‚¨è¦å‘ {seller} ä»¥ {robux} ç§Ÿç”¨{assetType}ã€Œ{assetName}ã€å—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"æ‚¨è¦å‘ {seller} ä»¥ {robux} ç§Ÿç”¨{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "æ‚¨è¦å‘ {seller} ä»¥ {robux} ç§Ÿç”¨{assetType}ã€Œ{assetName}ã€çš„ä½¿ç”¨æ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "æš«æ™‚ç„¡æ³•è³¼è²·ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå¾ž {seller} ä»¥ {robux} å–å¾— {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "æ‚¨å·²æˆåŠŸå¾ž {seller} ä»¥ {robux} å–å¾— {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} å–å¾—å° {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} å–å¾—å° {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå¾ž {seller} ä»¥ {robux} è³¼è²· {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "æ‚¨å·²æˆåŠŸå¾ž {seller} ä»¥ {robux} è³¼è²· {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} è³¼è²· {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} è³¼è²· {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸè‡ª {seller} ä»¥ {robux} çºŒè¨‚ {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "æ‚¨å·²æˆåŠŸè‡ª {seller} ä»¥ {robux} çºŒè¨‚ {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} çºŒè¨‚ {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} çºŒè¨‚ {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸè‡ª {seller} ä»¥ {robux} ç§Ÿç”¨ {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "æ‚¨å·²æˆåŠŸè‡ª {seller} ä»¥ {robux} ç§Ÿç”¨ {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} ç§Ÿç”¨ {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "æ‚¨å·²æˆåŠŸå‘ {seller} ä»¥ {robux} ç§Ÿç”¨ {assetName} {assetType}çš„ä½¿ç”¨æ¬Šã€‚";
	}
}


}
