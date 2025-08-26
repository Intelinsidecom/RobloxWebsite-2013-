namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_ja_jp : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "ä»Šã™ãè²·ã†";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "è¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ç¶šã‘ã‚‹";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚º";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "ä»Šã™ãã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "ã‚ã¨ã§";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "ä»Šã™ããƒ¬ãƒ³ã‚¿ãƒ«ã™ã‚‹";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "è³‡é‡‘ãŒè¶³ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "ã‚¢ã‚¤ãƒ†ãƒ ã®ä¾¡æ ¼ãŒå¤‰ã‚ã‚Šã¾ã—ãŸ";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "è³¼å…¥å®Œäº†";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãƒ¬ãƒ³ã‚¿ãƒ«ã™ã‚‹";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "åŒæ„ã—ã¦æ”¯æ‰•ã†";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ç„¡æ–™";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "ä¸€æ™‚çš„ã«è³¼å…¥ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public PurchaseDialogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ä»Šã™ãè²·ã†";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "è¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç¶šã‘ã‚‹";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚º";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "ä»Šã™ãã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "ã‚ã¨ã§";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "ä»Šã™ããƒ¬ãƒ³ã‚¿ãƒ«ã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "è³‡é‡‘ãŒè¶³ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã®ä¾¡æ ¼ãŒå¤‰ã‚ã‚Šã¾ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "è³¼å…¥å®Œäº†";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãƒ¬ãƒ³ã‚¿ãƒ«ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "åŒæ„ã—ã¦æ”¯æ‰•ã†";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ç„¡æ–™";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"å–å¼•å¾Œã®æ®‹é«˜ã¯{robuxBalance}ã«ãªã‚Šã¾ã™";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "å–å¼•å¾Œã®æ®‹é«˜ã¯{robuxBalance}ã«ãªã‚Šã¾ã™";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†ã«ã¯ã€ã‚ã¨{robux}ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†ã«ã¯ã€ã‚ã¨{robux}ãŒå¿…è¦ã§ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"ã‚·ãƒ§ãƒƒãƒ”ãƒ³ã‚°ä¸­ã«ã€ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã®ä¾¡æ ¼ãŒ{robuxBefore}ã‹ã‚‰{robuxAfter}ã«å¤‰ã‚ã‚Šã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "ã‚·ãƒ§ãƒƒãƒ”ãƒ³ã‚°ä¸­ã«ã€ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã®ä¾¡æ ¼ãŒ{robuxBefore}ã‹ã‚‰{robuxAfter}ã«å¤‰ã‚ã‚Šã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{robux}ã§è³¼å…¥ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{robux}ã§è³¼å…¥ã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§è³¼å…¥ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§è³¼å…¥ã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{freeTextStart}ç„¡æ–™{freeTextEnd}ã§ã‚²ãƒƒãƒˆã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{freeTextStart}ç„¡æ–™{freeTextEnd}ã§ã‚²ãƒƒãƒˆã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{freeTextStart}ç„¡æ–™{freeTextEnd}ã§ã‚²ãƒƒãƒˆã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{freeTextStart}ç„¡æ–™{freeTextEnd}ã§ã‚²ãƒƒãƒˆã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetType} ã€Œ{assetName}ã€ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "ä¸€æ™‚çš„ã«è³¼å…¥ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§å–å¾—ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§å–å¾—ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§å–å¾—ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§å–å¾—ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§è³¼å…¥ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§è³¼å…¥ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§è³¼å…¥ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§è³¼å…¥ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§æ›´æ–°ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§æ›´æ–°ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§æ›´æ–°ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§æ›´æ–°ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "{seller}ã•ã‚“ãŒä½œæˆã—ãŸ{assetName} {assetType}ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’{robux}ã§ãƒ¬ãƒ³ã‚¿ãƒ«ã—ã¾ã—ãŸã€‚";
	}
}


}
