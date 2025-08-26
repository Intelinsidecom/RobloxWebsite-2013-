namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_zh_cjv : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "å…‘æ¢ç¤¼å“å¡";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "æ›´æ–°ä¿¡ç”¨å¡";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "è´­ä¹°æ¸ é“";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. Youâ€™ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux æ˜¯æˆ‘ä»¬è®¸å¤šåœ¨çº¿æ¸¸æˆä¸­ä½¿ç”¨çš„è™šæ‹Ÿè´§å¸ã€‚ä½ å¯ä»¥ä½¿ç”¨ Robux æ‰“é€ ä¸ªæ€§åè¶³çš„è™šæ‹Ÿå½¢è±¡ã€èŽ·å–å¯ç”¨äºŽå¤šäººæ¸¸æˆæˆ˜æ–—ä¸­çš„é…·ç‚«è£…å¤‡ï¼Œå¹¶è´­ä¹°é™é‡ç‰©å“ä»¥å‡ºå”®å’Œäº¤æ˜“ã€‚è¦å®žçŽ°è¿™ä¸€åˆ‡ï¼Œä½ éƒ½å°†éœ€è¦ Robuxã€‚ä½ è¿˜åœ¨ç­‰ä»€ä¹ˆï¼Ÿ";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "ç¤¼å“å¡";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "å®¶é•¿";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "å¯é€šè¿‡ä¸‹åˆ—æ¸ é“è´­ä¹° Robuxï¼š";

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
	public override string LabelRobloxGameCards => "Roblox ç¤¼å“å¡";

	public BuildersClubPanelResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "å…‘æ¢ç¤¼å“å¡";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "æ›´æ–°ä¿¡ç”¨å¡";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "è´­ä¹°æ¸ é“";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"å…³äºŽè´¦å•ä¸Žä»˜æ¬¾é—®é¢˜ï¼Œè¯·è”ç³»ï¼š{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "å…³äºŽè´¦å•ä¸Žä»˜æ¬¾é—®é¢˜ï¼Œè¯·è”ç³»ï¼š{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux æ˜¯æˆ‘ä»¬è®¸å¤šåœ¨çº¿æ¸¸æˆä¸­ä½¿ç”¨çš„è™šæ‹Ÿè´§å¸ã€‚ä½ å¯ä»¥ä½¿ç”¨ Robux æ‰“é€ ä¸ªæ€§åè¶³çš„è™šæ‹Ÿå½¢è±¡ã€èŽ·å–å¯ç”¨äºŽå¤šäººæ¸¸æˆæˆ˜æ–—ä¸­çš„é…·ç‚«è£…å¤‡ï¼Œå¹¶è´­ä¹°é™é‡ç‰©å“ä»¥å‡ºå”®å’Œäº¤æ˜“ã€‚è¦å®žçŽ°è¿™ä¸€åˆ‡ï¼Œä½ éƒ½å°†éœ€è¦ Robuxã€‚ä½ è¿˜åœ¨ç­‰ä»€ä¹ˆï¼Ÿ";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"ä½ å¯ä»¥åœ¨ Builders Club ä¼šå‘˜èµ„æ ¼ç»­è®¢æ—¥æœŸä¹‹å‰éšæ—¶å…³é—­è‡ªåŠ¨ç»­è®¢ï¼Œå¹¶åœ¨å½“å‰å‰©ä½™çš„å·²ä»˜è´¹æœŸé™å†…ç»§ç»­äº«æœ‰ Builders Club çš„æƒç›Šã€‚è‹¥è¦å…³é—­ä¼šå‘˜è‡ªåŠ¨ç»­è®¢ï¼Œè¯·åœ¨è®¾ç½®é¡µé¢çš„{linkStartTag}è´¦å•{linkEndTag}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼ç»­è®¢â€æŒ‰é’®ï¼Œç„¶åŽç¡®è®¤å–æ¶ˆã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "ä½ å¯ä»¥åœ¨ Builders Club ä¼šå‘˜èµ„æ ¼ç»­è®¢æ—¥æœŸä¹‹å‰éšæ—¶å…³é—­è‡ªåŠ¨ç»­è®¢ï¼Œå¹¶åœ¨å½“å‰å‰©ä½™çš„å·²ä»˜è´¹æœŸé™å†…ç»§ç»­äº«æœ‰ Builders Club çš„æƒç›Šã€‚è‹¥è¦å…³é—­ä¼šå‘˜è‡ªåŠ¨ç»­è®¢ï¼Œè¯·åœ¨è®¾ç½®é¡µé¢çš„{linkStartTag}è´¦å•{linkEndTag}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼ç»­è®¢â€æŒ‰é’®ï¼Œç„¶åŽç¡®è®¤å–æ¶ˆã€‚";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"ä½ å¯ä»¥åœ¨ Premium ä¼šå‘˜èµ„æ ¼ç»­è®¢æ—¥æœŸä¹‹å‰éšæ—¶å…³é—­è‡ªåŠ¨ç»­è®¢ï¼Œå¹¶åœ¨å½“å‰å‰©ä½™çš„å·²ä»˜è´¹æœŸé™å†…ç»§ç»­äº«æœ‰ Premium çš„ç¦åˆ©ã€‚è‹¥è¦å…³é—­ä¼šå‘˜è‡ªåŠ¨ç»­è®¢ï¼Œè¯·åœ¨è®¾ç½®é¡µé¢çš„{linkStartTag}è´¦å•{linkEndTag}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼ç»­è®¢â€æŒ‰é’®ï¼Œç„¶åŽç¡®è®¤å–æ¶ˆã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "ä½ å¯ä»¥åœ¨ Premium ä¼šå‘˜èµ„æ ¼ç»­è®¢æ—¥æœŸä¹‹å‰éšæ—¶å…³é—­è‡ªåŠ¨ç»­è®¢ï¼Œå¹¶åœ¨å½“å‰å‰©ä½™çš„å·²ä»˜è´¹æœŸé™å†…ç»§ç»­äº«æœ‰ Premium çš„ç¦åˆ©ã€‚è‹¥è¦å…³é—­ä¼šå‘˜è‡ªåŠ¨ç»­è®¢ï¼Œè¯·åœ¨è®¾ç½®é¡µé¢çš„{linkStartTag}è´¦å•{linkEndTag}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼ç»­è®¢â€æŒ‰é’®ï¼Œç„¶åŽç¡®è®¤å–æ¶ˆã€‚";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"äº†è§£æ›´å¤šå…³äºŽ Builders Club åŠæˆ‘ä»¬å¦‚ä½•{startLinkTag}ä¿æŠ¤å„¿ç«¥å®‰å…¨{endLinkTag}çš„æ–¹å¼ã€‚";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "äº†è§£æ›´å¤šå…³äºŽ Builders Club åŠæˆ‘ä»¬å¦‚ä½•{startLinkTag}ä¿æŠ¤å„¿ç«¥å®‰å…¨{endLinkTag}çš„æ–¹å¼ã€‚";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"è¿›ä¸€æ­¥äº†è§£ Premium åŠæˆ‘ä»¬å¦‚ä½•{startLinkTag}ç»´æŠ¤å„¿ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "è¿›ä¸€æ­¥äº†è§£ Premium åŠæˆ‘ä»¬å¦‚ä½•{startLinkTag}ç»´æŠ¤å„¿ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "ç¤¼å“å¡";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "å®¶é•¿";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "å¯é€šè¿‡ä¸‹åˆ—æ¸ é“è´­ä¹° Robuxï¼š";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"ç‚¹æ•°ä½™é¢ï¼š{amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "ç‚¹æ•°ä½™é¢ï¼š{amount}";
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
		return "Roblox ç¤¼å“å¡";
	}
}


}
