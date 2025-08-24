namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_zh_tw : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "轉換到 Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兌換";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "取得 Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox 點數";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "處理 Roblox 點數時發生錯誤，請稍後再試！";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "我們已向您收取 Roblox 點數，但給您 Robux 時發生錯誤。。若要取得您的 Robux，請聯絡客服人員。";

	public RobloxCreditResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "轉換到 Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兌換";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"將 {balance} Roblox 點數兌換成 {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "將 {balance} Roblox 點數兌換成 {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"將 {balance} Roblox 點數兌換成 {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "將 {balance} Roblox 點數兌換成 {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "取得 Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox 點數";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"目前餘額：${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "目前餘額：${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "處理 Roblox 點數時發生錯誤，請稍後再試！";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "我們已向您收取 Roblox 點數，但給您 Robux 時發生錯誤。。若要取得您的 Robux，請聯絡客服人員。";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"您已成功兌換 {robuxAmount} Robux！";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "您已成功兌換 {robuxAmount} Robux！";
	}
}
