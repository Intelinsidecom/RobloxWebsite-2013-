namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_zh_cn : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
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
	public override string GetActionCashOut => "取现";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "立即获取 OBC";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "升级会员资格";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "验证";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "验证电子邮件";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "立即验证";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "访问 DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "你即将准备就绪！";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "你需要 Outrageous Builders Club 才能将 Robux 兑换为现金。";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "你需要 Outrageous Builders Club 才能取现。";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "当前汇率";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "你需要经验证的电子邮件地址才能使用 DevEx。";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "你目前不符合资格。";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "你的 Robux 不足，无法取现。";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "你即将把 Robux 兑换为现金！";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "你快完成了！你马上就可以将 Robux 兑换为现金了！";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "你必须先验证电子邮件才能取现。";

	public DevExHomeResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "取现";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "立即获取 OBC";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "升级会员资格";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "验证";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "验证电子邮件";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "立即验证";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "访问 DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "你即将准备就绪！";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "你需要 Outrageous Builders Club 才能将 Robux 兑换为现金。";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "你需要 Outrageous Builders Club 才能取现。";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "当前汇率";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "你需要经验证的电子邮件地址才能使用 DevEx。";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "你目前不符合资格。";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "你的 Robux 不足，无法取现。";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "你即将把 Robux 兑换为现金！";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "你快完成了！你马上就可以将 Robux 兑换为现金了！";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "你必须先验证电子邮件才能取现。";
	}
}
