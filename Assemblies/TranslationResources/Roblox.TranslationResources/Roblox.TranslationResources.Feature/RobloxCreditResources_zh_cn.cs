namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_zh_cn : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "转换为 Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兑换";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "取得 Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox 点数";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "处理您的 Roblox 点数时发生了问题。请稍后再试一次！";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "我们已存入您的 Roblox 点数，但在进行 Robux 拨款时发生了问题。请联络客户支持部门来取得您的 Robux。";

	public RobloxCreditResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "转换为 Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兑换";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"将您的 {balance} Roblox 点数兑换为 {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "将您的 {balance} Roblox 点数兑换为 {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"将您的 {balance} Roblox 点数兑换为 {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "将您的 {balance} Roblox 点数兑换为 {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "取得 Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox 点数";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"当前余额：${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "当前余额：${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "处理您的 Roblox 点数时发生了问题。请稍后再试一次！";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "我们已存入您的 Roblox 点数，但在进行 Robux 拨款时发生了问题。请联络客户支持部门来取得您的 Robux。";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"您成功兑换了 {robuxAmount} Robux！";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "您成功兑换了 {robuxAmount} Robux！";
	}
}
