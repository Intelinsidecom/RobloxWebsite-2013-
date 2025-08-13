namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_zh_cn : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "取现";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "立即获取";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "立即获取 OBC";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "升级会员资格";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "验证";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "验证电子邮件";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "立即验证";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "访问 DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange：创作游戏，赚取金钱。";

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
	public override string HeadingYourUpdate => "你的更新";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "你即将准备就绪！";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "你需要 Outrageous Builders Club 才能将 Robux 兑换为现金。";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "你需要 Outrageous Builders Club 才能取现。";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "当前汇率";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "其状态为已完成";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "其状态为待处理";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "其状态为被拒绝";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "你需要经验证的电子邮件地址才能使用 DevEx。";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "你目前不符合资格。";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "你的 Robux 不足，无法取现。";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "你将需要 Roblox Premium 以将 Robux 兑换为现金。";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "你即将把 Robux 兑换为现金！";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "你快完成了！你马上就可以将 Robux 兑换为现金了！";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "你必须先验证电子邮件才能取现。";

	public CashOutResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "取现";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "立即获取";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "立即获取 OBC";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "升级会员资格";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "验证";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "验证电子邮件";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "立即验证";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "访问 DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"你的 DevEx 请求已完成。请查看你的{startMoneyLink}金钱{endMoneyLink}页面了解详情。";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "你的 DevEx 请求已完成。请查看你的{startMoneyLink}金钱{endMoneyLink}页面了解详情。";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"你的 DevEx 请求提交时间为：{requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "你的 DevEx 请求提交时间为：{requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* 旧版 Robux 可能会以不同汇率兑限。请点按{helpLinkStart}此处{helpLinkEnd}了解更多信息。";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* 旧版 Robux 可能会以不同汇率兑限。请点按{helpLinkStart}此处{helpLinkEnd}了解更多信息。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}前往此处{endDevExLink}了解更多关于 Developer Exchange 的内容。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}前往此处{endDevExLink}了解更多关于 Developer Exchange 的内容。";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}访问{endDevExLink}我们的 Developer Exchange。";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}访问{endDevExLink}我们的 Developer Exchange。";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange：创作游戏，赚取金钱。";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "你的更新";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "你即将准备就绪！";
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
		return "你需要 Outrageous Builders Club 才能将 Robux 兑换为现金。";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "你需要 Outrageous Builders Club 才能取现。";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "当前汇率";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"当前汇率会应用至所有大于 {minimumDevexRobuxAmount} Robux 的数额";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "当前汇率会应用至所有大于 {minimumDevexRobuxAmount} Robux 的数额";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "其状态为已完成";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "其状态为待处理";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "其状态为被拒绝";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "你需要经验证的电子邮件地址才能使用 DevEx。";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "你目前不符合资格。";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "你的 Robux 不足，无法取现。";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "你将需要 Roblox Premium 以将 Robux 兑换为现金。";
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
		return $"以 {usdAmount} 购买 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "以 {usdAmount} 购买 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "你即将把 Robux 兑换为现金！";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "你快完成了！你马上就可以将 Robux 兑换为现金了！";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "你必须先验证电子邮件才能取现。";
	}
}
