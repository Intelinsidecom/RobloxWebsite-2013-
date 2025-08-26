namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_ko_kr : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "ì¹´ë“œ ì‚¬ìš©";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "ì‹ ìš©ì¹´ë“œ ì •ë³´ ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "êµ¬ë§¤ ìž¥ì†Œ";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. Youâ€™ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "RobuxëŠ” ìˆ˜ë§Žì€ Roblox ì˜¨ë¼ì¸ ê²Œìž„ì—ì„œ ì‚¬ìš©ë˜ëŠ” ê°€ìƒ í†µí™”ìž…ë‹ˆë‹¤. ì•„ë°”íƒ€ ê¾¸ë¯¸ê¸° ë° ë©€í‹°í”Œë ˆì´ì–´ ìž¥ë¹„ êµ¬ìž… ë¿ ì•„ë‹ˆë¼ í•œì •íŒ ì•„ì´í…œ íŒë§¤ ë° ê±°ëž˜ì—ë„ ì‚¬ìš©í•  ìˆ˜ ìžˆì£ . ì§€ê¸ˆ êµ¬ìž…í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "ê²Œìž„ì¹´ë“œ";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "ë³´í˜¸ìž ê°€ì´ë“œ";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Robux êµ¬ë§¤ ìˆ˜ë‹¨";

	/// <summary>
	/// Key: "Label.Itunes"
	/// image alt tag text
	/// English String: "iTunes"
	/// </summary>
	public override string LabelItunes => "iTunes";

	/// <summary>
	/// Key: "Label.Rixty"
	/// image alt tag text
	/// English String: "Rixty"
	/// </summary>
	public override string LabelRixty => "Rixty";

	/// <summary>
	/// Key: "Label.RobloxGameCards"
	/// label
	/// English String: "Roblox Gamecards"
	/// </summary>
	public override string LabelRobloxGameCards => "Roblox ê²Œìž„ì¹´ë“œ";

	public BuildersClubPanelResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "ì¹´ë“œ ì‚¬ìš©";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "ì‹ ìš©ì¹´ë“œ ì •ë³´ ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "êµ¬ë§¤ ìž¥ì†Œ";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"ì²­êµ¬ ë° ê²°ì œ ê´€ë ¨ ì§ˆë¬¸: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "ì²­êµ¬ ë° ê²°ì œ ê´€ë ¨ ì§ˆë¬¸: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "RobuxëŠ” ìˆ˜ë§Žì€ Roblox ì˜¨ë¼ì¸ ê²Œìž„ì—ì„œ ì‚¬ìš©ë˜ëŠ” ê°€ìƒ í†µí™”ìž…ë‹ˆë‹¤. ì•„ë°”íƒ€ ê¾¸ë¯¸ê¸° ë° ë©€í‹°í”Œë ˆì´ì–´ ìž¥ë¹„ êµ¬ìž… ë¿ ì•„ë‹ˆë¼ í•œì •íŒ ì•„ì´í…œ íŒë§¤ ë° ê±°ëž˜ì—ë„ ì‚¬ìš©í•  ìˆ˜ ìžˆì£ . ì§€ê¸ˆ êµ¬ìž…í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"ê°±ì‹ ì¼ ì´ì „ì´ë¼ë©´ ì–¸ì œë“ ì§€ ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë”ë¼ë„ ì´ë¯¸ ì§€ë¶ˆí•˜ì‹  ê¸°ê°„ ë™ì•ˆ ê³„ì† Builders Club í˜œíƒì„ ëˆ„ë¦¬ì‹¤ ìˆ˜ ìžˆì–´ìš”. ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë ¤ë©´ ì„¤ì • íŽ˜ì´ì§€ì˜ {linkStartTag}ì²­êµ¬{linkEndTag} íƒ­ì—ì„œ â€˜ë©¤ë²„ì‹­ ê°±ì‹  ì·¨ì†Œ' ë²„íŠ¼ì„ í´ë¦­í•œ ë‹¤ìŒ ì·¨ì†Œë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "ê°±ì‹ ì¼ ì´ì „ì´ë¼ë©´ ì–¸ì œë“ ì§€ ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë”ë¼ë„ ì´ë¯¸ ì§€ë¶ˆí•˜ì‹  ê¸°ê°„ ë™ì•ˆ ê³„ì† Builders Club í˜œíƒì„ ëˆ„ë¦¬ì‹¤ ìˆ˜ ìžˆì–´ìš”. ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë ¤ë©´ ì„¤ì • íŽ˜ì´ì§€ì˜ {linkStartTag}ì²­êµ¬{linkEndTag} íƒ­ì—ì„œ â€˜ë©¤ë²„ì‹­ ê°±ì‹  ì·¨ì†Œ' ë²„íŠ¼ì„ í´ë¦­í•œ ë‹¤ìŒ ì·¨ì†Œë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"ê°±ì‹ ì¼ ì´ì „ì´ë¼ë©´ ì–¸ì œë“ ì§€ ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë”ë¼ë„ ì´ë¯¸ ì§€ë¶ˆí•˜ì‹  ê¸°ê°„ ë™ì•ˆ ê³„ì† Premium í˜œíƒì„ ëˆ„ë¦¬ì‹¤ ìˆ˜ ìžˆì–´ìš”. ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë ¤ë©´ ì„¤ì • íŽ˜ì´ì§€ì˜ {linkStartTag}ì²­êµ¬{linkEndTag} íƒ­ì—ì„œ â€˜ë©¤ë²„ì‹­ ê°±ì‹  ì·¨ì†Œ' ë²„íŠ¼ì„ í´ë¦­í•œ ë‹¤ìŒ ì·¨ì†Œë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "ê°±ì‹ ì¼ ì´ì „ì´ë¼ë©´ ì–¸ì œë“ ì§€ ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë”ë¼ë„ ì´ë¯¸ ì§€ë¶ˆí•˜ì‹  ê¸°ê°„ ë™ì•ˆ ê³„ì† Premium í˜œíƒì„ ëˆ„ë¦¬ì‹¤ ìˆ˜ ìžˆì–´ìš”. ë©¤ë²„ì‹­ ìžë™ ê°±ì‹ ì„ ì·¨ì†Œí•˜ë ¤ë©´ ì„¤ì • íŽ˜ì´ì§€ì˜ {linkStartTag}ì²­êµ¬{linkEndTag} íƒ­ì—ì„œ â€˜ë©¤ë²„ì‹­ ê°±ì‹  ì·¨ì†Œ' ë²„íŠ¼ì„ í´ë¦­í•œ ë‹¤ìŒ ì·¨ì†Œë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Builders Club ë° Robloxì˜ {startLinkTag}ìžë…€ ë³´í˜¸ ë°©ì•ˆ{endLinkTag}ì— ëŒ€í•´ ì•Œì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Builders Club ë° Robloxì˜ {startLinkTag}ìžë…€ ë³´í˜¸ ë°©ì•ˆ{endLinkTag}ì— ëŒ€í•´ ì•Œì•„ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Roblox Premium ë° {startLinkTag}ìžë…€ ë³´í˜¸ ë°©ì•ˆ{endLinkTag}ì— ëŒ€í•´ ì•Œì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Roblox Premium ë° {startLinkTag}ìžë…€ ë³´í˜¸ ë°©ì•ˆ{endLinkTag}ì— ëŒ€í•´ ì•Œì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "ê²Œìž„ì¹´ë“œ";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "ë³´í˜¸ìž ê°€ì´ë“œ";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Robux êµ¬ë§¤ ìˆ˜ë‹¨";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"í¬ë ˆë”§ ìž”ì•¡: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "í¬ë ˆë”§ ìž”ì•¡: {amount}";
	}

	protected override string _GetTemplateForLabelItunes()
	{
		return "iTunes";
	}

	protected override string _GetTemplateForLabelRixty()
	{
		return "Rixty";
	}

	protected override string _GetTemplateForLabelRobloxGameCards()
	{
		return "Roblox ê²Œìž„ì¹´ë“œ";
	}
}


}
