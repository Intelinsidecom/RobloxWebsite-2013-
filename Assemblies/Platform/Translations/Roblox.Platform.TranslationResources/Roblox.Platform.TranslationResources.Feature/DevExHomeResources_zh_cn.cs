namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_zh_cn : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
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
	public override string GetActionCashOut => "å–çŽ°";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "ç«‹å³èŽ·å– OBC";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "å‡çº§ä¼šå‘˜èµ„æ ¼";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "éªŒè¯";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "éªŒè¯ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "ç«‹å³éªŒè¯";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "è®¿é—® DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "ä½ å³å°†å‡†å¤‡å°±ç»ªï¼";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "ä½ éœ€è¦ Outrageous Builders Club æ‰èƒ½å°† Robux å…‘æ¢ä¸ºçŽ°é‡‘ã€‚";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "ä½ éœ€è¦ Outrageous Builders Club æ‰èƒ½å–çŽ°ã€‚";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "å½“å‰æ±‡çŽ‡";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "ä½ éœ€è¦ç»éªŒè¯çš„ç”µå­é‚®ä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "ä½ ç›®å‰ä¸ç¬¦åˆèµ„æ ¼ã€‚";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "ä½ çš„ Robux ä¸è¶³ï¼Œæ— æ³•å–çŽ°ã€‚";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "ä½ å³å°†æŠŠ Robux å…‘æ¢ä¸ºçŽ°é‡‘ï¼";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "ä½ å¿«å®Œæˆäº†ï¼ä½ é©¬ä¸Šå°±å¯ä»¥å°† Robux å…‘æ¢ä¸ºçŽ°é‡‘äº†ï¼";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "ä½ å¿…é¡»å…ˆéªŒè¯ç”µå­é‚®ä»¶æ‰èƒ½å–çŽ°ã€‚";

	public DevExHomeResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "å–çŽ°";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "ç«‹å³èŽ·å– OBC";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "å‡çº§ä¼šå‘˜èµ„æ ¼";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "éªŒè¯";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "éªŒè¯ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "ç«‹å³éªŒè¯";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "è®¿é—® DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "ä½ å³å°†å‡†å¤‡å°±ç»ªï¼";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "ä½ éœ€è¦ Outrageous Builders Club æ‰èƒ½å°† Robux å…‘æ¢ä¸ºçŽ°é‡‘ã€‚";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "ä½ éœ€è¦ Outrageous Builders Club æ‰èƒ½å–çŽ°ã€‚";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "å½“å‰æ±‡çŽ‡";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "ä½ éœ€è¦ç»éªŒè¯çš„ç”µå­é‚®ä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "ä½ ç›®å‰ä¸ç¬¦åˆèµ„æ ¼ã€‚";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "ä½ çš„ Robux ä¸è¶³ï¼Œæ— æ³•å–çŽ°ã€‚";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "ä½ å³å°†æŠŠ Robux å…‘æ¢ä¸ºçŽ°é‡‘ï¼";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "ä½ å¿«å®Œæˆäº†ï¼ä½ é©¬ä¸Šå°±å¯ä»¥å°† Robux å…‘æ¢ä¸ºçŽ°é‡‘äº†ï¼";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "ä½ å¿…é¡»å…ˆéªŒè¯ç”µå­é‚®ä»¶æ‰èƒ½å–çŽ°ã€‚";
	}
}


}
