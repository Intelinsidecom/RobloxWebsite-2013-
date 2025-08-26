namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_zh_cjv : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "è´­ä¹°é€šè¡Œè¯";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "ç«‹å³è´­ä¹°";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "é…ç½®";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ç»§ç»­";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "è‡ªå®šä¹‰";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "ç«‹å³èŽ·å–";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "ä»¥åŽå†è¯´";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "å¥½";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "ç«‹å³ç§Ÿç”¨";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "è´­ä¹°ç‰©å“";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "èŽ·å–é“å…·";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "èµ„é‡‘ä¸è¶³";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "é“å…·ä»·æ ¼å·²æ›´æ”¹";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "è´­ä¹°å®Œæˆ";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "ç§Ÿç”¨é“å…·";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "åŒæ„å¹¶ä»˜æ¬¾";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "å…è´¹";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "æš‚æ—¶æ— æ³•è´­ä¹°ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public PurchaseDialogResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "è´­ä¹°é€šè¡Œè¯";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ç«‹å³è´­ä¹°";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "é…ç½®";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç»§ç»­";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "è‡ªå®šä¹‰";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "ç«‹å³èŽ·å–";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "ä»¥åŽå†è¯´";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "ç«‹å³ç§Ÿç”¨";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "è´­ä¹°ç‰©å“";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "å‘ç”Ÿé”™è¯¯";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "èŽ·å–é“å…·";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "èµ„é‡‘ä¸è¶³";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "é“å…·ä»·æ ¼å·²æ›´æ”¹";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "è´­ä¹°å®Œæˆ";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "ç§Ÿç”¨é“å…·";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "åŒæ„å¹¶ä»˜æ¬¾";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "å…è´¹";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"ä½ åœ¨æ­¤æ¬¡äº¤æ˜“åŽçš„ä½™é¢å°†ä¸º {robuxBalance}";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "ä½ åœ¨æ­¤æ¬¡äº¤æ˜“åŽçš„ä½™é¢å°†ä¸º {robuxBalance}";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"ä½ è¿˜éœ€è¦ {robux} æ‰èƒ½è´­ä¹°æ­¤é“å…·ã€‚";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "ä½ è¿˜éœ€è¦ {robux} æ‰èƒ½è´­ä¹°æ­¤é“å…·ã€‚";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"åœ¨ä½ è´­ç‰©æ—¶ï¼Œæ­¤é“å…·çš„ä»·æ ¼å·²ä»Ž {robuxBefore} æ›´æ”¹ä¸º {robuxAfter}ã€‚";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "åœ¨ä½ è´­ç‰©æ—¶ï¼Œæ­¤é“å…·çš„ä»·æ ¼å·²ä»Ž {robuxBefore} æ›´æ”¹ä¸º {robuxAfter}ã€‚";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€è´­ä¹°{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€è´­ä¹°{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€è´­ä¹°{assetType}â€œ{assetName}â€çš„ä½¿ç”¨æƒï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€è´­ä¹°{assetType}â€œ{assetName}â€çš„ä½¿ç”¨æƒï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"ä½ æ˜¯å¦è¦{freeTextStart}å…è´¹{freeTextEnd}å‘ {seller} èŽ·å–{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "ä½ æ˜¯å¦è¦{freeTextStart}å…è´¹{freeTextEnd}å‘ {seller} èŽ·å–{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"ä½ æ˜¯å¦è¦{freeTextStart}å…è´¹{freeTextEnd}å‘ {seller} èŽ·å–{assetType}â€œ{assetName}â€çš„é€šè¡Œè¯ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "ä½ æ˜¯å¦è¦{freeTextStart}å…è´¹{freeTextEnd}å‘ {seller} èŽ·å–{assetType}â€œ{assetName}â€çš„é€šè¡Œè¯ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€ç§Ÿç”¨{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€ç§Ÿç”¨{assetType}â€œ{assetName}â€ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€œç§Ÿç”¨{assetType}â€œ{assetName}â€çš„ä½¿ç”¨æƒï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{seller}â€œç§Ÿç”¨{assetType}â€œ{assetName}â€çš„ä½¿ç”¨æƒï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "æš‚æ—¶æ— æ³•è´­ä¹°ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} èŽ·å– {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} èŽ·å– {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} èŽ·å– {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} èŽ·å– {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} è´­ä¹° {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} è´­ä¹° {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} è´­ä¹° {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} è´­ä¹° {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç»­è®¢ {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç»­è®¢ {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç»­è®¢ {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç»­è®¢ {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç§Ÿç”¨ {assetName} {assetType}ã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç§Ÿç”¨ {assetName} {assetType}ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç§Ÿç”¨ {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "ä½ å·²æˆåŠŸä»¥ {robux} çš„ä»·æ ¼å‘ {seller} ç§Ÿç”¨ {assetName} {assetType} çš„ä½¿ç”¨æƒã€‚";
	}
}


}
