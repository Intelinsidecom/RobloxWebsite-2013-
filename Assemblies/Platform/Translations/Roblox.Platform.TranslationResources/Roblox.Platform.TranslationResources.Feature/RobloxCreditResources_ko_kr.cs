namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_ko_kr : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Robuxë¡œ ì „í™˜";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "ì‚¬ìš©";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Robux ì–»ê¸°";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox í¬ë ˆë”§";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "Roblox í¬ë ˆë”§ ì²˜ë¦¬ì— ë¬¸ì œê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”!";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "Weâ€™ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Roblox í¬ë ˆë”§ ì‚¬ìš©ì€ ì™„ë£Œë˜ì—ˆì§€ë§Œ, ì˜¤ë¥˜ë¡œ ì¸í•´ Robuxë¥¼ ì§€ê¸‰ë°›ì§€ ëª»í•˜ì…¨ì–´ìš”. ì§€ì› ì„¼í„°ì— ì—°ë½í•´ Robuxë¥¼ ë°›ìœ¼ì„¸ìš”.";

	public RobloxCreditResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Robuxë¡œ ì „í™˜";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "ì‚¬ìš©";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"{balance} Roblox í¬ë ˆë”§ì„ {iconRobux}{robuxAmount}ë¡œ êµí™˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "{balance} Roblox í¬ë ˆë”§ì„ {iconRobux}{robuxAmount}ë¡œ êµí™˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Robux ì–»ê¸°";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox í¬ë ˆë”§";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"í˜„ìž¬ ìž”ì•¡: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "í˜„ìž¬ ìž”ì•¡: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "Roblox í¬ë ˆë”§ ì²˜ë¦¬ì— ë¬¸ì œê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Roblox í¬ë ˆë”§ ì‚¬ìš©ì€ ì™„ë£Œë˜ì—ˆì§€ë§Œ, ì˜¤ë¥˜ë¡œ ì¸í•´ Robuxë¥¼ ì§€ê¸‰ë°›ì§€ ëª»í•˜ì…¨ì–´ìš”. ì§€ì› ì„¼í„°ì— ì—°ë½í•´ Robuxë¥¼ ë°›ìœ¼ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"{robuxAmount} Robuxë¥¼ êµí™˜ë°›ì•˜ì–´ìš”!";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "{robuxAmount} Robuxë¥¼ êµí™˜ë°›ì•˜ì–´ìš”!";
	}
}


}
