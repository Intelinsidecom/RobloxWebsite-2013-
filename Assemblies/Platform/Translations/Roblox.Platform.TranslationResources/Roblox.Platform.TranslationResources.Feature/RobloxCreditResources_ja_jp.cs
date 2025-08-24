namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_ja_jp : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Robuxに換算する";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "引き換える";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Robuxをゲット";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Robloxクレジット";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "お持ちのRobloxクレジットの処理で問題が発生しました。後でもう一度お試しください！";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Robloxクレジットを入れました。しかし、Robux付与の処理で問題が発生しました。Robuxを受け取るには、カスタマーサポートにご連絡ください。";

	public RobloxCreditResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Robuxに換算する";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "引き換える";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"お持ちの{balance} Robloxクレジットを{robuxAmount} に引き換える";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "お持ちの{balance} Robloxクレジットを{robuxAmount} に引き換える";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"お持ちの{balance} Robloxクレジットを {iconRobux} {robuxAmount} に引き換える";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "お持ちの{balance} Robloxクレジットを {iconRobux} {robuxAmount} に引き換える";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Robuxをゲット";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Robloxクレジット";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"現在の残高: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "現在の残高: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "お持ちのRobloxクレジットの処理で問題が発生しました。後でもう一度お試しください！";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Robloxクレジットを入れました。しかし、Robux付与の処理で問題が発生しました。Robuxを受け取るには、カスタマーサポートにご連絡ください。";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"{robuxAmount} Robuxの引き換えに成功しました！";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "{robuxAmount} Robuxの引き換えに成功しました！";
	}
}
