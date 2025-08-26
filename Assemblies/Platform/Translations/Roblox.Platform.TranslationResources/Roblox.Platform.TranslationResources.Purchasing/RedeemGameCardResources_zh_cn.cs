namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_zh_cn : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "å…³é—­";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "è´­ä¹°ç¤¼å“å¡";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…‘æ¢";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "å°†å¡ç‰‡åˆå¹¶æ¥èŽ·å¾—æ›´å¤š Roblox ç‚¹æ•°ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "è‹¥è¦å…‘æ¢ç¤¼å“å¡ï¼Œä½ å¿…é¡»å…ˆç™»å½• Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "è´­ä¹°æ—¶ä»…é™ä½¿ç”¨ä¸€ç§ä»˜æ¬¾æ–¹å¼ã€‚ç¤¼å“å¡ç‚¹æ•°æ— æ³•ä¸Žå…¶ä»–ä»˜æ¬¾æ–¹å¼åˆå¹¶ã€‚";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "è¯·ä»Žä»»ä¸€åˆä½œé›¶å”®å•†å¤„è´­ä¹° Roblox ç¤¼å“å¡ï¼Œæˆ–æŽ¥å—ä»–äººèµ é€çš„ Roblox ç¤¼å“å¡ã€‚";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "ä½ å¯å°† Roblox ç‚¹æ•°ç”¨åœ¨ Robux å’Œ Builders Clubï¼";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "è¯·åœ¨å…‘æ¢åŒºä¸­è¾“å…¥å¡ç‰‡ä¸Šçš„ PINã€‚";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "è¯·è¾“å…¥ PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "èŽ·å¾— Roblox ç‚¹æ•°å¯ç”¨äºŽ";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "å…‘æ¢æ–¹æ³•";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "ä½¿ç”¨è¯´æ˜Ž";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "å…‘æ¢ Roblox ç¤¼å“å¡";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "å…‘æ¢ Roblox ç¤¼å“å¡";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "éœ€è¦ Roblox ç¤¼å“å¡ï¼Ÿ";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN ç ";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "å·²å…‘æ¢ Robuxï¼š";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "ä½ çš„ç‚¹æ•°ä½™é¢ï¼š";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "æ­¤ç¤¼å“å¡å·²è¢«å…‘æ¢ã€‚";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "ä»Ž GameStop å†å…‘æ¢ä¸€å¼  Roblox å¡å³å¯èŽ·å¾—é¢å¤– Robux å¥–åŠ±ã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å·²å»¶æœŸæˆåŠŸï¼";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "è¯·ç¨å€™æœ€å¤š 5 åˆ†é’Ÿä»¥ç­‰å¾…æ›´æ”¹ç”Ÿæ•ˆã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å·²æˆåŠŸå…‘æ¢ï¼";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "æœªæ‰¾åˆ°ç›¸ç¬¦çš„ä»£ç ã€‚";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "æ‰¾ä¸åˆ°æ‰€è¯·æ±‚çš„å¯¹è±¡ã€‚";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "æ­¤åŠŸèƒ½å½“å‰å·²åœç”¨ã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN æ— æ•ˆ";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "ä½ å¿…é¡»ç™»å½•æ‰èƒ½æ‰§è¡Œæ­¤æ“ä½œã€‚";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "æ‰¾ä¸åˆ°æ‰€è¯·æ±‚çš„å¯¹è±¡ã€‚è¯·é‡è¯•è¯·æ±‚ï¼Œå¦‚æžœé—®é¢˜ä»ç„¶å­˜åœ¨ï¼Œè¯·è”ç³»å®¢æˆ·æœåŠ¡ã€‚";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "ä½ å·²æˆåŠŸå…‘æ¢å¡ç‰‡ï¼";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "å…‘æ¢ä»£ç è¿‡å¤šã€‚è¯·ç¨åŽé‡æ–°æäº¤è¯·æ±‚ã€‚";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "å¤±è´¥è¯·æ±‚å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public RedeemGameCardResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "è´­ä¹°ç¤¼å“å¡";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…‘æ¢";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "å°†å¡ç‰‡åˆå¹¶æ¥èŽ·å¾—æ›´å¤š Roblox ç‚¹æ•°ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "è‹¥è¦å…‘æ¢ç¤¼å“å¡ï¼Œä½ å¿…é¡»å…ˆç™»å½• Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "è´­ä¹°æ—¶ä»…é™ä½¿ç”¨ä¸€ç§ä»˜æ¬¾æ–¹å¼ã€‚ç¤¼å“å¡ç‚¹æ•°æ— æ³•ä¸Žå…¶ä»–ä»˜æ¬¾æ–¹å¼åˆå¹¶ã€‚";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"è¯·ä»Žä»»ä¸€{retailerLinkStart}åˆä½œé›¶å”®å•†{retailerLinkEnd}å¤„è´­ä¹° Roblox ç¤¼å“å¡ï¼Œæˆ–æŽ¥å—ä»–äººèµ äºˆçš„ Roblox ç¤¼å“å¡ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "è¯·ä»Žä»»ä¸€{retailerLinkStart}åˆä½œé›¶å”®å•†{retailerLinkEnd}å¤„è´­ä¹° Roblox ç¤¼å“å¡ï¼Œæˆ–æŽ¥å—ä»–äººèµ äºˆçš„ Roblox ç¤¼å“å¡ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "è¯·ä»Žä»»ä¸€åˆä½œé›¶å”®å•†å¤„è´­ä¹° Roblox ç¤¼å“å¡ï¼Œæˆ–æŽ¥å—ä»–äººèµ é€çš„ Roblox ç¤¼å“å¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "ä½ å¯å°† Roblox ç‚¹æ•°ç”¨åœ¨ Robux å’Œ Builders Clubï¼";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "è¯·åœ¨å…‘æ¢åŒºä¸­è¾“å…¥å¡ç‰‡ä¸Šçš„ PINã€‚";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "è¯·è¾“å…¥ PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "èŽ·å¾— Roblox ç‚¹æ•°å¯ç”¨äºŽ";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "å…‘æ¢æ–¹æ³•";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "ä½¿ç”¨è¯´æ˜Ž";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "å…‘æ¢ Roblox ç¤¼å“å¡";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "å…‘æ¢ Roblox ç¤¼å“å¡";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "éœ€è¦ Roblox ç¤¼å“å¡ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN ç ";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "å·²å…‘æ¢ Robuxï¼š";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "ä½ çš„ç‚¹æ•°ä½™é¢ï¼š";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "æ­¤ç¤¼å“å¡å·²è¢«å…‘æ¢ã€‚";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "ä»Ž GameStop å†å…‘æ¢ä¸€å¼  Roblox å¡å³å¯èŽ·å¾—é¢å¤– Robux å¥–åŠ±ã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å·²å»¶æœŸæˆåŠŸï¼";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "è¯·ç¨å€™æœ€å¤š 5 åˆ†é’Ÿä»¥ç­‰å¾…æ›´æ”¹ç”Ÿæ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å·²æˆåŠŸå…‘æ¢ï¼";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "æœªæ‰¾åˆ°ç›¸ç¬¦çš„ä»£ç ã€‚";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "æ‰¾ä¸åˆ°æ‰€è¯·æ±‚çš„å¯¹è±¡ã€‚";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "æ­¤åŠŸèƒ½å½“å‰å·²åœç”¨ã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN æ— æ•ˆ";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "ä½ å¿…é¡»ç™»å½•æ‰èƒ½æ‰§è¡Œæ­¤æ“ä½œã€‚";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"ç”¨æˆ·å°è¯•å…‘æ¢ PINï¼Œä½†å•†å®¶ä¸å­˜åœ¨ã€‚ç”¨æˆ· IDï¼š{authenticatedUserId} PINï¼š{cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "ç”¨æˆ·å°è¯•å…‘æ¢ PINï¼Œä½†å•†å®¶ä¸å­˜åœ¨ã€‚ç”¨æˆ· IDï¼š{authenticatedUserId} PINï¼š{cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "æ‰¾ä¸åˆ°æ‰€è¯·æ±‚çš„å¯¹è±¡ã€‚è¯·é‡è¯•è¯·æ±‚ï¼Œå¦‚æžœé—®é¢˜ä»ç„¶å­˜åœ¨ï¼Œè¯·è”ç³»å®¢æˆ·æœåŠ¡ã€‚";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ä½ å·²æˆåŠŸå…‘æ¢å¡ç‰‡ï¼";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"ä½ å·²æˆåŠŸå°†å¡å…‘æ¢ä¸º {productName}";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "ä½ å·²æˆåŠŸå°†å¡å…‘æ¢ä¸º {productName}";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "å…‘æ¢ä»£ç è¿‡å¤šã€‚è¯·ç¨åŽé‡æ–°æäº¤è¯·æ±‚ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "å¤±è´¥è¯·æ±‚å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"æ„Ÿè°¢ä½ ä»Ž GameStop å…‘æ¢äº†ä¸¤å¼  Roblox å¡ã€‚{robuxCount} Robux å·²æ·»åŠ è‡³ä½ çš„å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "æ„Ÿè°¢ä½ ä»Ž GameStop å…‘æ¢äº†ä¸¤å¼  Roblox å¡ã€‚{robuxCount} Robux å·²æ·»åŠ è‡³ä½ çš„å¸æˆ·ã€‚";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"ä»Ž Walmart å†å…‘æ¢ä¸€å¼  Roblox å¡å³å¯èŽ·å¾— {rewardName}ã€‚";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "ä»Ž Walmart å†å…‘æ¢ä¸€å¼  Roblox å¡å³å¯èŽ·å¾— {rewardName}ã€‚";
	}
}


}
