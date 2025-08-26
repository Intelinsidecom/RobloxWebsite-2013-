namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_zh_cjv : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "æ‰¾ä¸åˆ°ä»£ç ï¼Ÿ";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "å…³é—­";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "ç»§ç»­å‰å¾€è§†é¢‘";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "æœ‰ä¿ƒé”€ä»£ç ï¼Ÿè¯·ç‚¹æŒ‰è¿™é‡Œ";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "å…‘æ¢æ–¹æ³•";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…‘æ¢";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "å…‘æ¢å…¶ä»–é“å…·";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "æŸ¥çœ‹é“å…·";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "ä½ å³å°†ç¦»å¼€ Robloxï¼Œå‰å¾€ Youtube è§‚çœ‹è§†é¢‘ã€‚Youtube ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "å…‘æ¢æˆåŠŸ";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "å…‘æ¢ Roblox è™šæ‹Ÿé“å…·";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "ä½ å³å°†ç¦»å¼€ Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "è¾“å…¥çŽ©å…·ä»£ç ";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "ä»£ç æ— æ•ˆï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "è‹¥è¦ä½¿ç”¨ä»£ç å…‘æ¢è™šæ‹Ÿé“å…·ï¼Œè¯·å…ˆç™»å½• Robloxï¼";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "ä½ å·²æˆåŠŸå…‘æ¢ä½ çš„é“å…·ï¼";

	public RedeemToyResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "æ‰¾ä¸åˆ°ä»£ç ï¼Ÿ";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "ç»§ç»­å‰å¾€è§†é¢‘";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "æœ‰ä¿ƒé”€ä»£ç ï¼Ÿè¯·ç‚¹æŒ‰è¿™é‡Œ";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "å…‘æ¢æ–¹æ³•";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…‘æ¢";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "å…‘æ¢å…¶ä»–é“å…·";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "æŸ¥çœ‹é“å…·";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"ä½ å·²æˆåŠŸä»Žâ€œ{creatorName}â€å…‘æ¢ {spanTagStart}â€œ{itemName}â€{spanTagEnd}ï¼ˆ{itemType}ï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "ä½ å·²æˆåŠŸä»Žâ€œ{creatorName}â€å…‘æ¢ {spanTagStart}â€œ{itemName}â€{spanTagEnd}ï¼ˆ{itemType}ï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "ä½ å³å°†ç¦»å¼€ Robloxï¼Œå‰å¾€ Youtube è§‚çœ‹è§†é¢‘ã€‚Youtube ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "å…‘æ¢æˆåŠŸ";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "å…‘æ¢ Roblox è™šæ‹Ÿé“å…·";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "ä½ å³å°†ç¦»å¼€ Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "è¾“å…¥çŽ©å…·ä»£ç ";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "ä»£ç æ— æ•ˆï¼Œè¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "è‹¥è¦ä½¿ç”¨ä»£ç å…‘æ¢è™šæ‹Ÿé“å…·ï¼Œè¯·å…ˆç™»å½• Robloxï¼";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ä½ å·²æˆåŠŸå…‘æ¢ä½ çš„é“å…·ï¼";
	}
}


}
