namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_ja_jp : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Robuxã«æ›ç®—ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Robuxã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "ãŠæŒã¡ã®Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã®å‡¦ç†ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "Weâ€™ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’å…¥ã‚Œã¾ã—ãŸã€‚ã—ã‹ã—ã€Robuxä»˜ä¸Žã®å‡¦ç†ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚Robuxã‚’å—ã‘å–ã‚‹ã«ã¯ã€ã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒãƒ¼ãƒˆã«ã”é€£çµ¡ãã ã•ã„ã€‚";

	public RobloxCreditResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Robuxã«æ›ç®—ã™ã‚‹";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å¼•ãæ›ãˆã‚‹";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"ãŠæŒã¡ã®{balance} Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’{robuxAmount} ã«å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "ãŠæŒã¡ã®{balance} Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’{robuxAmount} ã«å¼•ãæ›ãˆã‚‹";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"ãŠæŒã¡ã®{balance} Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ {iconRobux} {robuxAmount} ã«å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "ãŠæŒã¡ã®{balance} Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’ {iconRobux} {robuxAmount} ã«å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Robuxã‚’ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆ";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"ç¾åœ¨ã®æ®‹é«˜: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "ç¾åœ¨ã®æ®‹é«˜: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "ãŠæŒã¡ã®Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã®å‡¦ç†ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Robloxã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚’å…¥ã‚Œã¾ã—ãŸã€‚ã—ã‹ã—ã€Robuxä»˜ä¸Žã®å‡¦ç†ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚Robuxã‚’å—ã‘å–ã‚‹ã«ã¯ã€ã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒãƒ¼ãƒˆã«ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"{robuxAmount} Robuxã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "{robuxAmount} Robuxã®å¼•ãæ›ãˆã«æˆåŠŸã—ã¾ã—ãŸï¼";
	}
}


}
