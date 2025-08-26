namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_zh_cjv : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "è½¬æ¢ä¸º Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…‘æ¢";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "å–å¾— Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox ç‚¹æ•°";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "å¤„ç†æ‚¨çš„ Roblox ç‚¹æ•°æ—¶å‘ç”Ÿäº†é—®é¢˜ã€‚è¯·ç¨åŽå†è¯•ä¸€æ¬¡ï¼";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "Weâ€™ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "æˆ‘ä»¬å·²å­˜å…¥æ‚¨çš„ Roblox ç‚¹æ•°ï¼Œä½†åœ¨è¿›è¡Œ Robux æ‹¨æ¬¾æ—¶å‘ç”Ÿäº†é—®é¢˜ã€‚è¯·è”ç»œå®¢æˆ·æ”¯æŒéƒ¨é—¨æ¥å–å¾—æ‚¨çš„ Robuxã€‚";

	public RobloxCreditResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "è½¬æ¢ä¸º Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…‘æ¢";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"å°†æ‚¨çš„ {balance} Roblox ç‚¹æ•°å…‘æ¢ä¸º {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "å°†æ‚¨çš„ {balance} Roblox ç‚¹æ•°å…‘æ¢ä¸º {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"å°†æ‚¨çš„ {balance} Roblox ç‚¹æ•°å…‘æ¢ä¸º {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "å°†æ‚¨çš„ {balance} Roblox ç‚¹æ•°å…‘æ¢ä¸º {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "å–å¾— Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox ç‚¹æ•°";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"å½“å‰ä½™é¢ï¼š${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "å½“å‰ä½™é¢ï¼š${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "å¤„ç†æ‚¨çš„ Roblox ç‚¹æ•°æ—¶å‘ç”Ÿäº†é—®é¢˜ã€‚è¯·ç¨åŽå†è¯•ä¸€æ¬¡ï¼";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "æˆ‘ä»¬å·²å­˜å…¥æ‚¨çš„ Roblox ç‚¹æ•°ï¼Œä½†åœ¨è¿›è¡Œ Robux æ‹¨æ¬¾æ—¶å‘ç”Ÿäº†é—®é¢˜ã€‚è¯·è”ç»œå®¢æˆ·æ”¯æŒéƒ¨é—¨æ¥å–å¾—æ‚¨çš„ Robuxã€‚";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"æ‚¨æˆåŠŸå…‘æ¢äº† {robuxAmount} Robuxï¼";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "æ‚¨æˆåŠŸå…‘æ¢äº† {robuxAmount} Robuxï¼";
	}
}


}
