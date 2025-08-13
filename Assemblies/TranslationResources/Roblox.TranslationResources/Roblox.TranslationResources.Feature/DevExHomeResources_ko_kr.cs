namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_ko_kr : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "취소";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "현금 인출";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "지금 OBC 구매";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "멤버십 업그레이드";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "인증";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "이메일 인증";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "지금 인증";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "DevEx 가기";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "거의 다 되었어요!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Robux를 현금으로 환전하려면 Outrageous Builders Club에 가입해야 해요.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "현금을 인출하려면 먼저 Outrageous Builders Club에 가입해야 합니다.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "현재 환율";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "개발자 환전을 이용하려면 이메일 주소부터 인증해야 합니다.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "회원님은 현재 권한이 없습니다.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "Robux가 부족해서 현금을 인출할 수 없어요.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "Robux를 현금으로 환전하고 있습니다!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "거의 다 끝나가요! 곧 Robux를 현금으로 환전할 수 있어요!";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "현금을 인출하려면 먼저 이메일 인증을 완료해야 합니다.";

	public DevExHomeResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "현금 인출";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "지금 OBC 구매";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "멤버십 업그레이드";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "인증";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "지금 인증";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "DevEx 가기";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "거의 다 되었어요!";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Robux를 현금으로 환전하려면 Outrageous Builders Club에 가입해야 해요.";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "현금을 인출하려면 먼저 Outrageous Builders Club에 가입해야 합니다.";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "현재 환율";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "개발자 환전을 이용하려면 이메일 주소부터 인증해야 합니다.";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "회원님은 현재 권한이 없습니다.";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "Robux가 부족해서 현금을 인출할 수 없어요.";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "Robux를 현금으로 환전하고 있습니다!";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "거의 다 끝나가요! 곧 Robux를 현금으로 환전할 수 있어요!";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "현금을 인출하려면 먼저 이메일 인증을 완료해야 합니다.";
	}
}
