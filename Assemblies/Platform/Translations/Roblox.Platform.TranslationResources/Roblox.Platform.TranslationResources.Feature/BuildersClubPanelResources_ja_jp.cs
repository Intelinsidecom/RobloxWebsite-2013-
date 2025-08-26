namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_ja_jp : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’æ›´æ–°";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "è³¼å…¥å ´æ‰€";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. Youâ€™ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robuxã¯å½“ç¤¾ã®ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã‚²ãƒ¼ãƒ ã§ä½¿ç”¨ã•ã‚Œã¦ã„ã‚‹ä»®æƒ³é€šè²¨ã§ã™ã€‚Robuxã‚’ä½¿ã£ã¦ã€ã‚¢ãƒã‚¿ãƒ¼ã®å¤–è¦‹ã‚’å¤‰ãˆã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ã‚¯ãƒ¼ãƒ«ãªã‚®ã‚¢ã‚’æ‰‹ã«å…¥ã‚Œã¦ã€ãƒžãƒ«ãƒãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãƒãƒˆãƒ«ã«æŒã¡è¾¼ã‚€ã“ã¨ã‚‚ã§ãã¾ã™ã€‚é™å®šã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã£ã¦ã€è»¢å£²ã—ãŸã‚Šå–å¼•ã—ãŸã‚Šã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ä½•ã‚’ã™ã‚‹ã«ã‚‚RobuxãŒå¿…è¦ã«ãªã‚Šã¾ã™ã€‚æ—©é€Ÿã€æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ã€‚";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "ä¿è­·è€…ã®æ–¹ã¸";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "ã“ã¡ã‚‰ã§Robuxã‚’è²·ã†:";

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
	public override string LabelRobloxGameCards => "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰";

	public BuildersClubPanelResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "ã‚«ãƒ¼ãƒ‰ã‚’å¼•ãæ›ãˆã‚‹";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’æ›´æ–°";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "è³¼å…¥å ´æ‰€";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"ã”è«‹æ±‚ã¨ãŠæ”¯æ‰•ã„ã«ã¤ã„ã¦ã®ãŠå•ã„åˆã‚ã›å…ˆ: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "ã”è«‹æ±‚ã¨ãŠæ”¯æ‰•ã„ã«ã¤ã„ã¦ã®ãŠå•ã„åˆã‚ã›å…ˆ: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robuxã¯å½“ç¤¾ã®ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã‚²ãƒ¼ãƒ ã§ä½¿ç”¨ã•ã‚Œã¦ã„ã‚‹ä»®æƒ³é€šè²¨ã§ã™ã€‚Robuxã‚’ä½¿ã£ã¦ã€ã‚¢ãƒã‚¿ãƒ¼ã®å¤–è¦‹ã‚’å¤‰ãˆã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ã‚¯ãƒ¼ãƒ«ãªã‚®ã‚¢ã‚’æ‰‹ã«å…¥ã‚Œã¦ã€ãƒžãƒ«ãƒãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãƒãƒˆãƒ«ã«æŒã¡è¾¼ã‚€ã“ã¨ã‚‚ã§ãã¾ã™ã€‚é™å®šã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã£ã¦ã€è»¢å£²ã—ãŸã‚Šå–å¼•ã—ãŸã‚Šã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ä½•ã‚’ã™ã‚‹ã«ã‚‚RobuxãŒå¿…è¦ã«ãªã‚Šã¾ã™ã€‚æ—©é€Ÿã€æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ã€‚";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"æ›´æ–°æ—¥ã¾ã§ãªã‚‰ã€ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã¯ã„ã¤ã§ã‚‚ã‚ªãƒ•ã«ã§ãã¾ã™ã€‚ã‚ªãƒ•ã«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€Builders Clubã®ç‰¹å…¸ã‚’å—ã‘ã‚‰ã‚Œã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã«ã¯ã€è¨­å®šãƒšãƒ¼ã‚¸ã®{linkStartTag}è«‹æ±‚{linkEndTag}ã‚¿ãƒ–ã«ã‚ã‚‹ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—æ›´æ–°ã®ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã‚’æ‰¿èªã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "æ›´æ–°æ—¥ã¾ã§ãªã‚‰ã€ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã¯ã„ã¤ã§ã‚‚ã‚ªãƒ•ã«ã§ãã¾ã™ã€‚ã‚ªãƒ•ã«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€Builders Clubã®ç‰¹å…¸ã‚’å—ã‘ã‚‰ã‚Œã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã«ã¯ã€è¨­å®šãƒšãƒ¼ã‚¸ã®{linkStartTag}è«‹æ±‚{linkEndTag}ã‚¿ãƒ–ã«ã‚ã‚‹ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—æ›´æ–°ã®ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã‚’æ‰¿èªã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"æ›´æ–°æ—¥ã¾ã§ãªã‚‰ã€ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã¯ã„ã¤ã§ã‚‚ã‚ªãƒ•ã«ã§ãã¾ã™ã€‚ã‚ªãƒ•ã«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€Premiumã®ç‰¹å…¸ã‚’å—ã‘ã‚‰ã‚Œã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã«ã¯ã€è¨­å®šãƒšãƒ¼ã‚¸ã® {linkStartTag}è«‹æ±‚{linkEndTag} ã‚¿ãƒ–ã«ã‚ã‚‹ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—æ›´æ–°ã®ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã‚’æ‰¿èªã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "æ›´æ–°æ—¥ã¾ã§ãªã‚‰ã€ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã¯ã„ã¤ã§ã‚‚ã‚ªãƒ•ã«ã§ãã¾ã™ã€‚ã‚ªãƒ•ã«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€Premiumã®ç‰¹å…¸ã‚’å—ã‘ã‚‰ã‚Œã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®è‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã«ã¯ã€è¨­å®šãƒšãƒ¼ã‚¸ã® {linkStartTag}è«‹æ±‚{linkEndTag} ã‚¿ãƒ–ã«ã‚ã‚‹ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—æ›´æ–°ã®ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã‚’æ‰¿èªã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Builders Clubã«é–¢ã™ã‚‹æƒ…å ±ã‚„å½“ç¤¾ãŒå–ã‚Šçµ„ã‚“ã§ã„ã‚‹ {startLinkTag}å­ä¾›ãŸã¡ã®å®‰å…¨ã‚’å®ˆã‚‹ãŸã‚ã®å¯¾ç­–{endLinkTag} ã«ã¤ã„ã¦ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Builders Clubã«é–¢ã™ã‚‹æƒ…å ±ã‚„å½“ç¤¾ãŒå–ã‚Šçµ„ã‚“ã§ã„ã‚‹ {startLinkTag}å­ä¾›ãŸã¡ã®å®‰å…¨ã‚’å®ˆã‚‹ãŸã‚ã®å¯¾ç­–{endLinkTag} ã«ã¤ã„ã¦ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Premiumã«é–¢ã™ã‚‹æƒ…å ±ã‚„å½“ç¤¾ãŒå–ã‚Šçµ„ã‚“ã§ã„ã‚‹ {startLinkTag}å­ä¾›ãŸã¡ã®å®‰å…¨ã‚’å®ˆã‚‹ãŸã‚ã®å¯¾ç­–{endLinkTag} ã«ã¤ã„ã¦ã”ç¢ºèªãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Premiumã«é–¢ã™ã‚‹æƒ…å ±ã‚„å½“ç¤¾ãŒå–ã‚Šçµ„ã‚“ã§ã„ã‚‹ {startLinkTag}å­ä¾›ãŸã¡ã®å®‰å…¨ã‚’å®ˆã‚‹ãŸã‚ã®å¯¾ç­–{endLinkTag} ã«ã¤ã„ã¦ã”ç¢ºèªãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "ã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "ä¿è­·è€…ã®æ–¹ã¸";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "ã“ã¡ã‚‰ã§Robuxã‚’è²·ã†:";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆæ®‹é«˜: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆæ®‹é«˜: {amount}";
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
		return "Robloxã‚²ãƒ¼ãƒ ã‚«ãƒ¼ãƒ‰";
	}
}


}
