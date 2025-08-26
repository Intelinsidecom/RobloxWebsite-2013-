namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_zh_tw : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "å…Œç¾";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "ç¾åœ¨å–å¾—";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "ç¾åœ¨å–å¾— OBC";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "å‡ç´šæœƒå“¡è³‡æ ¼";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "é©—è­‰";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "é©—è­‰é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "ç¾åœ¨é©—è­‰";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "å‰å¾€ DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchangeï¼šå‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢ã€‚";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "æ‚¨çš„æ›´æ–°";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "å¿«å¥½äº†ï¼";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "ç›®å‰åŒ¯çŽ‡";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "ç‹€æ…‹ç‚ºå®Œæˆ";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "ç‹€æ…‹ç‚ºå¾…è™•ç†";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "ç‹€æ…‹ç‚ºé­æ‹’";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "æ‚¨ç›®å‰è³‡æ ¼ä¸ç¬¦ã€‚";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "æ‚¨éœ€è¦ Roblox Premium æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "æ‚¨å¿«å¯ä»¥ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘äº†ï¼";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "å°±å·®ä¸€é»žäº†ï¼Œæ‚¨å³å°‡å–å¾—ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘çš„è³‡æ ¼ï¼";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "è‹¥è¦å…Œç¾ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";

	public CashOutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "å…Œç¾";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "ç¾åœ¨å–å¾—";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "ç¾åœ¨å–å¾— OBC";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "å‡ç´šæœƒå“¡è³‡æ ¼";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "é©—è­‰";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "é©—è­‰é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "ç¾åœ¨é©—è­‰";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "å‰å¾€ DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"æ‚¨çš„ DevEx è«‹æ±‚å·²å®Œæˆã€‚è«‹å‰å¾€æ‚¨çš„{startMoneyLink}é‡‘éŒ¢{endMoneyLink}é é¢æŸ¥çœ‹è©³ç´°è³‡æ–™ã€‚";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "æ‚¨çš„ DevEx è«‹æ±‚å·²å®Œæˆã€‚è«‹å‰å¾€æ‚¨çš„{startMoneyLink}é‡‘éŒ¢{endMoneyLink}é é¢æŸ¥çœ‹è©³ç´°è³‡æ–™ã€‚";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"æ‚¨çš„ DevEx è«‹æ±‚æäº¤æ™‚é–“ç‚ºï¼š{requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "æ‚¨çš„ DevEx è«‹æ±‚æäº¤æ™‚é–“ç‚ºï¼š{requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"ï¼ŠèˆŠç‰ˆ Robux å¯èƒ½æœƒä»¥ä¸åŒåŒ¯çŽ‡å…Œç¾ã€‚è«‹æŒ‰ä¸‹{helpLinkStart}æ­¤è™•{helpLinkEnd}å–å¾—æ›´å¤šè³‡è¨Šã€‚";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "ï¼ŠèˆŠç‰ˆ Robux å¯èƒ½æœƒä»¥ä¸åŒåŒ¯çŽ‡å…Œç¾ã€‚è«‹æŒ‰ä¸‹{helpLinkStart}æ­¤è™•{helpLinkEnd}å–å¾—æ›´å¤šè³‡è¨Šã€‚";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}å‰å¾€æ­¤è™•{endDevExLink}æ·±å…¥äº†è§£ Developer Exchangeã€‚";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}å‰å¾€æ­¤è™•{endDevExLink}æ·±å…¥äº†è§£ Developer Exchangeã€‚";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}å‰å¾€{endDevExLink}æˆ‘å€‘çš„ã€ŒDeveloper Exchangeã€ã€‚";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}å‰å¾€{endDevExLink}æˆ‘å€‘çš„ã€ŒDeveloper Exchangeã€ã€‚";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchangeï¼šå‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢ã€‚";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "æ‚¨çš„æ›´æ–°";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "å¿«å¥½äº†ï¼";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public override string LabelAmountRobux(string amount)
	{
		return $"{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelAmountRobux()
	{
		return "{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelBuilderClubForCash()
	{
		return "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "æ‚¨éœ€è¦ Outrageous Builders Club æ‰èƒ½å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "ç›®å‰åŒ¯çŽ‡";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"ç›®å‰åŒ¯çŽ‡é©ç”¨æ–¼æ‰€æœ‰è¶…éŽ {minimumDevexRobuxAmount} Robux çš„æ•¸é‡";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "ç›®å‰åŒ¯çŽ‡é©ç”¨æ–¼æ‰€æœ‰è¶…éŽ {minimumDevexRobuxAmount} Robux çš„æ•¸é‡";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "ç‹€æ…‹ç‚ºå®Œæˆ";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "ç‹€æ…‹ç‚ºå¾…è™•ç†";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "ç‹€æ…‹ç‚ºé­æ‹’";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½ä½¿ç”¨ DevExã€‚";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "æ‚¨ç›®å‰è³‡æ ¼ä¸ç¬¦ã€‚";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "æ‚¨éœ€è¦ Roblox Premium æ‰èƒ½å°‡ Robux å…Œç¾ã€‚";
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
		return $"ä»¥ {robuxAmount} Robux å…Œæ› {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "ä»¥ {robuxAmount} Robux å…Œæ› {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "æ‚¨å¿«å¯ä»¥ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘äº†ï¼";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "å°±å·®ä¸€é»žäº†ï¼Œæ‚¨å³å°‡å–å¾—ä½¿ç”¨ Robux å…Œæ›ç¾é‡‘çš„è³‡æ ¼ï¼";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "è‹¥è¦å…Œç¾ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";
	}
}


}
