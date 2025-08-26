namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_zh_tw : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "è½‰æ›åˆ° Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…Œæ›";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "å–å¾— Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox é»žæ•¸";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "è™•ç† Roblox é»žæ•¸æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ï¼";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "Weâ€™ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "æˆ‘å€‘å·²å‘æ‚¨æ”¶å– Roblox é»žæ•¸ï¼Œä½†çµ¦æ‚¨ Robux æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚ã€‚è‹¥è¦å–å¾—æ‚¨çš„ Robuxï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";

	public RobloxCreditResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "è½‰æ›åˆ° Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…Œæ›";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"å°‡ {balance} Roblox é»žæ•¸å…Œæ›æˆ {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "å°‡ {balance} Roblox é»žæ•¸å…Œæ›æˆ {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"å°‡ {balance} Roblox é»žæ•¸å…Œæ›æˆ {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "å°‡ {balance} Roblox é»žæ•¸å…Œæ›æˆ {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "å–å¾— Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox é»žæ•¸";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"ç›®å‰é¤˜é¡ï¼š${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "ç›®å‰é¤˜é¡ï¼š${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "è™•ç† Roblox é»žæ•¸æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ï¼";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "æˆ‘å€‘å·²å‘æ‚¨æ”¶å– Roblox é»žæ•¸ï¼Œä½†çµ¦æ‚¨ Robux æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚ã€‚è‹¥è¦å–å¾—æ‚¨çš„ Robuxï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"æ‚¨å·²æˆåŠŸå…Œæ› {robuxAmount} Robuxï¼";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "æ‚¨å·²æˆåŠŸå…Œæ› {robuxAmount} Robuxï¼";
	}
}


}
