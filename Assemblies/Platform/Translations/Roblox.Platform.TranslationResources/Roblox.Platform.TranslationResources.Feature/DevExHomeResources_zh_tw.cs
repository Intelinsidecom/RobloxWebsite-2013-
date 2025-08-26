namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_zh_tw : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "å…Œç¾";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "ç¾åœ¨å–å¾— OBC";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "å‡ç´šæœƒå“¡è³‡æ ¼";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "é©—è­‰";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "é©—è­‰é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "ç¾åœ¨é©—è­‰";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "å‰å¾€ DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "å¿«å¥½äº†ï¼";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å…Œç¾ã€‚";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "ç›®å‰åŒ¯çŽ‡";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "æ‚¨ç›®å‰è³‡æ ¼ä¸ç¬¦ã€‚";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å…Œç¾ã€‚";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "æ‚¨å¿«è¦å¯ä»¥ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘äº†ï¼";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "å°±å·®ä¸€é»žäº†ï¼Œæ‚¨å³å°‡å–å¾—ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘çš„è³‡æ ¼ï¼";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "è‹¥è¦å…Œç¾ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";

	public DevExHomeResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "å…Œç¾";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "ç¾åœ¨å–å¾— OBC";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "å‡ç´šæœƒå“¡è³‡æ ¼";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "é©—è­‰";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "é©—è­‰é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "ç¾åœ¨é©—è­‰";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "å‰å¾€ DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "å¿«å¥½äº†ï¼";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "ç›®å‰åŒ¯çŽ‡";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "æ‚¨ç›®å‰è³‡æ ¼ä¸ç¬¦ã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "æ‚¨å¿«è¦å¯ä»¥ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘äº†ï¼";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "å°±å·®ä¸€é»žäº†ï¼Œæ‚¨å³å°‡å–å¾—ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘çš„è³‡æ ¼ï¼";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "è‹¥è¦å…Œç¾ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";
	}
}


}
