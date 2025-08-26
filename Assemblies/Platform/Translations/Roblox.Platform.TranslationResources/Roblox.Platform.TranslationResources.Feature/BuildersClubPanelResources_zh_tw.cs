namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_zh_tw : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è³¼è²· Robux";

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
	public override string ActionRedeemCard => "å…Œæ›é»žæ•¸å¡";

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
	public override string ActionWhereToBuy => "å“ªè£¡è³¼è²·";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. Youâ€™ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux æ˜¯ Roblox å°ˆç”¨çš„è™›æ“¬è²¨å¹£ã€‚æ‚¨å¯ä»¥ä½¿ç”¨ Robux æ‰“æ‰®æ‚¨çš„è™›æ“¬äººå¶ã€å–å¾—æˆ°é¬¥ç”¨çš„é…·ç‚«è£å‚™åŠè³¼è²·é™é‡é“å…·è½‰å”®å’Œäº¤æ˜“ã€‚ä¸è¦çŒ¶è±«ï¼Œç¾åœ¨å°±è³¼è²· Robuxï¼";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "è³¼è²· Robux";

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
	public override string HeadingGameCards => "é»žæ•¸å¡";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "å®¶é•·";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "å¯ç”±ä»¥ä¸‹é¸é …è³¼è²· Robuxï¼š";

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
	public override string LabelRobloxGameCards => "Roblox é»žæ•¸å¡";

	public BuildersClubPanelResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "å…Œæ›é»žæ•¸å¡";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "æ›´æ–°ä¿¡ç”¨å¡";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "å“ªè£¡è³¼è²·";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"å¸³å‹™å’Œä»˜æ¬¾å•é¡Œï¼š{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "å¸³å‹™å’Œä»˜æ¬¾å•é¡Œï¼š{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux æ˜¯ Roblox å°ˆç”¨çš„è™›æ“¬è²¨å¹£ã€‚æ‚¨å¯ä»¥ä½¿ç”¨ Robux æ‰“æ‰®æ‚¨çš„è™›æ“¬äººå¶ã€å–å¾—æˆ°é¬¥ç”¨çš„é…·ç‚«è£å‚™åŠè³¼è²·é™é‡é“å…·è½‰å”®å’Œäº¤æ˜“ã€‚ä¸è¦çŒ¶è±«ï¼Œç¾åœ¨å°±è³¼è²· Robuxï¼";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"æ‚¨åœ¨ Builders Club æœƒå“¡è³‡æ ¼çºŒç´„æ—¥æœŸä¹‹å‰å¯ä»¥éš¨æ™‚é—œé–‰è‡ªå‹•çºŒç´„ï¼Œä¸¦åœ¨æœƒå“¡è³‡æ ¼åœæ­¢ä¹‹å‰ç¹¼çºŒäº«ç”¨ Builders Clubã€‚è‹¥è¦é—œé–‰æœƒå“¡è³‡æ ¼è‡ªå‹•çºŒç´„ï¼Œè«‹åœ¨è¨­å®šé é¢çš„{linkStartTag}å¸³å‹™{linkEndTag}æ¨™ç±¤æŒ‰ä¸‹ã€Œå–æ¶ˆçºŒç´„ã€æŒ‰éˆ•ï¼Œç¢ºèªå–æ¶ˆæœƒå“¡è³‡æ ¼çºŒç´„ã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "æ‚¨åœ¨ Builders Club æœƒå“¡è³‡æ ¼çºŒç´„æ—¥æœŸä¹‹å‰å¯ä»¥éš¨æ™‚é—œé–‰è‡ªå‹•çºŒç´„ï¼Œä¸¦åœ¨æœƒå“¡è³‡æ ¼åœæ­¢ä¹‹å‰ç¹¼çºŒäº«ç”¨ Builders Clubã€‚è‹¥è¦é—œé–‰æœƒå“¡è³‡æ ¼è‡ªå‹•çºŒç´„ï¼Œè«‹åœ¨è¨­å®šé é¢çš„{linkStartTag}å¸³å‹™{linkEndTag}æ¨™ç±¤æŒ‰ä¸‹ã€Œå–æ¶ˆçºŒç´„ã€æŒ‰éˆ•ï¼Œç¢ºèªå–æ¶ˆæœƒå“¡è³‡æ ¼çºŒç´„ã€‚";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"æ‚¨åœ¨ Premium æœƒå“¡è³‡æ ¼çºŒç´„æ—¥æœŸä¹‹å‰å¯ä»¥éš¨æ™‚é—œé–‰è‡ªå‹•çºŒç´„ï¼Œä¸¦åœ¨æœƒå“¡è³‡æ ¼åœæ­¢ä¹‹å‰ç¹¼çºŒäº«ç”¨ Premiumã€‚è‹¥è¦é—œé–‰æœƒå“¡è³‡æ ¼è‡ªå‹•çºŒç´„ï¼Œè«‹åœ¨è¨­å®šé é¢çš„{linkStartTag}å¸³å‹™{linkEndTag}æ¨™ç±¤æŒ‰ä¸‹ã€Œå–æ¶ˆçºŒç´„ã€æŒ‰éˆ•ï¼Œç¢ºèªå–æ¶ˆæœƒå“¡è³‡æ ¼çºŒç´„ã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "æ‚¨åœ¨ Premium æœƒå“¡è³‡æ ¼çºŒç´„æ—¥æœŸä¹‹å‰å¯ä»¥éš¨æ™‚é—œé–‰è‡ªå‹•çºŒç´„ï¼Œä¸¦åœ¨æœƒå“¡è³‡æ ¼åœæ­¢ä¹‹å‰ç¹¼çºŒäº«ç”¨ Premiumã€‚è‹¥è¦é—œé–‰æœƒå“¡è³‡æ ¼è‡ªå‹•çºŒç´„ï¼Œè«‹åœ¨è¨­å®šé é¢çš„{linkStartTag}å¸³å‹™{linkEndTag}æ¨™ç±¤æŒ‰ä¸‹ã€Œå–æ¶ˆçºŒç´„ã€æŒ‰éˆ•ï¼Œç¢ºèªå–æ¶ˆæœƒå“¡è³‡æ ¼çºŒç´„ã€‚";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"é€²ä¸€æ­¥äº†è§£ Builders Clubï¼ŒåŠæˆ‘å€‘å¦‚ä½•{startLinkTag}ç¶­è­·å…’ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "é€²ä¸€æ­¥äº†è§£ Builders Clubï¼ŒåŠæˆ‘å€‘å¦‚ä½•{startLinkTag}ç¶­è­·å…’ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"é€²ä¸€æ­¥äº†è§£ Premiumï¼ŒåŠæˆ‘å€‘å¦‚ä½•{startLinkTag}ç¶­è­·å…’ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "é€²ä¸€æ­¥äº†è§£ Premiumï¼ŒåŠæˆ‘å€‘å¦‚ä½•{startLinkTag}ç¶­è­·å…’ç«¥å®‰å…¨{endLinkTag}ã€‚";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "é»žæ•¸å¡";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "å®¶é•·";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "å¯ç”±ä»¥ä¸‹é¸é …è³¼è²· Robuxï¼š";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"é»žæ•¸é¤˜é¡ï¼š{amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "é»žæ•¸é¤˜é¡ï¼š{amount}";
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
		return "Roblox é»žæ•¸å¡";
	}
}


}
