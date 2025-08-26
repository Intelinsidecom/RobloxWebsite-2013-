namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_ja_jp : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "ã‚«ãƒ¼ãƒ‰ã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å¼•ãæ›ãˆ";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "ã‚«ãƒ¼ãƒ‰ã‚’çµ„ã¿åˆã‚ã›ã¦ã€ã•ã‚‰ã«Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹ã«ã¯Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "è³¼å…¥ã«ã¯ã€1ç¨®é¡žã®æ”¯æ‰•ã„æ–¹æ³•ã®ã¿ä½¿ç”¨ã§ãã¾ã™ã€‚ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã¯ã€ä»–ã®ãŠæ”¯æ‰•ã„æ–¹æ³•ã¨çµ„ã¿åˆã‚ã›ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "ææºã—ã¦ã„ã‚‹è²©å£²å…ƒã‹ã‚‰Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’è²·ã£ãŸã‚Šã€èª°ã‹ã‹ã‚‰Robloxã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Robuxã‚„Builders Clubã«Robloxã‚’ä½¿ã„ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "å¼•ãæ›ãˆã‚»ã‚¯ã‚·ãƒ§ãƒ³ã«ã‚«ãƒ¼ãƒ‰ã®PINã‚’å…¥åŠ›ã—ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "PINã‚’å…¥åŠ›";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "å¼•ãæ›ãˆæ–¹æ³•";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "ä½¿ã„æ–¹";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Robloxã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PINã‚³ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "å¼•ãæ›ãˆæ¸ˆã¿ã®Robux:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "ãŠæŒã¡ã®ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆæ®‹é«˜:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "ã“ã®ã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã¯å¼•ãæ›ãˆæ¸ˆã¿ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "ã‚‚ã†1æžšRobloxã‚«ãƒ¼ãƒ‰ã‚’GameStopã§å¼•ãæ›ãˆã‚‹ã¨ã€ãƒœãƒ¼ãƒŠã‚¹Robuxã‚’å—ã‘å–ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’æœŸé™å»¶é•·ã—ã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "å¤‰æ›´ãŒåæ˜ ã•ã‚Œã‚‹ã¾ã§ã€é•·ãã¦5åˆ†ã»ã©ã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’å¼•ãæ›ãˆã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "ä¸€è‡´ã™ã‚‹ã‚³ãƒ¼ãƒ‰ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ãŸã‚ªãƒ–ã‚¸ã‚§ã‚¯ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "ã“ã®æ©Ÿèƒ½ã¯ç¾åœ¨ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "ç„¡åŠ¹ãªPIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "ã“ã®æ“ä½œã‚’å®Ÿè¡Œã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ãŸã‚ªãƒ–ã‚¸ã‚§ã‚¯ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚å•é¡ŒãŒå†ç™ºã™ã‚‹å ´åˆã¯ã€ã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒ¼ãƒ“ã‚¹ã«ãŠå•ã„åˆã‚ã›ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "ã‚«ãƒ¼ãƒ‰ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "å¼•ãæ›ãˆãŸã‚³ãƒ¼ãƒ‰ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã®å¤±æ•—å›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public RedeemGameCardResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "ã‚«ãƒ¼ãƒ‰ã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å¼•ãæ›ãˆ";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "ã‚«ãƒ¼ãƒ‰ã‚’çµ„ã¿åˆã‚ã›ã¦ã€ã•ã‚‰ã«Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹ã«ã¯Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "è³¼å…¥ã«ã¯ã€1ç¨®é¡žã®æ”¯æ‰•ã„æ–¹æ³•ã®ã¿ä½¿ç”¨ã§ãã¾ã™ã€‚ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã¯ã€ä»–ã®ãŠæ”¯æ‰•ã„æ–¹æ³•ã¨çµ„ã¿åˆã‚ã›ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"{retailerLinkStart}å‚åŠ ä¸­ã®è²©å£²è€…{retailerLinkEnd}ã‹ã‚‰Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’è²·ã£ãŸã‚Šã€èª°ã‹ã‹ã‚‰Robloxã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã™ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "{retailerLinkStart}å‚åŠ ä¸­ã®è²©å£²è€…{retailerLinkEnd}ã‹ã‚‰Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’è²·ã£ãŸã‚Šã€èª°ã‹ã‹ã‚‰Robloxã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã™ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "ææºã—ã¦ã„ã‚‹è²©å£²å…ƒã‹ã‚‰Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’è²·ã£ãŸã‚Šã€èª°ã‹ã‹ã‚‰Robloxã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Robuxã‚„Builders Clubã«Robloxã‚’ä½¿ã„ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "å¼•ãæ›ãˆã‚»ã‚¯ã‚·ãƒ§ãƒ³ã«ã‚«ãƒ¼ãƒ‰ã®PINã‚’å…¥åŠ›ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "PINã‚’å…¥åŠ›";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "å¼•ãæ›ãˆæ–¹æ³•";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "ä½¿ã„æ–¹";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Robloxã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PINã‚³ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "å¼•ãæ›ãˆæ¸ˆã¿ã®Robux:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "ãŠæŒã¡ã®ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆæ®‹é«˜:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "ã“ã®ã‚®ãƒ•ãƒˆã‚«ãƒ¼ãƒ‰ã¯å¼•ãæ›ãˆæ¸ˆã¿ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "ã‚‚ã†1æžšRobloxã‚«ãƒ¼ãƒ‰ã‚’GameStopã§å¼•ãæ›ãˆã‚‹ã¨ã€ãƒœãƒ¼ãƒŠã‚¹Robuxã‚’å—ã‘å–ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’æœŸé™å»¶é•·ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "å¤‰æ›´ãŒåæ˜ ã•ã‚Œã‚‹ã¾ã§ã€é•·ãã¦5åˆ†ã»ã©ã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’å¼•ãæ›ãˆã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "ä¸€è‡´ã™ã‚‹ã‚³ãƒ¼ãƒ‰ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ãŸã‚ªãƒ–ã‚¸ã‚§ã‚¯ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "ã“ã®æ©Ÿèƒ½ã¯ç¾åœ¨ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "ç„¡åŠ¹ãªPIN";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "ã“ã®æ“ä½œã‚’å®Ÿè¡Œã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒPINã®å¼•ãæ›ãˆã‚’ã—ã‚ˆã†ã¨ã—ã¾ã—ãŸãŒã€è²©å£²è€…ãŒå­˜åœ¨ã—ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ID: {authenticatedUserId} PINç•ªå·: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒPINã®å¼•ãæ›ãˆã‚’ã—ã‚ˆã†ã¨ã—ã¾ã—ãŸãŒã€è²©å£²è€…ãŒå­˜åœ¨ã—ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ID: {authenticatedUserId} PINç•ªå·: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ãŸã‚ªãƒ–ã‚¸ã‚§ã‚¯ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚å•é¡ŒãŒå†ç™ºã™ã‚‹å ´åˆã¯ã€ã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒ¼ãƒ“ã‚¹ã«ãŠå•ã„åˆã‚ã›ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ã‚«ãƒ¼ãƒ‰ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"ã‚«ãƒ¼ãƒ‰ã¨{productName}ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "ã‚«ãƒ¼ãƒ‰ã¨{productName}ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "å¼•ãæ›ãˆãŸã‚³ãƒ¼ãƒ‰ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã®å¤±æ•—å›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"GameStopã§2æžšã®Robloxã‚«ãƒ¼ãƒ‰å¼•ãæ›ãˆã‚’è¡Œã£ã¦ã„ãŸã ãã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ã€‚{robuxCount} RobuxãŒã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«è¿½åŠ ã•ã‚Œã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "GameStopã§2æžšã®Robloxã‚«ãƒ¼ãƒ‰å¼•ãæ›ãˆã‚’è¡Œã£ã¦ã„ãŸã ãã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ã€‚{robuxCount} RobuxãŒã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«è¿½åŠ ã•ã‚Œã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"ã‚‚ã†1æžšRobloxã‚«ãƒ¼ãƒ‰ã‚’Walmartã§å¼•ãæ›ãˆã‚‹ã¨ã€{rewardName} ã‚’å—ã‘å–ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "ã‚‚ã†1æžšRobloxã‚«ãƒ¼ãƒ‰ã‚’Walmartã§å¼•ãæ›ãˆã‚‹ã¨ã€{rewardName} ã‚’å—ã‘å–ã‚Œã¾ã™ã€‚";
	}
}


}
