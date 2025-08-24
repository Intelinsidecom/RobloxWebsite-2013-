namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "현금 인출";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "지금 이용하세요";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "지금 OBC 가입";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "멤버십 업그레이드";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "인증";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "이메일 인증";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "지금 인증";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "DevEx 방문";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "개발자 환전: 게임 개발을 통해 수익 창출까지";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "개발자 환전";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "사용자 업데이트";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "거의 다 되었어요!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Robux를 현금으로 환전하려면 Outrageous Builders Club에 가입해야 합니다.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "현금을 인출하려면 Outrageous Builders Club에 가입해야 해요.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "현재 환율";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "환전 요청이 완료되었습니다";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "환전 요청이 대기 중입니다";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "환전 요청이 거부되었습니다";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "DevEx를 이용하려면 이메일 주소를 인증해야 합니다.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "회원님은 현재 본 서비스를 이용하실 수 없습니다.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "Robux가 부족해서 현금을 인출할 수 없어요.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Robux를 현금으로 교환하려면 Roblox Premium이 필요해요.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "Robux를 현금으로 환전하는 중입니다!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "거의 다 끝나가요! 조금만 더 있으면 Robux를 현금으로 환전할 수 있어요!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "현금을 인출하려면 먼저 이메일을 인증해야 합니다.";

	public CashOutResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "현금 인출";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "지금 이용하세요";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "지금 OBC 가입";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "멤버십 업그레이드";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "인증";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "지금 인증";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "DevEx 방문";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"DevEx 요청이 완료되었습니다. 자세한 사항은 {startMoneyLink}자금{endMoneyLink} 페이지에서 확인하세요.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "DevEx 요청이 완료되었습니다. 자세한 사항은 {startMoneyLink}자금{endMoneyLink} 페이지에서 확인하세요.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"{requestDate}에 DevEx 요청을 하셨습니다";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "{requestDate}에 DevEx 요청을 하셨습니다";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* 구(舊) Robux에는 다른 환율이 적용될 수도 있습니다. {helpLinkStart}여기{helpLinkEnd}를 클릭해 자세한 정보를 확인하세요.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* 구(舊) Robux에는 다른 환율이 적용될 수도 있습니다. {helpLinkStart}여기{helpLinkEnd}를 클릭해 자세한 정보를 확인하세요.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"개발자 환전에 대해 {startDevExLink}자세히 알아보세요{endDevExLink}.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "개발자 환전에 대해 {startDevExLink}자세히 알아보세요{endDevExLink}.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"개발자 환전을 {startDevExLink}방문{endDevExLink}하세요.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "개발자 환전을 {startDevExLink}방문{endDevExLink}하세요.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "개발자 환전: 게임 개발을 통해 수익 창출까지";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "개발자 환전";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "사용자 업데이트";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "거의 다 되었어요!";
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
		return "Robux를 현금으로 환전하려면 Outrageous Builders Club에 가입해야 합니다.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "현금을 인출하려면 Outrageous Builders Club에 가입해야 해요.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "현재 환율";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"현재 환율은 {minimumDevexRobuxAmount} Robux를 초과하는 모든 금액에 적용됩니다.";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "현재 환율은 {minimumDevexRobuxAmount} Robux를 초과하는 모든 금액에 적용됩니다.";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "환전 요청이 완료되었습니다";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "환전 요청이 대기 중입니다";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "환전 요청이 거부되었습니다";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "DevEx를 이용하려면 이메일 주소를 인증해야 합니다.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "회원님은 현재 본 서비스를 이용하실 수 없습니다.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "Robux가 부족해서 현금을 인출할 수 없어요.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Robux를 현금으로 교환하려면 Roblox Premium이 필요해요.";
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
		return $"{robuxAmount} Robux당 {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount} Robux당 {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "Robux를 현금으로 환전하는 중입니다!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "거의 다 끝나가요! 조금만 더 있으면 Robux를 현금으로 환전할 수 있어요!";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "현금을 인출하려면 먼저 이메일을 인증해야 합니다.";
	}
}
