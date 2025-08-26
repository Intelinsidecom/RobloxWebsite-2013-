namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_ja_jp : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "ä»Šã™ãOBCã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "èªè¨¼";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "ä»Šã™ãèªè¨¼";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "DevExã«ã‚¢ã‚¯ã‚»ã‚¹";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "ã‚ã¨å°‘ã—ã§ã™ï¼";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Robuxã‚’ç¾é‡‘ã«äº¤æ›ã™ã‚‹ã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "ç¾åœ¨ã®äº¤æ›ãƒ¬ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "DevExã‚’ä½¿ã†ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "ç¾åœ¨ã€æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "ã‚‚ã†ã™ãRobuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "ã‚‚ã†å°‘ã—ã§ã™ï¼ã‚ã¨å°‘ã—ã§Robuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹å‰ã«ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ãŒå¿…è¦ã§ã™ã€‚";

	public DevExHomeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "ä»Šã™ãOBCã‚’ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "èªè¨¼";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "ä»Šã™ãèªè¨¼";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "DevExã«ã‚¢ã‚¯ã‚»ã‚¹";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "ã‚ã¨å°‘ã—ã§ã™ï¼";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Robuxã‚’ç¾é‡‘ã«äº¤æ›ã™ã‚‹ã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "ç¾åœ¨ã®äº¤æ›ãƒ¬ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "DevExã‚’ä½¿ã†ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "ç¾åœ¨ã€æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "ã‚‚ã†ã™ãRobuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "ã‚‚ã†å°‘ã—ã§ã™ï¼ã‚ã¨å°‘ã—ã§Robuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹å‰ã«ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ãŒå¿…è¦ã§ã™ã€‚";
	}
}


}
