namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_zh_tw : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "è¨»å†Š";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "è³¼è²·é»žæ•¸å¡";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…Œæ›";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "åˆä½µé»žæ•¸å¡ï¼Œå–å¾—æ›´å¤š Roblox é»žæ•¸ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "è‹¥è¦å…Œæ›é»žæ•¸å¡ï¼Œè«‹å…ˆç™»å…¥ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "é™ä»¥ä¸€ç¨®ä»˜æ¬¾å½¢å¼é€²è¡Œè³¼è²·ã€‚é»žæ•¸å¡é»žæ•¸ç„¡æ³•èˆ‡å…¶ä»–ä»˜æ¬¾å½¢å¼åˆä½µã€‚";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "è«‹å¾žåˆä½œå•†å®¶è³¼è²· Roblox é»žæ•¸å¡ï¼Œæˆ–è€…å‘ä»–äººå–å¾— Roblox é»žæ•¸å¡ã€‚";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "æ‚¨å¯ä»¥å°‡ Roblox é»žæ•¸ç”¨åœ¨ Robux å’Œ Builders Clubï¼";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "è«‹åœ¨å…Œæ›å€è¼¸å…¥é»žæ•¸å¡ä¸Šçš„ PINã€‚";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "è¼¸å…¥ PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "å–å¾— Roblox é»žæ•¸ï¼Œç”¨åœ¨";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "å…Œæ›æ–¹å¼";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "ä½¿ç”¨èªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "å…Œæ› Roblox é»žæ•¸å¡";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "å…Œæ› Roblox é»žæ•¸å¡";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "éœ€è¦ Roblox é»žæ•¸å¡ï¼Ÿ";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "å·²å…Œæ› Robuxï¼š";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "æ‚¨çš„é»žæ•¸é¤˜é¡ï¼š";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "æ­¤é»žæ•¸å¡å·²è¢«å…Œæ›ã€‚";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "æ‚¨åªè¦å†å…Œæ›ä¸€å¼µ GameStop çš„ Roblox é»žæ•¸å¡ï¼Œå°±å¯ä»¥ç²å¾—çŽå‹µ Robuxã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "æˆåŠŸå»¶é•· Builders Club æœƒå“¡è³‡æ ¼ï¼";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "æ›´æ–°å°‡åœ¨ 5 åˆ†é˜å…§ç”Ÿæ•ˆã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "æˆåŠŸå…Œæ› Builders Club æœƒå“¡è³‡æ ¼ï¼";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "æ²’æœ‰æ‰¾åˆ°ç›¸ç¬¦ä»£ç¢¼ã€‚";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "æ‰¾ä¸åˆ°è«‹æ±‚çš„ç‰©ä»¶ã€‚";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "æ­¤åŠŸèƒ½ç›®å‰åœç”¨ã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "è‹¥è¦åŸ·è¡Œæ­¤å‹•ä½œï¼Œè«‹å…ˆç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "æ‰¾ä¸åˆ°è«‹æ±‚çš„ç‰©ä»¶ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚è‹¥æ­¤å•é¡ŒæŒçºŒï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "æˆåŠŸå…Œæ›é»žæ•¸å¡ï¼";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "å·²å…Œæ›éŽå¤šä»£ç¢¼ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "è«‹æ±‚å¤±æ•—æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public RedeemGameCardResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "è³¼è²·é»žæ•¸å¡";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…Œæ›";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "åˆä½µé»žæ•¸å¡ï¼Œå–å¾—æ›´å¤š Roblox é»žæ•¸ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "è‹¥è¦å…Œæ›é»žæ•¸å¡ï¼Œè«‹å…ˆç™»å…¥ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "é™ä»¥ä¸€ç¨®ä»˜æ¬¾å½¢å¼é€²è¡Œè³¼è²·ã€‚é»žæ•¸å¡é»žæ•¸ç„¡æ³•èˆ‡å…¶ä»–ä»˜æ¬¾å½¢å¼åˆä½µã€‚";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"è«‹å¾ž{retailerLinkStart}åˆä½œå•†å®¶{retailerLinkEnd}è³¼è²· Roblox é»žæ•¸å¡ï¼Œæˆ–è€…å‘ä»–äººå–å¾— Roblox é»žæ•¸å¡ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "è«‹å¾ž{retailerLinkStart}åˆä½œå•†å®¶{retailerLinkEnd}è³¼è²· Roblox é»žæ•¸å¡ï¼Œæˆ–è€…å‘ä»–äººå–å¾— Roblox é»žæ•¸å¡ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "è«‹å¾žåˆä½œå•†å®¶è³¼è²· Roblox é»žæ•¸å¡ï¼Œæˆ–è€…å‘ä»–äººå–å¾— Roblox é»žæ•¸å¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "æ‚¨å¯ä»¥å°‡ Roblox é»žæ•¸ç”¨åœ¨ Robux å’Œ Builders Clubï¼";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "è«‹åœ¨å…Œæ›å€è¼¸å…¥é»žæ•¸å¡ä¸Šçš„ PINã€‚";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "è¼¸å…¥ PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "å–å¾— Roblox é»žæ•¸ï¼Œç”¨åœ¨";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "å…Œæ›æ–¹å¼";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "ä½¿ç”¨èªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "å…Œæ› Roblox é»žæ•¸å¡";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "å…Œæ› Roblox é»žæ•¸å¡";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "éœ€è¦ Roblox é»žæ•¸å¡ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "å·²å…Œæ› Robuxï¼š";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "æ‚¨çš„é»žæ•¸é¤˜é¡ï¼š";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "æ­¤é»žæ•¸å¡å·²è¢«å…Œæ›ã€‚";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "æ‚¨åªè¦å†å…Œæ›ä¸€å¼µ GameStop çš„ Roblox é»žæ•¸å¡ï¼Œå°±å¯ä»¥ç²å¾—çŽå‹µ Robuxã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "æˆåŠŸå»¶é•· Builders Club æœƒå“¡è³‡æ ¼ï¼";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "æ›´æ–°å°‡åœ¨ 5 åˆ†é˜å…§ç”Ÿæ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "æˆåŠŸå…Œæ› Builders Club æœƒå“¡è³‡æ ¼ï¼";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "æ²’æœ‰æ‰¾åˆ°ç›¸ç¬¦ä»£ç¢¼ã€‚";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "æ‰¾ä¸åˆ°è«‹æ±‚çš„ç‰©ä»¶ã€‚";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "æ­¤åŠŸèƒ½ç›®å‰åœç”¨ã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "è‹¥è¦åŸ·è¡Œæ­¤å‹•ä½œï¼Œè«‹å…ˆç™»å…¥ã€‚";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"ä½¿ç”¨è€…å˜—è©¦å…Œæ› PINï¼Œä½†å•†å®¶ä¸å­˜åœ¨ã€‚ä½¿ç”¨è€… IDï¼š{authenticatedUserId} PINï¼š{cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "ä½¿ç”¨è€…å˜—è©¦å…Œæ› PINï¼Œä½†å•†å®¶ä¸å­˜åœ¨ã€‚ä½¿ç”¨è€… IDï¼š{authenticatedUserId} PINï¼š{cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "æ‰¾ä¸åˆ°è«‹æ±‚çš„ç‰©ä»¶ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚è‹¥æ­¤å•é¡ŒæŒçºŒï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "æˆåŠŸå…Œæ›é»žæ•¸å¡ï¼";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"æ‚¨å·²æˆåŠŸå…Œæ›{productName}ï¼";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "æ‚¨å·²æˆåŠŸå…Œæ›{productName}ï¼";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "å·²å…Œæ›éŽå¤šä»£ç¢¼ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "è«‹æ±‚å¤±æ•—æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"è¬è¬æ‚¨å…Œæ›å…©å¼µ GameStop çš„ Roblox é»žæ•¸å¡ï¼Œå·²æ–°å¢ž {robuxCount} Robux åˆ°æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "è¬è¬æ‚¨å…Œæ›å…©å¼µ GameStop çš„ Roblox é»žæ•¸å¡ï¼Œå·²æ–°å¢ž {robuxCount} Robux åˆ°æ‚¨çš„å¸³è™Ÿã€‚";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"æ‚¨åªè¦å†å…Œæ›ä¸€å¼µ Walmart çš„ Roblox é»žæ•¸å¡ï¼Œå°±å¯ä»¥ç²å¾—{rewardName}ã€‚";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "æ‚¨åªè¦å†å…Œæ›ä¸€å¼µ Walmart çš„ Roblox é»žæ•¸å¡ï¼Œå°±å¯ä»¥ç²å¾—{rewardName}ã€‚";
	}
}


}
