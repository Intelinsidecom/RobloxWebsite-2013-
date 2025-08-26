namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_ko_kr : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "ì½”ë“œë¥¼ ì°¾ì„ ìˆ˜ ì—†ë‚˜ìš”?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "ë¹„ë””ì˜¤ ê³„ì† ë³´ê¸°";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "í”„ë¡œëª¨ì…˜ ì½”ë“œê°€ ìžˆìœ¼ì‹ ê°€ìš”? ì—¬ê¸°ë¥¼ í´ë¦­";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "ì‚¬ìš© ë°©ë²•";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "ì‚¬ìš©";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "ë‹¤ë¥¸ ì•„ì´í…œ ì‚¬ìš©";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "íšŒì›ê°€ìž…";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "ì•„ì´í…œ ë³´ê¸°";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Robloxë¥¼ ë‚˜ê°€ YouTube ë¹„ë””ì˜¤ë¥¼ ì‹œì²­í•˜ë ¤ í•˜ì‹œëŠ”êµ°ìš”. YouTubeëŠ” Roblox.comê³¼ëŠ” ë³„ê°œì˜ ì½˜í…ì¸ ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "ì‚¬ìš© ì™„ë£Œ";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Roblox ê°€ìƒ ì•„ì´í…œ ì‚¬ìš©";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "ì•ˆë…•ížˆ ê°€ì„¸ìš”";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "ìž¥ë‚œê° ì½”ë“œ ìž…ë ¥";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "ìœ íš¨í•˜ì§€ ì•Šì€ ì½”ë“œìž…ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "ì½”ë“œë¥¼ ê°€ìƒ ì•„ì´í…œìœ¼ë¡œ êµí™˜í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•´ì•¼ í•´ìš”!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "ì•„ì´í…œ ì‚¬ìš©ì„ ì™„ë£Œí–ˆì–´ìš”!";

	public RedeemToyResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "ì½”ë“œë¥¼ ì°¾ì„ ìˆ˜ ì—†ë‚˜ìš”?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "ë¹„ë””ì˜¤ ê³„ì† ë³´ê¸°";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "í”„ë¡œëª¨ì…˜ ì½”ë“œê°€ ìžˆìœ¼ì‹ ê°€ìš”? ì—¬ê¸°ë¥¼ í´ë¦­";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "ì‚¬ìš© ë°©ë²•";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "ì‚¬ìš©";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "ë‹¤ë¥¸ ì•„ì´í…œ ì‚¬ìš©";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "ì•„ì´í…œ ë³´ê¸°";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"{creatorName}ì˜ {spanTagStart}{itemName}{spanTagEnd}({itemType})ì„ ì„±ê³µì ìœ¼ë¡œ ì‚¬ìš©í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "{creatorName}ì˜ {spanTagStart}{itemName}{spanTagEnd}({itemType})ì„ ì„±ê³µì ìœ¼ë¡œ ì‚¬ìš©í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Robloxë¥¼ ë‚˜ê°€ YouTube ë¹„ë””ì˜¤ë¥¼ ì‹œì²­í•˜ë ¤ í•˜ì‹œëŠ”êµ°ìš”. YouTubeëŠ” Roblox.comê³¼ëŠ” ë³„ê°œì˜ ì½˜í…ì¸ ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "ì‚¬ìš© ì™„ë£Œ";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Roblox ê°€ìƒ ì•„ì´í…œ ì‚¬ìš©";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "ì•ˆë…•ížˆ ê°€ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "ìž¥ë‚œê° ì½”ë“œ ìž…ë ¥";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì½”ë“œìž…ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "ì½”ë“œë¥¼ ê°€ìƒ ì•„ì´í…œìœ¼ë¡œ êµí™˜í•˜ë ¤ë©´ Roblox ê³„ì •ì— ë¡œê·¸ì¸í•´ì•¼ í•´ìš”!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "ì•„ì´í…œ ì‚¬ìš©ì„ ì™„ë£Œí–ˆì–´ìš”!";
	}
}


}
