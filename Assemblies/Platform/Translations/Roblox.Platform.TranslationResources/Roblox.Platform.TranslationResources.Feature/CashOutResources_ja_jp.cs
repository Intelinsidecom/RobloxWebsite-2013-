namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_ja_jp : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "ä»Šã™ãã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "ä»Šã™ãOBCã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "èªè¨¼";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "ä»Šã™ãèªè¨¼";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "DevExã«ã‚¢ã‚¯ã‚»ã‚¹";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange: ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ã€ãŠé‡‘ã‚’ç¨¼ã”ã†ã€‚";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ã‚¨ã‚¯ã‚¹ãƒã‚§ãƒ³ã‚¸";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "ã‚ãªãŸã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "ã‚ã¨å°‘ã—ã§ã™ï¼";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Robuxã‚’ç¾é‡‘ã«äº¤æ›ã™ã‚‹ã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "ç¾åœ¨ã®ãƒ¬ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "çŠ¶æ³ã¯å®Œäº†æ¸ˆã¿ã§ã™";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "çŠ¶æ³ã¯ä¿ç•™ä¸­ã§ã™";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "çŠ¶æ³ã¯å´ä¸‹æ¸ˆã¿ã§ã™";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "DevExã‚’ä½¿ã†ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "ç¾åœ¨ã€æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Robuxã‚’ç¾é‡‘ã¨ä¸¡æ›¿ã™ã‚‹ã«ã¯ã€Roblox PremiumãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "ã‚‚ã†ã™ãRobuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "ã‚‚ã†å°‘ã—ã§ã™ï¼ã‚ã¨å°‘ã—ã§Robuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã‚’è¡Œã†å‰ã«ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ãŒå¿…è¦ã§ã™ã€‚";

	public CashOutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "ä»Šã™ãã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "ä»Šã™ãOBCã‚’ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "èªè¨¼";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "ä»Šã™ãèªè¨¼";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "DevExã«ã‚¢ã‚¯ã‚»ã‚¹";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"DevExãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå®Œäº†ã—ã¾ã—ãŸã€‚{startMoneyLink}è²¯é‡‘ç®±{endMoneyLink}ãƒšãƒ¼ã‚¸ã§è©³ç´°ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "DevExãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå®Œäº†ã—ã¾ã—ãŸã€‚{startMoneyLink}è²¯é‡‘ç®±{endMoneyLink}ãƒšãƒ¼ã‚¸ã§è©³ç´°ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"DevExãƒªã‚¯ã‚¨ã‚¹ãƒˆé€ä¿¡æ—¥æ™‚: {requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "DevExãƒªã‚¯ã‚¨ã‚¹ãƒˆé€ä¿¡æ—¥æ™‚: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* å¤ã„Robuxã¯æ›é‡‘ãƒ¬ãƒ¼ãƒˆãŒç•°ãªã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚è©³ç´°ã«ã¤ã„ã¦ã¯{helpLinkStart}ã“ã¡ã‚‰{helpLinkEnd}ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* å¤ã„Robuxã¯æ›é‡‘ãƒ¬ãƒ¼ãƒˆãŒç•°ãªã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚è©³ç´°ã«ã¤ã„ã¦ã¯{helpLinkStart}ã“ã¡ã‚‰{helpLinkEnd}ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"Developer Exchangeã«ã¤ã„ã¦{startDevExLink}è©³ç´°ã‚’ç¢ºèª{endDevExLink}ã™ã‚‹ã€‚";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "Developer Exchangeã«ã¤ã„ã¦{startDevExLink}è©³ç´°ã‚’ç¢ºèª{endDevExLink}ã™ã‚‹ã€‚";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"Developer Exchangeã«{startDevExLink}ã‚¢ã‚¯ã‚»ã‚¹{endDevExLink}ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "Developer Exchangeã«{startDevExLink}ã‚¢ã‚¯ã‚»ã‚¹{endDevExLink}ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange: ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ã€ãŠé‡‘ã‚’ç¨¼ã”ã†ã€‚";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ã‚¨ã‚¯ã‚¹ãƒã‚§ãƒ³ã‚¸";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "ã‚ãªãŸã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "ã‚ã¨å°‘ã—ã§ã™ï¼";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public override string LabelAmountRobux(string amount)
	{
		return $"{amount} Robux";
	}

	protected override string _GetTemplateForLabelAmountRobux()
	{
		return "{amount} Robux";
	}

	protected override string _GetTemplateForLabelBuilderClubForCash()
	{
		return "Robuxã‚’ç¾é‡‘ã«äº¤æ›ã™ã‚‹ã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã«ã¯ã€Outrageous Builders ClubãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "ç¾åœ¨ã®ãƒ¬ãƒ¼ãƒˆ";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"ç¾åœ¨ã®ãƒ¬ãƒ¼ãƒˆã¯ã€ {minimumDevexRobuxAmount} Robuxä»¥ä¸Šã®ã™ã¹ã¦ã®é¡ã«é©ç”¨ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "ç¾åœ¨ã®ãƒ¬ãƒ¼ãƒˆã¯ã€ {minimumDevexRobuxAmount} Robuxä»¥ä¸Šã®ã™ã¹ã¦ã®é¡ã«é©ç”¨ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "çŠ¶æ³ã¯å®Œäº†æ¸ˆã¿ã§ã™";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "çŠ¶æ³ã¯ä¿ç•™ä¸­ã§ã™";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "çŠ¶æ³ã¯å´ä¸‹æ¸ˆã¿ã§ã™";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "DevExã‚’ä½¿ã†ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "ç¾åœ¨ã€æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Robuxã‚’ç¾é‡‘ã¨ä¸¡æ›¿ã™ã‚‹ã«ã¯ã€Roblox PremiumãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.RobuxToUSD"
	/// label
	/// English String: "{robuxAmount} Robux for {usdAmount}"
	/// </summary>
	public override string LabelRobuxToUSD(string robuxAmount, string usdAmount)
	{
		return $"{usdAmount}ã§{robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{usdAmount}ã§{robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "ã‚‚ã†ã™ãRobuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "ã‚‚ã†å°‘ã—ã§ã™ï¼ã‚ã¨å°‘ã—ã§Robuxã‚’ç¾é‡‘ã¨äº¤æ›ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã‚’è¡Œã†å‰ã«ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ãŒå¿…è¦ã§ã™ã€‚";
	}
}


}
