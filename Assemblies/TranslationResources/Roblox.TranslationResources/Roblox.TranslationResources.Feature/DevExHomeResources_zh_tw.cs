namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_zh_tw : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "取消";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "兌現";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "現在取得 OBC";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "升級會員資格";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "驗證";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "驗證電子郵件地址";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "現在驗證";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "前往 DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "快好了！";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "您需要 Outrageous Builders Club 才能將 Robux 兌現。";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "您需要 Outrageous Builders Club 才能兌現。";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "目前匯率";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "您需要已驗證的電子郵件地址才能使用 DevEx。";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "您目前資格不符。";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "您的 Robux 不足，無法兌現。";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "您快要可以使用 Robux 兌換現金了！";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "就差一點了，您即將取得使用 Robux 兌換現金的資格！";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "若要兌現，請先驗證電子郵件地址。";

	public DevExHomeResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "兌現";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "現在取得 OBC";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "升級會員資格";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "驗證";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "驗證電子郵件地址";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "現在驗證";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "前往 DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "快好了！";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "您需要 Outrageous Builders Club 才能將 Robux 兌現。";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "您需要 Outrageous Builders Club 才能兌現。";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "目前匯率";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "您需要已驗證的電子郵件地址才能使用 DevEx。";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "您目前資格不符。";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "您的 Robux 不足，無法兌現。";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "您快要可以使用 Robux 兌換現金了！";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "就差一點了，您即將取得使用 Robux 兌換現金的資格！";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "若要兌現，請先驗證電子郵件地址。";
	}
}
