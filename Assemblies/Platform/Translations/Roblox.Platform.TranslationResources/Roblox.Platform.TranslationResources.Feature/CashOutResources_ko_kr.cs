namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_ko_kr : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "í˜„ê¸ˆ ì¸ì¶œ";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "ì§€ê¸ˆ ì´ìš©í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "ì§€ê¸ˆ OBC ê°€ìž…";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "ë©¤ë²„ì‹­ ì—…ê·¸ë ˆì´ë“œ";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ì¸ì¦";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "ì´ë©”ì¼ ì¸ì¦";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "ì§€ê¸ˆ ì¸ì¦";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "DevEx ë°©ë¬¸";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "ê°œë°œìž í™˜ì „: ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "ê°œë°œìž í™˜ì „";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "ì‚¬ìš©ìž ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "ê±°ì˜ ë‹¤ ë˜ì—ˆì–´ìš”!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•˜ë ¤ë©´ Outrageous Builders Clubì— ê°€ìž…í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "í˜„ê¸ˆì„ ì¸ì¶œí•˜ë ¤ë©´ Outrageous Builders Clubì— ê°€ìž…í•´ì•¼ í•´ìš”.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "í˜„ìž¬ í™˜ìœ¨";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "í™˜ì „ ìš”ì²­ì´ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "í™˜ì „ ìš”ì²­ì´ ëŒ€ê¸° ì¤‘ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "í™˜ì „ ìš”ì²­ì´ ê±°ë¶€ë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "DevExë¥¼ ì´ìš©í•˜ë ¤ë©´ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "íšŒì›ë‹˜ì€ í˜„ìž¬ ë³¸ ì„œë¹„ìŠ¤ë¥¼ ì´ìš©í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "Robuxê°€ ë¶€ì¡±í•´ì„œ í˜„ê¸ˆì„ ì¸ì¶œí•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ êµí™˜í•˜ë ¤ë©´ Roblox Premiumì´ í•„ìš”í•´ìš”.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•˜ëŠ” ì¤‘ìž…ë‹ˆë‹¤!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "ê±°ì˜ ë‹¤ ëë‚˜ê°€ìš”! ì¡°ê¸ˆë§Œ ë” ìžˆìœ¼ë©´ Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•  ìˆ˜ ìžˆì–´ìš”!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "í˜„ê¸ˆì„ ì¸ì¶œí•˜ë ¤ë©´ ë¨¼ì € ì´ë©”ì¼ì„ ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";

	public CashOutResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "í˜„ê¸ˆ ì¸ì¶œ";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "ì§€ê¸ˆ ì´ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "ì§€ê¸ˆ OBC ê°€ìž…";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "ë©¤ë²„ì‹­ ì—…ê·¸ë ˆì´ë“œ";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ì¸ì¦";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "ì´ë©”ì¼ ì¸ì¦";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "ì§€ê¸ˆ ì¸ì¦";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "DevEx ë°©ë¬¸";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"DevEx ìš”ì²­ì´ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤. ìžì„¸í•œ ì‚¬í•­ì€ {startMoneyLink}ìžê¸ˆ{endMoneyLink} íŽ˜ì´ì§€ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "DevEx ìš”ì²­ì´ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤. ìžì„¸í•œ ì‚¬í•­ì€ {startMoneyLink}ìžê¸ˆ{endMoneyLink} íŽ˜ì´ì§€ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"{requestDate}ì— DevEx ìš”ì²­ì„ í•˜ì…¨ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "{requestDate}ì— DevEx ìš”ì²­ì„ í•˜ì…¨ìŠµë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* êµ¬(èˆŠ) Robuxì—ëŠ” ë‹¤ë¥¸ í™˜ìœ¨ì´ ì ìš©ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. {helpLinkStart}ì—¬ê¸°{helpLinkEnd}ë¥¼ í´ë¦­í•´ ìžì„¸í•œ ì •ë³´ë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* êµ¬(èˆŠ) Robuxì—ëŠ” ë‹¤ë¥¸ í™˜ìœ¨ì´ ì ìš©ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. {helpLinkStart}ì—¬ê¸°{helpLinkEnd}ë¥¼ í´ë¦­í•´ ìžì„¸í•œ ì •ë³´ë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"ê°œë°œìž í™˜ì „ì— ëŒ€í•´ {startDevExLink}ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”{endDevExLink}.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "ê°œë°œìž í™˜ì „ì— ëŒ€í•´ {startDevExLink}ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”{endDevExLink}.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"ê°œë°œìž í™˜ì „ì„ {startDevExLink}ë°©ë¬¸{endDevExLink}í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "ê°œë°œìž í™˜ì „ì„ {startDevExLink}ë°©ë¬¸{endDevExLink}í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "ê°œë°œìž í™˜ì „: ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "ê°œë°œìž í™˜ì „";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "ì‚¬ìš©ìž ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "ê±°ì˜ ë‹¤ ë˜ì—ˆì–´ìš”!";
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
		return "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•˜ë ¤ë©´ Outrageous Builders Clubì— ê°€ìž…í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "í˜„ê¸ˆì„ ì¸ì¶œí•˜ë ¤ë©´ Outrageous Builders Clubì— ê°€ìž…í•´ì•¼ í•´ìš”.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "í˜„ìž¬ í™˜ìœ¨";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"í˜„ìž¬ í™˜ìœ¨ì€ {minimumDevexRobuxAmount} Robuxë¥¼ ì´ˆê³¼í•˜ëŠ” ëª¨ë“  ê¸ˆì•¡ì— ì ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "í˜„ìž¬ í™˜ìœ¨ì€ {minimumDevexRobuxAmount} Robuxë¥¼ ì´ˆê³¼í•˜ëŠ” ëª¨ë“  ê¸ˆì•¡ì— ì ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "í™˜ì „ ìš”ì²­ì´ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "í™˜ì „ ìš”ì²­ì´ ëŒ€ê¸° ì¤‘ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "í™˜ì „ ìš”ì²­ì´ ê±°ë¶€ë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "DevExë¥¼ ì´ìš©í•˜ë ¤ë©´ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "íšŒì›ë‹˜ì€ í˜„ìž¬ ë³¸ ì„œë¹„ìŠ¤ë¥¼ ì´ìš©í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "Robuxê°€ ë¶€ì¡±í•´ì„œ í˜„ê¸ˆì„ ì¸ì¶œí•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ êµí™˜í•˜ë ¤ë©´ Roblox Premiumì´ í•„ìš”í•´ìš”.";
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
		return $"{robuxAmount} Robuxë‹¹ {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount} Robuxë‹¹ {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•˜ëŠ” ì¤‘ìž…ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "ê±°ì˜ ë‹¤ ëë‚˜ê°€ìš”! ì¡°ê¸ˆë§Œ ë” ìžˆìœ¼ë©´ Robuxë¥¼ í˜„ê¸ˆìœ¼ë¡œ í™˜ì „í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "í˜„ê¸ˆì„ ì¸ì¶œí•˜ë ¤ë©´ ë¨¼ì € ì´ë©”ì¼ì„ ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";
	}
}


}
