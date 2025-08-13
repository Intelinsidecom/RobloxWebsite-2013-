namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "キャッシュアウト";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "今すぐゲット";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "今すぐOBCをゲット";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "メンバーシップをアップグレード";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "認証";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "メールアドレスを認証";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "今すぐ認証";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "DevExにアクセス";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange: ゲームを制作して、お金を稼ごう。";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "デベロッパーエクスチェンジ";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "あなたのアップデート";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "あと少しです！";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Robuxを現金に交換するには、Outrageous Builders Clubが必要です。";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "キャッシュアウトには、Outrageous Builders Clubが必要です。";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "現在のレート";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "状況は完了済みです";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "状況は保留中です";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "状況は却下済みです";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "DevExを使うには認証済みのメールアドレスが必要です。";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "現在、権限がありません。";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "Robuxが不足しているためキャッシュアウトできません。";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Robuxを現金と両替するには、Roblox Premiumが必要です。";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "もうすぐRobuxを現金と交換できるようになります！";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "もう少しです！あと少しでRobuxを現金と交換できるようになります！";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "キャッシュアウトを行う前に、メールアドレスの認証が必要です。";

	public CashOutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "キャッシュアウト";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "今すぐゲット";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "今すぐOBCをゲット";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "メンバーシップをアップグレード";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "認証";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "今すぐ認証";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "DevExにアクセス";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"DevExリクエストが完了しました。{startMoneyLink}貯金箱{endMoneyLink}ページで詳細を確認してください。";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "DevExリクエストが完了しました。{startMoneyLink}貯金箱{endMoneyLink}ページで詳細を確認してください。";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"DevExリクエスト送信日時: {requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "DevExリクエスト送信日時: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* 古いRobuxは換金レートが異なる場合があります。詳細については{helpLinkStart}こちら{helpLinkEnd}をクリックしてください。";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* 古いRobuxは換金レートが異なる場合があります。詳細については{helpLinkStart}こちら{helpLinkEnd}をクリックしてください。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"Developer Exchangeについて{startDevExLink}詳細を確認{endDevExLink}する。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "Developer Exchangeについて{startDevExLink}詳細を確認{endDevExLink}する。";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"Developer Exchangeに{startDevExLink}アクセス{endDevExLink}してください。";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "Developer Exchangeに{startDevExLink}アクセス{endDevExLink}してください。";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange: ゲームを制作して、お金を稼ごう。";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "デベロッパーエクスチェンジ";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "あなたのアップデート";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "あと少しです！";
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
		return "Robuxを現金に交換するには、Outrageous Builders Clubが必要です。";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "キャッシュアウトには、Outrageous Builders Clubが必要です。";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "現在のレート";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"現在のレートは、 {minimumDevexRobuxAmount} Robux以上のすべての額に適用されます。";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "現在のレートは、 {minimumDevexRobuxAmount} Robux以上のすべての額に適用されます。";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "状況は完了済みです";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "状況は保留中です";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "状況は却下済みです";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "DevExを使うには認証済みのメールアドレスが必要です。";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "現在、権限がありません。";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "Robuxが不足しているためキャッシュアウトできません。";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Robuxを現金と両替するには、Roblox Premiumが必要です。";
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
		return $"{usdAmount}で{robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{usdAmount}で{robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "もうすぐRobuxを現金と交換できるようになります！";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "もう少しです！あと少しでRobuxを現金と交換できるようになります！";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "キャッシュアウトを行う前に、メールアドレスの認証が必要です。";
	}
}
