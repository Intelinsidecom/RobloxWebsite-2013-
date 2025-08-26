namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_ja_jp : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "ã‚³ãƒ¼ãƒ‰ãŒè¦‹ã¤ã‹ã‚‰ãªã„å ´åˆ";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "åˆ¥ã‚µã‚¤ãƒˆã§ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚‹";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "ãƒ—ãƒ­ãƒ¢ãƒ¼ã‚·ãƒ§ãƒ³ã‚³ãƒ¼ãƒ‰ã‚’æŒã£ã¦ã„ã‚‹å ´åˆã¯ã€ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "å¼•ãæ›ãˆæ–¹æ³•";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å¼•ãæ›ãˆ";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "ä»–ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Robloxã‚’çµ‚äº†ã—ã¦YouTubeã§ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚YouTubeã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Robloxãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã‚’å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Robloxã§ã¯ãªã„ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "ãƒˆã‚¤ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "ã‚³ãƒ¼ãƒ‰ãŒç„¡åŠ¹ã§ã™ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "ãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã®ã‚³ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹ã«ã¯ã€Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "ã‚¢ã‚¤ãƒ†ãƒ ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";

	public RedeemToyResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "ã‚³ãƒ¼ãƒ‰ãŒè¦‹ã¤ã‹ã‚‰ãªã„å ´åˆ";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "åˆ¥ã‚µã‚¤ãƒˆã§ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚‹";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "ãƒ—ãƒ­ãƒ¢ãƒ¼ã‚·ãƒ§ãƒ³ã‚³ãƒ¼ãƒ‰ã‚’æŒã£ã¦ã„ã‚‹å ´åˆã¯ã€ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "å¼•ãæ›ãˆæ–¹æ³•";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å¼•ãæ›ãˆ";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "ä»–ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"{creatorName} ã•ã‚“ã® {spanTagStart}{itemName}{spanTagEnd} ({itemType}) ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "{creatorName} ã•ã‚“ã® {spanTagStart}{itemName}{spanTagEnd} ({itemType}) ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Robloxã‚’çµ‚äº†ã—ã¦YouTubeã§ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚YouTubeã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Robloxãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã‚’å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Robloxã§ã¯ãªã„ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "ãƒˆã‚¤ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "ã‚³ãƒ¼ãƒ‰ãŒç„¡åŠ¹ã§ã™ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "ãƒãƒ¼ãƒãƒ£ãƒ«ã‚¢ã‚¤ãƒ†ãƒ ã®ã‚³ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹ã«ã¯ã€Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸã€‚";
	}
}


}
