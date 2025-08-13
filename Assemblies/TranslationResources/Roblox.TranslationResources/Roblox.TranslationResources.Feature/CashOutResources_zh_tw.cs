namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "兌現";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "現在取得";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "現在取得 OBC";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "升級會員資格";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "驗證";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "驗證電子郵件地址";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "現在驗證";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "前往 DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange：創作遊戲，賺取金錢。";

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
	public override string HeadingYourUpdate => "您的更新";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "快好了！";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "您需要 Outrageous Builders Club 才能將 Robux 兌現。";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "您需要 Outrageous Builders Club 才能兌現。";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "目前匯率";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "狀態為完成";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "狀態為待處理";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "狀態為遭拒";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "您需要已驗證的電子郵件地址才能使用 DevEx。";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "您目前資格不符。";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "您的 Robux 不足，無法兌現。";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "您需要 Roblox Premium 才能將 Robux 兌現。";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "您快可以使用 Robux 兌換現金了！";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "就差一點了，您即將取得使用 Robux 兌換現金的資格！";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "若要兌現，請先驗證電子郵件地址。";

	public CashOutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "兌現";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "現在取得";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "現在取得 OBC";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "升級會員資格";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "驗證";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "驗證電子郵件地址";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "現在驗證";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "前往 DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"您的 DevEx 請求已完成。請前往您的{startMoneyLink}金錢{endMoneyLink}頁面查看詳細資料。";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "您的 DevEx 請求已完成。請前往您的{startMoneyLink}金錢{endMoneyLink}頁面查看詳細資料。";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"您的 DevEx 請求提交時間為：{requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "您的 DevEx 請求提交時間為：{requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"＊舊版 Robux 可能會以不同匯率兌現。請按下{helpLinkStart}此處{helpLinkEnd}取得更多資訊。";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "＊舊版 Robux 可能會以不同匯率兌現。請按下{helpLinkStart}此處{helpLinkEnd}取得更多資訊。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}前往此處{endDevExLink}深入了解 Developer Exchange。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}前往此處{endDevExLink}深入了解 Developer Exchange。";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}前往{endDevExLink}我們的「Developer Exchange」。";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}前往{endDevExLink}我們的「Developer Exchange」。";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange：創作遊戲，賺取金錢。";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "您的更新";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "快好了！";
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
		return "您需要 Outrageous Builders Club 才能將 Robux 兌現。";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "您需要 Outrageous Builders Club 才能兌現。";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "目前匯率";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"目前匯率適用於所有超過 {minimumDevexRobuxAmount} Robux 的數量";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "目前匯率適用於所有超過 {minimumDevexRobuxAmount} Robux 的數量";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "狀態為完成";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "狀態為待處理";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "狀態為遭拒";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "您需要已驗證的電子郵件地址才能使用 DevEx。";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "您目前資格不符。";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "您的 Robux 不足，無法兌現。";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "您需要 Roblox Premium 才能將 Robux 兌現。";
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
		return $"以 {robuxAmount} Robux 兌換 {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "以 {robuxAmount} Robux 兌換 {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "您快可以使用 Robux 兌換現金了！";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "就差一點了，您即將取得使用 Robux 兌換現金的資格！";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "若要兌現，請先驗證電子郵件地址。";
	}
}
