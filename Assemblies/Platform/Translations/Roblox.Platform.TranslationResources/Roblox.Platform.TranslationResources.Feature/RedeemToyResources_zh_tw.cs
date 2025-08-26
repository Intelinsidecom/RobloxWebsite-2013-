namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_zh_tw : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
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
	public override string ActionCantFindCode => "æ‰¾ä¸åˆ°æ‚¨çš„ä»£ç¢¼ï¼Ÿ";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "å‰å¾€å½±ç‰‡";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "æœ‰ä»£ç¢¼ï¼Ÿè«‹æŒ‰ä¸‹æ­¤è™•";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "å…Œæ›æ–¹å¼";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…Œæ›";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "ç¹¼çºŒå…Œæ›é“å…·";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "è¨»å†Š";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "æª¢è¦–é“å…·";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "æ‚¨å³å°‡é›¢é–‹ Robloxï¼Œä¸¦å‰å¾€ YouTube è§€çœ‹å½±ç‰‡ã€‚YouTube ä¸å±¬æ–¼ Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "å…Œæ›æˆåŠŸ";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "å…Œæ› Roblox è™›æ“¬é“å…·";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "æ‚¨å³å°‡é›¢é–‹ Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "è¼¸å…¥çŽ©å…·ä»£ç¢¼";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "ä»£ç¢¼ç„¡æ•ˆï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "è‹¥è¦ä½¿ç”¨ä»£ç¢¼å…Œæ›è™›æ“¬é“å…·ï¼Œè«‹å…ˆç™»å…¥ Roblox ï¼";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "æ‚¨å·²æˆåŠŸå…Œæ›é“å…·ã€‚";

	public RedeemToyResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "æ‰¾ä¸åˆ°æ‚¨çš„ä»£ç¢¼ï¼Ÿ";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "å‰å¾€å½±ç‰‡";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "æœ‰ä»£ç¢¼ï¼Ÿè«‹æŒ‰ä¸‹æ­¤è™•";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "å…Œæ›æ–¹å¼";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…Œæ›";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "ç¹¼çºŒå…Œæ›é“å…·";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "æª¢è¦–é“å…·";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"æ‚¨å·²æˆåŠŸå…Œæ› {creatorName} çš„ {spanTagStart}{itemName}{spanTagEnd}ï¼ˆ{itemType}ï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "æ‚¨å·²æˆåŠŸå…Œæ› {creatorName} çš„ {spanTagStart}{itemName}{spanTagEnd}ï¼ˆ{itemType}ï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "æ‚¨å³å°‡é›¢é–‹ Robloxï¼Œä¸¦å‰å¾€ YouTube è§€çœ‹å½±ç‰‡ã€‚YouTube ä¸å±¬æ–¼ Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "å…Œæ›æˆåŠŸ";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "å…Œæ› Roblox è™›æ“¬é“å…·";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "æ‚¨å³å°‡é›¢é–‹ Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "è¼¸å…¥çŽ©å…·ä»£ç¢¼";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "ä»£ç¢¼ç„¡æ•ˆï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "è‹¥è¦ä½¿ç”¨ä»£ç¢¼å…Œæ›è™›æ“¬é“å…·ï¼Œè«‹å…ˆç™»å…¥ Roblox ï¼";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "æ‚¨å·²æˆåŠŸå…Œæ›é“å…·ã€‚";
	}
}


}
