namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_ko_kr : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "íšŒì›ê°€ìž…";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "ì¹´ë“œ êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "ì‚¬ìš©";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "ì¹´ë“œë¥¼ ê²°í•©í•˜ë©´ ë” ë§Žì€ Roblox í¬ë ˆë”§ì„ ë°›ìœ¼ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "ê²Œìž„ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "êµ¬ë§¤ ì‹œ í•˜ë‚˜ì˜ ê²°ì œ ìˆ˜ë‹¨ë§Œ ì‚¬ìš©í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê²Œìž„ì¹´ë“œ í¬ë ˆë”§ì€ ë‹¤ë¥¸ ê²°ì œ ìˆ˜ë‹¨ê³¼ í•¨ê»˜ ì‚¬ìš©í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "ì œíœ´ ë§¤ìž¥ì—ì„œ Roblox ê²Œìž„ì¹´ë“œë¥¼ êµ¬ë§¤í•˜ê±°ë‚˜ ì„ ë¬¼ë°›ì€ Roblox ìƒí’ˆê¶Œì„ ì´ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Roblox í¬ë ˆë”§ìœ¼ë¡œ Robuxë¥¼ êµ¬ìž…í•˜ê±°ë‚˜ Builders Clubì— ê°€ìž…í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "ì¹´ë“œ ì‚¬ìš©ëž€ì— ì¹´ë“œ PINì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "PIN ìž…ë ¥";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Roblox í¬ë ˆë”§ìœ¼ë¡œ êµ¬ìž…í•´ë³´ì„¸ìš”";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "ì‚¬ìš© ë°©ë²•";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "ì‚¬ìš© ë°©ë²•";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Roblox ì¹´ë“œ ì‚¬ìš©";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Roblox ê²Œìž„ì¹´ë“œ ì‚¬ìš©";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Roblox ê²Œìž„ì¹´ë“œê°€ í•„ìš”í•˜ì„¸ìš”?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN ì½”ë“œ";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "êµí™˜ë°›ì€ Robux:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "ë‚˜ì˜ í¬ë ˆë”§ ìž”ì•¡:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "ì´ë¯¸ ì‚¬ìš©í•œ ìƒí’ˆê¶Œìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "GameStopì—ì„œ êµ¬ìž…í•œ Roblox ì¹´ë“œë¥¼ í•œ ìž¥ ë” ì‚¬ìš©í•˜ì‹œê³  ë³´ë„ˆìŠ¤ Robuxë„ ë°›ì•„ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Builders Club ë©¤ë²„ì‹­ ì—°ìž¥ì„ ì™„ë£Œí–ˆì–´ìš”!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "ë³€ê²½ ì‚¬í•­ì„ ì ìš©í•˜ë ¤ë©´ ìµœëŒ€ 5 ë¶„ì´ ì†Œìš”ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Builders Club ë©¤ë²„ì‹­ êµ¬ë§¤ë¥¼ ì™„ë£Œí–ˆì–´ìš”!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "ì¼ì¹˜í•˜ëŠ” ì½”ë“œê°€ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "ìš”ì²­í•œ ëŒ€ìƒì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "ë³¸ ê¸°ëŠ¥ì€ í˜„ìž¬ ë¹„í™œì„±í™” ìƒíƒœìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "ìœ íš¨í•˜ì§€ ì•Šì€ PIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "ë³¸ ìž‘ì—…ì„ ìˆ˜í–‰í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "ìš”ì²­í•œ ëŒ€ìƒì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "ì¹´ë“œ ì‚¬ìš©ì„ ì™„ë£Œí–ˆì–´ìš”!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "ì½”ë“œ ì‚¬ìš© ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public RedeemGameCardResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "ì¹´ë“œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "ì‚¬ìš©";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "ì¹´ë“œë¥¼ ê²°í•©í•˜ë©´ ë” ë§Žì€ Roblox í¬ë ˆë”§ì„ ë°›ìœ¼ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "ê²Œìž„ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "êµ¬ë§¤ ì‹œ í•˜ë‚˜ì˜ ê²°ì œ ìˆ˜ë‹¨ë§Œ ì‚¬ìš©í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê²Œìž„ì¹´ë“œ í¬ë ˆë”§ì€ ë‹¤ë¥¸ ê²°ì œ ìˆ˜ë‹¨ê³¼ í•¨ê»˜ ì‚¬ìš©í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"{retailerLinkStart}ì œíœ´ ë§¤ìž¥{retailerLinkEnd}ì—ì„œ Roblox ê²Œìž„ì¹´ë“œë¥¼ êµ¬ë§¤í•˜ê±°ë‚˜ ì„ ë¬¼ë°›ì€\nRoblox ìƒí’ˆê¶Œì„ ì´ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "{retailerLinkStart}ì œíœ´ ë§¤ìž¥{retailerLinkEnd}ì—ì„œ Roblox ê²Œìž„ì¹´ë“œë¥¼ êµ¬ë§¤í•˜ê±°ë‚˜ ì„ ë¬¼ë°›ì€\nRoblox ìƒí’ˆê¶Œì„ ì´ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "ì œíœ´ ë§¤ìž¥ì—ì„œ Roblox ê²Œìž„ì¹´ë“œë¥¼ êµ¬ë§¤í•˜ê±°ë‚˜ ì„ ë¬¼ë°›ì€ Roblox ìƒí’ˆê¶Œì„ ì´ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Roblox í¬ë ˆë”§ìœ¼ë¡œ Robuxë¥¼ êµ¬ìž…í•˜ê±°ë‚˜ Builders Clubì— ê°€ìž…í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "ì¹´ë“œ ì‚¬ìš©ëž€ì— ì¹´ë“œ PINì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "PIN ìž…ë ¥";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Roblox í¬ë ˆë”§ìœ¼ë¡œ êµ¬ìž…í•´ë³´ì„¸ìš”";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "ì‚¬ìš© ë°©ë²•";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "ì‚¬ìš© ë°©ë²•";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Roblox ì¹´ë“œ ì‚¬ìš©";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Roblox ê²Œìž„ì¹´ë“œ ì‚¬ìš©";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Roblox ê²Œìž„ì¹´ë“œê°€ í•„ìš”í•˜ì„¸ìš”?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN ì½”ë“œ";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "êµí™˜ë°›ì€ Robux:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "ë‚˜ì˜ í¬ë ˆë”§ ìž”ì•¡:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "ì´ë¯¸ ì‚¬ìš©í•œ ìƒí’ˆê¶Œìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "GameStopì—ì„œ êµ¬ìž…í•œ Roblox ì¹´ë“œë¥¼ í•œ ìž¥ ë” ì‚¬ìš©í•˜ì‹œê³  ë³´ë„ˆìŠ¤ Robuxë„ ë°›ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Builders Club ë©¤ë²„ì‹­ ì—°ìž¥ì„ ì™„ë£Œí–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "ë³€ê²½ ì‚¬í•­ì„ ì ìš©í•˜ë ¤ë©´ ìµœëŒ€ 5 ë¶„ì´ ì†Œìš”ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Builders Club ë©¤ë²„ì‹­ êµ¬ë§¤ë¥¼ ì™„ë£Œí–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "ì¼ì¹˜í•˜ëŠ” ì½”ë“œê°€ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "ìš”ì²­í•œ ëŒ€ìƒì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "ë³¸ ê¸°ëŠ¥ì€ í˜„ìž¬ ë¹„í™œì„±í™” ìƒíƒœìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ PIN";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "ë³¸ ìž‘ì—…ì„ ìˆ˜í–‰í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"ì‚¬ìš©ìžê°€ PIN ì‚¬ìš©ì„ ì‹œë„í–ˆì§€ë§Œ íŒë§¤ìžê°€ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. ì‚¬ìš©ìž ID: {authenticatedUserId} PIN ë²ˆí˜¸: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "ì‚¬ìš©ìžê°€ PIN ì‚¬ìš©ì„ ì‹œë„í–ˆì§€ë§Œ íŒë§¤ìžê°€ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. ì‚¬ìš©ìž ID: {authenticatedUserId} PIN ë²ˆí˜¸: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "ìš”ì²­í•œ ëŒ€ìƒì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ì¹´ë“œ ì‚¬ìš©ì„ ì™„ë£Œí–ˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"ì¹´ë“œë¡œ {productName}ì„(ë¥¼) êµ¬ë§¤í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "ì¹´ë“œë¡œ {productName}ì„(ë¥¼) êµ¬ë§¤í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "ì½”ë“œ ì‚¬ìš© ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"GameStopì—ì„œ êµ¬ìž…í•œ ë‘ ìž¥ì˜ Roblox ì¹´ë“œë¥¼ ì‚¬ìš©í•´ ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤. ê³„ì •ì— {robuxCount} Robuxê°€ ì ë¦½ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "GameStopì—ì„œ êµ¬ìž…í•œ ë‘ ìž¥ì˜ Roblox ì¹´ë“œë¥¼ ì‚¬ìš©í•´ ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤. ê³„ì •ì— {robuxCount} Robuxê°€ ì ë¦½ë˜ì—ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Walmartì—ì„œ êµ¬ìž…í•œ Roblox ì¹´ë“œë¥¼ í•œ ìž¥ ë” ì‚¬ìš©í•˜ì‹œê³  ë³´ë„ˆìŠ¤ {rewardName}ë„ ë°›ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Walmartì—ì„œ êµ¬ìž…í•œ Roblox ì¹´ë“œë¥¼ í•œ ìž¥ ë” ì‚¬ìš©í•˜ì‹œê³  ë³´ë„ˆìŠ¤ {rewardName}ë„ ë°›ì•„ë³´ì„¸ìš”.";
	}
}


}
