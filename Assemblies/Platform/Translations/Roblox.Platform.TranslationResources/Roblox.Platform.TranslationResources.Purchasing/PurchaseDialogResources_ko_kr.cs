namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_ko_kr : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "ì´ìš©ê¶Œ êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "ì§€ê¸ˆ êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "êµ¬ì„±";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ê³„ì†";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "ì‚¬ìš©ìž ì •ì˜";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "ì§€ê¸ˆ íšë“";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "ë‚˜ì¤‘ì—";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "í™•ì¸";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "ì§€ê¸ˆ ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "ì•„ì´í…œ êµ¬ë§¤";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "ì•„ì´í…œ íšë“";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "ìž”ì•¡ ë¶€ì¡±";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "ì•„ì´í…œ ê°€ê²© ë³€ë™ë¨";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "êµ¬ë§¤ ì™„ë£Œ";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "ì•„ì´í…œ ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "ë™ì˜ ë° ê²°ì œ";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ë¬´ë£Œ";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "ì¼ì‹œì ìœ¼ë¡œ êµ¬ë§¤ ë¶ˆê°€. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public PurchaseDialogResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "ì´ìš©ê¶Œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ì§€ê¸ˆ êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "êµ¬ì„±";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ê³„ì†";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "ì‚¬ìš©ìž ì •ì˜";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "ì§€ê¸ˆ íšë“";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "ë‚˜ì¤‘ì—";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "ì§€ê¸ˆ ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "ì•„ì´í…œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "ì˜¤ë¥˜ ë°œìƒ";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "ì•„ì´í…œ íšë“";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "ìž”ì•¡ ë¶€ì¡±";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "ì•„ì´í…œ ê°€ê²© ë³€ë™ë¨";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "êµ¬ë§¤ ì™„ë£Œ";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "ì•„ì´í…œ ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "ë™ì˜ ë° ê²°ì œ";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ë¬´ë£Œ";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"ë³¸ ê±°ëž˜ í›„ íšŒì›ë‹˜ì˜ ìž”ì•¡ì€ {robuxBalance}ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "ë³¸ ê±°ëž˜ í›„ íšŒì›ë‹˜ì˜ ìž”ì•¡ì€ {robuxBalance}ìž…ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"{robux}ì´(ê°€) ë” ìžˆì–´ì•¼ ë³¸ ì•„ì´í…œì„ êµ¬ë§¤í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "{robux}ì´(ê°€) ë” ìžˆì–´ì•¼ ë³¸ ì•„ì´í…œì„ êµ¬ë§¤í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"íšŒì›ë‹˜ì´ ì‡¼í•‘í•˜ëŠ” ë™ì•ˆ ì•„ì´í…œì˜ ê°€ê²©ì´ {robuxBefore}ì—ì„œ {robuxAfter}(ìœ¼)ë¡œ ë³€ê²½ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "íšŒì›ë‹˜ì´ ì‡¼í•‘í•˜ëŠ” ë™ì•ˆ ì•„ì´í…œì˜ ê°€ê²©ì´ {robuxBefore}ì—ì„œ {robuxAfter}(ìœ¼)ë¡œ ë³€ê²½ë˜ì—ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetType}: \"{assetName}\"ì„(ë¥¼) {robux}ì— êµ¬ë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetType}: \"{assetName}\"ì„(ë¥¼) {robux}ì— êµ¬ë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {robux}ì— êµ¬ë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {robux}ì— êµ¬ë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}ë‹˜ì˜ {assetType}: \"{assetName}\"ì„(ë¥¼) {freeTextStart}ë¬´ë£Œ{freeTextEnd}ë¡œ íšë“í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "{seller}ë‹˜ì˜ {assetType}: \"{assetName}\"ì„(ë¥¼) {freeTextStart}ë¬´ë£Œ{freeTextEnd}ë¡œ íšë“í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}ë‹˜ì˜ {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {freeTextStart}ë¬´ë£Œ{freeTextEnd}ë¡œ íšë“í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "{seller}ë‹˜ì˜ {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {freeTextStart}ë¬´ë£Œ{freeTextEnd}ë¡œ íšë“í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetType}: \"{assetName}\"ì„(ë¥¼) {robux}ì— ë¹Œë¦¬ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetType}: \"{assetName}\"ì„(ë¥¼) {robux}ì— ë¹Œë¦¬ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {robux}ì— ë¹Œë¦¬ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetType}: \"{assetName}\" ì´ìš©ê¶Œì„ {robux}ì— ë¹Œë¦¬ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "ì¼ì‹œì ìœ¼ë¡œ êµ¬ë§¤ ë¶ˆê°€. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— íšë“í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— íšë“í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— íšë“í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— íšë“í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— êµ¬ë§¤í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— êµ¬ë§¤í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— êµ¬ë§¤í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— êµ¬ë§¤í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— ê°±ì‹ í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— ê°±ì‹ í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— ê°±ì‹ í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "{seller}ë‹˜ì´ íŒë§¤í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— ê°±ì‹ í–ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— ë¹Œë ¸ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetName} {assetType}ì„(ë¥¼) {robux}ì— ë¹Œë ¸ìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— ë¹Œë ¸ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "{seller}ë‹˜ì´ ëŒ€ì—¬í•˜ëŠ” {assetName} {assetType}ì˜ ì´ìš©ê¶Œì„ {robux}ì— ë¹Œë ¸ìŠµë‹ˆë‹¤.";
	}
}


}
